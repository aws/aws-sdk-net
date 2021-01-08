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

namespace Amazon.IoTSiteWise
{
    /// <summary>
    /// Implementation for accessing IoTSiteWise
    ///
    /// Welcome to the AWS IoT SiteWise API Reference. AWS IoT SiteWise is an AWS service
    /// that connects <a href="https://en.wikipedia.org/wiki/Internet_of_things#Industrial_applications">Industrial
    /// Internet of Things (IIoT)</a> devices to the power of the AWS Cloud. For more information,
    /// see the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/">AWS IoT
    /// SiteWise User Guide</a>. For information about AWS IoT SiteWise quotas, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
    /// in the <i>AWS IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class AmazonIoTSiteWiseClient : AmazonServiceClient, IAmazonIoTSiteWise
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTSiteWiseMetadata();

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// assets</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssets service method.</param>
        /// 
        /// <returns>The response from the AssociateAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  BatchAssociateProjectAssets

        /// <summary>
        /// Associates a group (batch) of assets with an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateProjectAssets service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Disassociates a group (batch) of assets from an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateProjectAssets service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  BatchPutAssetPropertyValue

        /// <summary>
        /// Sends a list of asset property values to AWS IoT SiteWise. Each value is a timestamp-quality-value
        /// (TQV) data point. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ingest-api.html">Ingesting
        /// data using the API</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// With respect to Unix epoch time, AWS IoT SiteWise accepts only TQVs that have a timestamp
        /// of no more than 7 days in the past and no more than 5 minutes in the future. AWS IoT
        /// SiteWise rejects timestamps outside of the inclusive range of [-7 days, +5 minutes]
        /// and returns a <code>TimestampOutOfRangeException</code> error.
        /// </para>
        ///  
        /// <para>
        /// For each asset property, AWS IoT SiteWise overwrites TQVs with duplicate timestamps
        /// unless the newer TQV has a different quality. For example, if you store a TQV <code>{T1,
        /// GOOD, V1}</code>, then storing <code>{T1, GOOD, V2}</code> replaces the existing TQV.
        /// </para>
        ///  </important> 
        /// <para>
        /// AWS IoT SiteWise authorizes access to each <code>BatchPutAssetPropertyValue</code>
        /// entry individually. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-batchputassetpropertyvalue-action">BatchPutAssetPropertyValue
        /// authorization</a> in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Creates an access policy that grants the specified identity (AWS SSO user, AWS SSO
        /// group, or IAM user) access to the specified AWS IoT SiteWise Monitor portal or project
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// assets</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// asset models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModel service method.</param>
        /// 
        /// <returns>The response from the CreateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  CreateDashboard

        /// <summary>
        /// Creates a dashboard in an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  CreateGateway

        /// <summary>
        /// Creates a gateway, which is a virtual or edge device that delivers industrial data
        /// streams from local servers to AWS IoT SiteWise. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gateway-connector.html">Ingesting
        /// data using a gateway</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Creates a portal, which can contain projects and dashboards. AWS IoT SiteWise Monitor
        /// uses AWS SSO or IAM to authenticate portal users and manage user permissions.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can sign in to a new portal, you must add at least one identity to that
        /// portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
        /// or removing portal administrators</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise Monitor resource. You can use this operation to revoke access to
        /// an AWS IoT SiteWise Monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>. 
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DeleteDashboard

        /// <summary>
        /// Deletes a dashboard from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DeleteGateway

        /// <summary>
        /// Deletes a gateway from AWS IoT SiteWise. When you delete a gateway, some of the gateway's
        /// files remain in your gateway's file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Deletes a portal from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Deletes a project from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeAccessPolicy

        /// <summary>
        /// Describes an access policy, which specifies an identity's access to an AWS IoT SiteWise
        /// Monitor portal or project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeAsset

        /// <summary>
        /// Retrieves information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// 
        /// <returns>The response from the DescribeAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeAssetModel

        /// <summary>
        /// Retrieves information about an asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModel service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeDashboard

