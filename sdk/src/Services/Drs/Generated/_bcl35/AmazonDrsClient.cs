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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Drs.Model;
using Amazon.Drs.Model.Internal.MarshallTransformations;
using Amazon.Drs.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Drs
{
    /// <summary>
    /// Implementation for accessing Drs
    ///
    /// AWS Elastic Disaster Recovery Service.
    /// </summary>
    public partial class AmazonDrsClient : AmazonServiceClient, IAmazonDrs
    {
        private static IServiceMetadata serviceMetadata = new AmazonDrsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDrsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDrsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DrsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDrsClient with the credentials loaded from the application's
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
        public AmazonDrsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDrsConfig()) { }

        /// <summary>
        /// Constructs AmazonDrsClient with the credentials loaded from the application's
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
        public AmazonDrsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDrsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDrsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDrsClient Configuration Object</param>
        public AmazonDrsClient(AmazonDrsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDrsClient(AWSCredentials credentials)
            : this(credentials, new AmazonDrsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDrsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDrsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Credentials and an
        /// AmazonDrsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDrsClient Configuration Object</param>
        public AmazonDrsClient(AWSCredentials credentials, AmazonDrsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDrsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDrsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDrsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDrsClient Configuration Object</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDrsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDrsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDrsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDrsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDrsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDrsClient Configuration Object</param>
        public AmazonDrsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDrsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDrsEndpointResolver());
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


        #region  CreateExtendedSourceServer

        /// <summary>
        /// Create an extended source server in the target Account based on the source server
        /// in staging account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtendedSourceServer service method.</param>
        /// 
        /// <returns>The response from the CreateExtendedSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateExtendedSourceServer">REST API Reference for CreateExtendedSourceServer Operation</seealso>
        public virtual CreateExtendedSourceServerResponse CreateExtendedSourceServer(CreateExtendedSourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExtendedSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtendedSourceServerResponseUnmarshaller.Instance;

            return Invoke<CreateExtendedSourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExtendedSourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExtendedSourceServer operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExtendedSourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateExtendedSourceServer">REST API Reference for CreateExtendedSourceServer Operation</seealso>
        public virtual IAsyncResult BeginCreateExtendedSourceServer(CreateExtendedSourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExtendedSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtendedSourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExtendedSourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExtendedSourceServer.</param>
        /// 
        /// <returns>Returns a  CreateExtendedSourceServerResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateExtendedSourceServer">REST API Reference for CreateExtendedSourceServer Operation</seealso>
        public virtual CreateExtendedSourceServerResponse EndCreateExtendedSourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExtendedSourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationConfigurationTemplate

        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateReplicationConfigurationTemplateResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        public virtual CreateReplicationConfigurationTemplateResponse EndCreateReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJob

        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecoveryInstance

        /// <summary>
        /// Deletes a single Recovery Instance by ID. This deletes the Recovery Instance resource
        /// from Elastic Disaster Recovery. The Recovery Instance must be disconnected first in
        /// order to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteRecoveryInstance">REST API Reference for DeleteRecoveryInstance Operation</seealso>
        public virtual DeleteRecoveryInstanceResponse DeleteRecoveryInstance(DeleteRecoveryInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryInstance operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecoveryInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteRecoveryInstance">REST API Reference for DeleteRecoveryInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecoveryInstance(DeleteRecoveryInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecoveryInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecoveryInstance.</param>
        /// 
        /// <returns>Returns a  DeleteRecoveryInstanceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteRecoveryInstance">REST API Reference for DeleteRecoveryInstance Operation</seealso>
        public virtual DeleteRecoveryInstanceResponse EndDeleteRecoveryInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecoveryInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationConfigurationTemplate

        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationConfigurationTemplateResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        public virtual DeleteReplicationConfigurationTemplateResponse EndDeleteReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSourceServer

        /// <summary>
        /// Deletes a single Source Server by ID. The Source Server must be disconnected first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual IAsyncResult BeginDeleteSourceServer(DeleteSourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceServer.</param>
        /// 
        /// <returns>Returns a  DeleteSourceServerResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        public virtual DeleteSourceServerResponse EndDeleteSourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobLogItems

        /// <summary>
        /// Retrieves a detailed Job log with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobLogItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobLogItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobLogItems(DescribeJobLogItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobLogItems.</param>
        /// 
        /// <returns>Returns a  DescribeJobLogItemsResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        public virtual DescribeJobLogItemsResponse EndDescribeJobLogItems(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobLogItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobs

        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are created by the StartRecovery, TerminateRecoveryInstances and StartFailbackLaunch
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse DescribeJobs(DescribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobs(DescribeJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobs.</param>
        /// 
        /// <returns>Returns a  DescribeJobsResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse EndDescribeJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecoveryInstances

        /// <summary>
        /// Lists all Recovery Instances or multiple Recovery Instances by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoveryInstances">REST API Reference for DescribeRecoveryInstances Operation</seealso>
        public virtual DescribeRecoveryInstancesResponse DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeRecoveryInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecoveryInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryInstances operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecoveryInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoveryInstances">REST API Reference for DescribeRecoveryInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecoveryInstances(DescribeRecoveryInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecoveryInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecoveryInstances.</param>
        /// 
        /// <returns>Returns a  DescribeRecoveryInstancesResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoveryInstances">REST API Reference for DescribeRecoveryInstances Operation</seealso>
        public virtual DescribeRecoveryInstancesResponse EndDescribeRecoveryInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecoveryInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecoverySnapshots

        /// <summary>
        /// Lists all Recovery Snapshots for a single Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoverySnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoverySnapshots service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoverySnapshots">REST API Reference for DescribeRecoverySnapshots Operation</seealso>
        public virtual DescribeRecoverySnapshotsResponse DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoverySnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoverySnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecoverySnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecoverySnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoverySnapshots operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecoverySnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoverySnapshots">REST API Reference for DescribeRecoverySnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoverySnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoverySnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecoverySnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecoverySnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeRecoverySnapshotsResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoverySnapshots">REST API Reference for DescribeRecoverySnapshots Operation</seealso>
        public virtual DescribeRecoverySnapshotsResponse EndDescribeRecoverySnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecoverySnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationConfigurationTemplates

        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigurationTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationConfigurationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationConfigurationTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationConfigurationTemplatesResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        public virtual DescribeReplicationConfigurationTemplatesResponse EndDescribeReplicationConfigurationTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationConfigurationTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSourceServers

        /// <summary>
        /// Lists all Source Servers or multiple Source Servers filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual IAsyncResult BeginDescribeSourceServers(DescribeSourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceServers.</param>
        /// 
        /// <returns>Returns a  DescribeSourceServersResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        public virtual DescribeSourceServersResponse EndDescribeSourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectRecoveryInstance

        /// <summary>
        /// Disconnect a Recovery Instance from Elastic Disaster Recovery. Data replication is
        /// stopped immediately. All AWS resources created by Elastic Disaster Recovery for enabling
        /// the replication of the Recovery Instance will be terminated / deleted within 90 minutes.
        /// If the agent on the Recovery Instance has not been prevented from communicating with
        /// the Elastic Disaster Recovery service, then it will receive a command to uninstall
        /// itself (within approximately 10 minutes). The following properties of the Recovery
        /// Instance will be changed immediately: dataReplicationInfo.dataReplicationState will
        /// be set to DISCONNECTED; The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks
        /// will be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectRecoveryInstance service method.</param>
        /// 
        /// <returns>The response from the DisconnectRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectRecoveryInstance">REST API Reference for DisconnectRecoveryInstance Operation</seealso>
        public virtual DisconnectRecoveryInstanceResponse DisconnectRecoveryInstance(DisconnectRecoveryInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectRecoveryInstanceResponseUnmarshaller.Instance;

            return Invoke<DisconnectRecoveryInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectRecoveryInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectRecoveryInstance operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectRecoveryInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectRecoveryInstance">REST API Reference for DisconnectRecoveryInstance Operation</seealso>
        public virtual IAsyncResult BeginDisconnectRecoveryInstance(DisconnectRecoveryInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectRecoveryInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectRecoveryInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectRecoveryInstance.</param>
        /// 
        /// <returns>Returns a  DisconnectRecoveryInstanceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectRecoveryInstance">REST API Reference for DisconnectRecoveryInstance Operation</seealso>
        public virtual DisconnectRecoveryInstanceResponse EndDisconnectRecoveryInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectRecoveryInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectSourceServer

        /// <summary>
        /// Disconnects a specific Source Server from Elastic Disaster Recovery. Data replication
        /// is stopped immediately. All AWS resources created by Elastic Disaster Recovery for
        /// enabling the replication of the Source Server will be terminated / deleted within
        /// 90 minutes. You cannot disconnect a Source Server if it has a Recovery Instance. If
        /// the agent on the Source Server has not been prevented from communicating with the
        /// Elastic Disaster Recovery service, then it will receive a command to uninstall itself
        /// (within approximately 10 minutes). The following properties of the SourceServer will
        /// be changed immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectSourceServer service method.</param>
        /// 
        /// <returns>The response from the DisconnectSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectSourceServer">REST API Reference for DisconnectSourceServer Operation</seealso>
        public virtual DisconnectSourceServerResponse DisconnectSourceServer(DisconnectSourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectSourceServerResponseUnmarshaller.Instance;

            return Invoke<DisconnectSourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectSourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectSourceServer operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectSourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectSourceServer">REST API Reference for DisconnectSourceServer Operation</seealso>
        public virtual IAsyncResult BeginDisconnectSourceServer(DisconnectSourceServerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectSourceServerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectSourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectSourceServer.</param>
        /// 
        /// <returns>Returns a  DisconnectSourceServerResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectSourceServer">REST API Reference for DisconnectSourceServer Operation</seealso>
        public virtual DisconnectSourceServerResponse EndDisconnectSourceServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectSourceServerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFailbackReplicationConfiguration

        /// <summary>
        /// Lists all Failback ReplicationConfigurations, filtered by Recovery Instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailbackReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetFailbackReplicationConfiguration">REST API Reference for GetFailbackReplicationConfiguration Operation</seealso>
        public virtual GetFailbackReplicationConfigurationResponse GetFailbackReplicationConfiguration(GetFailbackReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFailbackReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFailbackReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFailbackReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFailbackReplicationConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFailbackReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetFailbackReplicationConfiguration">REST API Reference for GetFailbackReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetFailbackReplicationConfiguration(GetFailbackReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFailbackReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFailbackReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFailbackReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFailbackReplicationConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetFailbackReplicationConfiguration">REST API Reference for GetFailbackReplicationConfiguration Operation</seealso>
        public virtual GetFailbackReplicationConfigurationResponse EndGetFailbackReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFailbackReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLaunchConfiguration

        /// <summary>
        /// Gets a LaunchConfiguration, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetLaunchConfiguration(GetLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLaunchConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        public virtual GetLaunchConfigurationResponse EndGetLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReplicationConfiguration

        /// <summary>
        /// Gets a ReplicationConfiguration, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetReplicationConfiguration(GetReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetReplicationConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        public virtual GetReplicationConfigurationResponse EndGetReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  InitializeService

        /// <summary>
        /// Initialize Elastic Disaster Recovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeService operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual IAsyncResult BeginInitializeService(InitializeServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InitializeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitializeService.</param>
        /// 
        /// <returns>Returns a  InitializeServiceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual InitializeServiceResponse EndInitializeService(IAsyncResult asyncResult)
        {
            return EndInvoke<InitializeServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExtensibleSourceServers

        /// <summary>
        /// Returns a list of source servers on a staging account that are extensible, which means
        /// that: a. The source server is not already extended into this Account. b. The source
        /// server on the Account we’re reading from is not an extension of another source server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensibleSourceServers service method.</param>
        /// 
        /// <returns>The response from the ListExtensibleSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListExtensibleSourceServers">REST API Reference for ListExtensibleSourceServers Operation</seealso>
        public virtual ListExtensibleSourceServersResponse ListExtensibleSourceServers(ListExtensibleSourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensibleSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensibleSourceServersResponseUnmarshaller.Instance;

            return Invoke<ListExtensibleSourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExtensibleSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensibleSourceServers operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensibleSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListExtensibleSourceServers">REST API Reference for ListExtensibleSourceServers Operation</seealso>
        public virtual IAsyncResult BeginListExtensibleSourceServers(ListExtensibleSourceServersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensibleSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensibleSourceServersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensibleSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensibleSourceServers.</param>
        /// 
        /// <returns>Returns a  ListExtensibleSourceServersResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListExtensibleSourceServers">REST API Reference for ListExtensibleSourceServers Operation</seealso>
        public virtual ListExtensibleSourceServersResponse EndListExtensibleSourceServers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExtensibleSourceServersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStagingAccounts

        /// <summary>
        /// Returns an array of staging accounts for existing extended source servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStagingAccounts service method.</param>
        /// 
        /// <returns>The response from the ListStagingAccounts service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListStagingAccounts">REST API Reference for ListStagingAccounts Operation</seealso>
        public virtual ListStagingAccountsResponse ListStagingAccounts(ListStagingAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagingAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagingAccountsResponseUnmarshaller.Instance;

            return Invoke<ListStagingAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStagingAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStagingAccounts operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStagingAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListStagingAccounts">REST API Reference for ListStagingAccounts Operation</seealso>
        public virtual IAsyncResult BeginListStagingAccounts(ListStagingAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagingAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagingAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStagingAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStagingAccounts.</param>
        /// 
        /// <returns>Returns a  ListStagingAccountsResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListStagingAccounts">REST API Reference for ListStagingAccounts Operation</seealso>
        public virtual ListStagingAccountsResponse EndListStagingAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStagingAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all tags for your Elastic Disaster Recovery resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RetryDataReplication

        /// <summary>
        /// WARNING: RetryDataReplication is deprecated. Causes the data replication initiation
        /// sequence to begin immediately upon next Handshake for the specified Source Server
        /// ID, regardless of when the previous initiation started. This command will work only
        /// if the Source Server is stalled or is in a DISCONNECTED or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        [Obsolete("WARNING: RetryDataReplication is deprecated")]
        public virtual RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return Invoke<RetryDataReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryDataReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        [Obsolete("WARNING: RetryDataReplication is deprecated")]
        public virtual IAsyncResult BeginRetryDataReplication(RetryDataReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryDataReplication.</param>
        /// 
        /// <returns>Returns a  RetryDataReplicationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        [Obsolete("WARNING: RetryDataReplication is deprecated")]
        public virtual RetryDataReplicationResponse EndRetryDataReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<RetryDataReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  ReverseReplication

        /// <summary>
        /// Start replication to origin / target region - applies only to protected instances
        /// that originated in EC2. For recovery instances on target region - starts replication
        /// back to origin region. For failback instances on origin region - starts replication
        /// to target region to re-protect them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseReplication service method.</param>
        /// 
        /// <returns>The response from the ReverseReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ReverseReplication">REST API Reference for ReverseReplication Operation</seealso>
        public virtual ReverseReplicationResponse ReverseReplication(ReverseReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseReplicationResponseUnmarshaller.Instance;

            return Invoke<ReverseReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReverseReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReverseReplication operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReverseReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ReverseReplication">REST API Reference for ReverseReplication Operation</seealso>
        public virtual IAsyncResult BeginReverseReplication(ReverseReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReverseReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReverseReplication.</param>
        /// 
        /// <returns>Returns a  ReverseReplicationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ReverseReplication">REST API Reference for ReverseReplication Operation</seealso>
        public virtual ReverseReplicationResponse EndReverseReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<ReverseReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFailbackLaunch

        /// <summary>
        /// Initiates a Job for launching the machine that is being failed back to from the specified
        /// Recovery Instance. This will run conversion on the failback client and will reboot
        /// your machine, thus completing the failback process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailbackLaunch service method.</param>
        /// 
        /// <returns>The response from the StartFailbackLaunch service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartFailbackLaunch">REST API Reference for StartFailbackLaunch Operation</seealso>
        public virtual StartFailbackLaunchResponse StartFailbackLaunch(StartFailbackLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFailbackLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFailbackLaunchResponseUnmarshaller.Instance;

            return Invoke<StartFailbackLaunchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFailbackLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFailbackLaunch operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFailbackLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartFailbackLaunch">REST API Reference for StartFailbackLaunch Operation</seealso>
        public virtual IAsyncResult BeginStartFailbackLaunch(StartFailbackLaunchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFailbackLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFailbackLaunchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFailbackLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFailbackLaunch.</param>
        /// 
        /// <returns>Returns a  StartFailbackLaunchResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartFailbackLaunch">REST API Reference for StartFailbackLaunch Operation</seealso>
        public virtual StartFailbackLaunchResponse EndStartFailbackLaunch(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFailbackLaunchResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRecovery

        /// <summary>
        /// Launches Recovery Instances for the specified Source Servers. For each Source Server
        /// you may choose a point in time snapshot to launch from, or use an on demand snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecovery service method.</param>
        /// 
        /// <returns>The response from the StartRecovery service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartRecovery">REST API Reference for StartRecovery Operation</seealso>
        public virtual StartRecoveryResponse StartRecovery(StartRecoveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecoveryResponseUnmarshaller.Instance;

            return Invoke<StartRecoveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRecovery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRecovery operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRecovery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartRecovery">REST API Reference for StartRecovery Operation</seealso>
        public virtual IAsyncResult BeginStartRecovery(StartRecoveryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecoveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRecovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRecovery.</param>
        /// 
        /// <returns>Returns a  StartRecoveryResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartRecovery">REST API Reference for StartRecovery Operation</seealso>
        public virtual StartRecoveryResponse EndStartRecovery(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRecoveryResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplication

        /// <summary>
        /// Starts replication for a stopped Source Server. This action would make the Source
        /// Server protected again and restart billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse StartReplication(StartReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return Invoke<StartReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplication operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual IAsyncResult BeginStartReplication(StartReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplication.</param>
        /// 
        /// <returns>Returns a  StartReplicationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse EndStartReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFailback

        /// <summary>
        /// Stops the failback process for a specified Recovery Instance. This changes the Failback
        /// State of the Recovery Instance back to FAILBACK_NOT_STARTED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFailback service method.</param>
        /// 
        /// <returns>The response from the StopFailback service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopFailback">REST API Reference for StopFailback Operation</seealso>
        public virtual StopFailbackResponse StopFailback(StopFailbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFailbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFailbackResponseUnmarshaller.Instance;

            return Invoke<StopFailbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFailback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFailback operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFailback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopFailback">REST API Reference for StopFailback Operation</seealso>
        public virtual IAsyncResult BeginStopFailback(StopFailbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFailbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFailbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopFailback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFailback.</param>
        /// 
        /// <returns>Returns a  StopFailbackResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopFailback">REST API Reference for StopFailback Operation</seealso>
        public virtual StopFailbackResponse EndStopFailback(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFailbackResponse>(asyncResult);
        }

        #endregion
        
        #region  StopReplication

        /// <summary>
        /// Stops replication for a Source Server. This action would make the Source Server unprotected,
        /// delete its existing snapshots and stop billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// 
        /// <returns>The response from the StopReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual StopReplicationResponse StopReplication(StopReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;

            return Invoke<StopReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplication operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual IAsyncResult BeginStopReplication(StopReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopReplication.</param>
        /// 
        /// <returns>Returns a  StopReplicationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual StopReplicationResponse EndStopReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StopReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Elastic Disaster Recovery
        /// resource or resources. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateRecoveryInstances

        /// <summary>
        /// Initiates a Job for terminating the EC2 resources associated with the specified Recovery
        /// Instances, and then will delete the Recovery Instances from the Elastic Disaster Recovery
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateRecoveryInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TerminateRecoveryInstances">REST API Reference for TerminateRecoveryInstances Operation</seealso>
        public virtual TerminateRecoveryInstancesResponse TerminateRecoveryInstances(TerminateRecoveryInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateRecoveryInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateRecoveryInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateRecoveryInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateRecoveryInstances operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateRecoveryInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TerminateRecoveryInstances">REST API Reference for TerminateRecoveryInstances Operation</seealso>
        public virtual IAsyncResult BeginTerminateRecoveryInstances(TerminateRecoveryInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateRecoveryInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateRecoveryInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateRecoveryInstances.</param>
        /// 
        /// <returns>Returns a  TerminateRecoveryInstancesResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TerminateRecoveryInstances">REST API Reference for TerminateRecoveryInstances Operation</seealso>
        public virtual TerminateRecoveryInstancesResponse EndTerminateRecoveryInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateRecoveryInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes the specified set of tags from the specified set of Elastic Disaster Recovery
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFailbackReplicationConfiguration

        /// <summary>
        /// Allows you to update the failback replication configuration of a Recovery Instance
        /// by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailbackReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateFailbackReplicationConfiguration">REST API Reference for UpdateFailbackReplicationConfiguration Operation</seealso>
        public virtual UpdateFailbackReplicationConfigurationResponse UpdateFailbackReplicationConfiguration(UpdateFailbackReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFailbackReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFailbackReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFailbackReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailbackReplicationConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFailbackReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateFailbackReplicationConfiguration">REST API Reference for UpdateFailbackReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateFailbackReplicationConfiguration(UpdateFailbackReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFailbackReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFailbackReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFailbackReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFailbackReplicationConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateFailbackReplicationConfiguration">REST API Reference for UpdateFailbackReplicationConfiguration Operation</seealso>
        public virtual UpdateFailbackReplicationConfigurationResponse EndUpdateFailbackReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFailbackReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLaunchConfiguration

        /// <summary>
        /// Updates a LaunchConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        public virtual UpdateLaunchConfigurationResponse EndUpdateLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLaunchConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationConfiguration

        /// <summary>
        /// Allows you to update a ReplicationConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        public virtual UpdateReplicationConfigurationResponse EndUpdateReplicationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReplicationConfigurationTemplate

        /// <summary>
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationConfigurationTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate operation on AmazonDrsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationTemplateResult from Drs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        public virtual UpdateReplicationConfigurationTemplateResponse EndUpdateReplicationConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReplicationConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
    }
}