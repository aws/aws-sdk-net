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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// Create an extended source server in the target Account based on the source server
        /// in staging account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtendedSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateExtendedSourceServerResponse> CreateExtendedSourceServerAsync(CreateExtendedSourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExtendedSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtendedSourceServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateExtendedSourceServerResponse>(request, options, cancellationToken);
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
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateReplicationConfigurationTemplateResponse> CreateReplicationConfigurationTemplateAsync(CreateReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
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
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
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
        /// Deletes a single Recovery Instance by ID. This deletes the Recovery Instance resource
        /// from Elastic Disaster Recovery. The Recovery Instance must be disconnected first in
        /// order to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRecoveryInstanceResponse> DeleteRecoveryInstanceAsync(DeleteRecoveryInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRecoveryInstanceResponse>(request, options, cancellationToken);
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
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteReplicationConfigurationTemplateResponse> DeleteReplicationConfigurationTemplateAsync(DeleteReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
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
        /// Deletes a single Source Server by ID. The Source Server must be disconnected first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSourceServerResponse> DeleteSourceServerAsync(DeleteSourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSourceServerResponse>(request, options, cancellationToken);
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
        /// Retrieves a detailed Job log with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeJobLogItemsResponse> DescribeJobLogItemsAsync(DescribeJobLogItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobLogItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobLogItemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobLogItemsResponse>(request, options, cancellationToken);
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
        /// Returns a list of Jobs. Use the JobsID and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are created by the StartRecovery, TerminateRecoveryInstances and StartFailbackLaunch
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobsResponse>(request, options, cancellationToken);
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
        /// Lists all Recovery Instances or multiple Recovery Instances by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRecoveryInstancesResponse> DescribeRecoveryInstancesAsync(DescribeRecoveryInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecoveryInstancesResponse>(request, options, cancellationToken);
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
        /// Lists all Recovery Snapshots for a single Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoverySnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRecoverySnapshotsResponse> DescribeRecoverySnapshotsAsync(DescribeRecoverySnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoverySnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoverySnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecoverySnapshotsResponse>(request, options, cancellationToken);
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
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeReplicationConfigurationTemplatesResponse> DescribeReplicationConfigurationTemplatesAsync(DescribeReplicationConfigurationTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationConfigurationTemplatesResponse>(request, options, cancellationToken);
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
        /// Lists all Source Servers or multiple Source Servers filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeSourceServersResponse> DescribeSourceServersAsync(DescribeSourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceServersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSourceServersResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisconnectRecoveryInstanceResponse> DisconnectRecoveryInstanceAsync(DisconnectRecoveryInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectRecoveryInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectRecoveryInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisconnectRecoveryInstanceResponse>(request, options, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisconnectSourceServerResponse> DisconnectSourceServerAsync(DisconnectSourceServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectSourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectSourceServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisconnectSourceServerResponse>(request, options, cancellationToken);
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
        /// Lists all Failback ReplicationConfigurations, filtered by Recovery Instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailbackReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFailbackReplicationConfigurationResponse> GetFailbackReplicationConfigurationAsync(GetFailbackReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFailbackReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFailbackReplicationConfigurationResponse>(request, options, cancellationToken);
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
        /// Gets a LaunchConfiguration, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLaunchConfigurationResponse> GetLaunchConfigurationAsync(GetLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLaunchConfigurationResponse>(request, options, cancellationToken);
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
        /// Gets a ReplicationConfiguration, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReplicationConfigurationResponse> GetReplicationConfigurationAsync(GetReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetReplicationConfigurationResponse>(request, options, cancellationToken);
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
        /// Initialize Elastic Disaster Recovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<InitializeServiceResponse>(request, options, cancellationToken);
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
        /// Returns a list of source servers on a staging account that are extensible, which means
        /// that: a. The source server is not already extended into this Account. b. The source
        /// server on the Account we’re reading from is not an extension of another source server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensibleSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListExtensibleSourceServersResponse> ListExtensibleSourceServersAsync(ListExtensibleSourceServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensibleSourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensibleSourceServersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExtensibleSourceServersResponse>(request, options, cancellationToken);
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
        /// Returns an array of staging accounts for existing extended source servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStagingAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListStagingAccountsResponse> ListStagingAccountsAsync(ListStagingAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagingAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagingAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStagingAccountsResponse>(request, options, cancellationToken);
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
        /// List all tags for your Elastic Disaster Recovery resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// WARNING: RetryDataReplication is deprecated. Causes the data replication initiation
        /// sequence to begin immediately upon next Handshake for the specified Source Server
        /// ID, regardless of when the previous initiation started. This command will work only
        /// if the Source Server is stalled or is in a DISCONNECTED or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RetryDataReplicationResponse> RetryDataReplicationAsync(RetryDataReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryDataReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryDataReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetryDataReplicationResponse>(request, options, cancellationToken);
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
        /// Start replication to origin / target region - applies only to protected instances
        /// that originated in EC2. For recovery instances on target region - starts replication
        /// back to origin region. For failback instances on origin region - starts replication
        /// to target region to re-protect them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ReverseReplicationResponse> ReverseReplicationAsync(ReverseReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReverseReplicationResponse>(request, options, cancellationToken);
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
        /// Initiates a Job for launching the machine that is being failed back to from the specified
        /// Recovery Instance. This will run conversion on the failback client and will reboot
        /// your machine, thus completing the failback process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailbackLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartFailbackLaunchResponse> StartFailbackLaunchAsync(StartFailbackLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFailbackLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFailbackLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFailbackLaunchResponse>(request, options, cancellationToken);
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
        /// Launches Recovery Instances for the specified Source Servers. For each Source Server
        /// you may choose a point in time snapshot to launch from, or use an on demand snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartRecoveryResponse> StartRecoveryAsync(StartRecoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecoveryResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartRecoveryResponse>(request, options, cancellationToken);
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
        /// Starts replication for a stopped Source Server. This action would make the Source
        /// Server protected again and restart billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationResponse>(request, options, cancellationToken);
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
        /// Stops the failback process for a specified Recovery Instance. This changes the Failback
        /// State of the Recovery Instance back to FAILBACK_NOT_STARTED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFailback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopFailbackResponse> StopFailbackAsync(StopFailbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFailbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFailbackResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopFailbackResponse>(request, options, cancellationToken);
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
        /// Stops replication for a Source Server. This action would make the Source Server unprotected,
        /// delete its existing snapshots and stop billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopReplicationResponse> StopReplicationAsync(StopReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopReplicationResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites only the specified tags for the specified Elastic Disaster Recovery
        /// resource or resources. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// Initiates a Job for terminating the EC2 resources associated with the specified Recovery
        /// Instances, and then will delete the Recovery Instances from the Elastic Disaster Recovery
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateRecoveryInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TerminateRecoveryInstancesResponse> TerminateRecoveryInstancesAsync(TerminateRecoveryInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateRecoveryInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateRecoveryInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateRecoveryInstancesResponse>(request, options, cancellationToken);
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
        /// Deletes the specified set of tags from the specified set of Elastic Disaster Recovery
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Allows you to update the failback replication configuration of a Recovery Instance
        /// by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailbackReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFailbackReplicationConfigurationResponse> UpdateFailbackReplicationConfigurationAsync(UpdateFailbackReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFailbackReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFailbackReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFailbackReplicationConfigurationResponse>(request, options, cancellationToken);
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
        /// Updates a LaunchConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateLaunchConfigurationResponse> UpdateLaunchConfigurationAsync(UpdateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLaunchConfigurationResponse>(request, options, cancellationToken);
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
        /// Allows you to update a ReplicationConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateReplicationConfigurationResponse> UpdateReplicationConfigurationAsync(UpdateReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateReplicationConfigurationResponse>(request, options, cancellationToken);
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
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateReplicationConfigurationTemplateResponse> UpdateReplicationConfigurationTemplateAsync(UpdateReplicationConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateReplicationConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}