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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GlueDataBrew.Model;
using Amazon.GlueDataBrew.Model.Internal.MarshallTransformations;
using Amazon.GlueDataBrew.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GlueDataBrew
{
    /// <summary>
    /// Implementation for accessing GlueDataBrew
    ///
    /// AWS Glue DataBrew is a visual, cloud-scale data-preparation service. DataBrew simplifies
    /// data preparation tasks, targeting data issues that are hard to spot and time-consuming
    /// to fix. DataBrew empowers users of all technical levels to visualize the data and
    /// perform one-click data transformations, with no coding required.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonGlueDataBrewClient : AmazonServiceClient, IAmazonGlueDataBrew
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlueDataBrewMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with the credentials loaded from the application's
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
        public AmazonGlueDataBrewClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueDataBrewConfig()) { }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with the credentials loaded from the application's
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
        public AmazonGlueDataBrewClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueDataBrewConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlueDataBrewClient Configuration Object</param>
        public AmazonGlueDataBrewClient(AmazonGlueDataBrewConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlueDataBrewClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlueDataBrewConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueDataBrewClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlueDataBrewConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Credentials and an
        /// AmazonGlueDataBrewClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlueDataBrewClient Configuration Object</param>
        public AmazonGlueDataBrewClient(AWSCredentials credentials, AmazonGlueDataBrewConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueDataBrewConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueDataBrewConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueDataBrewClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlueDataBrewClient Configuration Object</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlueDataBrewConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueDataBrewConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueDataBrewConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueDataBrewClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueDataBrewClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlueDataBrewClient Configuration Object</param>
        public AmazonGlueDataBrewClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlueDataBrewConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IGlueDataBrewPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGlueDataBrewPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GlueDataBrewPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  BatchDeleteRecipeVersion

        internal virtual BatchDeleteRecipeVersionResponse BatchDeleteRecipeVersion(BatchDeleteRecipeVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteRecipeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteRecipeVersionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteRecipeVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more versions of a recipe at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRecipeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteRecipeVersion service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/BatchDeleteRecipeVersion">REST API Reference for BatchDeleteRecipeVersion Operation</seealso>
        public virtual Task<BatchDeleteRecipeVersionResponse> BatchDeleteRecipeVersionAsync(BatchDeleteRecipeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteRecipeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteRecipeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteRecipeVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AWS Glue DataBrew dataset for this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProfileJob

        internal virtual CreateProfileJobResponse CreateProfileJob(CreateProfileJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileJobResponseUnmarshaller.Instance;

            return Invoke<CreateProfileJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a new job to profile an AWS Glue DataBrew dataset that exists in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProfileJob">REST API Reference for CreateProfileJob Operation</seealso>
        public virtual Task<CreateProfileJobResponse> CreateProfileJobAsync(CreateProfileJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AWS Glue DataBrew project in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRecipe

        internal virtual CreateRecipeResponse CreateRecipe(CreateRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecipeResponseUnmarshaller.Instance;

            return Invoke<CreateRecipeResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AWS Glue DataBrew recipe for the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipe">REST API Reference for CreateRecipe Operation</seealso>
        public virtual Task<CreateRecipeResponse> CreateRecipeAsync(CreateRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRecipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRecipeJob

        internal virtual CreateRecipeJobResponse CreateRecipeJob(CreateRecipeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecipeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecipeJobResponseUnmarshaller.Instance;

            return Invoke<CreateRecipeJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a new job for an existing AWS Glue DataBrew recipe in the current AWS account.
        /// You can create a standalone job using either a project, or a combination of a recipe
        /// and a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipeJob">REST API Reference for CreateRecipeJob Operation</seealso>
        public virtual Task<CreateRecipeJobResponse> CreateRecipeJobAsync(CreateRecipeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecipeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecipeJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRecipeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSchedule

        internal virtual CreateScheduleResponse CreateSchedule(CreateScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a new schedule for one or more AWS Glue DataBrew jobs. Jobs can be run at
        /// a specific date and time, or at regular intervals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        public virtual Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset from AWS Glue DataBrew.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified AWS Glue DataBrew job from the current AWS account. The job
        /// can be for a recipe or for a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing AWS Glue DataBrew project from the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRecipeVersion

        internal virtual DeleteRecipeVersionResponse DeleteRecipeVersion(DeleteRecipeVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecipeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecipeVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteRecipeVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a single version of an AWS Glue DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecipeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecipeVersion service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRecipeVersion">REST API Reference for DeleteRecipeVersion Operation</seealso>
        public virtual Task<DeleteRecipeVersionResponse> DeleteRecipeVersionAsync(DeleteRecipeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecipeVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecipeVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecipeVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchedule

        internal virtual DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified AWS Glue DataBrew schedule from the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        public virtual Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew dataset that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }



        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew job that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }



        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew project that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecipe

        internal virtual DescribeRecipeResponse DescribeRecipe(DescribeRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return Invoke<DescribeRecipeResponse>(request, options);
        }



        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew recipe that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        public virtual Task<DescribeRecipeResponse> DescribeRecipeAsync(DescribeRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSchedule

        internal virtual DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduleResponse>(request, options);
        }



        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew schedule that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual Task<DescribeScheduleResponse> DescribeScheduleAsync(DescribeScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the AWS Glue DataBrew datasets for the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobRuns

        internal virtual ListJobRunsResponse ListJobRuns(ListJobRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return Invoke<ListJobRunsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the previous runs of a particular AWS Glue DataBrew job in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS Glue DataBrew jobs in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the DataBrew projects in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecipes

        internal virtual ListRecipesResponse ListRecipes(ListRecipesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return Invoke<ListRecipesResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the AWS Glue DataBrew recipes in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        public virtual Task<ListRecipesResponse> ListRecipesAsync(ListRecipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecipesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecipeVersions

        internal virtual ListRecipeVersionsResponse ListRecipeVersions(ListRecipeVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListRecipeVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the versions of a particular AWS Glue DataBrew recipe in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecipeVersions service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipeVersions">REST API Reference for ListRecipeVersions Operation</seealso>
        public virtual Task<ListRecipeVersionsResponse> ListRecipeVersionsAsync(ListRecipeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecipeVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchedules

        internal virtual ListSchedulesResponse ListSchedules(ListSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS Glue DataBrew schedules in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        public virtual Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchedulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all the tags for an AWS Glue DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishRecipe

        internal virtual PublishRecipeResponse PublishRecipe(PublishRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishRecipeResponseUnmarshaller.Instance;

            return Invoke<PublishRecipeResponse>(request, options);
        }



        /// <summary>
        /// Publishes a new major version of an AWS Glue DataBrew recipe that exists in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/PublishRecipe">REST API Reference for PublishRecipe Operation</seealso>
        public virtual Task<PublishRecipeResponse> PublishRecipeAsync(PublishRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<PublishRecipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendProjectSessionAction

        internal virtual SendProjectSessionActionResponse SendProjectSessionAction(SendProjectSessionActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendProjectSessionActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendProjectSessionActionResponseUnmarshaller.Instance;

            return Invoke<SendProjectSessionActionResponse>(request, options);
        }



        /// <summary>
        /// Performs a recipe step within an interactive AWS Glue DataBrew session that's currently
        /// open.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendProjectSessionAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendProjectSessionAction service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/SendProjectSessionAction">REST API Reference for SendProjectSessionAction Operation</seealso>
        public virtual Task<SendProjectSessionActionResponse> SendProjectSessionActionAsync(SendProjectSessionActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendProjectSessionActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendProjectSessionActionResponseUnmarshaller.Instance;

            return InvokeAsync<SendProjectSessionActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun

        internal virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunResponse>(request, options);
        }



        /// <summary>
        /// Runs an AWS Glue DataBrew job that exists in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartProjectSession

        internal virtual StartProjectSessionResponse StartProjectSession(StartProjectSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProjectSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectSessionResponseUnmarshaller.Instance;

            return Invoke<StartProjectSessionResponse>(request, options);
        }



        /// <summary>
        /// Creates an interactive session, enabling you to manipulate an AWS Glue DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProjectSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProjectSession service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartProjectSession">REST API Reference for StartProjectSession Operation</seealso>
        public virtual Task<StartProjectSessionResponse> StartProjectSessionAsync(StartProjectSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProjectSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartProjectSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopJobRun

        internal virtual StopJobRunResponse StopJobRun(StopJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobRunResponseUnmarshaller.Instance;

            return Invoke<StopJobRunResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified job from running in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StopJobRun">REST API Reference for StopJobRun Operation</seealso>
        public virtual Task<StopJobRunResponse> StopJobRunAsync(StopJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds metadata tags to an AWS Glue DataBrew resource, such as a dataset, job, project,
        /// or recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes metadata tags from an AWS Glue DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataset

        internal virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew dataset in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProfileJob

        internal virtual UpdateProfileJobResponse UpdateProfileJob(UpdateProfileJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileJobResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileJobResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew job in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProfileJob">REST API Reference for UpdateProfileJob Operation</seealso>
        public virtual Task<UpdateProfileJobResponse> UpdateProfileJobAsync(UpdateProfileJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew project in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRecipe

        internal virtual UpdateRecipeResponse UpdateRecipe(UpdateRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecipeResponseUnmarshaller.Instance;

            return Invoke<UpdateRecipeResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of the latest working version of an AWS Glue DataBrew recipe
        /// in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipe">REST API Reference for UpdateRecipe Operation</seealso>
        public virtual Task<UpdateRecipeResponse> UpdateRecipeAsync(UpdateRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRecipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRecipeJob

        internal virtual UpdateRecipeJobResponse UpdateRecipeJob(UpdateRecipeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecipeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecipeJobResponseUnmarshaller.Instance;

            return Invoke<UpdateRecipeJobResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew recipe job in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipeJob">REST API Reference for UpdateRecipeJob Operation</seealso>
        public virtual Task<UpdateRecipeJobResponse> UpdateRecipeJobAsync(UpdateRecipeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecipeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecipeJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRecipeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSchedule

        internal virtual UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduleResponse>(request, options);
        }



        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew schedule in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        public virtual Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}