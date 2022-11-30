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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataExchange.Model;
using Amazon.DataExchange.Model.Internal.MarshallTransformations;
using Amazon.DataExchange.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataExchange
{
    /// <summary>
    /// Implementation for accessing DataExchange
    ///
    /// AWS Data Exchange is a service that makes it easy for AWS customers to exchange data
    /// in the cloud. You can use the AWS Data Exchange APIs to create, update, manage, and
    /// access file-based data set in the AWS Cloud.
    /// 
    ///  
    /// <para>
    /// As a subscriber, you can view and access the data sets that you have an entitlement
    /// to through a subscription. You can use the APIs to download or copy your entitled
    /// data sets to Amazon Simple Storage Service (Amazon S3) for use across a variety of
    /// AWS analytics and machine learning services.
    /// </para>
    ///  
    /// <para>
    /// As a provider, you can create and manage your data sets that you would like to publish
    /// to a product. Being able to package and provide your data sets into products requires
    /// a few steps to determine eligibility. For more information, visit the <i>AWS Data
    /// Exchange User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A data set is a collection of data that can be changed or updated over time. Data
    /// sets can be updated using revisions, which represent a new version or incremental
    /// change to a data set. A revision contains one or more assets. An asset in AWS Data
    /// Exchange is a piece of data that can be stored as an Amazon S3 object, Redshift datashare,
    /// API Gateway API, AWS Lake Formation data permission, or Amazon S3 data access. The
    /// asset can be a structured data file, an image file, or some other data file. Jobs
    /// are asynchronous import or export operations used to create or copy assets.
    /// </para>
    /// </summary>
    public partial class AmazonDataExchangeClient : AmazonServiceClient, IAmazonDataExchange
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataExchangeMetadata();
        private IDataExchangePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataExchangePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataExchangePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        public AmazonDataExchangeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataExchangeConfig()) { }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        public AmazonDataExchangeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataExchangeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(AmazonDataExchangeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataExchangeClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataExchangeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Credentials and an
        /// AmazonDataExchangeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(AWSCredentials credentials, AmazonDataExchangeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataExchangeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataExchangeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataExchangeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataExchangeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataExchangeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataExchangeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataExchangeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataExchangeClient Configuration Object</param>
        public AmazonDataExchangeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataExchangeConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataExchangeEndpointResolver());
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


        #region  CancelJob


        /// <summary>
        /// This operation cancels a job. Jobs can be cancelled only when they are in the WAITING
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }


        /// <summary>
        /// This operation cancels a job. Jobs can be cancelled only when they are in the WAITING
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSet


        /// <summary>
        /// This operation creates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual CreateDataSetResponse CreateDataSet(CreateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return Invoke<CreateDataSetResponse>(request, options);
        }


        /// <summary>
        /// This operation creates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventAction


        /// <summary>
        /// This operation creates an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction service method.</param>
        /// 
        /// <returns>The response from the CreateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        public virtual CreateEventActionResponse CreateEventAction(CreateEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventActionResponseUnmarshaller.Instance;

            return Invoke<CreateEventActionResponse>(request, options);
        }


        /// <summary>
        /// This operation creates an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        public virtual Task<CreateEventActionResponse> CreateEventActionAsync(CreateEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// This operation creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


        /// <summary>
        /// This operation creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRevision


        /// <summary>
        /// This operation creates a revision for a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision service method.</param>
        /// 
        /// <returns>The response from the CreateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        public virtual CreateRevisionResponse CreateRevision(CreateRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateRevisionResponse>(request, options);
        }


        /// <summary>
        /// This operation creates a revision for a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        public virtual Task<CreateRevisionResponse> CreateRevisionAsync(CreateRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAsset


        /// <summary>
        /// This operation deletes an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSet


        /// <summary>
        /// This operation deletes a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSetResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventAction


        /// <summary>
        /// This operation deletes the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction service method.</param>
        /// 
        /// <returns>The response from the DeleteEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        public virtual DeleteEventActionResponse DeleteEventAction(DeleteEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventActionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventActionResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        public virtual Task<DeleteEventActionResponse> DeleteEventActionAsync(DeleteEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRevision


        /// <summary>
        /// This operation deletes a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision service method.</param>
        /// 
        /// <returns>The response from the DeleteRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        public virtual DeleteRevisionResponse DeleteRevision(DeleteRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRevisionResponseUnmarshaller.Instance;

            return Invoke<DeleteRevisionResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        public virtual Task<DeleteRevisionResponse> DeleteRevisionAsync(DeleteRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAsset


        /// <summary>
        /// This operation returns information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse GetAsset(GetAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return Invoke<GetAssetResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual Task<GetAssetResponse> GetAssetAsync(GetAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSet


        /// <summary>
        /// This operation returns information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet service method.</param>
        /// 
        /// <returns>The response from the GetDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        public virtual GetDataSetResponse GetDataSet(GetDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetResponseUnmarshaller.Instance;

            return Invoke<GetDataSetResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        public virtual Task<GetDataSetResponse> GetDataSetAsync(GetDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventAction


        /// <summary>
        /// This operation retrieves information about an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction service method.</param>
        /// 
        /// <returns>The response from the GetEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        public virtual GetEventActionResponse GetEventAction(GetEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventActionResponseUnmarshaller.Instance;

            return Invoke<GetEventActionResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves information about an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        public virtual Task<GetEventActionResponse> GetEventActionAsync(GetEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob


        /// <summary>
        /// This operation returns information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRevision


        /// <summary>
        /// This operation returns information about a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual GetRevisionResponse GetRevision(GetRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return Invoke<GetRevisionResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual Task<GetRevisionResponse> GetRevisionAsync(GetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSetRevisions


        /// <summary>
        /// This operation lists a data set's revisions sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions service method.</param>
        /// 
        /// <returns>The response from the ListDataSetRevisions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        public virtual ListDataSetRevisionsResponse ListDataSetRevisions(ListDataSetRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetRevisionsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists a data set's revisions sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSetRevisions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        public virtual Task<ListDataSetRevisionsResponse> ListDataSetRevisionsAsync(ListDataSetRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSetRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSets


        /// <summary>
        /// This operation lists your data sets. When listing by origin OWNED, results are sorted
        /// by CreatedAt in descending order. When listing by origin ENTITLED, there is no order
        /// and the maxResults parameter is ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists your data sets. When listing by origin OWNED, results are sorted
        /// by CreatedAt in descending order. When listing by origin ENTITLED, there is no order
        /// and the maxResults parameter is ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventActions


        /// <summary>
        /// This operation lists your event actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions service method.</param>
        /// 
        /// <returns>The response from the ListEventActions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        public virtual ListEventActionsResponse ListEventActions(ListEventActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventActionsResponseUnmarshaller.Instance;

            return Invoke<ListEventActionsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists your event actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventActions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        public virtual Task<ListEventActionsResponse> ListEventActionsAsync(ListEventActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// This operation lists your jobs sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists your jobs sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRevisionAssets


        /// <summary>
        /// This operation lists a revision's assets sorted alphabetically in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets service method.</param>
        /// 
        /// <returns>The response from the ListRevisionAssets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        public virtual ListRevisionAssetsResponse ListRevisionAssets(ListRevisionAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRevisionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevisionAssetsResponseUnmarshaller.Instance;

            return Invoke<ListRevisionAssetsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists a revision's assets sorted alphabetically in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevisionAssets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        public virtual Task<ListRevisionAssetsResponse> ListRevisionAssetsAsync(ListRevisionAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRevisionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevisionAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRevisionAssetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// This operation lists the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation lists the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeRevision


        /// <summary>
        /// This operation revokes subscribers' access to a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision service method.</param>
        /// 
        /// <returns>The response from the RevokeRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        public virtual RevokeRevisionResponse RevokeRevision(RevokeRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRevisionResponseUnmarshaller.Instance;

            return Invoke<RevokeRevisionResponse>(request, options);
        }


        /// <summary>
        /// This operation revokes subscribers' access to a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        public virtual Task<RevokeRevisionResponse> RevokeRevisionAsync(RevokeRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendApiAsset


        /// <summary>
        /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
        /// API Gateway API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset service method.</param>
        /// 
        /// <returns>The response from the SendApiAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        public virtual SendApiAssetResponse SendApiAsset(SendApiAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendApiAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendApiAssetResponseUnmarshaller.Instance;

            return Invoke<SendApiAssetResponse>(request, options);
        }


        /// <summary>
        /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
        /// API Gateway API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendApiAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        public virtual Task<SendApiAssetResponse> SendApiAssetAsync(SendApiAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendApiAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendApiAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendApiAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJob


        /// <summary>
        /// This operation starts a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse StartJob(StartJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return Invoke<StartJobResponse>(request, options);
        }


        /// <summary>
        /// This operation starts a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual Task<StartJobResponse> StartJobAsync(StartJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// This operation tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// This operation removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAsset


        /// <summary>
        /// This operation updates an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual UpdateAssetResponse UpdateAsset(UpdateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetResponse>(request, options);
        }


        /// <summary>
        /// This operation updates an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual Task<UpdateAssetResponse> UpdateAssetAsync(UpdateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSet


        /// <summary>
        /// This operation updates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetResponse>(request, options);
        }


        /// <summary>
        /// This operation updates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventAction


        /// <summary>
        /// This operation updates the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction service method.</param>
        /// 
        /// <returns>The response from the UpdateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        public virtual UpdateEventActionResponse UpdateEventAction(UpdateEventActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventActionResponseUnmarshaller.Instance;

            return Invoke<UpdateEventActionResponse>(request, options);
        }


        /// <summary>
        /// This operation updates the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        public virtual Task<UpdateEventActionResponse> UpdateEventActionAsync(UpdateEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRevision


        /// <summary>
        /// This operation updates a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision service method.</param>
        /// 
        /// <returns>The response from the UpdateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        public virtual UpdateRevisionResponse UpdateRevision(UpdateRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevisionResponseUnmarshaller.Instance;

            return Invoke<UpdateRevisionResponse>(request, options);
        }


        /// <summary>
        /// This operation updates a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        public virtual Task<UpdateRevisionResponse> UpdateRevisionAsync(UpdateRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}