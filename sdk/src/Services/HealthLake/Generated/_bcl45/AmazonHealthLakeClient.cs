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

namespace Amazon.HealthLake
{
    /// <summary>
    /// Implementation for accessing HealthLake
    ///
    /// Amazon HealthLake is a HIPAA eligibile service that allows customers to store, transform,
    /// query, and analyze their FHIR-formatted data in a consistent fashion in the cloud.
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonHealthLakeConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonHealthLakeConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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


        #region  CreateFHIRDatastore


        /// <summary>
        /// Creates a Data Store that can ingest and export FHIR formatted data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Creates a Data Store that can ingest and export FHIR formatted data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFHIRDatastore


        /// <summary>
        /// Deletes a Data Store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the DeleteFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The Data Store is in a transition state and the user requested action can not be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Data Store.
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
        /// The Data Store is in a transition state and the user requested action can not be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRDatastore


        /// <summary>
        /// Gets the properties associated with the FHIR Data Store, including the Data Store
        /// ID, Data Store ARN, Data Store name, Data Store status, created at, Data Store type
        /// version, and Data Store endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Gets the properties associated with the FHIR Data Store, including the Data Store
        /// ID, Data Store ARN, Data Store name, Data Store status, created at, Data Store type
        /// version, and Data Store endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRDatastoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRExportJob


        /// <summary>
        /// Displays the properties of a FHIR export job, including the ID, ARN, name, and the
        /// status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRExportJobResponse>(request, options);
        }


        /// <summary>
        /// Displays the properties of a FHIR export job, including the ID, ARN, name, and the
        /// status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFHIRImportJob


        /// <summary>
        /// Displays the properties of a FHIR import job, including the ID, ARN, name, and the
        /// status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeFHIRImportJobResponse>(request, options);
        }


        /// <summary>
        /// Displays the properties of a FHIR import job, including the ID, ARN, name, and the
        /// status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFHIRImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFHIRImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFHIRDatastores


        /// <summary>
        /// Lists all FHIR Data Stores that are in the user’s account, regardless of Data Store
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// 
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFHIRDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListFHIRDatastoresResponse>(request, options);
        }


        /// <summary>
        /// Lists all FHIR Data Stores that are in the user’s account, regardless of Data Store
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFHIRDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFHIRDatastoresResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFHIRDatastoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFHIRExportJob


        /// <summary>
        /// Begins a FHIR export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRExportJob service method.</param>
        /// 
        /// <returns>The response from the StartFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRExportJobResponseUnmarshaller.Instance;

            return Invoke<StartFHIRExportJobResponse>(request, options);
        }


        /// <summary>
        /// Begins a FHIR export job.
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
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFHIRExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFHIRExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFHIRImportJob


        /// <summary>
        /// Begins a FHIR Import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRImportJob service method.</param>
        /// 
        /// <returns>The response from the StartFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRImportJobResponseUnmarshaller.Instance;

            return Invoke<StartFHIRImportJobResponse>(request, options);
        }


        /// <summary>
        /// Begins a FHIR Import job.
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
        /// Unknown error occurs in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested Data Store was not found.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFHIRImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFHIRImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFHIRImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}