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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.HealthLake.Model;
using Amazon.HealthLake.Model.Internal.MarshallTransformations;
using Amazon.HealthLake.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.HealthLake
{
    /// <summary>
    /// <para>Implementation for accessing HealthLake</para>
    ///
    /// This is the <i>AWS HealthLake API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/healthlake/latest/devguide/what-is.html">What
    /// is AWS HealthLake?</a> in the <i>AWS HealthLake Developer Guide</i>.
    /// </summary>
    public partial class AmazonHealthLakeClient : AmazonServiceClient, IAmazonHealthLake
    {
        private static IServiceMetadata serviceMetadata = new AmazonHealthLakeMetadata();
        private IHealthLakePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IHealthLakePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new HealthLakePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonHealthLakeClient with the credentials loaded from the application's
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
        public AmazonHealthLakeClient()
            : base(new AmazonHealthLakeConfig()) { }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with the credentials loaded from the application's
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
        public AmazonHealthLakeClient(RegionEndpoint region)
            : base(new AmazonHealthLakeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonHealthLakeClient Configuration Object</param>
        public AmazonHealthLakeClient(AmazonHealthLakeConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonHealthLakeClient(AWSCredentials credentials)
            : this(credentials, new AmazonHealthLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHealthLakeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonHealthLakeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Credentials and an
        /// AmazonHealthLakeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonHealthLakeClient Configuration Object</param>
        public AmazonHealthLakeClient(AWSCredentials credentials, AmazonHealthLakeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonHealthLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonHealthLakeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonHealthLakeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonHealthLakeClient Configuration Object</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonHealthLakeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonHealthLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonHealthLakeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonHealthLakeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonHealthLakeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonHealthLakeClient Configuration Object</param>
        public AmazonHealthLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonHealthLakeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonHealthLakeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonHealthLakeAuthSchemeHandler());
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


        #region  CreateFHIRDatastore


        /// <summary>
        /// Create a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateFHIRDatastore">REST API Reference for CreateFHIRDatastore Operation</seealso>
        public virtual CreateFHIRDatastoreResponse CreateFHIRDatastore(CreateFHIRDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Create a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateFHIRDatastore">REST API Reference for CreateFHIRDatastore Operation</seealso>
        public virtual Task<CreateFHIRDatastoreResponse> CreateFHIRDatastoreAsync(CreateFHIRDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFHIRDatastore


        /// <summary>
        /// Delete a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the DeleteFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteFHIRDatastore">REST API Reference for DeleteFHIRDatastore Operation</seealso>
        public virtual DeleteFHIRDatastoreResponse DeleteFHIRDatastore(DeleteFHIRDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Delete a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteFHIRDatastore">REST API Reference for DeleteFHIRDatastore Operation</seealso>
        public virtual Task<DeleteFHIRDatastoreResponse> DeleteFHIRDatastoreAsync(DeleteFHIRDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRDatastore


        /// <summary>
        /// Get properties for a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRDatastore">REST API Reference for DescribeFHIRDatastore Operation</seealso>
        public virtual DescribeFHIRDatastoreResponse DescribeFHIRDatastore(DescribeFHIRDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Get properties for a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRDatastore">REST API Reference for DescribeFHIRDatastore Operation</seealso>
        public virtual Task<DescribeFHIRDatastoreResponse> DescribeFHIRDatastoreAsync(DescribeFHIRDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRExportJob


        /// <summary>
        /// Get FHIR export job properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRExportJob">REST API Reference for DescribeFHIRExportJob Operation</seealso>
        public virtual DescribeFHIRExportJobResponse DescribeFHIRExportJob(DescribeFHIRExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRExportJobResponse>(request, options);
        }


        /// <summary>
        /// Get FHIR export job properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRExportJob">REST API Reference for DescribeFHIRExportJob Operation</seealso>
        public virtual Task<DescribeFHIRExportJobResponse> DescribeFHIRExportJobAsync(DescribeFHIRExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRImportJob


        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRImportJob">REST API Reference for DescribeFHIRImportJob Operation</seealso>
        public virtual DescribeFHIRImportJobResponse DescribeFHIRImportJob(DescribeFHIRImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRImportJobResponse>(request, options);
        }


        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRImportJob">REST API Reference for DescribeFHIRImportJob Operation</seealso>
        public virtual Task<DescribeFHIRImportJobResponse> DescribeFHIRImportJobAsync(DescribeFHIRImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFHIRDatastores


        /// <summary>
        /// List all FHIR-enabled data stores in a user’s account, regardless of data store status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// 
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRDatastores">REST API Reference for ListFHIRDatastores Operation</seealso>
        public virtual ListFHIRDatastoresResponse ListFHIRDatastores(ListFHIRDatastoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListFHIRDatastoresResponse>(request, options);
        }


        /// <summary>
        /// List all FHIR-enabled data stores in a user’s account, regardless of data store status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRDatastores">REST API Reference for ListFHIRDatastores Operation</seealso>
        public virtual Task<ListFHIRDatastoresResponse> ListFHIRDatastoresAsync(ListFHIRDatastoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRDatastoresResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFHIRDatastoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFHIRExportJobs


        /// <summary>
        /// Lists all FHIR export jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListFHIRExportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRExportJobs">REST API Reference for ListFHIRExportJobs Operation</seealso>
        public virtual ListFHIRExportJobsResponse ListFHIRExportJobs(ListFHIRExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListFHIRExportJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists all FHIR export jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFHIRExportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRExportJobs">REST API Reference for ListFHIRExportJobs Operation</seealso>
        public virtual Task<ListFHIRExportJobsResponse> ListFHIRExportJobsAsync(ListFHIRExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRExportJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFHIRExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFHIRImportJobs


        /// <summary>
        /// List all FHIR import jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListFHIRImportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRImportJobs">REST API Reference for ListFHIRImportJobs Operation</seealso>
        public virtual ListFHIRImportJobsResponse ListFHIRImportJobs(ListFHIRImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListFHIRImportJobsResponse>(request, options);
        }


        /// <summary>
        /// List all FHIR import jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFHIRImportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRImportJobs">REST API Reference for ListFHIRImportJobs Operation</seealso>
        public virtual Task<ListFHIRImportJobsResponse> ListFHIRImportJobsAsync(ListFHIRImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFHIRImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRImportJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFHIRImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all existing tags associated with a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all existing tags associated with a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFHIRExportJob


        /// <summary>
        /// Start a FHIR export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRExportJob service method.</param>
        /// 
        /// <returns>The response from the StartFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRExportJob">REST API Reference for StartFHIRExportJob Operation</seealso>
        public virtual StartFHIRExportJobResponse StartFHIRExportJob(StartFHIRExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRExportJobResponseUnmarshaller.Instance;

            return Invoke<StartFHIRExportJobResponse>(request, options);
        }


        /// <summary>
        /// Start a FHIR export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRExportJob">REST API Reference for StartFHIRExportJob Operation</seealso>
        public virtual Task<StartFHIRExportJobResponse> StartFHIRExportJobAsync(StartFHIRExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFHIRExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFHIRImportJob


        /// <summary>
        /// Start importing bulk FHIR data into an ACTIVE data store. The import job imports FHIR
        /// data found in the <c>InputDataConfig</c> object and stores processing results in the
        /// <c>JobOutputDataConfig</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRImportJob service method.</param>
        /// 
        /// <returns>The response from the StartFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRImportJob">REST API Reference for StartFHIRImportJob Operation</seealso>
        public virtual StartFHIRImportJobResponse StartFHIRImportJob(StartFHIRImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRImportJobResponseUnmarshaller.Instance;

            return Invoke<StartFHIRImportJobResponse>(request, options);
        }


        /// <summary>
        /// Start importing bulk FHIR data into an ACTIVE data store. The import job imports FHIR
        /// data found in the <c>InputDataConfig</c> object and stores processing results in the
        /// <c>JobOutputDataConfig</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRImportJob">REST API Reference for StartFHIRImportJob Operation</seealso>
        public virtual Task<StartFHIRImportJobResponse> StartFHIRImportJobAsync(StartFHIRImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFHIRImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a user-specifed key and value tag to a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Add a user-specifed key and value tag to a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove a user-specifed key and value tag from a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove a user-specifed key and value tag from a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}