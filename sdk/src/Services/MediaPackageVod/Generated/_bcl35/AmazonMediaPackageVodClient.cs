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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaPackageVod.Model;
using Amazon.MediaPackageVod.Model.Internal.MarshallTransformations;
using Amazon.MediaPackageVod.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.MediaPackageVod
{
    /// <summary>
    /// <para>Implementation for accessing MediaPackageVod</para>
    ///
    /// AWS Elemental MediaPackage VOD
    /// </summary>
    public partial class AmazonMediaPackageVodClient : AmazonServiceClient, IAmazonMediaPackageVod
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaPackageVodMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IMediaPackageVodPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaPackageVodPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaPackageVodPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        public AmazonMediaPackageVodClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageVodConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        public AmazonMediaPackageVodClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageVodConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(AmazonMediaPackageVodConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaPackageVodConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials and an
        /// AmazonMediaPackageVodClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials, AmazonMediaPackageVodConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageVodConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageVodClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaPackageVodConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageVodConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageVodClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaPackageVodConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaPackageVodEndpointResolver());
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


        #region  ConfigureLogs

        /// <summary>
        /// Changes the packaging group's properities to configure log subscription
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogs service method.</param>
        /// 
        /// <returns>The response from the ConfigureLogs service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ConfigureLogs">REST API Reference for ConfigureLogs Operation</seealso>
        public virtual ConfigureLogsResponse ConfigureLogs(ConfigureLogsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConfigureLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsResponseUnmarshaller.Instance;

            return Invoke<ConfigureLogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogs operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ConfigureLogs">REST API Reference for ConfigureLogs Operation</seealso>
        public virtual IAsyncResult BeginConfigureLogs(ConfigureLogsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConfigureLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureLogs.</param>
        /// 
        /// <returns>Returns a  ConfigureLogsResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ConfigureLogs">REST API Reference for ConfigureLogs Operation</seealso>
        public virtual ConfigureLogsResponse EndConfigureLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfigureLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAsset

        /// <summary>
        /// Creates a new MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual IAsyncResult BeginCreateAsset(CreateAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateAssetResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse EndCreateAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePackagingConfiguration

        /// <summary>
        /// Creates a new MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreatePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        public virtual CreatePackagingConfigurationResponse CreatePackagingConfiguration(CreatePackagingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreatePackagingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingConfiguration operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackagingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreatePackagingConfiguration(CreatePackagingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackagingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreatePackagingConfigurationResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        public virtual CreatePackagingConfigurationResponse EndCreatePackagingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePackagingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePackagingGroup

        /// <summary>
        /// Creates a new MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingGroup service method.</param>
        /// 
        /// <returns>The response from the CreatePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        public virtual CreatePackagingGroupResponse CreatePackagingGroup(CreatePackagingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePackagingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingGroup operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackagingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        public virtual IAsyncResult BeginCreatePackagingGroup(CreatePackagingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackagingGroup.</param>
        /// 
        /// <returns>Returns a  CreatePackagingGroupResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        public virtual CreatePackagingGroupResponse EndCreatePackagingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePackagingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAsset

        /// <summary>
        /// Deletes an existing MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual IAsyncResult BeginDeleteAsset(DeleteAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteAssetResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse EndDeleteAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePackagingConfiguration

        /// <summary>
        /// Deletes a MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        public virtual DeletePackagingConfigurationResponse DeletePackagingConfiguration(DeletePackagingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePackagingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingConfiguration operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackagingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeletePackagingConfiguration(DeletePackagingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackagingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePackagingConfigurationResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        public virtual DeletePackagingConfigurationResponse EndDeletePackagingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePackagingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePackagingGroup

        /// <summary>
        /// Deletes a MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingGroup service method.</param>
        /// 
        /// <returns>The response from the DeletePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        public virtual DeletePackagingGroupResponse DeletePackagingGroup(DeletePackagingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePackagingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingGroup operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackagingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        public virtual IAsyncResult BeginDeletePackagingGroup(DeletePackagingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackagingGroup.</param>
        /// 
        /// <returns>Returns a  DeletePackagingGroupResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        public virtual DeletePackagingGroupResponse EndDeletePackagingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePackagingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAsset

        /// <summary>
        /// Returns a description of a MediaPackage VOD Asset resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// 
        /// <returns>The response from the DescribeAsset service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual DescribeAssetResponse DescribeAsset(DescribeAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual IAsyncResult BeginDescribeAsset(DescribeAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DescribeAssetResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual DescribeAssetResponse EndDescribeAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackagingConfiguration

        /// <summary>
        /// Returns a description of a MediaPackage VOD PackagingConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribePackagingConfiguration service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        public virtual DescribePackagingConfigurationResponse DescribePackagingConfiguration(DescribePackagingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribePackagingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingConfiguration operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackagingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribePackagingConfiguration(DescribePackagingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackagingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribePackagingConfigurationResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        public virtual DescribePackagingConfigurationResponse EndDescribePackagingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackagingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackagingGroup

        /// <summary>
        /// Returns a description of a MediaPackage VOD PackagingGroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        public virtual DescribePackagingGroupResponse DescribePackagingGroup(DescribePackagingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribePackagingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingGroup operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackagingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribePackagingGroup(DescribePackagingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackagingGroup.</param>
        /// 
        /// <returns>Returns a  DescribePackagingGroupResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        public virtual DescribePackagingGroupResponse EndDescribePackagingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackagingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssets

        /// <summary>
        /// Returns a collection of MediaPackage VOD Asset resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual ListAssetsResponse ListAssets(ListAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssets operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual IAsyncResult BeginListAssets(ListAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListAssetsResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual ListAssetsResponse EndListAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackagingConfigurations

        /// <summary>
        /// Returns a collection of MediaPackage VOD PackagingConfiguration resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPackagingConfigurations service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        public virtual ListPackagingConfigurationsResponse ListPackagingConfigurations(ListPackagingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPackagingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingConfigurations operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackagingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListPackagingConfigurations(ListPackagingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackagingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackagingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPackagingConfigurationsResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        public virtual ListPackagingConfigurationsResponse EndListPackagingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackagingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackagingGroups

        /// <summary>
        /// Returns a collection of MediaPackage VOD PackagingGroup resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingGroups service method.</param>
        /// 
        /// <returns>The response from the ListPackagingGroups service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        public virtual ListPackagingGroupsResponse ListPackagingGroups(ListPackagingGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListPackagingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingGroups operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackagingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        public virtual IAsyncResult BeginListPackagingGroups(ListPackagingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackagingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackagingGroups.</param>
        /// 
        /// <returns>Returns a  ListPackagingGroupsResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        public virtual ListPackagingGroupsResponse EndListPackagingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackagingGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to the specified resource. You can specify one or more tags to add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the specified resource. You can specify one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePackagingGroup

        /// <summary>
        /// Updates a specific packaging group. You can't change the id attribute or any other
        /// system-generated attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackagingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdatePackagingGroup service method, as returned by MediaPackageVod.</returns>
        /// <exception cref="Amazon.MediaPackageVod.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageVod.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UpdatePackagingGroup">REST API Reference for UpdatePackagingGroup Operation</seealso>
        public virtual UpdatePackagingGroupResponse UpdatePackagingGroup(UpdatePackagingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdatePackagingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackagingGroup operation on AmazonMediaPackageVodClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePackagingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UpdatePackagingGroup">REST API Reference for UpdatePackagingGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdatePackagingGroup(UpdatePackagingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackagingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePackagingGroup.</param>
        /// 
        /// <returns>Returns a  UpdatePackagingGroupResult from MediaPackageVod.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/UpdatePackagingGroup">REST API Reference for UpdatePackagingGroup Operation</seealso>
        public virtual UpdatePackagingGroupResponse EndUpdatePackagingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePackagingGroupResponse>(asyncResult);
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
            var resolver = new AmazonMediaPackageVodEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}