        /// <summary>
        /// Retrieves information about a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeDefaultEncryptionConfiguration

        /// <summary>
        /// Retrieves information about the default encryption configuration for the AWS account
        /// in the default or specified region. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  DescribeGateway

        /// <summary>
        /// Retrieves information about a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
        /// 
        /// <returns>The response from the DescribeGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Retrieves information about a gateway capability configuration. Each gateway capability
        /// defines data sources for a gateway. A capability configuration can contain multiple
        /// data source configurations. If you define OPC-UA sources for a gateway in the AWS
        /// IoT SiteWise console, all of your OPC-UA sources are stored in one capability configuration.
        /// To list all capability configurations for a gateway, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGateway.html">DescribeGateway</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayCapabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Retrieves the current AWS IoT SiteWise logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  GetAssetPropertyAggregates

        /// <summary>
        /// Gets aggregated values for an asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
        /// aggregates</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyAggregates service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyAggregates service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// current values</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// historical values</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the GetAssetPropertyValueHistory service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  ListAccessPolicies

        /// <summary>
        /// Retrieves a paginated list of access policies for an identity (an AWS SSO user, an
        /// AWS SSO group, or an IAM user) or an AWS IoT SiteWise Monitor resource (a portal or
        /// project).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  ListAssetModels

        /// <summary>
        /// Retrieves a paginated list of summaries of all asset models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModels service method.</param>
        /// 
        /// <returns>The response from the ListAssetModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// List child assets associated to a parent asset by a hierarchy that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List an asset's parent asset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  ListDashboards

        /// <summary>
        /// Retrieves a paginated list of dashboards for an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  ListGateways

        /// <summary>
        /// Retrieves a paginated list of gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  ListPortals

        /// <summary>
        /// Retrieves a paginated list of AWS IoT SiteWise Monitor portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Retrieves a paginated list of assets associated with an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectAssets service method.</param>
        /// 
        /// <returns>The response from the ListProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Retrieves a paginated list of projects for an AWS IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Retrieves the list of tags for an AWS IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  PutDefaultEncryptionConfiguration

        /// <summary>
        /// Sets the default encryption configuration for the AWS account. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Sets logging options for AWS IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  TagResource

        /// <summary>
        /// Adds tags to an AWS IoT SiteWise resource. If a tag already exists for the resource,
        /// this operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.TooManyTagsException">
        /// You've reached the limit for the number of tags allowed for a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// naming limits and requirements</a> in the <i>AWS General Reference</i>.
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
        /// Removes a tag from an AWS IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Updates an existing access policy that specifies an identity's access to an AWS IoT
        /// SiteWise Monitor portal or project resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// This operation overwrites the existing model with the provided model. To avoid deleting
        /// your asset model's properties or hierarchies, you must include their IDs and definitions
        /// in the updated asset model payload. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetModel.html">DescribeAssetModel</a>.
        /// </para>
        ///  
        /// <para>
        /// If you remove a property from an asset model, AWS IoT SiteWise deletes all previous
        /// data for that property. If you remove a hierarchy definition from an asset model,
        /// AWS IoT SiteWise disassociates every asset associated with that hierarchy. You can't
        /// change the type or data type of an existing property.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModel service method.</param>
        /// 
        /// <returns>The response from the UpdateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
        #region  UpdateDashboard

        /// <summary>
        /// Updates an AWS IoT SiteWise Monitor dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Each gateway capability defines data sources for a gateway. A capability configuration
        /// can contain multiple data source configurations. If you define OPC-UA sources for
        /// a gateway in the AWS IoT SiteWise console, all of your OPC-UA sources are stored in
        /// one capability configuration. To list all capability configurations for a gateway,
        /// use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGateway.html">DescribeGateway</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayCapabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the limit for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Updates an AWS IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Updates an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// AWS IoT SiteWise can't process your request right now. Try again later.
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
        /// of AWS IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>AWS IoT SiteWise User Guide</i>.
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
        
    }
}