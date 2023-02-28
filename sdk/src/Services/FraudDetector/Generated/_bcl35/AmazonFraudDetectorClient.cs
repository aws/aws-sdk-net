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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.FraudDetector.Model;
using Amazon.FraudDetector.Model.Internal.MarshallTransformations;
using Amazon.FraudDetector.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FraudDetector
{
    /// <summary>
    /// Implementation for accessing FraudDetector
    ///
    /// This is the Amazon Fraud Detector API Reference. This guide is for developers who
    /// need detailed information about Amazon Fraud Detector API actions, data types, and
    /// errors. For more information about Amazon Fraud Detector features, see the <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/">Amazon
    /// Fraud Detector User Guide</a>.
    /// 
    ///  
    /// <para>
    /// We provide the Query API as well as AWS software development kits (SDK) for Amazon
    /// Fraud Detector in Java and Python programming languages.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Fraud Detector Query API provides HTTPS requests that use the HTTP verb
    /// GET or POST and a Query parameter <code>Action</code>. AWS SDK provides libraries,
    /// sample code, tutorials, and other resources for software developers who prefer to
    /// build applications using language-specific APIs instead of submitting a request over
    /// HTTP or HTTPS. These libraries provide basic functions that automatically take care
    /// of tasks such as cryptographically signing your requests, retrying requests, and handling
    /// error responses, so that it is easier for you to get started. For more information
    /// about the AWS SDKs, see <a href="https://docs.aws.amazon.com/https:/aws.amazon.com/tools/">Tools
    /// to build on AWS</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonFraudDetectorClient : AmazonServiceClient, IAmazonFraudDetector
    {
        private static IServiceMetadata serviceMetadata = new AmazonFraudDetectorMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IFraudDetectorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFraudDetectorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FraudDetectorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        public AmazonFraudDetectorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFraudDetectorConfig()) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        public AmazonFraudDetectorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFraudDetectorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(AmazonFraudDetectorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials)
            : this(credentials, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFraudDetectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials and an
        /// AmazonFraudDetectorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials, AmazonFraudDetectorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFraudDetectorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFraudDetectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFraudDetectorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFraudDetectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFraudDetectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFraudDetectorConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFraudDetectorEndpointResolver());
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


        #region  BatchCreateVariable

        /// <summary>
        /// Creates a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable service method.</param>
        /// 
        /// <returns>The response from the BatchCreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual BatchCreateVariableResponse BatchCreateVariable(BatchCreateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVariableResponseUnmarshaller.Instance;

            return Invoke<BatchCreateVariableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateVariable(BatchCreateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateVariable.</param>
        /// 
        /// <returns>Returns a  BatchCreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual BatchCreateVariableResponse EndBatchCreateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateVariableResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetVariable

        /// <summary>
        /// Gets a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable service method.</param>
        /// 
        /// <returns>The response from the BatchGetVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual BatchGetVariableResponse BatchGetVariable(BatchGetVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVariableResponseUnmarshaller.Instance;

            return Invoke<BatchGetVariableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual IAsyncResult BeginBatchGetVariable(BatchGetVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetVariable.</param>
        /// 
        /// <returns>Returns a  BatchGetVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual BatchGetVariableResponse EndBatchGetVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetVariableResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelBatchImportJob

        /// <summary>
        /// Cancels an in-progress batch import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        public virtual CancelBatchImportJobResponse CancelBatchImportJob(CancelBatchImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchImportJobResponseUnmarshaller.Instance;

            return Invoke<CancelBatchImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        public virtual IAsyncResult BeginCancelBatchImportJob(CancelBatchImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBatchImportJob.</param>
        /// 
        /// <returns>Returns a  CancelBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        public virtual CancelBatchImportJobResponse EndCancelBatchImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelBatchImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelBatchPredictionJob

        /// <summary>
        /// Cancels the specified batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the CancelBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        public virtual CancelBatchPredictionJobResponse CancelBatchPredictionJob(CancelBatchPredictionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchPredictionJobResponseUnmarshaller.Instance;

            return Invoke<CancelBatchPredictionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        public virtual IAsyncResult BeginCancelBatchPredictionJob(CancelBatchPredictionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchPredictionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  CancelBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        public virtual CancelBatchPredictionJobResponse EndCancelBatchPredictionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelBatchPredictionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBatchImportJob

        /// <summary>
        /// Creates a batch import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        public virtual CreateBatchImportJobResponse CreateBatchImportJob(CreateBatchImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateBatchImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateBatchImportJob(CreateBatchImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchImportJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        public virtual CreateBatchImportJobResponse EndCreateBatchImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBatchImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBatchPredictionJob

        /// <summary>
        /// Creates a batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the CreateBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        public virtual CreateBatchPredictionJobResponse CreateBatchPredictionJob(CreateBatchPredictionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchPredictionJobResponseUnmarshaller.Instance;

            return Invoke<CreateBatchPredictionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        public virtual IAsyncResult BeginCreateBatchPredictionJob(CreateBatchPredictionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchPredictionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        public virtual CreateBatchPredictionJobResponse EndCreateBatchPredictionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBatchPredictionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDetectorVersion

        /// <summary>
        /// Creates a detector version. The detector version starts in a <code>DRAFT</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual CreateDetectorVersionResponse CreateDetectorVersion(CreateDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateDetectorVersion(CreateDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  CreateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual CreateDetectorVersionResponse EndCreateDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDetectorVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateList

        /// <summary>
        /// Creates a list. 
        /// 
        ///  
        /// <para>
        /// List is a set of input data for a variable in your event dataset. You use the input
        /// data in a rule that's associated with your detector. For more information, see <a
        /// href="https://docs.aws.amazon.com/frauddetector/latest/ug/lists.html">Lists</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateList service method.</param>
        /// 
        /// <returns>The response from the CreateList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        public virtual CreateListResponse CreateList(CreateListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListResponseUnmarshaller.Instance;

            return Invoke<CreateListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        public virtual IAsyncResult BeginCreateList(CreateListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateList.</param>
        /// 
        /// <returns>Returns a  CreateListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        public virtual CreateListResponse EndCreateList(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateListResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Creates a model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModelVersion

        /// <summary>
        /// Creates a version of the model using the specified model type and model id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual CreateModelVersionResponse CreateModelVersion(CreateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;

            return Invoke<CreateModelVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateModelVersion(CreateModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelVersion.</param>
        /// 
        /// <returns>Returns a  CreateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual CreateModelVersionResponse EndCreateModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRule

        /// <summary>
        /// Creates a rule for use with the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse EndCreateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVariable

        /// <summary>
        /// Creates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable service method.</param>
        /// 
        /// <returns>The response from the CreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual CreateVariableResponse CreateVariable(CreateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;

            return Invoke<CreateVariableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual IAsyncResult BeginCreateVariable(CreateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVariable.</param>
        /// 
        /// <returns>Returns a  CreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual CreateVariableResponse EndCreateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVariableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBatchImportJob

        /// <summary>
        /// Deletes the specified batch import job ID record. This action does not delete the
        /// data that was batch imported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        public virtual DeleteBatchImportJobResponse DeleteBatchImportJob(DeleteBatchImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchImportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteBatchImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteBatchImportJob(DeleteBatchImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBatchImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        public virtual DeleteBatchImportJobResponse EndDeleteBatchImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBatchImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBatchPredictionJob

        /// <summary>
        /// Deletes a batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        public virtual DeleteBatchPredictionJobResponse DeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchPredictionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteBatchPredictionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchPredictionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchPredictionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  DeleteBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        public virtual DeleteBatchPredictionJobResponse EndDeleteBatchPredictionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBatchPredictionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDetector

        /// <summary>
        /// Deletes the detector. Before deleting a detector, you must first delete all detector
        /// versions and rule versions associated with the detector.
        /// 
        ///  
        /// <para>
        /// When you delete a detector, Amazon Fraud Detector permanently deletes the detector
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual IAsyncResult BeginDeleteDetector(DeleteDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetector.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual DeleteDetectorResponse EndDeleteDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDetectorVersion

        /// <summary>
        /// Deletes the detector version. You cannot delete detector versions that are in <code>ACTIVE</code>
        /// status.
        /// 
        ///  
        /// <para>
        /// When you delete a detector version, Amazon Fraud Detector permanently deletes the
        /// detector and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual DeleteDetectorVersionResponse DeleteDetectorVersion(DeleteDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteDetectorVersion(DeleteDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetectorVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual DeleteDetectorVersionResponse EndDeleteDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDetectorVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEntityType

        /// <summary>
        /// Deletes an entity type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an entity type that is included in an event type.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType service method.</param>
        /// 
        /// <returns>The response from the DeleteEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        public virtual DeleteEntityTypeResponse DeleteEntityType(DeleteEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        public virtual IAsyncResult BeginDeleteEntityType(DeleteEntityTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEntityType.</param>
        /// 
        /// <returns>Returns a  DeleteEntityTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        public virtual DeleteEntityTypeResponse EndDeleteEntityType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEntityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEvent

        /// <summary>
        /// Deletes the specified event.
        /// 
        ///  
        /// <para>
        /// When you delete an event, Amazon Fraud Detector permanently deletes that event and
        /// the event data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual DeleteEventResponse DeleteEvent(DeleteEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;

            return Invoke<DeleteEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual IAsyncResult BeginDeleteEvent(DeleteEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvent.</param>
        /// 
        /// <returns>Returns a  DeleteEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual DeleteEventResponse EndDeleteEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventsByEventType

        /// <summary>
        /// Deletes all events of a particular event type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsByEventType service method.</param>
        /// 
        /// <returns>The response from the DeleteEventsByEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        public virtual DeleteEventsByEventTypeResponse DeleteEventsByEventType(DeleteEventsByEventTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventsByEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventsByEventTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteEventsByEventTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventsByEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsByEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventsByEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventsByEventType(DeleteEventsByEventTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventsByEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventsByEventTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventsByEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventsByEventType.</param>
        /// 
        /// <returns>Returns a  DeleteEventsByEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        public virtual DeleteEventsByEventTypeResponse EndDeleteEventsByEventType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventsByEventTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventType

        /// <summary>
        /// Deletes an event type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an event type that is used in a detector or a model.
        /// </para>
        ///  
        /// <para>
        /// When you delete an event type, Amazon Fraud Detector permanently deletes that event
        /// type and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType service method.</param>
        /// 
        /// <returns>The response from the DeleteEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        public virtual DeleteEventTypeResponse DeleteEventType(DeleteEventTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteEventTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventType(DeleteEventTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventType.</param>
        /// 
        /// <returns>Returns a  DeleteEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        public virtual DeleteEventTypeResponse EndDeleteEventType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteExternalModel

        /// <summary>
        /// Removes a SageMaker model from Amazon Fraud Detector.
        /// 
        ///  
        /// <para>
        /// You can remove an Amazon SageMaker model if it is not associated with a detector version.
        /// Removing a SageMaker model disconnects it from Amazon Fraud Detector, but the model
        /// remains available in SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel service method.</param>
        /// 
        /// <returns>The response from the DeleteExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        public virtual DeleteExternalModelResponse DeleteExternalModel(DeleteExternalModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExternalModelResponseUnmarshaller.Instance;

            return Invoke<DeleteExternalModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExternalModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExternalModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteExternalModel(DeleteExternalModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExternalModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExternalModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExternalModel.</param>
        /// 
        /// <returns>Returns a  DeleteExternalModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        public virtual DeleteExternalModelResponse EndDeleteExternalModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExternalModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLabel

        /// <summary>
        /// Deletes a label.
        /// 
        ///  
        /// <para>
        /// You cannot delete labels that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a label assigned to an event ID. You must first delete the relevant
        /// event ID.
        /// </para>
        ///  
        /// <para>
        /// When you delete a label, Amazon Fraud Detector permanently deletes that label and
        /// the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual DeleteLabelResponse DeleteLabel(DeleteLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual IAsyncResult BeginDeleteLabel(DeleteLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabel.</param>
        /// 
        /// <returns>Returns a  DeleteLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual DeleteLabelResponse EndDeleteLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteList

        /// <summary>
        /// Deletes the list, provided it is not used in a rule. 
        /// 
        ///  
        /// <para>
        ///  When you delete a list, Amazon Fraud Detector permanently deletes that list and the
        /// elements in the list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteList service method.</param>
        /// 
        /// <returns>The response from the DeleteList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        public virtual DeleteListResponse DeleteList(DeleteListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListResponseUnmarshaller.Instance;

            return Invoke<DeleteListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        public virtual IAsyncResult BeginDeleteList(DeleteListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteList.</param>
        /// 
        /// <returns>Returns a  DeleteListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        public virtual DeleteListResponse EndDeleteList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModel

        /// <summary>
        /// Deletes a model.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model, Amazon Fraud Detector permanently deletes that model and
        /// the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModelVersion

        /// <summary>
        /// Deletes a model version.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model version, Amazon Fraud Detector permanently deletes that model
        /// version and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        public virtual DeleteModelVersionResponse DeleteModelVersion(DeleteModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteModelVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteModelVersion(DeleteModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelVersion.</param>
        /// 
        /// <returns>Returns a  DeleteModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        public virtual DeleteModelVersionResponse EndDeleteModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOutcome

        /// <summary>
        /// Deletes an outcome.
        /// 
        ///  
        /// <para>
        /// You cannot delete an outcome that is used in a rule version.
        /// </para>
        ///  
        /// <para>
        /// When you delete an outcome, Amazon Fraud Detector permanently deletes that outcome
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome service method.</param>
        /// 
        /// <returns>The response from the DeleteOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        public virtual DeleteOutcomeResponse DeleteOutcome(DeleteOutcomeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutcomeResponseUnmarshaller.Instance;

            return Invoke<DeleteOutcomeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutcome operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutcome
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        public virtual IAsyncResult BeginDeleteOutcome(DeleteOutcomeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutcomeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutcome operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutcome.</param>
        /// 
        /// <returns>Returns a  DeleteOutcomeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        public virtual DeleteOutcomeResponse EndDeleteOutcome(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOutcomeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRule

        /// <summary>
        /// Deletes the rule. You cannot delete a rule if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// 
        ///  
        /// <para>
        /// When you delete a rule, Amazon Fraud Detector permanently deletes that rule and the
        /// data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVariable

        /// <summary>
        /// Deletes a variable.
        /// 
        ///  
        /// <para>
        /// You can't delete variables that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// Amazon Fraud Detector automatically deletes model output variables and SageMaker model
        /// output variables when you delete the model. You can't delete these variables manually.
        /// </para>
        ///  
        /// <para>
        /// When you delete a variable, Amazon Fraud Detector permanently deletes that variable
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable service method.</param>
        /// 
        /// <returns>The response from the DeleteVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        public virtual DeleteVariableResponse DeleteVariable(DeleteVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariableResponseUnmarshaller.Instance;

            return Invoke<DeleteVariableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        public virtual IAsyncResult BeginDeleteVariable(DeleteVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVariable.</param>
        /// 
        /// <returns>Returns a  DeleteVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        public virtual DeleteVariableResponse EndDeleteVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVariableResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDetector

        /// <summary>
        /// Gets all versions for a specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual IAsyncResult BeginDescribeDetector(DescribeDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetector.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse EndDescribeDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeModelVersions

        /// <summary>
        /// Gets all of the model versions for the specified model type or for the specified model
        /// type and model ID. You can also get details for a single, specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeModelVersions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual DescribeModelVersionsResponse DescribeModelVersions(DescribeModelVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeModelVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeModelVersions(DescribeModelVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelVersions.</param>
        /// 
        /// <returns>Returns a  DescribeModelVersionsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual DescribeModelVersionsResponse EndDescribeModelVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeModelVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBatchImportJobs

        /// <summary>
        /// Gets all batch import jobs or a specific job of the specified ID. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 50 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 1 and 50. To get the next page results, provide the pagination token from
        /// the <code>GetBatchImportJobsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetBatchImportJobs service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        public virtual GetBatchImportJobsResponse GetBatchImportJobs(GetBatchImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetBatchImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchImportJobs operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBatchImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        public virtual IAsyncResult BeginGetBatchImportJobs(GetBatchImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBatchImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBatchImportJobs.</param>
        /// 
        /// <returns>Returns a  GetBatchImportJobsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        public virtual GetBatchImportJobsResponse EndGetBatchImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBatchImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBatchPredictionJobs

        /// <summary>
        /// Gets all batch prediction jobs or a specific job if you specify a job ID. This is
        /// a paginated API. If you provide a null maxResults, this action retrieves a maximum
        /// of 50 records per page. If you provide a maxResults, the value must be between 1 and
        /// 50. To get the next page results, provide the pagination token from the GetBatchPredictionJobsResponse
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPredictionJobs service method.</param>
        /// 
        /// <returns>The response from the GetBatchPredictionJobs service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        public virtual GetBatchPredictionJobsResponse GetBatchPredictionJobs(GetBatchPredictionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchPredictionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchPredictionJobsResponseUnmarshaller.Instance;

            return Invoke<GetBatchPredictionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchPredictionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPredictionJobs operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBatchPredictionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        public virtual IAsyncResult BeginGetBatchPredictionJobs(GetBatchPredictionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchPredictionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchPredictionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBatchPredictionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBatchPredictionJobs.</param>
        /// 
        /// <returns>Returns a  GetBatchPredictionJobsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        public virtual GetBatchPredictionJobsResponse EndGetBatchPredictionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBatchPredictionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeleteEventsByEventTypeStatus

        /// <summary>
        /// Retrieves the status of a <code>DeleteEventsByEventType</code> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeleteEventsByEventTypeStatus service method.</param>
        /// 
        /// <returns>The response from the GetDeleteEventsByEventTypeStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        public virtual GetDeleteEventsByEventTypeStatusResponse GetDeleteEventsByEventTypeStatus(GetDeleteEventsByEventTypeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeleteEventsByEventTypeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeleteEventsByEventTypeStatusResponseUnmarshaller.Instance;

            return Invoke<GetDeleteEventsByEventTypeStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeleteEventsByEventTypeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeleteEventsByEventTypeStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeleteEventsByEventTypeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        public virtual IAsyncResult BeginGetDeleteEventsByEventTypeStatus(GetDeleteEventsByEventTypeStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeleteEventsByEventTypeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeleteEventsByEventTypeStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeleteEventsByEventTypeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeleteEventsByEventTypeStatus.</param>
        /// 
        /// <returns>Returns a  GetDeleteEventsByEventTypeStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        public virtual GetDeleteEventsByEventTypeStatusResponse EndGetDeleteEventsByEventTypeStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeleteEventsByEventTypeStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDetectors

        /// <summary>
        /// Gets all detectors or a single detector if a <code>detectorId</code> is specified.
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetDetectorsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual GetDetectorsResponse GetDetectors(GetDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorsResponseUnmarshaller.Instance;

            return Invoke<GetDetectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual IAsyncResult BeginGetDetectors(GetDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectors.</param>
        /// 
        /// <returns>Returns a  GetDetectorsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual GetDetectorsResponse EndGetDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDetectorVersion

        /// <summary>
        /// Gets a particular detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the GetDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual GetDetectorVersionResponse GetDetectorVersion(GetDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<GetDetectorVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginGetDetectorVersion(GetDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectorVersion.</param>
        /// 
        /// <returns>Returns a  GetDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual GetDetectorVersionResponse EndGetDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEntityTypes

        /// <summary>
        /// Gets all entity types or a specific entity type if a name is specified. This is a
        /// paginated API. If you provide a null <code>maxResults</code>, this action retrieves
        /// a maximum of 10 records per page. If you provide a <code>maxResults</code>, the value
        /// must be between 5 and 10. To get the next page results, provide the pagination token
        /// from the <code>GetEntityTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes service method.</param>
        /// 
        /// <returns>The response from the GetEntityTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        public virtual GetEntityTypesResponse GetEntityTypes(GetEntityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityTypesResponseUnmarshaller.Instance;

            return Invoke<GetEntityTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEntityTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        public virtual IAsyncResult BeginGetEntityTypes(GetEntityTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEntityTypes.</param>
        /// 
        /// <returns>Returns a  GetEntityTypesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        public virtual GetEntityTypesResponse EndGetEntityTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEntityTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvent

        /// <summary>
        /// Retrieves details of events stored with Amazon Fraud Detector. This action does not
        /// retrieve prediction results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// 
        /// <returns>The response from the GetEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        public virtual GetEventResponse GetEvent(GetEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventResponseUnmarshaller.Instance;

            return Invoke<GetEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        public virtual IAsyncResult BeginGetEvent(GetEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvent.</param>
        /// 
        /// <returns>Returns a  GetEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        public virtual GetEventResponse EndGetEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventPrediction

        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction service method.</param>
        /// 
        /// <returns>The response from the GetEventPrediction service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceUnavailableException">
        /// An exception indicating that the attached customer-owned (external) model threw an
        /// exception when Amazon Fraud Detector invoked the model.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        public virtual GetEventPredictionResponse GetEventPrediction(GetEventPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionResponseUnmarshaller.Instance;

            return Invoke<GetEventPredictionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        public virtual IAsyncResult BeginGetEventPrediction(GetEventPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventPrediction.</param>
        /// 
        /// <returns>Returns a  GetEventPredictionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        public virtual GetEventPredictionResponse EndGetEventPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventPredictionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventPredictionMetadata

        /// <summary>
        /// Gets details of the past fraud predictions for the specified event ID, event type,
        /// detector ID, and detector version ID that was generated in the specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPredictionMetadata service method.</param>
        /// 
        /// <returns>The response from the GetEventPredictionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        public virtual GetEventPredictionMetadataResponse GetEventPredictionMetadata(GetEventPredictionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionMetadataResponseUnmarshaller.Instance;

            return Invoke<GetEventPredictionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventPredictionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventPredictionMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventPredictionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetEventPredictionMetadata(GetEventPredictionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventPredictionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventPredictionMetadata.</param>
        /// 
        /// <returns>Returns a  GetEventPredictionMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        public virtual GetEventPredictionMetadataResponse EndGetEventPredictionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventPredictionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventTypes

        /// <summary>
        /// Gets all event types or a specific event type if name is provided. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 10 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 5 and 10. To get the next page results, provide the pagination token from
        /// the <code>GetEventTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes service method.</param>
        /// 
        /// <returns>The response from the GetEventTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        public virtual GetEventTypesResponse GetEventTypes(GetEventTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTypesResponseUnmarshaller.Instance;

            return Invoke<GetEventTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        public virtual IAsyncResult BeginGetEventTypes(GetEventTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventTypes.</param>
        /// 
        /// <returns>Returns a  GetEventTypesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        public virtual GetEventTypesResponse EndGetEventTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExternalModels

        /// <summary>
        /// Gets the details for one or more Amazon SageMaker models that have been imported into
        /// the service. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetExternalModelsResult</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels service method.</param>
        /// 
        /// <returns>The response from the GetExternalModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual GetExternalModelsResponse GetExternalModels(GetExternalModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExternalModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExternalModelsResponseUnmarshaller.Instance;

            return Invoke<GetExternalModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExternalModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual IAsyncResult BeginGetExternalModels(GetExternalModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExternalModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExternalModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExternalModels.</param>
        /// 
        /// <returns>Returns a  GetExternalModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual GetExternalModelsResponse EndGetExternalModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExternalModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKMSEncryptionKey

        /// <summary>
        /// Gets the encryption key if a KMS key has been specified to be used to encrypt content
        /// in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        public virtual GetKMSEncryptionKeyResponse GetKMSEncryptionKey(GetKMSEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKMSEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<GetKMSEncryptionKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKMSEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        public virtual IAsyncResult BeginGetKMSEncryptionKey(GetKMSEncryptionKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKMSEncryptionKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKMSEncryptionKey.</param>
        /// 
        /// <returns>Returns a  GetKMSEncryptionKeyResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        public virtual GetKMSEncryptionKeyResponse EndGetKMSEncryptionKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKMSEncryptionKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLabels

        /// <summary>
        /// Gets all labels or a specific label if name is provided. This is a paginated API.
        /// If you provide a null <code>maxResults</code>, this action retrieves a maximum of
        /// 50 records per page. If you provide a <code>maxResults</code>, the value must be between
        /// 10 and 50. To get the next page results, provide the pagination token from the <code>GetGetLabelsResponse</code>
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabels service method.</param>
        /// 
        /// <returns>The response from the GetLabels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        public virtual GetLabelsResponse GetLabels(GetLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelsResponseUnmarshaller.Instance;

            return Invoke<GetLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        public virtual IAsyncResult BeginGetLabels(GetLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLabels.</param>
        /// 
        /// <returns>Returns a  GetLabelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        public virtual GetLabelsResponse EndGetLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetListElements

        /// <summary>
        /// Gets all the elements in the specified list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListElements service method.</param>
        /// 
        /// <returns>The response from the GetListElements service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        public virtual GetListElementsResponse GetListElements(GetListElementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListElementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListElementsResponseUnmarshaller.Instance;

            return Invoke<GetListElementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetListElements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListElements operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListElements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        public virtual IAsyncResult BeginGetListElements(GetListElementsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListElementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListElementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetListElements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListElements.</param>
        /// 
        /// <returns>Returns a  GetListElementsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        public virtual GetListElementsResponse EndGetListElements(IAsyncResult asyncResult)
        {
            return EndInvoke<GetListElementsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetListsMetadata

        /// <summary>
        /// Gets the metadata of either all the lists under the account or the specified list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListsMetadata service method.</param>
        /// 
        /// <returns>The response from the GetListsMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        public virtual GetListsMetadataResponse GetListsMetadata(GetListsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListsMetadataResponseUnmarshaller.Instance;

            return Invoke<GetListsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetListsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListsMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetListsMetadata(GetListsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetListsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListsMetadata.</param>
        /// 
        /// <returns>Returns a  GetListsMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        public virtual GetListsMetadataResponse EndGetListsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetListsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModels

        /// <summary>
        /// Gets one or more models. Gets all models for the Amazon Web Services account if no
        /// model type and no model id provided. Gets all models for the Amazon Web Services account
        /// and model type, if the model type is specified but model id is not provided. Gets
        /// a specific model if (model type, model id) tuple is specified. 
        /// 
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 1 and 10. To get the next page results, provide the pagination
        /// token from the response as part of your request. A null pagination token fetches the
        /// records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse EndGetModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelVersion

        /// <summary>
        /// Gets the details of the specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual GetModelVersionResponse GetModelVersion(GetModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;

            return Invoke<GetModelVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual IAsyncResult BeginGetModelVersion(GetModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelVersion.</param>
        /// 
        /// <returns>Returns a  GetModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual GetModelVersionResponse EndGetModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOutcomes

        /// <summary>
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 100 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the pagination
        /// token from the <code>GetOutcomesResult</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes service method.</param>
        /// 
        /// <returns>The response from the GetOutcomes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual GetOutcomesResponse GetOutcomes(GetOutcomesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutcomesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutcomesResponseUnmarshaller.Instance;

            return Invoke<GetOutcomesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutcomes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual IAsyncResult BeginGetOutcomes(GetOutcomesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutcomesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutcomesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutcomes.</param>
        /// 
        /// <returns>Returns a  GetOutcomesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual GetOutcomesResponse EndGetOutcomes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOutcomesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRules

        /// <summary>
        /// Get all rules for a detector (paginated) if <code>ruleId</code> and <code>ruleVersion</code>
        /// are not specified. Gets all rules for the detector and the <code>ruleId</code> if
        /// present (paginated). Gets a specific rule if both the <code>ruleId</code> and the
        /// <code>ruleVersion</code> are specified.
        /// 
        ///  
        /// <para>
        /// This is a paginated API. Providing null maxResults results in retrieving maximum of
        /// 100 records per page. If you provide maxResults the value must be between 50 and 100.
        /// To get the next page result, a provide a pagination token from GetRulesResult as part
        /// of your request. Null pagination token fetches the records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual GetRulesResponse GetRules(GetRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRulesResponseUnmarshaller.Instance;

            return Invoke<GetRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRules operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual IAsyncResult BeginGetRules(GetRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRules.</param>
        /// 
        /// <returns>Returns a  GetRulesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual GetRulesResponse EndGetRules(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVariables

        /// <summary>
        /// Gets all of the variables or the specific variable. This is a paginated API. Providing
        /// null <code>maxSizePerPage</code> results in retrieving maximum of 100 records per
        /// page. If you provide <code>maxSizePerPage</code> the value must be between 50 and
        /// 100. To get the next page result, a provide a pagination token from <code>GetVariablesResult</code>
        /// as part of your request. Null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariables service method.</param>
        /// 
        /// <returns>The response from the GetVariables service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual GetVariablesResponse GetVariables(GetVariablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariablesResponseUnmarshaller.Instance;

            return Invoke<GetVariablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariables operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual IAsyncResult BeginGetVariables(GetVariablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariables.</param>
        /// 
        /// <returns>Returns a  GetVariablesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual GetVariablesResponse EndGetVariables(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVariablesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventPredictions

        /// <summary>
        /// Gets a list of past predictions. The list can be filtered by detector ID, detector
        /// version ID, event ID, event type, or by specifying a time period. If filter is not
        /// specified, the most recent prediction is returned.
        /// 
        ///  
        /// <para>
        /// For example, the following filter lists all past predictions for <code>xyz</code>
        /// event type - <code>{ "eventType":{ "value": "xyz" }” } </code> 
        /// </para>
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// will retrieve a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the <code>nextToken</code>
        /// from the response as part of your request. A null <code>nextToken</code> fetches the
        /// records from the beginning. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventPredictions service method.</param>
        /// 
        /// <returns>The response from the ListEventPredictions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        public virtual ListEventPredictionsResponse ListEventPredictions(ListEventPredictionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventPredictionsResponseUnmarshaller.Instance;

            return Invoke<ListEventPredictionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventPredictions operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventPredictions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        public virtual IAsyncResult BeginListEventPredictions(ListEventPredictionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventPredictionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventPredictions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventPredictions.</param>
        /// 
        /// <returns>Returns a  ListEventPredictionsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        public virtual ListEventPredictionsResponse EndListEventPredictions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventPredictionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with the resource. This is a paginated API. To get the next
        /// page results, provide the pagination token from the response as part of your request.
        /// A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDetector

        /// <summary>
        /// Creates or updates a detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDetector service method.</param>
        /// 
        /// <returns>The response from the PutDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual PutDetectorResponse PutDetector(PutDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDetectorResponseUnmarshaller.Instance;

            return Invoke<PutDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual IAsyncResult BeginPutDetector(PutDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDetector.</param>
        /// 
        /// <returns>Returns a  PutDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual PutDetectorResponse EndPutDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEntityType

        /// <summary>
        /// Creates or updates an entity type. An entity represents who is performing the event.
        /// As part of a fraud prediction, you pass the entity ID to indicate the specific entity
        /// who performed the event. An entity type classifies the entity. Example classifications
        /// include customer, merchant, or account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType service method.</param>
        /// 
        /// <returns>The response from the PutEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        public virtual PutEntityTypeResponse PutEntityType(PutEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEntityTypeResponseUnmarshaller.Instance;

            return Invoke<PutEntityTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        public virtual IAsyncResult BeginPutEntityType(PutEntityTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEntityTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEntityType.</param>
        /// 
        /// <returns>Returns a  PutEntityTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        public virtual PutEntityTypeResponse EndPutEntityType(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEntityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEventType

        /// <summary>
        /// Creates or updates an event type. An event is a business activity that is evaluated
        /// for fraud risk. With Amazon Fraud Detector, you generate fraud predictions for events.
        /// An event type defines the structure for an event sent to Amazon Fraud Detector. This
        /// includes the variables sent as part of the event, the entity performing the event
        /// (such as a customer), and the labels that classify the event. Example event types
        /// include online payment transactions, account registrations, and authentications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventType service method.</param>
        /// 
        /// <returns>The response from the PutEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        public virtual PutEventTypeResponse PutEventType(PutEventTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventTypeResponseUnmarshaller.Instance;

            return Invoke<PutEventTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        public virtual IAsyncResult BeginPutEventType(PutEventTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventType.</param>
        /// 
        /// <returns>Returns a  PutEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        public virtual PutEventTypeResponse EndPutEventType(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  PutExternalModel

        /// <summary>
        /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
        /// to update the configuration of the model endpoint, including the IAM role and/or the
        /// mapped variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel service method.</param>
        /// 
        /// <returns>The response from the PutExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual PutExternalModelResponse PutExternalModel(PutExternalModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutExternalModelResponseUnmarshaller.Instance;

            return Invoke<PutExternalModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutExternalModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual IAsyncResult BeginPutExternalModel(PutExternalModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutExternalModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutExternalModel.</param>
        /// 
        /// <returns>Returns a  PutExternalModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual PutExternalModelResponse EndPutExternalModel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutExternalModelResponse>(asyncResult);
        }

        #endregion
        
        #region  PutKMSEncryptionKey

        /// <summary>
        /// Specifies the KMS key to be used to encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the PutKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        public virtual PutKMSEncryptionKeyResponse PutKMSEncryptionKey(PutKMSEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKMSEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<PutKMSEncryptionKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKMSEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        public virtual IAsyncResult BeginPutKMSEncryptionKey(PutKMSEncryptionKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKMSEncryptionKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKMSEncryptionKey.</param>
        /// 
        /// <returns>Returns a  PutKMSEncryptionKeyResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        public virtual PutKMSEncryptionKeyResponse EndPutKMSEncryptionKey(IAsyncResult asyncResult)
        {
            return EndInvoke<PutKMSEncryptionKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLabel

        /// <summary>
        /// Creates or updates label. A label classifies an event as fraudulent or legitimate.
        /// Labels are associated with event types and used to train supervised machine learning
        /// models in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLabel service method.</param>
        /// 
        /// <returns>The response from the PutLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        public virtual PutLabelResponse PutLabel(PutLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLabelResponseUnmarshaller.Instance;

            return Invoke<PutLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        public virtual IAsyncResult BeginPutLabel(PutLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLabel.</param>
        /// 
        /// <returns>Returns a  PutLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        public virtual PutLabelResponse EndPutLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  PutOutcome

        /// <summary>
        /// Creates or updates an outcome.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome service method.</param>
        /// 
        /// <returns>The response from the PutOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual PutOutcomeResponse PutOutcome(PutOutcomeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutcomeResponseUnmarshaller.Instance;

            return Invoke<PutOutcomeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOutcome
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual IAsyncResult BeginPutOutcome(PutOutcomeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutcomeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOutcome.</param>
        /// 
        /// <returns>Returns a  PutOutcomeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual PutOutcomeResponse EndPutOutcome(IAsyncResult asyncResult)
        {
            return EndInvoke<PutOutcomeResponse>(asyncResult);
        }

        #endregion
        
        #region  SendEvent

        /// <summary>
        /// Stores events in Amazon Fraud Detector without generating fraud predictions for those
        /// events. For example, you can use <code>SendEvent</code> to upload a historical dataset,
        /// which you can then later use to train a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual SendEventResponse SendEvent(SendEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return Invoke<SendEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEvent.</param>
        /// 
        /// <returns>Returns a  SendEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual SendEventResponse EndSendEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<SendEventResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDetectorVersion

        /// <summary>
        /// Updates a detector version. The detector version attributes that you can update include
        /// models, external model endpoints, rules, rule execution mode, and description. You
        /// can only update a <code>DRAFT</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual UpdateDetectorVersionResponse UpdateDetectorVersion(UpdateDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersion(UpdateDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual UpdateDetectorVersionResponse EndUpdateDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDetectorVersionMetadata

        /// <summary>
        /// Updates the detector version's description. You can update the metadata for any detector
        /// version (<code>DRAFT, ACTIVE,</code> or <code>INACTIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual UpdateDetectorVersionMetadataResponse UpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual UpdateDetectorVersionMetadataResponse EndUpdateDetectorVersionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDetectorVersionStatus

        /// <summary>
        /// Updates the detector version’s status. You can perform the following promotions or
        /// demotions using <code>UpdateDetectorVersionStatus</code>: <code>DRAFT</code> to <code>ACTIVE</code>,
        /// <code>ACTIVE</code> to <code>INACTIVE</code>, and <code>INACTIVE</code> to <code>ACTIVE</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual UpdateDetectorVersionStatusResponse UpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionStatus.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual UpdateDetectorVersionStatusResponse EndUpdateDetectorVersionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventLabel

        /// <summary>
        /// Updates the specified event with a new label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLabel service method.</param>
        /// 
        /// <returns>The response from the UpdateEventLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        public virtual UpdateEventLabelResponse UpdateEventLabel(UpdateEventLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLabelResponseUnmarshaller.Instance;

            return Invoke<UpdateEventLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventLabel(UpdateEventLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventLabel.</param>
        /// 
        /// <returns>Returns a  UpdateEventLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        public virtual UpdateEventLabelResponse EndUpdateEventLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateList

        /// <summary>
        /// Updates a list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateList service method.</param>
        /// 
        /// <returns>The response from the UpdateList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        public virtual UpdateListResponse UpdateList(UpdateListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListResponseUnmarshaller.Instance;

            return Invoke<UpdateListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        public virtual IAsyncResult BeginUpdateList(UpdateListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateList.</param>
        /// 
        /// <returns>Returns a  UpdateListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        public virtual UpdateListResponse EndUpdateList(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateListResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModel

        /// <summary>
        /// Updates model description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModelVersion

        /// <summary>
        /// Updates a model version. Updating a model version retrains an existing model version
        /// using updated training data and produces a new minor version of the model. You can
        /// update the training data set location and data access role attributes using this action.
        /// This action creates and trains a new minor version of the model, for example version
        /// 1.01, 1.02, 1.03.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual UpdateModelVersionResponse UpdateModelVersion(UpdateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateModelVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateModelVersion(UpdateModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelVersion.</param>
        /// 
        /// <returns>Returns a  UpdateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual UpdateModelVersionResponse EndUpdateModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModelVersionStatus

        /// <summary>
        /// Updates the status of a model version.
        /// 
        ///  
        /// <para>
        /// You can perform the following status updates:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_IN_PROGRESS</code> status to <code>TRAINING_CANCELLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code> to <code>INACTIVE</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        public virtual UpdateModelVersionStatusResponse UpdateModelVersionStatus(UpdateModelVersionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateModelVersionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelVersionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateModelVersionStatus(UpdateModelVersionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelVersionStatus.</param>
        /// 
        /// <returns>Returns a  UpdateModelVersionStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        public virtual UpdateModelVersionStatusResponse EndUpdateModelVersionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelVersionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuleMetadata

        /// <summary>
        /// Updates a rule's metadata. The description attribute can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual UpdateRuleMetadataResponse UpdateRuleMetadata(UpdateRuleMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleMetadata(UpdateRuleMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateRuleMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual UpdateRuleMetadataResponse EndUpdateRuleMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuleVersion

        /// <summary>
        /// Updates a rule version resulting in a new rule version. Updates a rule version resulting
        /// in a new rule version (version 1, 2, 3 ...).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual UpdateRuleVersionResponse UpdateRuleVersion(UpdateRuleVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleVersion(UpdateRuleVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleVersion.</param>
        /// 
        /// <returns>Returns a  UpdateRuleVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual UpdateRuleVersionResponse EndUpdateRuleVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVariable

        /// <summary>
        /// Updates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable service method.</param>
        /// 
        /// <returns>The response from the UpdateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual UpdateVariableResponse UpdateVariable(UpdateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariableResponseUnmarshaller.Instance;

            return Invoke<UpdateVariableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual IAsyncResult BeginUpdateVariable(UpdateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVariable.</param>
        /// 
        /// <returns>Returns a  UpdateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual UpdateVariableResponse EndUpdateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVariableResponse>(asyncResult);
        }

        #endregion
        
    }
}