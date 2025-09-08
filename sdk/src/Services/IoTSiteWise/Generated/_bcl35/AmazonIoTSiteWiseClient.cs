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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTSiteWise.Model;
using Amazon.IoTSiteWise.Model.Internal.MarshallTransformations;
using Amazon.IoTSiteWise.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IoTSiteWise
{
    /// <summary>
    /// <para>Implementation for accessing IoTSiteWise</para>
    ///
    /// Welcome to the IoT SiteWise API Reference. IoT SiteWise is an Amazon Web Services
    /// service that connects <a href="https://en.wikipedia.org/wiki/Internet_of_things#Industrial_applications">Industrial
    /// Internet of Things (IIoT)</a> devices to the power of the Amazon Web Services Cloud.
    /// For more information, see the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/">IoT
    /// SiteWise User Guide</a>. For information about IoT SiteWise quotas, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
    /// in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class AmazonIoTSiteWiseClient : AmazonServiceClient, IAmazonIoTSiteWise
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTSiteWiseMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIoTSiteWisePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTSiteWisePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTSiteWisePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        public AmazonIoTSiteWiseClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTSiteWiseConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        public AmazonIoTSiteWiseClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTSiteWiseConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(AmazonIoTSiteWiseConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTSiteWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials and an
        /// AmazonIoTSiteWiseClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials, AmazonIoTSiteWiseConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSiteWiseConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSiteWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTSiteWiseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSiteWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSiteWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTSiteWiseConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSiteWiseEndpointResolver());
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


        #region  AssociateAssets

        /// <summary>
        /// Associates a child asset with the given parent asset through a hierarchy defined in
        /// the parent asset's model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/add-associated-assets.html">Associating
        /// assets</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssets service method.</param>
        /// 
        /// <returns>The response from the AssociateAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateAssets">REST API Reference for AssociateAssets Operation</seealso>
        public virtual AssociateAssetsResponse AssociateAssets(AssociateAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssetsResponseUnmarshaller.Instance;

            return Invoke<AssociateAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateAssets">REST API Reference for AssociateAssets Operation</seealso>
        public virtual IAsyncResult BeginAssociateAssets(AssociateAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAssets.</param>
        /// 
        /// <returns>Returns a  AssociateAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateAssets">REST API Reference for AssociateAssets Operation</seealso>
        public virtual AssociateAssetsResponse EndAssociateAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateTimeSeriesToAssetProperty

        /// <summary>
        /// Associates a time series (data stream) with an asset property.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTimeSeriesToAssetProperty service method.</param>
        /// 
        /// <returns>The response from the AssociateTimeSeriesToAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateTimeSeriesToAssetProperty">REST API Reference for AssociateTimeSeriesToAssetProperty Operation</seealso>
        public virtual AssociateTimeSeriesToAssetPropertyResponse AssociateTimeSeriesToAssetProperty(AssociateTimeSeriesToAssetPropertyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTimeSeriesToAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTimeSeriesToAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<AssociateTimeSeriesToAssetPropertyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTimeSeriesToAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTimeSeriesToAssetProperty operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTimeSeriesToAssetProperty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateTimeSeriesToAssetProperty">REST API Reference for AssociateTimeSeriesToAssetProperty Operation</seealso>
        public virtual IAsyncResult BeginAssociateTimeSeriesToAssetProperty(AssociateTimeSeriesToAssetPropertyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTimeSeriesToAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTimeSeriesToAssetPropertyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTimeSeriesToAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTimeSeriesToAssetProperty.</param>
        /// 
        /// <returns>Returns a  AssociateTimeSeriesToAssetPropertyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateTimeSeriesToAssetProperty">REST API Reference for AssociateTimeSeriesToAssetProperty Operation</seealso>
        public virtual AssociateTimeSeriesToAssetPropertyResponse EndAssociateTimeSeriesToAssetProperty(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTimeSeriesToAssetPropertyResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchAssociateProjectAssets

        /// <summary>
        /// Associates a group (batch) of assets with an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateProjectAssets service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchAssociateProjectAssets">REST API Reference for BatchAssociateProjectAssets Operation</seealso>
        public virtual BatchAssociateProjectAssetsResponse BatchAssociateProjectAssets(BatchAssociateProjectAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateProjectAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateProjectAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateProjectAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchAssociateProjectAssets">REST API Reference for BatchAssociateProjectAssets Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateProjectAssets(BatchAssociateProjectAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateProjectAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateProjectAssets.</param>
        /// 
        /// <returns>Returns a  BatchAssociateProjectAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchAssociateProjectAssets">REST API Reference for BatchAssociateProjectAssets Operation</seealso>
        public virtual BatchAssociateProjectAssetsResponse EndBatchAssociateProjectAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateProjectAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateProjectAssets

        /// <summary>
        /// Disassociates a group (batch) of assets from an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateProjectAssets service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDisassociateProjectAssets">REST API Reference for BatchDisassociateProjectAssets Operation</seealso>
        public virtual BatchDisassociateProjectAssetsResponse BatchDisassociateProjectAssets(BatchDisassociateProjectAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateProjectAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateProjectAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateProjectAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDisassociateProjectAssets">REST API Reference for BatchDisassociateProjectAssets Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateProjectAssets(BatchDisassociateProjectAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateProjectAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateProjectAssets.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateProjectAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDisassociateProjectAssets">REST API Reference for BatchDisassociateProjectAssets Operation</seealso>
        public virtual BatchDisassociateProjectAssetsResponse EndBatchDisassociateProjectAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateProjectAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetAssetPropertyAggregates

        /// <summary>
        /// Gets aggregated values (for example, average, minimum, and maximum) for one or more
        /// asset properties. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
        /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyAggregates service method.</param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyAggregates service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyAggregates">REST API Reference for BatchGetAssetPropertyAggregates Operation</seealso>
        public virtual BatchGetAssetPropertyAggregatesResponse BatchGetAssetPropertyAggregates(BatchGetAssetPropertyAggregatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyAggregatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAssetPropertyAggregates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyAggregates operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAssetPropertyAggregates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyAggregates">REST API Reference for BatchGetAssetPropertyAggregates Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAssetPropertyAggregates(BatchGetAssetPropertyAggregatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAssetPropertyAggregates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAssetPropertyAggregates.</param>
        /// 
        /// <returns>Returns a  BatchGetAssetPropertyAggregatesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyAggregates">REST API Reference for BatchGetAssetPropertyAggregates Operation</seealso>
        public virtual BatchGetAssetPropertyAggregatesResponse EndBatchGetAssetPropertyAggregates(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAssetPropertyAggregatesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetAssetPropertyValue

        /// <summary>
        /// Gets the current value for one or more asset properties. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#current-values">Querying
        /// current values</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValue">REST API Reference for BatchGetAssetPropertyValue Operation</seealso>
        public virtual BatchGetAssetPropertyValueResponse BatchGetAssetPropertyValue(BatchGetAssetPropertyValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyValueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValue operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAssetPropertyValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValue">REST API Reference for BatchGetAssetPropertyValue Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAssetPropertyValue(BatchGetAssetPropertyValueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAssetPropertyValue.</param>
        /// 
        /// <returns>Returns a  BatchGetAssetPropertyValueResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValue">REST API Reference for BatchGetAssetPropertyValue Operation</seealso>
        public virtual BatchGetAssetPropertyValueResponse EndBatchGetAssetPropertyValue(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAssetPropertyValueResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetAssetPropertyValueHistory

        /// <summary>
        /// Gets the historical values for one or more asset properties. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#historical-values">Querying
        /// historical values</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyValueHistory service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValueHistory">REST API Reference for BatchGetAssetPropertyValueHistory Operation</seealso>
        public virtual BatchGetAssetPropertyValueHistoryResponse BatchGetAssetPropertyValueHistory(BatchGetAssetPropertyValueHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyValueHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAssetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValueHistory operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAssetPropertyValueHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValueHistory">REST API Reference for BatchGetAssetPropertyValueHistory Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAssetPropertyValueHistory(BatchGetAssetPropertyValueHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAssetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAssetPropertyValueHistory.</param>
        /// 
        /// <returns>Returns a  BatchGetAssetPropertyValueHistoryResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValueHistory">REST API Reference for BatchGetAssetPropertyValueHistory Operation</seealso>
        public virtual BatchGetAssetPropertyValueHistoryResponse EndBatchGetAssetPropertyValueHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAssetPropertyValueHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutAssetPropertyValue

        /// <summary>
        /// Sends a list of asset property values to IoT SiteWise. Each value is a timestamp-quality-value
        /// (TQV) data point. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ingest-api.html">Ingesting
        /// data using the API</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// With respect to Unix epoch time, IoT SiteWise accepts only TQVs that have a timestamp
        /// of no more than 7 days in the past and no more than 10 minutes in the future. IoT
        /// SiteWise rejects timestamps outside of the inclusive range of [-7 days, +10 minutes]
        /// and returns a <c>TimestampOutOfRangeException</c> error.
        /// </para>
        ///  
        /// <para>
        /// For each asset property, IoT SiteWise overwrites TQVs with duplicate timestamps unless
        /// the newer TQV has a different quality. For example, if you store a TQV <c>{T1, GOOD,
        /// V1}</c>, then storing <c>{T1, GOOD, V2}</c> replaces the existing TQV.
        /// </para>
        ///  </important> 
        /// <para>
        /// IoT SiteWise authorizes access to each <c>BatchPutAssetPropertyValue</c> entry individually.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-batchputassetpropertyvalue-action">BatchPutAssetPropertyValue
        /// authorization</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAssetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the BatchPutAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchPutAssetPropertyValue">REST API Reference for BatchPutAssetPropertyValue Operation</seealso>
        public virtual BatchPutAssetPropertyValueResponse BatchPutAssetPropertyValue(BatchPutAssetPropertyValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<BatchPutAssetPropertyValueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAssetPropertyValue operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutAssetPropertyValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchPutAssetPropertyValue">REST API Reference for BatchPutAssetPropertyValue Operation</seealso>
        public virtual IAsyncResult BeginBatchPutAssetPropertyValue(BatchPutAssetPropertyValueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAssetPropertyValueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutAssetPropertyValue.</param>
        /// 
        /// <returns>Returns a  BatchPutAssetPropertyValueResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchPutAssetPropertyValue">REST API Reference for BatchPutAssetPropertyValue Operation</seealso>
        public virtual BatchPutAssetPropertyValueResponse EndBatchPutAssetPropertyValue(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutAssetPropertyValueResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessPolicy

        /// <summary>
        /// Creates an access policy that grants the specified identity (IAM Identity Center user,
        /// IAM Identity Center group, or IAM user) access to the specified IoT SiteWise Monitor
        /// portal or project resource.
        /// 
        ///  <note> 
        /// <para>
        /// Support for access policies that use an SSO Group as the identity is not supported
        /// at this time.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessPolicy(CreateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateAccessPolicyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual CreateAccessPolicyResponse EndCreateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAsset

        /// <summary>
        /// Creates an asset from an existing asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-assets.html">Creating
        /// assets</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual IAsyncResult BeginCreateAsset(CreateAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAsset.</param>
        /// 
        /// <returns>Returns a  CreateAssetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse EndCreateAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssetModel

        /// <summary>
        /// Creates an asset model from specified property and hierarchy definitions. You create
        /// assets from asset models. With asset models, you can easily create assets of the same
        /// type that have standardized definitions. Each asset created from a model inherits
        /// the asset model's property and hierarchy definitions. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/define-models.html">Defining
        /// asset models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create three types of asset models, <c>ASSET_MODEL</c>, <c>COMPONENT_MODEL</c>,
        /// or an <c>INTERFACE</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – (default) An asset model that you can use to create assets.
        /// Can't be included as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERFACE</b> – An interface is a type of model that defines a standard structure
        /// that can be applied to different asset models.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModel service method.</param>
        /// 
        /// <returns>The response from the CreateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModel">REST API Reference for CreateAssetModel Operation</seealso>
        public virtual CreateAssetModelResponse CreateAssetModel(CreateAssetModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelResponseUnmarshaller.Instance;

            return Invoke<CreateAssetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModel">REST API Reference for CreateAssetModel Operation</seealso>
        public virtual IAsyncResult BeginCreateAssetModel(CreateAssetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssetModel.</param>
        /// 
        /// <returns>Returns a  CreateAssetModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModel">REST API Reference for CreateAssetModel Operation</seealso>
        public virtual CreateAssetModelResponse EndCreateAssetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssetModelCompositeModel

        /// <summary>
        /// Creates a custom composite model from specified property and hierarchy definitions.
        /// There are two types of custom composite models, <c>inline</c> and <c>component-model-based</c>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use component-model-based custom composite models to define standard, reusable components.
        /// A component-model-based custom composite model consists of a name, a description,
        /// and the ID of the component model it references. A component-model-based custom composite
        /// model has no properties of its own; its referenced component model provides its associated
        /// properties to any created assets. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
        /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use inline custom composite models to organize the properties of an asset model. The
        /// properties of inline custom composite models are local to the asset model where they
        /// are included and can't be used to create multiple assets.
        /// </para>
        ///  
        /// <para>
        /// To create a component-model-based model, specify the <c>composedAssetModelId</c> of
        /// an existing asset model with <c>assetModelType</c> of <c>COMPONENT_MODEL</c>.
        /// </para>
        ///  
        /// <para>
        /// To create an inline model, specify the <c>assetModelCompositeModelProperties</c> and
        /// don't include an <c>composedAssetModelId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModelCompositeModel service method.</param>
        /// 
        /// <returns>The response from the CreateAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModelCompositeModel">REST API Reference for CreateAssetModelCompositeModel Operation</seealso>
        public virtual CreateAssetModelCompositeModelResponse CreateAssetModelCompositeModel(CreateAssetModelCompositeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<CreateAssetModelCompositeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModelCompositeModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssetModelCompositeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModelCompositeModel">REST API Reference for CreateAssetModelCompositeModel Operation</seealso>
        public virtual IAsyncResult BeginCreateAssetModelCompositeModel(CreateAssetModelCompositeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssetModelCompositeModel.</param>
        /// 
        /// <returns>Returns a  CreateAssetModelCompositeModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModelCompositeModel">REST API Reference for CreateAssetModelCompositeModel Operation</seealso>
        public virtual CreateAssetModelCompositeModelResponse EndCreateAssetModelCompositeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetModelCompositeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBulkImportJob

        /// <summary>
        /// Defines a job to ingest data to IoT SiteWise from Amazon S3. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/CreateBulkImportJob.html">Create
        /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Before you create a bulk import job, you must enable IoT SiteWise warm tier or IoT
        /// SiteWise cold tier. For more information about how to configure storage settings,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_PutStorageConfiguration.html">PutStorageConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// Bulk import is designed to store historical data to IoT SiteWise.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Newly ingested data in the hot tier triggers notifications and computations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After data moves from the hot tier to the warm or cold tier based on retention settings,
        /// it does not trigger computations or notifications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data older than 7 days does not trigger computations or notifications.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBulkImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateBulkImportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateBulkImportJob">REST API Reference for CreateBulkImportJob Operation</seealso>
        public virtual CreateBulkImportJobResponse CreateBulkImportJob(CreateBulkImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBulkImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateBulkImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBulkImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBulkImportJob operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBulkImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateBulkImportJob">REST API Reference for CreateBulkImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateBulkImportJob(CreateBulkImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBulkImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBulkImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBulkImportJob.</param>
        /// 
        /// <returns>Returns a  CreateBulkImportJobResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateBulkImportJob">REST API Reference for CreateBulkImportJob Operation</seealso>
        public virtual CreateBulkImportJobResponse EndCreateBulkImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBulkImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComputationModel

        /// <summary>
        /// Create a computation model with a configuration and data binding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputationModel service method.</param>
        /// 
        /// <returns>The response from the CreateComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateComputationModel">REST API Reference for CreateComputationModel Operation</seealso>
        public virtual CreateComputationModelResponse CreateComputationModel(CreateComputationModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputationModelResponseUnmarshaller.Instance;

            return Invoke<CreateComputationModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputationModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputationModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComputationModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateComputationModel">REST API Reference for CreateComputationModel Operation</seealso>
        public virtual IAsyncResult BeginCreateComputationModel(CreateComputationModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputationModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComputationModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComputationModel.</param>
        /// 
        /// <returns>Returns a  CreateComputationModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateComputationModel">REST API Reference for CreateComputationModel Operation</seealso>
        public virtual CreateComputationModelResponse EndCreateComputationModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComputationModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDashboard

        /// <summary>
        /// Creates a dashboard in an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual IAsyncResult BeginCreateDashboard(CreateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDashboard.</param>
        /// 
        /// <returns>Returns a  CreateDashboardResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse EndCreateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataset

        /// <summary>
        /// Creates a dataset to connect an external datasource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGateway

        /// <summary>
        /// Creates a gateway, which is a virtual or edge device that delivers industrial data
        /// streams from local servers to IoT SiteWise. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gateway-connector.html">Ingesting
        /// data using a gateway</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateGateway(CreateGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGateway.</param>
        /// 
        /// <returns>Returns a  CreateGatewayResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse EndCreateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortal

        /// <summary>
        /// Creates a portal, which can contain projects and dashboards. IoT SiteWise Monitor
        /// uses IAM Identity Center or IAM to authenticate portal users and manage user permissions.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can sign in to a new portal, you must add at least one identity to that
        /// portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
        /// or removing portal administrators</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual IAsyncResult BeginCreatePortal(CreatePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortal.</param>
        /// 
        /// <returns>Returns a  CreatePortalResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse EndCreatePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a project in the specified portal.
        /// 
        ///  <note> 
        /// <para>
        /// Make sure that the project name and description don't contain confidential information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateProjectResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessPolicy

        /// <summary>
        /// Deletes an access policy that grants the specified identity access to the specified
        /// IoT SiteWise Monitor resource. You can use this operation to revoke access to an IoT
        /// SiteWise Monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual DeleteAccessPolicyResponse DeleteAccessPolicy(DeleteAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessPolicy(DeleteAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPolicyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual DeleteAccessPolicyResponse EndDeleteAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAsset

        /// <summary>
        /// Deletes an asset. This action can't be undone. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete an asset that's associated to another asset. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DisassociateAssets.html">DisassociateAssets</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual IAsyncResult BeginDeleteAsset(DeleteAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAsset.</param>
        /// 
        /// <returns>Returns a  DeleteAssetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse EndDeleteAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssetModel

        /// <summary>
        /// Deletes an asset model. This action can't be undone. You must delete all assets created
        /// from an asset model before you can delete the model. Also, you can't delete an asset
        /// model if a parent asset model exists that contains a property formula expression that
        /// depends on the asset model that you want to delete. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModel">REST API Reference for DeleteAssetModel Operation</seealso>
        public virtual DeleteAssetModelResponse DeleteAssetModel(DeleteAssetModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModel">REST API Reference for DeleteAssetModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssetModel(DeleteAssetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssetModel.</param>
        /// 
        /// <returns>Returns a  DeleteAssetModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModel">REST API Reference for DeleteAssetModel Operation</seealso>
        public virtual DeleteAssetModelResponse EndDeleteAssetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssetModelCompositeModel

        /// <summary>
        /// Deletes a composite model. This action can't be undone. You must delete all assets
        /// created from a composite model before you can delete the model. Also, you can't delete
        /// a composite model if a parent asset model exists that contains a property formula
        /// expression that depends on the asset model that you want to delete. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelCompositeModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelCompositeModel">REST API Reference for DeleteAssetModelCompositeModel Operation</seealso>
        public virtual DeleteAssetModelCompositeModelResponse DeleteAssetModelCompositeModel(DeleteAssetModelCompositeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelCompositeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelCompositeModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssetModelCompositeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelCompositeModel">REST API Reference for DeleteAssetModelCompositeModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssetModelCompositeModel(DeleteAssetModelCompositeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelCompositeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssetModelCompositeModel.</param>
        /// 
        /// <returns>Returns a  DeleteAssetModelCompositeModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelCompositeModel">REST API Reference for DeleteAssetModelCompositeModel Operation</seealso>
        public virtual DeleteAssetModelCompositeModelResponse EndDeleteAssetModelCompositeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetModelCompositeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssetModelInterfaceRelationship

        /// <summary>
        /// Deletes an interface relationship between an asset model and an interface asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelInterfaceRelationship service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelInterfaceRelationship">REST API Reference for DeleteAssetModelInterfaceRelationship Operation</seealso>
        public virtual DeleteAssetModelInterfaceRelationshipResponse DeleteAssetModelInterfaceRelationship(DeleteAssetModelInterfaceRelationshipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelInterfaceRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelInterfaceRelationship operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssetModelInterfaceRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelInterfaceRelationship">REST API Reference for DeleteAssetModelInterfaceRelationship Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssetModelInterfaceRelationship(DeleteAssetModelInterfaceRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssetModelInterfaceRelationship.</param>
        /// 
        /// <returns>Returns a  DeleteAssetModelInterfaceRelationshipResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelInterfaceRelationship">REST API Reference for DeleteAssetModelInterfaceRelationship Operation</seealso>
        public virtual DeleteAssetModelInterfaceRelationshipResponse EndDeleteAssetModelInterfaceRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetModelInterfaceRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComputationModel

        /// <summary>
        /// Deletes a computation model. This action can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputationModel service method.</param>
        /// 
        /// <returns>The response from the DeleteComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteComputationModel">REST API Reference for DeleteComputationModel Operation</seealso>
        public virtual DeleteComputationModelResponse DeleteComputationModel(DeleteComputationModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputationModelResponseUnmarshaller.Instance;

            return Invoke<DeleteComputationModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComputationModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputationModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComputationModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteComputationModel">REST API Reference for DeleteComputationModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteComputationModel(DeleteComputationModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputationModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComputationModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComputationModel.</param>
        /// 
        /// <returns>Returns a  DeleteComputationModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteComputationModel">REST API Reference for DeleteComputationModel Operation</seealso>
        public virtual DeleteComputationModelResponse EndDeleteComputationModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComputationModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDashboard

        /// <summary>
        /// Deletes a dashboard from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual IAsyncResult BeginDeleteDashboard(DeleteDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboard.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse EndDeleteDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes a dataset. This cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGateway

        /// <summary>
        /// Deletes a gateway from IoT SiteWise. When you delete a gateway, some of the gateway's
        /// files remain in your gateway's file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePortal

        /// <summary>
        /// Deletes a portal from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual IAsyncResult BeginDeletePortal(DeletePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortal.</param>
        /// 
        /// <returns>Returns a  DeletePortalResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse EndDeletePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes a project from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteProjectResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTimeSeries

        /// <summary>
        /// Deletes a time series (data stream). If you delete a time series that's associated
        /// with an asset property, the asset property still exists, but the time series will
        /// no longer be associated with this asset property.
        /// 
        ///  
        /// <para>
        /// To identify a time series, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the time series isn't associated with an asset property, specify the <c>alias</c>
        /// of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the time series is associated with an asset property, specify one of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>alias</c> of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> that identifies the asset property.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeries service method.</param>
        /// 
        /// <returns>The response from the DeleteTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteTimeSeries">REST API Reference for DeleteTimeSeries Operation</seealso>
        public virtual DeleteTimeSeriesResponse DeleteTimeSeries(DeleteTimeSeriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<DeleteTimeSeriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeries operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTimeSeries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteTimeSeries">REST API Reference for DeleteTimeSeries Operation</seealso>
        public virtual IAsyncResult BeginDeleteTimeSeries(DeleteTimeSeriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTimeSeries.</param>
        /// 
        /// <returns>Returns a  DeleteTimeSeriesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteTimeSeries">REST API Reference for DeleteTimeSeries Operation</seealso>
        public virtual DeleteTimeSeriesResponse EndDeleteTimeSeries(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTimeSeriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccessPolicy

        /// <summary>
        /// Describes an access policy, which specifies an identity's access to an IoT SiteWise
        /// Monitor portal or project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAccessPolicy">REST API Reference for DescribeAccessPolicy Operation</seealso>
        public virtual DescribeAccessPolicyResponse DescribeAccessPolicy(DescribeAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPolicy operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAccessPolicy">REST API Reference for DescribeAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccessPolicy(DescribeAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeAccessPolicyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAccessPolicy">REST API Reference for DescribeAccessPolicy Operation</seealso>
        public virtual DescribeAccessPolicyResponse EndDescribeAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAction

        /// <summary>
        /// Retrieves information about an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction service method.</param>
        /// 
        /// <returns>The response from the DescribeAction service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        public virtual DescribeActionResponse DescribeAction(DescribeActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return Invoke<DescribeActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        public virtual IAsyncResult BeginDescribeAction(DescribeActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAction.</param>
        /// 
        /// <returns>Returns a  DescribeActionResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        public virtual DescribeActionResponse EndDescribeAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAsset

        /// <summary>
        /// Retrieves information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// 
        /// <returns>The response from the DescribeAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual DescribeAssetResponse DescribeAsset(DescribeAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual IAsyncResult BeginDescribeAsset(DescribeAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAsset.</param>
        /// 
        /// <returns>Returns a  DescribeAssetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual DescribeAssetResponse EndDescribeAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssetCompositeModel

        /// <summary>
        /// Retrieves information about an asset composite model (also known as an asset component).
        /// An <c>AssetCompositeModel</c> is an instance of an <c>AssetModelCompositeModel</c>.
        /// If you want to see information about the model this is based on, call <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetModelCompositeModel.html">DescribeAssetModelCompositeModel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetCompositeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetCompositeModel">REST API Reference for DescribeAssetCompositeModel Operation</seealso>
        public virtual DescribeAssetCompositeModelResponse DescribeAssetCompositeModel(DescribeAssetCompositeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetCompositeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetCompositeModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetCompositeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetCompositeModel">REST API Reference for DescribeAssetCompositeModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssetCompositeModel(DescribeAssetCompositeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetCompositeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetCompositeModel.</param>
        /// 
        /// <returns>Returns a  DescribeAssetCompositeModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetCompositeModel">REST API Reference for DescribeAssetCompositeModel Operation</seealso>
        public virtual DescribeAssetCompositeModelResponse EndDescribeAssetCompositeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetCompositeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssetModel

        /// <summary>
        /// Retrieves information about an asset model. This includes details about the asset
        /// model's properties, hierarchies, composite models, and any interface relationships
        /// if the asset model implements interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModel service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModel">REST API Reference for DescribeAssetModel Operation</seealso>
        public virtual DescribeAssetModelResponse DescribeAssetModel(DescribeAssetModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModel">REST API Reference for DescribeAssetModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssetModel(DescribeAssetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetModel.</param>
        /// 
        /// <returns>Returns a  DescribeAssetModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModel">REST API Reference for DescribeAssetModel Operation</seealso>
        public virtual DescribeAssetModelResponse EndDescribeAssetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssetModelCompositeModel

        /// <summary>
        /// Retrieves information about an asset model composite model (also known as an asset
        /// model component). For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
        /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelCompositeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelCompositeModel">REST API Reference for DescribeAssetModelCompositeModel Operation</seealso>
        public virtual DescribeAssetModelCompositeModelResponse DescribeAssetModelCompositeModel(DescribeAssetModelCompositeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelCompositeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelCompositeModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetModelCompositeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelCompositeModel">REST API Reference for DescribeAssetModelCompositeModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssetModelCompositeModel(DescribeAssetModelCompositeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelCompositeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetModelCompositeModel.</param>
        /// 
        /// <returns>Returns a  DescribeAssetModelCompositeModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelCompositeModel">REST API Reference for DescribeAssetModelCompositeModel Operation</seealso>
        public virtual DescribeAssetModelCompositeModelResponse EndDescribeAssetModelCompositeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetModelCompositeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssetModelInterfaceRelationship

        /// <summary>
        /// Retrieves information about an interface relationship between an asset model and an
        /// interface asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelInterfaceRelationship service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelInterfaceRelationship">REST API Reference for DescribeAssetModelInterfaceRelationship Operation</seealso>
        public virtual DescribeAssetModelInterfaceRelationshipResponse DescribeAssetModelInterfaceRelationship(DescribeAssetModelInterfaceRelationshipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelInterfaceRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelInterfaceRelationship operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetModelInterfaceRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelInterfaceRelationship">REST API Reference for DescribeAssetModelInterfaceRelationship Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssetModelInterfaceRelationship(DescribeAssetModelInterfaceRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetModelInterfaceRelationship.</param>
        /// 
        /// <returns>Returns a  DescribeAssetModelInterfaceRelationshipResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelInterfaceRelationship">REST API Reference for DescribeAssetModelInterfaceRelationship Operation</seealso>
        public virtual DescribeAssetModelInterfaceRelationshipResponse EndDescribeAssetModelInterfaceRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetModelInterfaceRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssetProperty

        /// <summary>
        /// Retrieves information about an asset property.
        /// 
        ///  <note> 
        /// <para>
        /// When you call this operation for an attribute property, this response includes the
        /// default attribute value that you define in the asset model. If you update the default
        /// value in the model, this operation's response includes the new default value.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation doesn't return the value of the asset property. To get the value of
        /// an asset property, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_GetAssetPropertyValue.html">GetAssetPropertyValue</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetProperty service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetProperty">REST API Reference for DescribeAssetProperty Operation</seealso>
        public virtual DescribeAssetPropertyResponse DescribeAssetProperty(DescribeAssetPropertyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetPropertyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetProperty operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetProperty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetProperty">REST API Reference for DescribeAssetProperty Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssetProperty(DescribeAssetPropertyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetPropertyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetProperty.</param>
        /// 
        /// <returns>Returns a  DescribeAssetPropertyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetProperty">REST API Reference for DescribeAssetProperty Operation</seealso>
        public virtual DescribeAssetPropertyResponse EndDescribeAssetProperty(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetPropertyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBulkImportJob

        /// <summary>
        /// Retrieves information about a bulk import job request. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/DescribeBulkImportJob.html">Describe
        /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBulkImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeBulkImportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeBulkImportJob">REST API Reference for DescribeBulkImportJob Operation</seealso>
        public virtual DescribeBulkImportJobResponse DescribeBulkImportJob(DescribeBulkImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBulkImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBulkImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBulkImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBulkImportJob operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBulkImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeBulkImportJob">REST API Reference for DescribeBulkImportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeBulkImportJob(DescribeBulkImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBulkImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBulkImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBulkImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeBulkImportJobResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeBulkImportJob">REST API Reference for DescribeBulkImportJob Operation</seealso>
        public virtual DescribeBulkImportJobResponse EndDescribeBulkImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBulkImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComputationModel

        /// <summary>
        /// Retrieves information about a computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModel service method.</param>
        /// 
        /// <returns>The response from the DescribeComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModel">REST API Reference for DescribeComputationModel Operation</seealso>
        public virtual DescribeComputationModelResponse DescribeComputationModel(DescribeComputationModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelResponseUnmarshaller.Instance;

            return Invoke<DescribeComputationModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComputationModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComputationModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModel">REST API Reference for DescribeComputationModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeComputationModel(DescribeComputationModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComputationModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComputationModel.</param>
        /// 
        /// <returns>Returns a  DescribeComputationModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModel">REST API Reference for DescribeComputationModel Operation</seealso>
        public virtual DescribeComputationModelResponse EndDescribeComputationModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComputationModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComputationModelExecutionSummary

        /// <summary>
        /// Retrieves information about the execution summary of a computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModelExecutionSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeComputationModelExecutionSummary service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModelExecutionSummary">REST API Reference for DescribeComputationModelExecutionSummary Operation</seealso>
        public virtual DescribeComputationModelExecutionSummaryResponse DescribeComputationModelExecutionSummary(DescribeComputationModelExecutionSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelExecutionSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelExecutionSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeComputationModelExecutionSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComputationModelExecutionSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModelExecutionSummary operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComputationModelExecutionSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModelExecutionSummary">REST API Reference for DescribeComputationModelExecutionSummary Operation</seealso>
        public virtual IAsyncResult BeginDescribeComputationModelExecutionSummary(DescribeComputationModelExecutionSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelExecutionSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelExecutionSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComputationModelExecutionSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComputationModelExecutionSummary.</param>
        /// 
        /// <returns>Returns a  DescribeComputationModelExecutionSummaryResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModelExecutionSummary">REST API Reference for DescribeComputationModelExecutionSummary Operation</seealso>
        public virtual DescribeComputationModelExecutionSummaryResponse EndDescribeComputationModelExecutionSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComputationModelExecutionSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDashboard

        /// <summary>
        /// Retrieves information about a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual IAsyncResult BeginDescribeDashboard(DescribeDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboard.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual DescribeDashboardResponse EndDescribeDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Retrieves information about a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDefaultEncryptionConfiguration

        /// <summary>
        /// Retrieves information about the default encryption configuration for the Amazon Web
        /// Services account in the default or specified Region. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDefaultEncryptionConfiguration">REST API Reference for DescribeDefaultEncryptionConfiguration Operation</seealso>
        public virtual DescribeDefaultEncryptionConfigurationResponse DescribeDefaultEncryptionConfiguration(DescribeDefaultEncryptionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultEncryptionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultEncryptionConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultEncryptionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDefaultEncryptionConfiguration">REST API Reference for DescribeDefaultEncryptionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeDefaultEncryptionConfiguration(DescribeDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultEncryptionConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDefaultEncryptionConfiguration">REST API Reference for DescribeDefaultEncryptionConfiguration Operation</seealso>
        public virtual DescribeDefaultEncryptionConfigurationResponse EndDescribeDefaultEncryptionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDefaultEncryptionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExecution

        /// <summary>
        /// Retrieves information about the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGateway

        /// <summary>
        /// Retrieves information about a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
        /// 
        /// <returns>The response from the DescribeGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual DescribeGatewayResponse DescribeGateway(DescribeGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual IAsyncResult BeginDescribeGateway(DescribeGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGateway.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual DescribeGatewayResponse EndDescribeGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGatewayCapabilityConfiguration

        /// <summary>
        /// Each gateway capability defines data sources for a gateway. This is the namespace
        /// of the gateway capability.
        /// 
        ///  
        /// <para>
        /// . The namespace follows the format <c>service:capability:version</c>, where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>service</c> - The service providing the capability, or <c>iotsitewise</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capability</c> - The specific capability type. Options include: <c>opcuacollector</c>
        /// for the OPC UA data source collector, or <c>publisher</c> for data publisher capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> - The version number of the capability. Option include <c>2</c> for
        /// Classic streams, V2 gateways, and <c>3</c> for MQTT-enabled, V3 gateways.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After updating a capability configuration, the sync status becomes <c>OUT_OF_SYNC</c>
        /// until the gateway processes the configuration.Use <c>DescribeGatewayCapabilityConfiguration</c>
        /// to check the sync status and verify the configuration was applied.
        /// </para>
        ///  
        /// <para>
        /// A gateway can have multiple capability configurations with different namespaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayCapabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGatewayCapabilityConfiguration">REST API Reference for DescribeGatewayCapabilityConfiguration Operation</seealso>
        public virtual DescribeGatewayCapabilityConfigurationResponse DescribeGatewayCapabilityConfiguration(DescribeGatewayCapabilityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayCapabilityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayCapabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayCapabilityConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGatewayCapabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGatewayCapabilityConfiguration">REST API Reference for DescribeGatewayCapabilityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeGatewayCapabilityConfiguration(DescribeGatewayCapabilityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGatewayCapabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayCapabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayCapabilityConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGatewayCapabilityConfiguration">REST API Reference for DescribeGatewayCapabilityConfiguration Operation</seealso>
        public virtual DescribeGatewayCapabilityConfigurationResponse EndDescribeGatewayCapabilityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayCapabilityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingOptions

        /// <summary>
        /// Retrieves the current IoT SiteWise logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingOptions(DescribeLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeLoggingOptionsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual DescribeLoggingOptionsResponse EndDescribeLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePortal

        /// <summary>
        /// Retrieves information about a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortal service method.</param>
        /// 
        /// <returns>The response from the DescribePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePortal">REST API Reference for DescribePortal Operation</seealso>
        public virtual DescribePortalResponse DescribePortal(DescribePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortalResponseUnmarshaller.Instance;

            return Invoke<DescribePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortal operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePortal">REST API Reference for DescribePortal Operation</seealso>
        public virtual IAsyncResult BeginDescribePortal(DescribePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortal.</param>
        /// 
        /// <returns>Returns a  DescribePortalResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePortal">REST API Reference for DescribePortal Operation</seealso>
        public virtual DescribePortalResponse EndDescribePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProject

        /// <summary>
        /// Retrieves information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStorageConfiguration

        /// <summary>
        /// Retrieves information about the storage configuration for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeStorageConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeStorageConfiguration">REST API Reference for DescribeStorageConfiguration Operation</seealso>
        public virtual DescribeStorageConfigurationResponse DescribeStorageConfiguration(DescribeStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeStorageConfiguration">REST API Reference for DescribeStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeStorageConfiguration(DescribeStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeStorageConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeStorageConfiguration">REST API Reference for DescribeStorageConfiguration Operation</seealso>
        public virtual DescribeStorageConfigurationResponse EndDescribeStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTimeSeries

        /// <summary>
        /// Retrieves information about a time series (data stream).
        /// 
        ///  
        /// <para>
        /// To identify a time series, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the time series isn't associated with an asset property, specify the <c>alias</c>
        /// of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the time series is associated with an asset property, specify one of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>alias</c> of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> that identifies the asset property.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeSeries service method.</param>
        /// 
        /// <returns>The response from the DescribeTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeTimeSeries">REST API Reference for DescribeTimeSeries Operation</seealso>
        public virtual DescribeTimeSeriesResponse DescribeTimeSeries(DescribeTimeSeriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<DescribeTimeSeriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeSeries operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTimeSeries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeTimeSeries">REST API Reference for DescribeTimeSeries Operation</seealso>
        public virtual IAsyncResult BeginDescribeTimeSeries(DescribeTimeSeriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeSeriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeSeries.</param>
        /// 
        /// <returns>Returns a  DescribeTimeSeriesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeTimeSeries">REST API Reference for DescribeTimeSeries Operation</seealso>
        public virtual DescribeTimeSeriesResponse EndDescribeTimeSeries(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTimeSeriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAssets

        /// <summary>
        /// Disassociates a child asset from the given parent asset through a hierarchy defined
        /// in the parent asset's model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssets service method.</param>
        /// 
        /// <returns>The response from the DisassociateAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateAssets">REST API Reference for DisassociateAssets Operation</seealso>
        public virtual DisassociateAssetsResponse DisassociateAssets(DisassociateAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssetsResponseUnmarshaller.Instance;

            return Invoke<DisassociateAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateAssets">REST API Reference for DisassociateAssets Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAssets(DisassociateAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAssets.</param>
        /// 
        /// <returns>Returns a  DisassociateAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateAssets">REST API Reference for DisassociateAssets Operation</seealso>
        public virtual DisassociateAssetsResponse EndDisassociateAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTimeSeriesFromAssetProperty

        /// <summary>
        /// Disassociates a time series (data stream) from an asset property.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTimeSeriesFromAssetProperty service method.</param>
        /// 
        /// <returns>The response from the DisassociateTimeSeriesFromAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateTimeSeriesFromAssetProperty">REST API Reference for DisassociateTimeSeriesFromAssetProperty Operation</seealso>
        public virtual DisassociateTimeSeriesFromAssetPropertyResponse DisassociateTimeSeriesFromAssetProperty(DisassociateTimeSeriesFromAssetPropertyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTimeSeriesFromAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTimeSeriesFromAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<DisassociateTimeSeriesFromAssetPropertyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTimeSeriesFromAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTimeSeriesFromAssetProperty operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTimeSeriesFromAssetProperty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateTimeSeriesFromAssetProperty">REST API Reference for DisassociateTimeSeriesFromAssetProperty Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTimeSeriesFromAssetProperty(DisassociateTimeSeriesFromAssetPropertyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTimeSeriesFromAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTimeSeriesFromAssetPropertyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTimeSeriesFromAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTimeSeriesFromAssetProperty.</param>
        /// 
        /// <returns>Returns a  DisassociateTimeSeriesFromAssetPropertyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateTimeSeriesFromAssetProperty">REST API Reference for DisassociateTimeSeriesFromAssetProperty Operation</seealso>
        public virtual DisassociateTimeSeriesFromAssetPropertyResponse EndDisassociateTimeSeriesFromAssetProperty(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTimeSeriesFromAssetPropertyResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteAction

        /// <summary>
        /// Executes an action on a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteAction service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteAction">REST API Reference for ExecuteAction Operation</seealso>
        public virtual ExecuteActionResponse ExecuteAction(ExecuteActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteAction operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteAction">REST API Reference for ExecuteAction Operation</seealso>
        public virtual IAsyncResult BeginExecuteAction(ExecuteActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteAction.</param>
        /// 
        /// <returns>Returns a  ExecuteActionResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteAction">REST API Reference for ExecuteAction Operation</seealso>
        public virtual ExecuteActionResponse EndExecuteAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteActionResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteQuery

        /// <summary>
        /// Run SQL queries to retrieve metadata and time-series data from asset models, assets,
        /// measurements, metrics, transforms, and aggregates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.QueryTimeoutException">
        /// The query timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ValidationException">
        /// The validation failed for this query.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual IAsyncResult BeginExecuteQuery(ExecuteQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteQueryResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse EndExecuteQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssetPropertyAggregates

        /// <summary>
        /// Gets aggregated values for an asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
        /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyAggregates service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyAggregates service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyAggregates">REST API Reference for GetAssetPropertyAggregates Operation</seealso>
        public virtual GetAssetPropertyAggregatesResponse GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyAggregatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetPropertyAggregates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyAggregates operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetPropertyAggregates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyAggregates">REST API Reference for GetAssetPropertyAggregates Operation</seealso>
        public virtual IAsyncResult BeginGetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetPropertyAggregates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetPropertyAggregates.</param>
        /// 
        /// <returns>Returns a  GetAssetPropertyAggregatesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyAggregates">REST API Reference for GetAssetPropertyAggregates Operation</seealso>
        public virtual GetAssetPropertyAggregatesResponse EndGetAssetPropertyAggregates(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetPropertyAggregatesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssetPropertyValue

        /// <summary>
        /// Gets an asset property's current value. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#current-values">Querying
        /// current values</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValue">REST API Reference for GetAssetPropertyValue Operation</seealso>
        public virtual GetAssetPropertyValueResponse GetAssetPropertyValue(GetAssetPropertyValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyValueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValue operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetPropertyValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValue">REST API Reference for GetAssetPropertyValue Operation</seealso>
        public virtual IAsyncResult BeginGetAssetPropertyValue(GetAssetPropertyValueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetPropertyValue.</param>
        /// 
        /// <returns>Returns a  GetAssetPropertyValueResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValue">REST API Reference for GetAssetPropertyValue Operation</seealso>
        public virtual GetAssetPropertyValueResponse EndGetAssetPropertyValue(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetPropertyValueResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssetPropertyValueHistory

        /// <summary>
        /// Gets the history of an asset property's values. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#historical-values">Querying
        /// historical values</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyValueHistory service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValueHistory">REST API Reference for GetAssetPropertyValueHistory Operation</seealso>
        public virtual GetAssetPropertyValueHistoryResponse GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyValueHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValueHistory operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetPropertyValueHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValueHistory">REST API Reference for GetAssetPropertyValueHistory Operation</seealso>
        public virtual IAsyncResult BeginGetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetPropertyValueHistory.</param>
        /// 
        /// <returns>Returns a  GetAssetPropertyValueHistoryResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValueHistory">REST API Reference for GetAssetPropertyValueHistory Operation</seealso>
        public virtual GetAssetPropertyValueHistoryResponse EndGetAssetPropertyValueHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetPropertyValueHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInterpolatedAssetPropertyValues

        /// <summary>
        /// Get interpolated values for an asset property for a specified time interval, during
        /// a period of time. If your time series is missing data points during the specified
        /// time interval, you can use interpolation to estimate the missing data.
        /// 
        ///  
        /// <para>
        /// For example, you can use this operation to return the interpolated temperature values
        /// for a wind turbine every 24 hours over a duration of 7 days.
        /// </para>
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInterpolatedAssetPropertyValues service method.</param>
        /// 
        /// <returns>The response from the GetInterpolatedAssetPropertyValues service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetInterpolatedAssetPropertyValues">REST API Reference for GetInterpolatedAssetPropertyValues Operation</seealso>
        public virtual GetInterpolatedAssetPropertyValuesResponse GetInterpolatedAssetPropertyValues(GetInterpolatedAssetPropertyValuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInterpolatedAssetPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInterpolatedAssetPropertyValuesResponseUnmarshaller.Instance;

            return Invoke<GetInterpolatedAssetPropertyValuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInterpolatedAssetPropertyValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInterpolatedAssetPropertyValues operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInterpolatedAssetPropertyValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetInterpolatedAssetPropertyValues">REST API Reference for GetInterpolatedAssetPropertyValues Operation</seealso>
        public virtual IAsyncResult BeginGetInterpolatedAssetPropertyValues(GetInterpolatedAssetPropertyValuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInterpolatedAssetPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInterpolatedAssetPropertyValuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInterpolatedAssetPropertyValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInterpolatedAssetPropertyValues.</param>
        /// 
        /// <returns>Returns a  GetInterpolatedAssetPropertyValuesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetInterpolatedAssetPropertyValues">REST API Reference for GetInterpolatedAssetPropertyValues Operation</seealso>
        public virtual GetInterpolatedAssetPropertyValuesResponse EndGetInterpolatedAssetPropertyValues(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInterpolatedAssetPropertyValuesResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeAssistant

        /// <summary>
        /// Invokes SiteWise Assistant to start or continue a conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAssistant service method.</param>
        /// 
        /// <returns>The response from the InvokeAssistant service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/InvokeAssistant">REST API Reference for InvokeAssistant Operation</seealso>
        public virtual InvokeAssistantResponse InvokeAssistant(InvokeAssistantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAssistantResponseUnmarshaller.Instance;

            return Invoke<InvokeAssistantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAssistant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAssistant operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeAssistant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/InvokeAssistant">REST API Reference for InvokeAssistant Operation</seealso>
        public virtual IAsyncResult BeginInvokeAssistant(InvokeAssistantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAssistantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAssistant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAssistant.</param>
        /// 
        /// <returns>Returns a  InvokeAssistantResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/InvokeAssistant">REST API Reference for InvokeAssistant Operation</seealso>
        public virtual InvokeAssistantResponse EndInvokeAssistant(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeAssistantResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessPolicies

        /// <summary>
        /// Retrieves a paginated list of access policies for an identity (an IAM Identity Center
        /// user, an IAM Identity Center group, or an IAM user) or an IoT SiteWise Monitor resource
        /// (a portal or project).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAccessPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual IAsyncResult BeginListAccessPolicies(ListAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPolicies.</param>
        /// 
        /// <returns>Returns a  ListAccessPoliciesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse EndListAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListActions

        /// <summary>
        /// Retrieves a paginated list of actions for a specific target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual ListActionsResponse ListActions(ListActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return Invoke<ListActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActions operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual IAsyncResult BeginListActions(ListActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActions.</param>
        /// 
        /// <returns>Returns a  ListActionsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual ListActionsResponse EndListActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetModelCompositeModels

        /// <summary>
        /// Retrieves a paginated list of composite models associated with the asset model
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelCompositeModels service method.</param>
        /// 
        /// <returns>The response from the ListAssetModelCompositeModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelCompositeModels">REST API Reference for ListAssetModelCompositeModels Operation</seealso>
        public virtual ListAssetModelCompositeModelsResponse ListAssetModelCompositeModels(ListAssetModelCompositeModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelCompositeModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelCompositeModelsResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelCompositeModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetModelCompositeModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelCompositeModels operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetModelCompositeModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelCompositeModels">REST API Reference for ListAssetModelCompositeModels Operation</seealso>
        public virtual IAsyncResult BeginListAssetModelCompositeModels(ListAssetModelCompositeModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelCompositeModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelCompositeModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetModelCompositeModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetModelCompositeModels.</param>
        /// 
        /// <returns>Returns a  ListAssetModelCompositeModelsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelCompositeModels">REST API Reference for ListAssetModelCompositeModels Operation</seealso>
        public virtual ListAssetModelCompositeModelsResponse EndListAssetModelCompositeModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetModelCompositeModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetModelProperties

        /// <summary>
        /// Retrieves a paginated list of properties associated with an asset model. If you update
        /// properties associated with the model before you finish listing all the properties,
        /// you need to start all over again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelProperties service method.</param>
        /// 
        /// <returns>The response from the ListAssetModelProperties service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelProperties">REST API Reference for ListAssetModelProperties Operation</seealso>
        public virtual ListAssetModelPropertiesResponse ListAssetModelProperties(ListAssetModelPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelPropertiesResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetModelProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelProperties operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetModelProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelProperties">REST API Reference for ListAssetModelProperties Operation</seealso>
        public virtual IAsyncResult BeginListAssetModelProperties(ListAssetModelPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetModelProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetModelProperties.</param>
        /// 
        /// <returns>Returns a  ListAssetModelPropertiesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelProperties">REST API Reference for ListAssetModelProperties Operation</seealso>
        public virtual ListAssetModelPropertiesResponse EndListAssetModelProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetModelPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetModels

        /// <summary>
        /// Retrieves a paginated list of summaries of all asset models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModels service method.</param>
        /// 
        /// <returns>The response from the ListAssetModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModels">REST API Reference for ListAssetModels Operation</seealso>
        public virtual ListAssetModelsResponse ListAssetModels(ListAssetModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelsResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModels operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModels">REST API Reference for ListAssetModels Operation</seealso>
        public virtual IAsyncResult BeginListAssetModels(ListAssetModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetModels.</param>
        /// 
        /// <returns>Returns a  ListAssetModelsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModels">REST API Reference for ListAssetModels Operation</seealso>
        public virtual ListAssetModelsResponse EndListAssetModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetProperties

        /// <summary>
        /// Retrieves a paginated list of properties associated with an asset. If you update properties
        /// associated with the model before you finish listing all the properties, you need to
        /// start all over again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetProperties service method.</param>
        /// 
        /// <returns>The response from the ListAssetProperties service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetProperties">REST API Reference for ListAssetProperties Operation</seealso>
        public virtual ListAssetPropertiesResponse ListAssetProperties(ListAssetPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetPropertiesResponseUnmarshaller.Instance;

            return Invoke<ListAssetPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetProperties operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetProperties">REST API Reference for ListAssetProperties Operation</seealso>
        public virtual IAsyncResult BeginListAssetProperties(ListAssetPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetProperties.</param>
        /// 
        /// <returns>Returns a  ListAssetPropertiesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetProperties">REST API Reference for ListAssetProperties Operation</seealso>
        public virtual ListAssetPropertiesResponse EndListAssetProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetRelationships

        /// <summary>
        /// Retrieves a paginated list of asset relationships for an asset. You can use this operation
        /// to identify an asset's root asset and all associated assets between that asset and
        /// its root.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRelationships service method.</param>
        /// 
        /// <returns>The response from the ListAssetRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetRelationships">REST API Reference for ListAssetRelationships Operation</seealso>
        public virtual ListAssetRelationshipsResponse ListAssetRelationships(ListAssetRelationshipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListAssetRelationshipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRelationships operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetRelationships">REST API Reference for ListAssetRelationships Operation</seealso>
        public virtual IAsyncResult BeginListAssetRelationships(ListAssetRelationshipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRelationshipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetRelationships.</param>
        /// 
        /// <returns>Returns a  ListAssetRelationshipsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetRelationships">REST API Reference for ListAssetRelationships Operation</seealso>
        public virtual ListAssetRelationshipsResponse EndListAssetRelationships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetRelationshipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssets

        /// <summary>
        /// Retrieves a paginated list of asset summaries.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// List assets based on a specific asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List top-level assets.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use this operation to list all assets. To retrieve summaries for all of
        /// your assets, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ListAssetModels.html">ListAssetModels</a>
        /// to get all of your asset model IDs. Then, use ListAssets to get all assets for each
        /// asset model.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual ListAssetsResponse ListAssets(ListAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual IAsyncResult BeginListAssets(ListAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssets.</param>
        /// 
        /// <returns>Returns a  ListAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual ListAssetsResponse EndListAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedAssets

        /// <summary>
        /// Retrieves a paginated list of associated assets.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHILD</c> - List all child assets associated to the asset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARENT</c> - List the asset's parent asset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssociatedAssets">REST API Reference for ListAssociatedAssets Operation</seealso>
        public virtual ListAssociatedAssetsResponse ListAssociatedAssets(ListAssociatedAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssociatedAssets">REST API Reference for ListAssociatedAssets Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedAssets(ListAssociatedAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedAssets.</param>
        /// 
        /// <returns>Returns a  ListAssociatedAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssociatedAssets">REST API Reference for ListAssociatedAssets Operation</seealso>
        public virtual ListAssociatedAssetsResponse EndListAssociatedAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBulkImportJobs

        /// <summary>
        /// Retrieves a paginated list of bulk import job requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ListBulkImportJobs.html">List
        /// bulk import jobs (CLI)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBulkImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListBulkImportJobs service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListBulkImportJobs">REST API Reference for ListBulkImportJobs Operation</seealso>
        public virtual ListBulkImportJobsResponse ListBulkImportJobs(ListBulkImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBulkImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListBulkImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBulkImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBulkImportJobs operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBulkImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListBulkImportJobs">REST API Reference for ListBulkImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListBulkImportJobs(ListBulkImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBulkImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBulkImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBulkImportJobs.</param>
        /// 
        /// <returns>Returns a  ListBulkImportJobsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListBulkImportJobs">REST API Reference for ListBulkImportJobs Operation</seealso>
        public virtual ListBulkImportJobsResponse EndListBulkImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBulkImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCompositionRelationships

        /// <summary>
        /// Retrieves a paginated list of composition relationships for an asset model of type
        /// <c>COMPONENT_MODEL</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompositionRelationships service method.</param>
        /// 
        /// <returns>The response from the ListCompositionRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListCompositionRelationships">REST API Reference for ListCompositionRelationships Operation</seealso>
        public virtual ListCompositionRelationshipsResponse ListCompositionRelationships(ListCompositionRelationshipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListCompositionRelationshipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCompositionRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompositionRelationships operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCompositionRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListCompositionRelationships">REST API Reference for ListCompositionRelationships Operation</seealso>
        public virtual IAsyncResult BeginListCompositionRelationships(ListCompositionRelationshipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionRelationshipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCompositionRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCompositionRelationships.</param>
        /// 
        /// <returns>Returns a  ListCompositionRelationshipsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListCompositionRelationships">REST API Reference for ListCompositionRelationships Operation</seealso>
        public virtual ListCompositionRelationshipsResponse EndListCompositionRelationships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCompositionRelationshipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComputationModelDataBindingUsages

        /// <summary>
        /// Lists all data binding usages for computation models. This allows to identify where
        /// specific data bindings are being utilized across the computation models. This track
        /// dependencies between data sources and computation models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelDataBindingUsages service method.</param>
        /// 
        /// <returns>The response from the ListComputationModelDataBindingUsages service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelDataBindingUsages">REST API Reference for ListComputationModelDataBindingUsages Operation</seealso>
        public virtual ListComputationModelDataBindingUsagesResponse ListComputationModelDataBindingUsages(ListComputationModelDataBindingUsagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelDataBindingUsagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelDataBindingUsagesResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelDataBindingUsagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComputationModelDataBindingUsages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelDataBindingUsages operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComputationModelDataBindingUsages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelDataBindingUsages">REST API Reference for ListComputationModelDataBindingUsages Operation</seealso>
        public virtual IAsyncResult BeginListComputationModelDataBindingUsages(ListComputationModelDataBindingUsagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelDataBindingUsagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelDataBindingUsagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComputationModelDataBindingUsages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComputationModelDataBindingUsages.</param>
        /// 
        /// <returns>Returns a  ListComputationModelDataBindingUsagesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelDataBindingUsages">REST API Reference for ListComputationModelDataBindingUsages Operation</seealso>
        public virtual ListComputationModelDataBindingUsagesResponse EndListComputationModelDataBindingUsages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComputationModelDataBindingUsagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComputationModelResolveToResources

        /// <summary>
        /// Lists all distinct resources that are resolved from the executed actions of the computation
        /// model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelResolveToResources service method.</param>
        /// 
        /// <returns>The response from the ListComputationModelResolveToResources service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelResolveToResources">REST API Reference for ListComputationModelResolveToResources Operation</seealso>
        public virtual ListComputationModelResolveToResourcesResponse ListComputationModelResolveToResources(ListComputationModelResolveToResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelResolveToResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelResolveToResourcesResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelResolveToResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComputationModelResolveToResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelResolveToResources operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComputationModelResolveToResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelResolveToResources">REST API Reference for ListComputationModelResolveToResources Operation</seealso>
        public virtual IAsyncResult BeginListComputationModelResolveToResources(ListComputationModelResolveToResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelResolveToResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelResolveToResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComputationModelResolveToResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComputationModelResolveToResources.</param>
        /// 
        /// <returns>Returns a  ListComputationModelResolveToResourcesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelResolveToResources">REST API Reference for ListComputationModelResolveToResources Operation</seealso>
        public virtual ListComputationModelResolveToResourcesResponse EndListComputationModelResolveToResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComputationModelResolveToResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComputationModels

        /// <summary>
        /// Retrieves a paginated list of summaries of all computation models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModels service method.</param>
        /// 
        /// <returns>The response from the ListComputationModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModels">REST API Reference for ListComputationModels Operation</seealso>
        public virtual ListComputationModelsResponse ListComputationModels(ListComputationModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelsResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComputationModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModels operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComputationModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModels">REST API Reference for ListComputationModels Operation</seealso>
        public virtual IAsyncResult BeginListComputationModels(ListComputationModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComputationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComputationModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComputationModels.</param>
        /// 
        /// <returns>Returns a  ListComputationModelsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModels">REST API Reference for ListComputationModels Operation</seealso>
        public virtual ListComputationModelsResponse EndListComputationModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComputationModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDashboards

        /// <summary>
        /// Retrieves a paginated list of dashboards for an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDashboardsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Retrieves a paginated list of datasets for a specific target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExecutions

        /// <summary>
        /// Retrieves a paginated list of summaries of all executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGateways

        /// <summary>
        /// Retrieves a paginated list of gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse EndListGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInterfaceRelationships

        /// <summary>
        /// Retrieves a paginated list of asset models that have a specific interface asset model
        /// applied to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInterfaceRelationships service method.</param>
        /// 
        /// <returns>The response from the ListInterfaceRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListInterfaceRelationships">REST API Reference for ListInterfaceRelationships Operation</seealso>
        public virtual ListInterfaceRelationshipsResponse ListInterfaceRelationships(ListInterfaceRelationshipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInterfaceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInterfaceRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListInterfaceRelationshipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInterfaceRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInterfaceRelationships operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInterfaceRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListInterfaceRelationships">REST API Reference for ListInterfaceRelationships Operation</seealso>
        public virtual IAsyncResult BeginListInterfaceRelationships(ListInterfaceRelationshipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInterfaceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInterfaceRelationshipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInterfaceRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInterfaceRelationships.</param>
        /// 
        /// <returns>Returns a  ListInterfaceRelationshipsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListInterfaceRelationships">REST API Reference for ListInterfaceRelationships Operation</seealso>
        public virtual ListInterfaceRelationshipsResponse EndListInterfaceRelationships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInterfaceRelationshipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPortals

        /// <summary>
        /// Retrieves a paginated list of IoT SiteWise Monitor portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortals operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual IAsyncResult BeginListPortals(ListPortalsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortals.</param>
        /// 
        /// <returns>Returns a  ListPortalsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse EndListPortals(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPortalsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjectAssets

        /// <summary>
        /// Retrieves a paginated list of assets associated with an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectAssets service method.</param>
        /// 
        /// <returns>The response from the ListProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjectAssets">REST API Reference for ListProjectAssets Operation</seealso>
        public virtual ListProjectAssetsResponse ListProjectAssets(ListProjectAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<ListProjectAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjectAssets operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjectAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjectAssets">REST API Reference for ListProjectAssets Operation</seealso>
        public virtual IAsyncResult BeginListProjectAssets(ListProjectAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjectAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjectAssets.</param>
        /// 
        /// <returns>Returns a  ListProjectAssetsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjectAssets">REST API Reference for ListProjectAssets Operation</seealso>
        public virtual ListProjectAssetsResponse EndListProjectAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Retrieves a paginated list of projects for an IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListProjectsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags for an IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTimeSeries

        /// <summary>
        /// Retrieves a paginated list of time series (data streams).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeries service method.</param>
        /// 
        /// <returns>The response from the ListTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTimeSeries">REST API Reference for ListTimeSeries Operation</seealso>
        public virtual ListTimeSeriesResponse ListTimeSeries(ListTimeSeriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<ListTimeSeriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeries operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTimeSeries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTimeSeries">REST API Reference for ListTimeSeries Operation</seealso>
        public virtual IAsyncResult BeginListTimeSeries(ListTimeSeriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTimeSeries.</param>
        /// 
        /// <returns>Returns a  ListTimeSeriesResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTimeSeries">REST API Reference for ListTimeSeries Operation</seealso>
        public virtual ListTimeSeriesResponse EndListTimeSeries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTimeSeriesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAssetModelInterfaceRelationship

        /// <summary>
        /// Creates or updates an interface relationship between an asset model and an interface
        /// asset model. This operation applies an interface to an asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAssetModelInterfaceRelationship service method.</param>
        /// 
        /// <returns>The response from the PutAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutAssetModelInterfaceRelationship">REST API Reference for PutAssetModelInterfaceRelationship Operation</seealso>
        public virtual PutAssetModelInterfaceRelationshipResponse PutAssetModelInterfaceRelationship(PutAssetModelInterfaceRelationshipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<PutAssetModelInterfaceRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAssetModelInterfaceRelationship operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAssetModelInterfaceRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutAssetModelInterfaceRelationship">REST API Reference for PutAssetModelInterfaceRelationship Operation</seealso>
        public virtual IAsyncResult BeginPutAssetModelInterfaceRelationship(PutAssetModelInterfaceRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAssetModelInterfaceRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAssetModelInterfaceRelationship.</param>
        /// 
        /// <returns>Returns a  PutAssetModelInterfaceRelationshipResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutAssetModelInterfaceRelationship">REST API Reference for PutAssetModelInterfaceRelationship Operation</seealso>
        public virtual PutAssetModelInterfaceRelationshipResponse EndPutAssetModelInterfaceRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAssetModelInterfaceRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDefaultEncryptionConfiguration

        /// <summary>
        /// Sets the default encryption configuration for the Amazon Web Services account. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual PutDefaultEncryptionConfigurationResponse PutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDefaultEncryptionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDefaultEncryptionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDefaultEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDefaultEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutDefaultEncryptionConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual PutDefaultEncryptionConfigurationResponse EndPutDefaultEncryptionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDefaultEncryptionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLoggingOptions

        /// <summary>
        /// Sets logging options for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
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
        /// <returns>Returns a  PutLoggingOptionsResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLoggingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutStorageConfiguration

        /// <summary>
        /// Configures storage settings for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutStorageConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutStorageConfiguration">REST API Reference for PutStorageConfiguration Operation</seealso>
        public virtual PutStorageConfigurationResponse PutStorageConfiguration(PutStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutStorageConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutStorageConfiguration">REST API Reference for PutStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutStorageConfiguration(PutStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  PutStorageConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutStorageConfiguration">REST API Reference for PutStorageConfiguration Operation</seealso>
        public virtual PutStorageConfigurationResponse EndPutStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to an IoT SiteWise resource. If a tag already exists for the resource, this
        /// operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.TooManyTagsException">
        /// You've reached the quota for the number of tags allowed for a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// naming limits and requirements</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessPolicy

        /// <summary>
        /// Updates an existing access policy that specifies an identity's access to an IoT SiteWise
        /// Monitor portal or project resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessPolicy(UpdateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccessPolicyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual UpdateAccessPolicyResponse EndUpdateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAsset

        /// <summary>
        /// Updates an asset's name. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual UpdateAssetResponse UpdateAsset(UpdateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual IAsyncResult BeginUpdateAsset(UpdateAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAsset.</param>
        /// 
        /// <returns>Returns a  UpdateAssetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual UpdateAssetResponse EndUpdateAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssetModel

        /// <summary>
        /// Updates an asset model and all of the assets that were created from the model. Each
        /// asset created from the model inherits the updated asset model's property and hierarchy
        /// definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// If you remove a property from an asset model, IoT SiteWise deletes all previous data
        /// for that property. You can’t change the type or data type of an existing property.
        /// </para>
        ///  
        /// <para>
        /// To replace an existing asset model property with a new one with the same <c>name</c>,
        /// do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit an <c>UpdateAssetModel</c> request with the entire existing property removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a second <c>UpdateAssetModel</c> request that includes the new property. The
        /// new asset property will have the same <c>name</c> as the previous one and IoT SiteWise
        /// will generate a new unique <c>id</c>.
        /// </para>
        ///  </li> </ol> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModel service method.</param>
        /// 
        /// <returns>The response from the UpdateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModel">REST API Reference for UpdateAssetModel Operation</seealso>
        public virtual UpdateAssetModelResponse UpdateAssetModel(UpdateAssetModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModel">REST API Reference for UpdateAssetModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssetModel(UpdateAssetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssetModel.</param>
        /// 
        /// <returns>Returns a  UpdateAssetModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModel">REST API Reference for UpdateAssetModel Operation</seealso>
        public virtual UpdateAssetModelResponse EndUpdateAssetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssetModelCompositeModel

        /// <summary>
        /// Updates a composite model and all of the assets that were created from the model.
        /// Each asset created from the model inherits the updated asset model's property and
        /// hierarchy definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// If you remove a property from a composite asset model, IoT SiteWise deletes all previous
        /// data for that property. You can’t change the type or data type of an existing property.
        /// </para>
        ///  
        /// <para>
        /// To replace an existing composite asset model property with a new one with the same
        /// <c>name</c>, do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit an <c>UpdateAssetModelCompositeModel</c> request with the entire existing property
        /// removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a second <c>UpdateAssetModelCompositeModel</c> request that includes the new
        /// property. The new asset property will have the same <c>name</c> as the previous one
        /// and IoT SiteWise will generate a new unique <c>id</c>.
        /// </para>
        ///  </li> </ol> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModelCompositeModel service method.</param>
        /// 
        /// <returns>The response from the UpdateAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModelCompositeModel">REST API Reference for UpdateAssetModelCompositeModel Operation</seealso>
        public virtual UpdateAssetModelCompositeModelResponse UpdateAssetModelCompositeModel(UpdateAssetModelCompositeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetModelCompositeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModelCompositeModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssetModelCompositeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModelCompositeModel">REST API Reference for UpdateAssetModelCompositeModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssetModelCompositeModel(UpdateAssetModelCompositeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssetModelCompositeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssetModelCompositeModel.</param>
        /// 
        /// <returns>Returns a  UpdateAssetModelCompositeModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModelCompositeModel">REST API Reference for UpdateAssetModelCompositeModel Operation</seealso>
        public virtual UpdateAssetModelCompositeModelResponse EndUpdateAssetModelCompositeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetModelCompositeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssetProperty

        /// <summary>
        /// Updates an asset property's alias and notification state.
        /// 
        ///  <important> 
        /// <para>
        /// This operation overwrites the property's existing alias and notification state. To
        /// keep your existing property's alias or notification state, you must include the existing
        /// values in the UpdateAssetProperty request. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetProperty.html">DescribeAssetProperty</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetProperty service method.</param>
        /// 
        /// <returns>The response from the UpdateAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetProperty">REST API Reference for UpdateAssetProperty Operation</seealso>
        public virtual UpdateAssetPropertyResponse UpdateAssetProperty(UpdateAssetPropertyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetPropertyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetProperty operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssetProperty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetProperty">REST API Reference for UpdateAssetProperty Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssetProperty(UpdateAssetPropertyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetPropertyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssetProperty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssetProperty.</param>
        /// 
        /// <returns>Returns a  UpdateAssetPropertyResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetProperty">REST API Reference for UpdateAssetProperty Operation</seealso>
        public virtual UpdateAssetPropertyResponse EndUpdateAssetProperty(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetPropertyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComputationModel

        /// <summary>
        /// Updates the computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputationModel service method.</param>
        /// 
        /// <returns>The response from the UpdateComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateComputationModel">REST API Reference for UpdateComputationModel Operation</seealso>
        public virtual UpdateComputationModelResponse UpdateComputationModel(UpdateComputationModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputationModelResponseUnmarshaller.Instance;

            return Invoke<UpdateComputationModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComputationModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputationModel operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComputationModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateComputationModel">REST API Reference for UpdateComputationModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateComputationModel(UpdateComputationModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputationModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComputationModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComputationModel.</param>
        /// 
        /// <returns>Returns a  UpdateComputationModelResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateComputationModel">REST API Reference for UpdateComputationModel Operation</seealso>
        public virtual UpdateComputationModelResponse EndUpdateComputationModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComputationModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDashboard

        /// <summary>
        /// Updates an IoT SiteWise Monitor dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual IAsyncResult BeginUpdateDashboard(UpdateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboard.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse EndUpdateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataset

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGateway

        /// <summary>
        /// Updates a gateway's name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateGateway(UpdateGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGateway.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual UpdateGatewayResponse EndUpdateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayCapabilityConfiguration

        /// <summary>
        /// Updates a gateway capability configuration or defines a new capability configuration.
        /// Each gateway capability defines data sources for a gateway.
        /// 
        ///  
        /// <para>
        /// Important workflow notes:
        /// </para>
        ///  
        /// <para>
        /// Each gateway capability defines data sources for a gateway. This is the namespace
        /// of the gateway capability.
        /// </para>
        ///  
        /// <para>
        /// . The namespace follows the format <c>service:capability:version</c>, where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>service</c> - The service providing the capability, or <c>iotsitewise</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capability</c> - The specific capability type. Options include: <c>opcuacollector</c>
        /// for the OPC UA data source collector, or <c>publisher</c> for data publisher capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> - The version number of the capability. Option include <c>2</c> for
        /// Classic streams, V2 gateways, and <c>3</c> for MQTT-enabled, V3 gateways.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After updating a capability configuration, the sync status becomes <c>OUT_OF_SYNC</c>
        /// until the gateway processes the configuration.Use <c>DescribeGatewayCapabilityConfiguration</c>
        /// to check the sync status and verify the configuration was applied.
        /// </para>
        ///  
        /// <para>
        /// A gateway can have multiple capability configurations with different namespaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayCapabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGatewayCapabilityConfiguration">REST API Reference for UpdateGatewayCapabilityConfiguration Operation</seealso>
        public virtual UpdateGatewayCapabilityConfigurationResponse UpdateGatewayCapabilityConfiguration(UpdateGatewayCapabilityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayCapabilityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayCapabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayCapabilityConfiguration operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayCapabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGatewayCapabilityConfiguration">REST API Reference for UpdateGatewayCapabilityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateGatewayCapabilityConfiguration(UpdateGatewayCapabilityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayCapabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayCapabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayCapabilityConfigurationResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGatewayCapabilityConfiguration">REST API Reference for UpdateGatewayCapabilityConfiguration Operation</seealso>
        public virtual UpdateGatewayCapabilityConfigurationResponse EndUpdateGatewayCapabilityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayCapabilityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePortal

        /// <summary>
        /// Updates an IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual IAsyncResult BeginUpdatePortal(UpdatePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortal.</param>
        /// 
        /// <returns>Returns a  UpdatePortalResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse EndUpdatePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProject

        /// <summary>
        /// Updates an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonIoTSiteWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UpdateProjectResult from IoTSiteWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
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
            var resolver = new AmazonIoTSiteWiseEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}