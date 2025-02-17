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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Ep2complexparameters.Model;
using Amazon.Ep2complexparameters.Model.Internal.MarshallTransformations;
using Amazon.Ep2complexparameters.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Ep2complexparameters
{
    /// <summary>
    /// <para>Implementation for accessing Ep2complexparameters</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonEp2complexparametersClient : AmazonServiceClient, IAmazonEp2complexparameters
    {
        private static IServiceMetadata serviceMetadata = new AmazonEp2complexparametersMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        public AmazonEp2complexparametersClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEp2complexparametersConfig()) { }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        public AmazonEp2complexparametersClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEp2complexparametersConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(AmazonEp2complexparametersConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials)
            : this(credentials, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEp2complexparametersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials and an
        /// AmazonEp2complexparametersClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials, AmazonEp2complexparametersConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2complexparametersConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2complexparametersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEp2complexparametersConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2complexparametersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2complexparametersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEp2complexparametersConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2complexparametersEndpointResolver());
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


        #region  EmptyStaticContextOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation service method.</param>
        /// 
        /// <returns>The response from the EmptyStaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        public virtual EmptyStaticContextOperationResponse EmptyStaticContextOperation(EmptyStaticContextOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EmptyStaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyStaticContextOperationResponseUnmarshaller.Instance;

            return Invoke<EmptyStaticContextOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyStaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyStaticContextOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        public virtual IAsyncResult BeginEmptyStaticContextOperation(EmptyStaticContextOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EmptyStaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyStaticContextOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyStaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyStaticContextOperation.</param>
        /// 
        /// <returns>Returns a  EmptyStaticContextOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        public virtual EmptyStaticContextOperationResponse EndEmptyStaticContextOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EmptyStaticContextOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfObjectsOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation service method.</param>
        /// 
        /// <returns>The response from the ListOfObjectsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        public virtual ListOfObjectsOperationResponse ListOfObjectsOperation(ListOfObjectsOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfObjectsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfObjectsOperationResponseUnmarshaller.Instance;

            return Invoke<ListOfObjectsOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfObjectsOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfObjectsOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        public virtual IAsyncResult BeginListOfObjectsOperation(ListOfObjectsOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfObjectsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfObjectsOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfObjectsOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfObjectsOperation.</param>
        /// 
        /// <returns>Returns a  ListOfObjectsOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        public virtual ListOfObjectsOperationResponse EndListOfObjectsOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfObjectsOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  MapOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MapOperation service method.</param>
        /// 
        /// <returns>The response from the MapOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        public virtual MapOperationResponse MapOperation(MapOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MapOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MapOperationResponseUnmarshaller.Instance;

            return Invoke<MapOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MapOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MapOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMapOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        public virtual IAsyncResult BeginMapOperation(MapOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MapOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MapOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MapOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMapOperation.</param>
        /// 
        /// <returns>Returns a  MapOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        public virtual MapOperationResponse EndMapOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<MapOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  NoBindingsOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation service method.</param>
        /// 
        /// <returns>The response from the NoBindingsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        public virtual NoBindingsOperationResponse NoBindingsOperation(NoBindingsOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoBindingsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoBindingsOperationResponseUnmarshaller.Instance;

            return Invoke<NoBindingsOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoBindingsOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoBindingsOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        public virtual IAsyncResult BeginNoBindingsOperation(NoBindingsOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoBindingsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoBindingsOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoBindingsOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoBindingsOperation.</param>
        /// 
        /// <returns>Returns a  NoBindingsOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        public virtual NoBindingsOperationResponse EndNoBindingsOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<NoBindingsOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  StaticContextOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation service method.</param>
        /// 
        /// <returns>The response from the StaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        public virtual StaticContextOperationResponse StaticContextOperation(StaticContextOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticContextOperationResponseUnmarshaller.Instance;

            return Invoke<StaticContextOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStaticContextOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        public virtual IAsyncResult BeginStaticContextOperation(StaticContextOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticContextOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticContextOperation.</param>
        /// 
        /// <returns>Returns a  StaticContextOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        public virtual StaticContextOperationResponse EndStaticContextOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<StaticContextOperationResponse>(asyncResult);
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
            var resolver = new AmazonEp2complexparametersEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}