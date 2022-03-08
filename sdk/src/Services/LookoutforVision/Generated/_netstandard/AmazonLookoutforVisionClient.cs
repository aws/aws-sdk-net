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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LookoutforVision.Model;
using Amazon.LookoutforVision.Model.Internal.MarshallTransformations;
using Amazon.LookoutforVision.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LookoutforVision
{
    /// <summary>
    /// Implementation for accessing LookoutforVision
    ///
    /// This is the Amazon Lookout for Vision API Reference. It provides descriptions of actions,
    /// data types, common parameters, and common errors.
    /// 
    ///  
    /// <para>
    /// Amazon Lookout for Vision enables you to find visual defects in industrial products,
    /// accurately and at scale. It uses computer vision to identify missing components in
    /// an industrial product, damage to vehicles or structures, irregularities in production
    /// lines, and even minuscule defects in silicon wafers — or any other physical item where
    /// quality is important such as a missing capacitor on printed circuit boards.
    /// </para>
    /// </summary>
    public partial class AmazonLookoutforVisionClient : AmazonServiceClient, IAmazonLookoutforVision
    {
        private static IServiceMetadata serviceMetadata = new AmazonLookoutforVisionMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with the credentials loaded from the application's
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
        public AmazonLookoutforVisionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutforVisionConfig()) { }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with the credentials loaded from the application's
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
        public AmazonLookoutforVisionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutforVisionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLookoutforVisionClient Configuration Object</param>
        public AmazonLookoutforVisionClient(AmazonLookoutforVisionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLookoutforVisionClient(AWSCredentials credentials)
            : this(credentials, new AmazonLookoutforVisionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutforVisionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLookoutforVisionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Credentials and an
        /// AmazonLookoutforVisionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLookoutforVisionClient Configuration Object</param>
        public AmazonLookoutforVisionClient(AWSCredentials credentials, AmazonLookoutforVisionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutforVisionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutforVisionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutforVisionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLookoutforVisionClient Configuration Object</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLookoutforVisionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutforVisionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutforVisionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutforVisionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutforVisionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLookoutforVisionClient Configuration Object</param>
        public AmazonLookoutforVisionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLookoutforVisionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILookoutforVisionPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILookoutforVisionPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LookoutforVisionPaginatorFactory(this);
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


        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new dataset in an Amazon Lookout for Vision project. <code>CreateDataset</code>
        /// can create a training or a test dataset from a valid dataset source (<code>DatasetSource</code>).
        /// 
        ///  
        /// <para>
        /// If you want a single dataset project, specify <code>train</code> for the value of
        /// <code>DatasetType</code>.
        /// </para>
        ///  
        /// <para>
        /// To have a project with separate training and test datasets, call <code>CreateDataset</code>
        /// twice. On the first call, specify <code>train</code> for the value of <code>DatasetType</code>.
        /// On the second call, specify <code>test</code> for the value of <code>DatasetType</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:CreateDataset</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of a model within an an Amazon Lookout for Vision project. <code>CreateModel</code>
        /// is an asynchronous operation in which Amazon Lookout for Vision trains, tests, and
        /// evaluates a new version of a model. 
        /// 
        ///  
        /// <para>
        /// To get the current status, check the <code>Status</code> field returned in the response
        /// from <a>DescribeModel</a>.
        /// </para>
        ///  
        /// <para>
        /// If the project has a single dataset, Amazon Lookout for Vision internally splits the
        /// dataset to create a training and a test dataset. If the project has a training and
        /// a test dataset, Lookout for Vision uses the respective datasets to train and test
        /// the model. 
        /// </para>
        ///  
        /// <para>
        /// After training completes, the evaluation metrics are stored at the location specified
        /// in <code>OutputConfig</code>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:CreateModel</code>
        /// operation. If you want to tag your model, you also require permission to the <code>lookoutvision:TagResource</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
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
        /// Creates an empty Amazon Lookout for Vision project. After you create the project,
        /// add a dataset by calling <a>CreateDataset</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:CreateProject</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
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
        /// Deletes an existing Amazon Lookout for Vision <code>dataset</code>. 
        /// 
        ///  
        /// <para>
        /// If your the project has a single dataset, you must create a new dataset before you
        /// can create a model.
        /// </para>
        ///  
        /// <para>
        /// If you project has a training dataset and a test dataset consider the following. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you delete the test dataset, your project reverts to a single dataset project.
        /// If you then train the model, Amazon Lookout for Vision internally splits the remaining
        /// dataset into a training and test dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete the training dataset, you must create a training dataset before you
        /// can create a model.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DeleteDataset</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Lookout for Vision model. You can't delete a running model. To stop
        /// a running model, use the <a>StopModel</a> operation.
        /// 
        ///  
        /// <para>
        /// It might take a few seconds to delete a model. To determine if a model has been deleted,
        /// call <a>ListModels</a> and check if the version of the model (<code>ModelVersion</code>)
        /// is in the <code>Models</code> array. 
        /// </para>
        ///   
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DeleteModel</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
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
        /// Deletes an Amazon Lookout for Vision project.
        /// 
        ///  
        /// <para>
        /// To delete a project, you must first delete each version of the model associated with
        /// the project. To delete a model use the <a>DeleteModel</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You also have to delete the dataset(s) associated with the model. For more information,
        /// see <a>DeleteDataset</a>. The images referenced by the training and test datasets
        /// aren't deleted. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DeleteProject</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
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
        /// Describe an Amazon Lookout for Vision dataset.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DescribeDataset</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModel

        internal virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }



        /// <summary>
        /// Describes a version of an Amazon Lookout for Vision model.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DescribeModel</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelPackagingJob

        internal virtual DescribeModelPackagingJobResponse DescribeModelPackagingJob(DescribeModelPackagingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackagingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeModelPackagingJobResponse>(request, options);
        }



        /// <summary>
        /// Describes an Amazon Lookout for Vision model packaging job. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DescribeModelPackagingJob</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Using your Amazon Lookout for Vision model on an edge
        /// device</i> in the Amazon Lookout for Vision Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackagingJob service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeModelPackagingJob">REST API Reference for DescribeModelPackagingJob Operation</seealso>
        public virtual Task<DescribeModelPackagingJobResponse> DescribeModelPackagingJobAsync(DescribeModelPackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackagingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelPackagingJobResponse>(request, options, cancellationToken);
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
        /// Describes an Amazon Lookout for Vision project.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DescribeProject</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectAnomalies

        internal virtual DetectAnomaliesResponse DetectAnomalies(DetectAnomaliesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectAnomaliesResponseUnmarshaller.Instance;

            return Invoke<DetectAnomaliesResponse>(request, options);
        }



        /// <summary>
        /// Detects anomalies in an image that you supply. 
        /// 
        ///  
        /// <para>
        /// The response from <code>DetectAnomalies</code> includes a boolean prediction that
        /// the image contains one or more anomalies and a confidence value for the prediction.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before calling <code>DetectAnomalies</code>, you must first start your model with
        /// the <a>StartModel</a> operation. You are charged for the amount of time, in minutes,
        /// that a model runs and for the number of anomaly detection units that your model uses.
        /// If you are not using a model, use the <a>StopModel</a> operation to stop your model.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:DetectAnomalies</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectAnomalies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectAnomalies service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DetectAnomalies">REST API Reference for DetectAnomalies Operation</seealso>
        public virtual Task<DetectAnomaliesResponse> DetectAnomaliesAsync(DetectAnomaliesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectAnomaliesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectAnomaliesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasetEntries

        internal virtual ListDatasetEntriesResponse ListDatasetEntries(ListDatasetEntriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetEntriesResponseUnmarshaller.Instance;

            return Invoke<ListDatasetEntriesResponse>(request, options);
        }



        /// <summary>
        /// Lists the JSON Lines within a dataset. An Amazon Lookout for Vision JSON Line contains
        /// the anomaly information for a single image, including the image location and the assigned
        /// label.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:ListDatasetEntries</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetEntries service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListDatasetEntries">REST API Reference for ListDatasetEntries Operation</seealso>
        public virtual Task<ListDatasetEntriesResponse> ListDatasetEntriesAsync(ListDatasetEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetEntriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelPackagingJobs

        internal virtual ListModelPackagingJobsResponse ListModelPackagingJobs(ListModelPackagingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagingJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelPackagingJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists the model packaging jobs created for an Amazon Lookout for Vision project.
        /// 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:ListModelPackagingJobs</code>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Using your Amazon Lookout for Vision model on an edge
        /// device</i> in the Amazon Lookout for Vision Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackagingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelPackagingJobs service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListModelPackagingJobs">REST API Reference for ListModelPackagingJobs Operation</seealso>
        public virtual Task<ListModelPackagingJobsResponse> ListModelPackagingJobsAsync(ListModelPackagingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelPackagingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a model in an Amazon Lookout for Vision project.
        /// 
        ///  
        /// <para>
        /// The <code>ListModels</code> operation is eventually consistent. Recent calls to <code>CreateModel</code>
        /// might take a while to appear in the response from <code>ListProjects</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:ListModels</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsResponse>(request, options, cancellationToken);
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
        /// Lists the Amazon Lookout for Vision projects in your AWS account.
        /// 
        ///  
        /// <para>
        /// The <code>ListProjects</code> operation is eventually consistent. Recent calls to
        /// <code>CreateProject</code> and <code>DeleteProject</code> might take a while to appear
        /// in the response from <code>ListProjects</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:ListProjects</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
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
        /// Returns a list of tags attached to the specified Amazon Lookout for Vision model.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:ListTagsForResource</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartModel

        internal virtual StartModelResponse StartModel(StartModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartModelResponseUnmarshaller.Instance;

            return Invoke<StartModelResponse>(request, options);
        }



        /// <summary>
        /// Starts the running of the version of an Amazon Lookout for Vision model. Starting
        /// a model takes a while to complete. To check the current state of the model, use <a>DescribeModel</a>.
        /// 
        ///  
        /// <para>
        /// A model is ready to use when its status is <code>HOSTED</code>.
        /// </para>
        ///  
        /// <para>
        /// Once the model is running, you can detect custom labels in new images by calling <a>DetectAnomalies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged for the amount of time that the model is running. To stop a running
        /// model, call <a>StopModel</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:StartModel</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StartModel">REST API Reference for StartModel Operation</seealso>
        public virtual Task<StartModelResponse> StartModelAsync(StartModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartModelResponseUnmarshaller.Instance;

            return InvokeAsync<StartModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartModelPackagingJob

        internal virtual StartModelPackagingJobResponse StartModelPackagingJob(StartModelPackagingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartModelPackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartModelPackagingJobResponseUnmarshaller.Instance;

            return Invoke<StartModelPackagingJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an Amazon Lookout for Vision model packaging job. A model packaging job creates
        /// an AWS IoT Greengrass component for a Lookout for Vision model. You can use the component
        /// to deploy your model to an edge device managed by Greengrass. 
        /// 
        ///  
        /// <para>
        /// Use the <a>DescribeModelPackagingJob</a> API to determine the current status of the
        /// job. The model packaging job is complete if the value of <code>Status</code> is <code>SUCCEEDED</code>.
        /// </para>
        ///  
        /// <para>
        /// To deploy the component to the target device, use the component name and component
        /// version with the AWS IoT Greengrass <a href="https://docs.aws.amazon.com/greengrass/v2/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation requires the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>lookoutvision:StartModelPackagingJob</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:PutObject</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>s3:GetBucketLocation</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>greengrass:CreateComponentVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>greengrass:DescribeComponent</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <code>greengrass:TagResource</code>. Only required if you want to tag the
        /// component.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <i>Using your Amazon Lookout for Vision model on an edge
        /// device</i> in the Amazon Lookout for Vision Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartModelPackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartModelPackagingJob service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StartModelPackagingJob">REST API Reference for StartModelPackagingJob Operation</seealso>
        public virtual Task<StartModelPackagingJobResponse> StartModelPackagingJobAsync(StartModelPackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartModelPackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartModelPackagingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartModelPackagingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopModel

        internal virtual StopModelResponse StopModel(StopModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelResponseUnmarshaller.Instance;

            return Invoke<StopModelResponse>(request, options);
        }



        /// <summary>
        /// Stops the hosting of a running model. The operation might take a while to complete.
        /// To check the current status, call <a>DescribeModel</a>. 
        /// 
        ///  
        /// <para>
        /// After the model hosting stops, the <code>Status</code> of the model is <code>TRAINED</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:StopModel</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StopModel">REST API Reference for StopModel Operation</seealso>
        public virtual Task<StopModelResponse> StopModelAsync(StopModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelResponseUnmarshaller.Instance;

            return InvokeAsync<StopModelResponse>(request, options, cancellationToken);
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
        /// Adds one or more key-value tags to an Amazon Lookout for Vision model. For more information,
        /// see <i>Tagging a model</i> in the <i>Amazon Lookout for Vision Developer Guide</i>.
        /// 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:TagResource</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from an Amazon Lookout for Vision model. For more information,
        /// see <i>Tagging a model</i> in the <i>Amazon Lookout for Vision Developer Guide</i>.
        /// 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:UntagResource</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatasetEntries

        internal virtual UpdateDatasetEntriesResponse UpdateDatasetEntries(UpdateDatasetEntriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetEntriesResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetEntriesResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates one or more JSON Line entries in a dataset. A JSON Line includes information
        /// about an image used for training or testing an Amazon Lookout for Vision model.
        /// 
        ///  
        /// <para>
        /// To update an existing JSON Line, use the <code>source-ref</code> field to identify
        /// the JSON Line. The JSON line that you supply replaces the existing JSON line. Any
        /// existing annotations that are not in the new JSON line are removed from the dataset.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Defining JSON lines for anomaly classification</i> in
        /// the Amazon Lookout for Vision Developer Guide. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The images you reference in the <code>source-ref</code> field of a JSON line, must
        /// be in the same S3 bucket as the existing images in the dataset. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updating a dataset might take a while to complete. To check the current status, call
        /// <a>DescribeDataset</a> and check the <code>Status</code> field in the response.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>lookoutvision:UpdateDatasetEntries</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatasetEntries service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/UpdateDatasetEntries">REST API Reference for UpdateDatasetEntries Operation</seealso>
        public virtual Task<UpdateDatasetEntriesResponse> UpdateDatasetEntriesAsync(UpdateDatasetEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetEntriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}