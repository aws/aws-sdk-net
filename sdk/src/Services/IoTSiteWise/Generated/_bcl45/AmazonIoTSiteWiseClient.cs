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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// Associates a child asset with the given parent asset through a hierarchy defined in
        /// the parent asset's model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/add-associated-assets.html">Associating
        /// assets</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateAssetsResponse> AssociateAssetsAsync(AssociateAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateAssetsResponse>(request, options, cancellationToken);
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
        /// Associates a group (batch) of assets with an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchAssociateProjectAssetsResponse> BatchAssociateProjectAssetsAsync(BatchAssociateProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateProjectAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateProjectAssetsResponse>(request, options, cancellationToken);
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
        /// Disassociates a group (batch) of assets from an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchDisassociateProjectAssetsResponse> BatchDisassociateProjectAssetsAsync(BatchDisassociateProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateProjectAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateProjectAssetsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchPutAssetPropertyValueResponse> BatchPutAssetPropertyValueAsync(BatchPutAssetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAssetPropertyValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutAssetPropertyValueResponse>(request, options, cancellationToken);
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
        /// Creates an access policy that grants the specified identity (AWS SSO user, AWS SSO
        /// group, or IAM user) access to the specified AWS IoT SiteWise Monitor portal or project
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAccessPolicyResponse> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessPolicyResponse>(request, options, cancellationToken);
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
        /// Creates an asset from an existing asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-assets.html">Creating
        /// assets</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssetResponse>(request, options, cancellationToken);
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
        /// Creates an asset model from specified property and hierarchy definitions. You create
        /// assets from asset models. With asset models, you can easily create assets of the same
        /// type that have standardized definitions. Each asset created from a model inherits
        /// the asset model's property and hierarchy definitions. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/define-models.html">Defining
        /// asset models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAssetModelResponse> CreateAssetModelAsync(CreateAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAssetModelResponse>(request, options, cancellationToken);
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
        /// Creates a dashboard in an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDashboardResponse>(request, options, cancellationToken);
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
        /// Creates a gateway, which is a virtual or edge device that delivers industrial data
        /// streams from local servers to AWS IoT SiteWise. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gateway-connector.html">Ingesting
        /// data using a gateway</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGatewayResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePortalResponse>(request, options, cancellationToken);
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
        /// Creates a project in the specified portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
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
        /// Deletes an access policy that grants the specified identity access to the specified
        /// AWS IoT SiteWise Monitor resource. You can use this operation to revoke access to
        /// an AWS IoT SiteWise Monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAccessPolicyResponse> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPolicyResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
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
        /// Deletes an asset model. This action can't be undone. You must delete all assets created
        /// from an asset model before you can delete the model. Also, you can't delete an asset
        /// model if a parent asset model exists that contains a property formula expression that
        /// depends on the asset model that you want to delete. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAssetModelResponse> DeleteAssetModelAsync(DeleteAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssetModelResponse>(request, options, cancellationToken);
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
        /// Deletes a dashboard from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDashboardResponse>(request, options, cancellationToken);
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
        /// Deletes a gateway from AWS IoT SiteWise. When you delete a gateway, some of the gateway's
        /// files remain in your gateway's file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
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
        /// Deletes a portal from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePortalResponse>(request, options, cancellationToken);
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
        /// Deletes a project from AWS IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
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
        /// Describes an access policy, which specifies an identity's access to an AWS IoT SiteWise
        /// Monitor portal or project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAccessPolicyResponse> DescribeAccessPolicyAsync(DescribeAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccessPolicyResponse>(request, options, cancellationToken);
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
        /// Retrieves information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAssetResponse> DescribeAssetAsync(DescribeAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAssetResponse>(request, options, cancellationToken);
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
        /// Retrieves information about an asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAssetModelResponse> DescribeAssetModelAsync(DescribeAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAssetModelResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAssetPropertyResponse> DescribeAssetPropertyAsync(DescribeAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetPropertyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAssetPropertyResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDashboardResponse>(request, options, cancellationToken);
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
        /// Retrieves information about the default encryption configuration for the AWS account
        /// in the default or specified region. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeDefaultEncryptionConfigurationResponse> DescribeDefaultEncryptionConfigurationAsync(DescribeDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultEncryptionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeGatewayResponse> DescribeGatewayAsync(DescribeGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGatewayResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a gateway capability configuration. Each gateway capability
        /// defines data sources for a gateway. A capability configuration can contain multiple
        /// data source configurations. If you define OPC-UA sources for a gateway in the AWS
        /// IoT SiteWise console, all of your OPC-UA sources are stored in one capability configuration.
        /// To list all capability configurations for a gateway, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGateway.html">DescribeGateway</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayCapabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeGatewayCapabilityConfigurationResponse> DescribeGatewayCapabilityConfigurationAsync(DescribeGatewayCapabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayCapabilityConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGatewayCapabilityConfigurationResponse>(request, options, cancellationToken);
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
        /// Retrieves the current AWS IoT SiteWise logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLoggingOptionsResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribePortalResponse> DescribePortalAsync(DescribePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortalResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortalResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
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
        /// Disassociates a child asset from the given parent asset through a hierarchy defined
        /// in the parent asset's model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateAssetsResponse> DisassociateAssetsAsync(DisassociateAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateAssetsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAssetPropertyAggregatesResponse> GetAssetPropertyAggregatesAsync(GetAssetPropertyAggregatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyAggregatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetPropertyAggregatesResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAssetPropertyValueResponse> GetAssetPropertyValueAsync(GetAssetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetPropertyValueResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAssetPropertyValueHistoryResponse> GetAssetPropertyValueHistoryAsync(GetAssetPropertyValueHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetPropertyValueHistoryResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of access policies for an identity (an AWS SSO user, an
        /// AWS SSO group, or an IAM user) or an AWS IoT SiteWise Monitor resource (a portal or
        /// project).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAccessPoliciesResponse> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessPoliciesResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of summaries of all asset models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAssetModelsResponse> ListAssetModelsAsync(ListAssetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetModelsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of asset relationships for an asset. You can use this operation
        /// to identify an asset's root asset and all associated assets between that asset and
        /// its root.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAssetRelationshipsResponse> ListAssetRelationshipsAsync(ListAssetRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRelationshipsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetRelationshipsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssetsResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAssociatedAssetsResponse> ListAssociatedAssetsAsync(ListAssociatedAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssociatedAssetsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of dashboards for an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDashboardsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of AWS IoT SiteWise Monitor portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortalsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of assets associated with an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListProjectAssetsResponse> ListProjectAssetsAsync(ListProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectAssetsResponse>(request, options, cancellationToken);
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
        /// Retrieves a paginated list of projects for an AWS IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
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
        /// Retrieves the list of tags for an AWS IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Sets the default encryption configuration for the AWS account. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutDefaultEncryptionConfigurationResponse> PutDefaultEncryptionConfigurationAsync(PutDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
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
        /// Sets logging options for AWS IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
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
        /// Adds tags to an AWS IoT SiteWise resource. If a tag already exists for the resource,
        /// this operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Removes a tag from an AWS IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Updates an existing access policy that specifies an identity's access to an AWS IoT
        /// SiteWise Monitor portal or project resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAccessPolicyResponse> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccessPolicyResponse>(request, options, cancellationToken);
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
        /// Updates an asset's name. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>AWS IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAssetResponse> UpdateAssetAsync(UpdateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAssetResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAssetModelResponse> UpdateAssetModelAsync(UpdateAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAssetModelResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAssetPropertyResponse> UpdateAssetPropertyAsync(UpdateAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetPropertyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAssetPropertyResponse>(request, options, cancellationToken);
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
        /// Updates an AWS IoT SiteWise Monitor dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDashboardResponse>(request, options, cancellationToken);
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
        /// Updates a gateway's name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateGatewayResponse> UpdateGatewayAsync(UpdateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGatewayResponse>(request, options, cancellationToken);
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
        /// Updates a gateway capability configuration or defines a new capability configuration.
        /// Each gateway capability defines data sources for a gateway. A capability configuration
        /// can contain multiple data source configurations. If you define OPC-UA sources for
        /// a gateway in the AWS IoT SiteWise console, all of your OPC-UA sources are stored in
        /// one capability configuration. To list all capability configurations for a gateway,
        /// use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGateway.html">DescribeGateway</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayCapabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateGatewayCapabilityConfigurationResponse> UpdateGatewayCapabilityConfigurationAsync(UpdateGatewayCapabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayCapabilityConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGatewayCapabilityConfigurationResponse>(request, options, cancellationToken);
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
        /// Updates an AWS IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePortalResponse>(request, options, cancellationToken);
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
        /// Updates an AWS IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}