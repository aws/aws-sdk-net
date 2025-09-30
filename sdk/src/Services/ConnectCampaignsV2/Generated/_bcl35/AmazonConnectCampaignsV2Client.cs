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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations;
using Amazon.ConnectCampaignsV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ConnectCampaignsV2
{
    /// <summary>
    /// <para>Implementation for accessing ConnectCampaignsV2</para>
    ///
    /// Provide APIs to create and manage Amazon Connect Campaigns.
    /// </summary>
    public partial class AmazonConnectCampaignsV2Client : AmazonServiceClient, IAmazonConnectCampaignsV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectCampaignsV2Metadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IConnectCampaignsV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectCampaignsV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectCampaignsV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with the credentials loaded from the application's
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
        public AmazonConnectCampaignsV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCampaignsV2Config()) { }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with the credentials loaded from the application's
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
        public AmazonConnectCampaignsV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCampaignsV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectCampaignsV2Client Configuration Object</param>
        public AmazonConnectCampaignsV2Client(AmazonConnectCampaignsV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectCampaignsV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonConnectCampaignsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignsV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectCampaignsV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Credentials and an
        /// AmazonConnectCampaignsV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectCampaignsV2Client Configuration Object</param>
        public AmazonConnectCampaignsV2Client(AWSCredentials credentials, AmazonConnectCampaignsV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCampaignsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCampaignsV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCampaignsV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectCampaignsV2Client Configuration Object</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectCampaignsV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCampaignsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCampaignsV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCampaignsV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCampaignsV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectCampaignsV2Client Configuration Object</param>
        public AmazonConnectCampaignsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectCampaignsV2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectCampaignsV2EndpointResolver());
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


        #region  CreateCampaign

        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaign

        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaignChannelSubtypeConfig

        /// <summary>
        /// Deletes the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        public virtual DeleteCampaignChannelSubtypeConfigResponse DeleteCampaignChannelSubtypeConfig(DeleteCampaignChannelSubtypeConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignChannelSubtypeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignChannelSubtypeConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignChannelSubtypeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignChannelSubtypeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaignChannelSubtypeConfig(DeleteCampaignChannelSubtypeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignChannelSubtypeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignChannelSubtypeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignChannelSubtypeConfig.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignChannelSubtypeConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        public virtual DeleteCampaignChannelSubtypeConfigResponse EndDeleteCampaignChannelSubtypeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignChannelSubtypeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaignCommunicationLimits

        /// <summary>
        /// Deletes the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        public virtual DeleteCampaignCommunicationLimitsResponse DeleteCampaignCommunicationLimits(DeleteCampaignCommunicationLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignCommunicationLimitsResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignCommunicationLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaignCommunicationLimits(DeleteCampaignCommunicationLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignCommunicationLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        public virtual DeleteCampaignCommunicationLimitsResponse EndDeleteCampaignCommunicationLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignCommunicationLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaignCommunicationTime

        /// <summary>
        /// Deletes the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        public virtual DeleteCampaignCommunicationTimeResponse DeleteCampaignCommunicationTime(DeleteCampaignCommunicationTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignCommunicationTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignCommunicationTimeResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignCommunicationTimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignCommunicationTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaignCommunicationTime(DeleteCampaignCommunicationTimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignCommunicationTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignCommunicationTimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignCommunicationTime.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignCommunicationTimeResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        public virtual DeleteCampaignCommunicationTimeResponse EndDeleteCampaignCommunicationTime(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignCommunicationTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectInstanceConfig

        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual DeleteConnectInstanceConfigResponse DeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectInstanceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  DeleteConnectInstanceConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        public virtual DeleteConnectInstanceConfigResponse EndDeleteConnectInstanceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectInstanceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectInstanceIntegration

        /// <summary>
        /// Delete the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        public virtual DeleteConnectInstanceIntegrationResponse DeleteConnectInstanceIntegration(DeleteConnectInstanceIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectInstanceIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectInstanceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectInstanceIntegration(DeleteConnectInstanceIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectInstanceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectInstanceIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectInstanceIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteConnectInstanceIntegrationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        public virtual DeleteConnectInstanceIntegrationResponse EndDeleteConnectInstanceIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectInstanceIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstanceOnboardingJob

        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual DeleteInstanceOnboardingJobResponse DeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceOnboardingJobResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceOnboardingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceOnboardingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceOnboardingJobResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        public virtual DeleteInstanceOnboardingJobResponse EndDeleteInstanceOnboardingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceOnboardingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCampaign

        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return Invoke<DescribeCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual IAsyncResult BeginDescribeCampaign(DescribeCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCampaign.</param>
        /// 
        /// <returns>Returns a  DescribeCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse EndDescribeCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignState

        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// 
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual GetCampaignStateResponse GetCampaignState(GetCampaignStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateResponseUnmarshaller.Instance;

            return Invoke<GetCampaignStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignState(GetCampaignStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignState.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        public virtual GetCampaignStateResponse EndGetCampaignState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignStateBatch

        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// 
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual GetCampaignStateBatchResponse GetCampaignStateBatch(GetCampaignStateBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateBatchResponseUnmarshaller.Instance;

            return Invoke<GetCampaignStateBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignStateBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignStateBatch(GetCampaignStateBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignStateBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignStateBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignStateBatch.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        public virtual GetCampaignStateBatchResponse EndGetCampaignStateBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignStateBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectInstanceConfig

        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual GetConnectInstanceConfigResponse GetConnectInstanceConfig(GetConnectInstanceConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectInstanceConfigResponseUnmarshaller.Instance;

            return Invoke<GetConnectInstanceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual IAsyncResult BeginGetConnectInstanceConfig(GetConnectInstanceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectInstanceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectInstanceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  GetConnectInstanceConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        public virtual GetConnectInstanceConfigResponse EndGetConnectInstanceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectInstanceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceCommunicationLimits

        /// <summary>
        /// Get the instance communication limits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the GetInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceCommunicationLimits">REST API Reference for GetInstanceCommunicationLimits Operation</seealso>
        public virtual GetInstanceCommunicationLimitsResponse GetInstanceCommunicationLimits(GetInstanceCommunicationLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceCommunicationLimitsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceCommunicationLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceCommunicationLimits">REST API Reference for GetInstanceCommunicationLimits Operation</seealso>
        public virtual IAsyncResult BeginGetInstanceCommunicationLimits(GetInstanceCommunicationLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceCommunicationLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  GetInstanceCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceCommunicationLimits">REST API Reference for GetInstanceCommunicationLimits Operation</seealso>
        public virtual GetInstanceCommunicationLimitsResponse EndGetInstanceCommunicationLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceCommunicationLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceOnboardingJobStatus

        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual GetInstanceOnboardingJobStatusResponse GetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceOnboardingJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceOnboardingJobStatusResponseUnmarshaller.Instance;

            return Invoke<GetInstanceOnboardingJobStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceOnboardingJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual IAsyncResult BeginGetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceOnboardingJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceOnboardingJobStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceOnboardingJobStatus.</param>
        /// 
        /// <returns>Returns a  GetInstanceOnboardingJobStatusResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        public virtual GetInstanceOnboardingJobStatusResponse EndGetInstanceOnboardingJobStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceOnboardingJobStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCampaigns

        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCampaignsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectInstanceIntegrations

        /// <summary>
        /// Provides summary information about the integration under the specified Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListConnectInstanceIntegrations service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        public virtual ListConnectInstanceIntegrationsResponse ListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectInstanceIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectInstanceIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListConnectInstanceIntegrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectInstanceIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectInstanceIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        public virtual IAsyncResult BeginListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectInstanceIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectInstanceIntegrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectInstanceIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectInstanceIntegrations.</param>
        /// 
        /// <returns>Returns a  ListConnectInstanceIntegrationsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        public virtual ListConnectInstanceIntegrationsResponse EndListConnectInstanceIntegrations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectInstanceIntegrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PauseCampaign

        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// 
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual PauseCampaignResponse PauseCampaign(PauseCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseCampaignResponseUnmarshaller.Instance;

            return Invoke<PauseCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPauseCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual IAsyncResult BeginPauseCampaign(PauseCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPauseCampaign.</param>
        /// 
        /// <returns>Returns a  PauseCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        public virtual PauseCampaignResponse EndPauseCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<PauseCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConnectInstanceIntegration

        /// <summary>
        /// Put or update the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration service method.</param>
        /// 
        /// <returns>The response from the PutConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        public virtual PutConnectInstanceIntegrationResponse PutConnectInstanceIntegration(PutConnectInstanceIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConnectInstanceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConnectInstanceIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutConnectInstanceIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConnectInstanceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        public virtual IAsyncResult BeginPutConnectInstanceIntegration(PutConnectInstanceIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConnectInstanceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConnectInstanceIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConnectInstanceIntegration.</param>
        /// 
        /// <returns>Returns a  PutConnectInstanceIntegrationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        public virtual PutConnectInstanceIntegrationResponse EndPutConnectInstanceIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConnectInstanceIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInstanceCommunicationLimits

        /// <summary>
        /// Put the instance communication limits. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstanceCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the PutInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutInstanceCommunicationLimits">REST API Reference for PutInstanceCommunicationLimits Operation</seealso>
        public virtual PutInstanceCommunicationLimitsResponse PutInstanceCommunicationLimits(PutInstanceCommunicationLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInstanceCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstanceCommunicationLimitsResponseUnmarshaller.Instance;

            return Invoke<PutInstanceCommunicationLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInstanceCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInstanceCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInstanceCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutInstanceCommunicationLimits">REST API Reference for PutInstanceCommunicationLimits Operation</seealso>
        public virtual IAsyncResult BeginPutInstanceCommunicationLimits(PutInstanceCommunicationLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInstanceCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstanceCommunicationLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInstanceCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInstanceCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  PutInstanceCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutInstanceCommunicationLimits">REST API Reference for PutInstanceCommunicationLimits Operation</seealso>
        public virtual PutInstanceCommunicationLimitsResponse EndPutInstanceCommunicationLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInstanceCommunicationLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutOutboundRequestBatch

        /// <summary>
        /// Creates outbound requests for the specified campaign Amazon Connect account. This
        /// API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch service method.</param>
        /// 
        /// <returns>The response from the PutOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        public virtual PutOutboundRequestBatchResponse PutOutboundRequestBatch(PutOutboundRequestBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOutboundRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutboundRequestBatchResponseUnmarshaller.Instance;

            return Invoke<PutOutboundRequestBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOutboundRequestBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        public virtual IAsyncResult BeginPutOutboundRequestBatch(PutOutboundRequestBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOutboundRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutboundRequestBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOutboundRequestBatch.</param>
        /// 
        /// <returns>Returns a  PutOutboundRequestBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        public virtual PutOutboundRequestBatchResponse EndPutOutboundRequestBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<PutOutboundRequestBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  PutProfileOutboundRequestBatch

        /// <summary>
        /// Takes in a list of profile outbound requests to be placed as part of an outbound campaign.
        /// This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch service method.</param>
        /// 
        /// <returns>The response from the PutProfileOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        public virtual PutProfileOutboundRequestBatchResponse PutProfileOutboundRequestBatch(PutProfileOutboundRequestBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileOutboundRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileOutboundRequestBatchResponseUnmarshaller.Instance;

            return Invoke<PutProfileOutboundRequestBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutProfileOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProfileOutboundRequestBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        public virtual IAsyncResult BeginPutProfileOutboundRequestBatch(PutProfileOutboundRequestBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileOutboundRequestBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileOutboundRequestBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutProfileOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProfileOutboundRequestBatch.</param>
        /// 
        /// <returns>Returns a  PutProfileOutboundRequestBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        public virtual PutProfileOutboundRequestBatchResponse EndPutProfileOutboundRequestBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<PutProfileOutboundRequestBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeCampaign

        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// 
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeCampaignResponseUnmarshaller.Instance;

            return Invoke<ResumeCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual IAsyncResult BeginResumeCampaign(ResumeCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeCampaign.</param>
        /// 
        /// <returns>Returns a  ResumeCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        public virtual ResumeCampaignResponse EndResumeCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCampaign

        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// 
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual StartCampaignResponse StartCampaign(StartCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignResponseUnmarshaller.Instance;

            return Invoke<StartCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual IAsyncResult BeginStartCampaign(StartCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCampaign.</param>
        /// 
        /// <returns>Returns a  StartCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        public virtual StartCampaignResponse EndStartCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  StartInstanceOnboardingJob

        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual StartInstanceOnboardingJobResponse StartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceOnboardingJobResponseUnmarshaller.Instance;

            return Invoke<StartInstanceOnboardingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual IAsyncResult BeginStartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInstanceOnboardingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceOnboardingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  StartInstanceOnboardingJobResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        public virtual StartInstanceOnboardingJobResponse EndStartInstanceOnboardingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInstanceOnboardingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCampaign

        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// 
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual StopCampaignResponse StopCampaign(StopCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCampaignResponseUnmarshaller.Instance;

            return Invoke<StopCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual IAsyncResult BeginStopCampaign(StopCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCampaign.</param>
        /// 
        /// <returns>Returns a  StopCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        public virtual StopCampaignResponse EndStopCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignChannelSubtypeConfig

        /// <summary>
        /// Updates the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        public virtual UpdateCampaignChannelSubtypeConfigResponse UpdateCampaignChannelSubtypeConfig(UpdateCampaignChannelSubtypeConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignChannelSubtypeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignChannelSubtypeConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignChannelSubtypeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignChannelSubtypeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignChannelSubtypeConfig(UpdateCampaignChannelSubtypeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignChannelSubtypeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignChannelSubtypeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignChannelSubtypeConfig.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignChannelSubtypeConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        public virtual UpdateCampaignChannelSubtypeConfigResponse EndUpdateCampaignChannelSubtypeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignChannelSubtypeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignCommunicationLimits

        /// <summary>
        /// Updates the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        public virtual UpdateCampaignCommunicationLimitsResponse UpdateCampaignCommunicationLimits(UpdateCampaignCommunicationLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignCommunicationLimitsResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignCommunicationLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignCommunicationLimits(UpdateCampaignCommunicationLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignCommunicationLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignCommunicationLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        public virtual UpdateCampaignCommunicationLimitsResponse EndUpdateCampaignCommunicationLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignCommunicationLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignCommunicationTime

        /// <summary>
        /// Updates the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        public virtual UpdateCampaignCommunicationTimeResponse UpdateCampaignCommunicationTime(UpdateCampaignCommunicationTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignCommunicationTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignCommunicationTimeResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignCommunicationTimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignCommunicationTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignCommunicationTime(UpdateCampaignCommunicationTimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignCommunicationTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignCommunicationTimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignCommunicationTime.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignCommunicationTimeResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        public virtual UpdateCampaignCommunicationTimeResponse EndUpdateCampaignCommunicationTime(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignCommunicationTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignFlowAssociation

        /// <summary>
        /// Updates the campaign flow associated with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignFlowAssociation service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        public virtual UpdateCampaignFlowAssociationResponse UpdateCampaignFlowAssociation(UpdateCampaignFlowAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignFlowAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignFlowAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignFlowAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignFlowAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignFlowAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignFlowAssociation(UpdateCampaignFlowAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignFlowAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignFlowAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignFlowAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignFlowAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignFlowAssociationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        public virtual UpdateCampaignFlowAssociationResponse EndUpdateCampaignFlowAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignFlowAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignName

        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual UpdateCampaignNameResponse UpdateCampaignName(UpdateCampaignNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignNameResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignName(UpdateCampaignNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignName.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignNameResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        public virtual UpdateCampaignNameResponse EndUpdateCampaignName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignSchedule

        /// <summary>
        /// Updates the schedule for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignSchedule service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        public virtual UpdateCampaignScheduleResponse UpdateCampaignSchedule(UpdateCampaignScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignSchedule(UpdateCampaignScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignScheduleResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        public virtual UpdateCampaignScheduleResponse EndUpdateCampaignSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaignSource

        /// <summary>
        /// Updates the campaign source with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignSource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        public virtual UpdateCampaignSourceResponse UpdateCampaignSource(UpdateCampaignSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaignSource(UpdateCampaignSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignSource.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignSourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        public virtual UpdateCampaignSourceResponse EndUpdateCampaignSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignSourceResponse>(asyncResult);
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
            var resolver = new AmazonConnectCampaignsV2EndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}