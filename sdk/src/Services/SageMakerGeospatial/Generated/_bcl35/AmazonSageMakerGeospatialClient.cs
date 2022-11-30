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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerGeospatial.Model;
using Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations;
using Amazon.SageMakerGeospatial.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMakerGeospatial
{
    /// <summary>
    /// Implementation for accessing SageMakerGeospatial
    ///
    /// Provides APIs for creating and managing SageMaker geospatial resources.
    /// </summary>
    public partial class AmazonSageMakerGeospatialClient : AmazonServiceClient, IAmazonSageMakerGeospatial
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerGeospatialMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISageMakerGeospatialPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISageMakerGeospatialPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SageMakerGeospatialPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        public AmazonSageMakerGeospatialClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerGeospatialConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        public AmazonSageMakerGeospatialClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerGeospatialConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(AmazonSageMakerGeospatialConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerGeospatialConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials and an
        /// AmazonSageMakerGeospatialClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials, AmazonSageMakerGeospatialConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerGeospatialConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerGeospatialClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerGeospatialConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerGeospatialConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerGeospatialClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerGeospatialConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerGeospatialEndpointResolver());
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


        #region  DeleteEarthObservationJob

        /// <summary>
        /// Use this operation to delete an Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        public virtual DeleteEarthObservationJobResponse DeleteEarthObservationJob(DeleteEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteEarthObservationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteEarthObservationJob(DeleteEarthObservationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEarthObservationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  DeleteEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        public virtual DeleteEarthObservationJobResponse EndDeleteEarthObservationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEarthObservationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVectorEnrichmentJob

        /// <summary>
        /// Use this operation to delete a Vector Enrichment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the DeleteVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        public virtual DeleteVectorEnrichmentJobResponse DeleteVectorEnrichmentJob(DeleteVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<DeleteVectorEnrichmentJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteVectorEnrichmentJob(DeleteVectorEnrichmentJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorEnrichmentJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  DeleteVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        public virtual DeleteVectorEnrichmentJobResponse EndDeleteVectorEnrichmentJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVectorEnrichmentJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportEarthObservationJob

        /// <summary>
        /// Use this operation to export results of an Earth Observation job and optionally source
        /// images used as input to the EOJ to an S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the ExportEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        public virtual ExportEarthObservationJobResponse ExportEarthObservationJob(ExportEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<ExportEarthObservationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        public virtual IAsyncResult BeginExportEarthObservationJob(ExportEarthObservationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEarthObservationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  ExportEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        public virtual ExportEarthObservationJobResponse EndExportEarthObservationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportEarthObservationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportVectorEnrichmentJob

        /// <summary>
        /// Use this operation to copy results of a Vector Enrichment job to an S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the ExportVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        public virtual ExportVectorEnrichmentJobResponse ExportVectorEnrichmentJob(ExportVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<ExportVectorEnrichmentJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        public virtual IAsyncResult BeginExportVectorEnrichmentJob(ExportVectorEnrichmentJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportVectorEnrichmentJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  ExportVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        public virtual ExportVectorEnrichmentJobResponse EndExportVectorEnrichmentJob(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportVectorEnrichmentJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEarthObservationJob

        /// <summary>
        /// Get the details for a previously initiated Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the GetEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        public virtual GetEarthObservationJobResponse GetEarthObservationJob(GetEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<GetEarthObservationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        public virtual IAsyncResult BeginGetEarthObservationJob(GetEarthObservationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEarthObservationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  GetEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        public virtual GetEarthObservationJobResponse EndGetEarthObservationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEarthObservationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRasterDataCollection

        /// <summary>
        /// Use this operation to get details of a specific raster data collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection service method.</param>
        /// 
        /// <returns>The response from the GetRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        public virtual GetRasterDataCollectionResponse GetRasterDataCollection(GetRasterDataCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRasterDataCollectionResponseUnmarshaller.Instance;

            return Invoke<GetRasterDataCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRasterDataCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        public virtual IAsyncResult BeginGetRasterDataCollection(GetRasterDataCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRasterDataCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRasterDataCollection.</param>
        /// 
        /// <returns>Returns a  GetRasterDataCollectionResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        public virtual GetRasterDataCollectionResponse EndGetRasterDataCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRasterDataCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTile

        /// <summary>
        /// Gets a web mercator tile for the given Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// 
        /// <returns>The response from the GetTile service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual GetTileResponse GetTile(GetTileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return Invoke<GetTileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTile operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual IAsyncResult BeginGetTile(GetTileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTile.</param>
        /// 
        /// <returns>Returns a  GetTileResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual GetTileResponse EndGetTile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVectorEnrichmentJob

        /// <summary>
        /// Retrieves details of a Vector Enrichment Job for a given job Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the GetVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        public virtual GetVectorEnrichmentJobResponse GetVectorEnrichmentJob(GetVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<GetVectorEnrichmentJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        public virtual IAsyncResult BeginGetVectorEnrichmentJob(GetVectorEnrichmentJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorEnrichmentJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  GetVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        public virtual GetVectorEnrichmentJobResponse EndGetVectorEnrichmentJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVectorEnrichmentJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEarthObservationJobs

        /// <summary>
        /// Use this operation to get a list of the Earth Observation jobs associated with the
        /// calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs service method.</param>
        /// 
        /// <returns>The response from the ListEarthObservationJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        public virtual ListEarthObservationJobsResponse ListEarthObservationJobs(ListEarthObservationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEarthObservationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEarthObservationJobsResponseUnmarshaller.Instance;

            return Invoke<ListEarthObservationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEarthObservationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEarthObservationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        public virtual IAsyncResult BeginListEarthObservationJobs(ListEarthObservationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEarthObservationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEarthObservationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEarthObservationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEarthObservationJobs.</param>
        /// 
        /// <returns>Returns a  ListEarthObservationJobsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        public virtual ListEarthObservationJobsResponse EndListEarthObservationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEarthObservationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRasterDataCollections

        /// <summary>
        /// Use this operation to get raster data collections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections service method.</param>
        /// 
        /// <returns>The response from the ListRasterDataCollections service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        public virtual ListRasterDataCollectionsResponse ListRasterDataCollections(ListRasterDataCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRasterDataCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRasterDataCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListRasterDataCollectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRasterDataCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRasterDataCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        public virtual IAsyncResult BeginListRasterDataCollections(ListRasterDataCollectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRasterDataCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRasterDataCollectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRasterDataCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRasterDataCollections.</param>
        /// 
        /// <returns>Returns a  ListRasterDataCollectionsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        public virtual ListRasterDataCollectionsResponse EndListRasterDataCollections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRasterDataCollectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVectorEnrichmentJobs

        /// <summary>
        /// Retrieves a list of vector enrichment jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs service method.</param>
        /// 
        /// <returns>The response from the ListVectorEnrichmentJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        public virtual ListVectorEnrichmentJobsResponse ListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVectorEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorEnrichmentJobsResponseUnmarshaller.Instance;

            return Invoke<ListVectorEnrichmentJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVectorEnrichmentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVectorEnrichmentJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        public virtual IAsyncResult BeginListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVectorEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorEnrichmentJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVectorEnrichmentJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVectorEnrichmentJobs.</param>
        /// 
        /// <returns>Returns a  ListVectorEnrichmentJobsResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        public virtual ListVectorEnrichmentJobsResponse EndListVectorEnrichmentJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVectorEnrichmentJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchRasterDataCollection

        /// <summary>
        /// Allows you run image query on a specific raster data collection to get a list of the
        /// satellite imagery matching the selected filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection service method.</param>
        /// 
        /// <returns>The response from the SearchRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        public virtual SearchRasterDataCollectionResponse SearchRasterDataCollection(SearchRasterDataCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRasterDataCollectionResponseUnmarshaller.Instance;

            return Invoke<SearchRasterDataCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRasterDataCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        public virtual IAsyncResult BeginSearchRasterDataCollection(SearchRasterDataCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRasterDataCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRasterDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRasterDataCollection.</param>
        /// 
        /// <returns>Returns a  SearchRasterDataCollectionResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        public virtual SearchRasterDataCollectionResponse EndSearchRasterDataCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchRasterDataCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartEarthObservationJob

        /// <summary>
        /// Use this operation to create an Earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the StartEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        public virtual StartEarthObservationJobResponse StartEarthObservationJob(StartEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<StartEarthObservationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        public virtual IAsyncResult BeginStartEarthObservationJob(StartEarthObservationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEarthObservationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  StartEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        public virtual StartEarthObservationJobResponse EndStartEarthObservationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEarthObservationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartVectorEnrichmentJob

        /// <summary>
        /// Creates a Vector Enrichment job for the supplied job type. Currently, there are two
        /// supported job types: reverse geocoding and map matching.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the StartVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        public virtual StartVectorEnrichmentJobResponse StartVectorEnrichmentJob(StartVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<StartVectorEnrichmentJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        public virtual IAsyncResult BeginStartVectorEnrichmentJob(StartVectorEnrichmentJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVectorEnrichmentJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  StartVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        public virtual StartVectorEnrichmentJobResponse EndStartVectorEnrichmentJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartVectorEnrichmentJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopEarthObservationJob

        /// <summary>
        /// Use this operation to stop an existing earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob service method.</param>
        /// 
        /// <returns>The response from the StopEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        public virtual StopEarthObservationJobResponse StopEarthObservationJob(StopEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<StopEarthObservationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEarthObservationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        public virtual IAsyncResult BeginStopEarthObservationJob(StopEarthObservationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEarthObservationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEarthObservationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEarthObservationJob.</param>
        /// 
        /// <returns>Returns a  StopEarthObservationJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        public virtual StopEarthObservationJobResponse EndStopEarthObservationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEarthObservationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopVectorEnrichmentJob

        /// <summary>
        /// Stops the Vector Enrichment job for a given job ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob service method.</param>
        /// 
        /// <returns>The response from the StopVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        public virtual StopVectorEnrichmentJobResponse StopVectorEnrichmentJob(StopVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<StopVectorEnrichmentJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopVectorEnrichmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        public virtual IAsyncResult BeginStopVectorEnrichmentJob(StopVectorEnrichmentJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVectorEnrichmentJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopVectorEnrichmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopVectorEnrichmentJob.</param>
        /// 
        /// <returns>Returns a  StopVectorEnrichmentJobResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        public virtual StopVectorEnrichmentJobResponse EndStopVectorEnrichmentJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopVectorEnrichmentJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// The resource you want to tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// The resource you want to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSageMakerGeospatialClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SageMakerGeospatial.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}