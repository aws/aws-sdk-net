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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MachineLearning.Model;
using Amazon.MachineLearning.Model.Internal.MarshallTransformations;
using Amazon.MachineLearning.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MachineLearning
{
    /// <summary>
    /// Implementation for accessing MachineLearning
    ///
    /// Definition of the public APIs exposed by Amazon Machine Learning
    /// </summary>
    public partial class AmazonMachineLearningClient : AmazonServiceClient, IAmazonMachineLearning
    {
        private static IServiceMetadata serviceMetadata = new AmazonMachineLearningMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        public AmazonMachineLearningClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMachineLearningConfig()) { }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        public AmazonMachineLearningClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMachineLearningConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(AmazonMachineLearningConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMachineLearningClient(AWSCredentials credentials)
            : this(credentials, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMachineLearningConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials and an
        /// AmazonMachineLearningClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(AWSCredentials credentials, AmazonMachineLearningConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMachineLearningConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMachineLearningClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMachineLearningConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMachineLearningConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMachineLearningClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMachineLearningConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.MachineLearning.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.MachineLearning.Internal.IdempotencyHandler());
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


        #region  AddTags

        /// <summary>
        /// Adds one or more tags to an object, up to a limit of 10. Each tag consists of a key
        /// and an optional value. If you add a tag using a key that is already associated with
        /// the ML object, <code>AddTags</code> updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidTagException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.TagLimitExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBatchPrediction

        /// <summary>
        /// Generates predictions for a group of observations. The observations to process exist
        /// in one or more data files referenced by a <code>DataSource</code>. This operation
        /// creates a new <code>BatchPrediction</code>, and uses an <code>MLModel</code> and the
        /// data files referenced by the <code>DataSource</code> as information sources. 
        /// 
        ///  
        /// <para>
        /// <code>CreateBatchPrediction</code> is an asynchronous operation. In response to <code>CreateBatchPrediction</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>BatchPrediction</code>
        /// status to <code>PENDING</code>. After the <code>BatchPrediction</code> completes,
        /// Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can poll for status updates by using the <a>GetBatchPrediction</a> operation and
        /// checking the <code>Status</code> parameter of the result. After the <code>COMPLETED</code>
        /// status appears, the results are available in the location specified by the <code>OutputUri</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction service method.</param>
        /// 
        /// <returns>The response from the CreateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateBatchPrediction">REST API Reference for CreateBatchPrediction Operation</seealso>
        public virtual CreateBatchPredictionResponse CreateBatchPrediction(CreateBatchPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<CreateBatchPredictionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateBatchPrediction">REST API Reference for CreateBatchPrediction Operation</seealso>
        public virtual IAsyncResult BeginCreateBatchPrediction(CreateBatchPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchPrediction.</param>
        /// 
        /// <returns>Returns a  CreateBatchPredictionResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateBatchPrediction">REST API Reference for CreateBatchPrediction Operation</seealso>
        public virtual CreateBatchPredictionResponse EndCreateBatchPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBatchPredictionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSourceFromRDS

        /// <summary>
        /// Creates a <code>DataSource</code> object from an <a href="http://aws.amazon.com/rds/">
        /// Amazon Relational Database Service</a> (Amazon RDS). A <code>DataSource</code> references
        /// data that can be used to perform <code>CreateMLModel</code>, <code>CreateEvaluation</code>,
        /// or <code>CreateBatchPrediction</code> operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromRDS</code> is an asynchronous operation. In response to
        /// <code>CreateDataSourceFromRDS</code>, Amazon Machine Learning (Amazon ML) immediately
        /// returns and sets the <code>DataSource</code> status to <code>PENDING</code>. After
        /// the <code>DataSource</code> is created and ready for use, Amazon ML sets the <code>Status</code>
        /// parameter to <code>COMPLETED</code>. <code>DataSource</code> in the <code>COMPLETED</code>
        /// or <code>PENDING</code> state can be used only to perform <code>&gt;CreateMLModel</code>&gt;,
        /// <code>CreateEvaluation</code>, or <code>CreateBatchPrediction</code> operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <code>GetDataSource</code> operation response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS service method.</param>
        /// 
        /// <returns>The response from the CreateDataSourceFromRDS service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRDS">REST API Reference for CreateDataSourceFromRDS Operation</seealso>
        public virtual CreateDataSourceFromRDSResponse CreateDataSourceFromRDS(CreateDataSourceFromRDSRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromRDSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromRDSResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromRDSResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRDS operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSourceFromRDS
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRDS">REST API Reference for CreateDataSourceFromRDS Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSourceFromRDS(CreateDataSourceFromRDSRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromRDSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromRDSResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSourceFromRDS operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSourceFromRDS.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceFromRDSResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRDS">REST API Reference for CreateDataSourceFromRDS Operation</seealso>
        public virtual CreateDataSourceFromRDSResponse EndCreateDataSourceFromRDS(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceFromRDSResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSourceFromRedshift

        /// <summary>
        /// Creates a <code>DataSource</code> from a database hosted on an Amazon Redshift cluster.
        /// A <code>DataSource</code> references data that can be used to perform either <code>CreateMLModel</code>,
        /// <code>CreateEvaluation</code>, or <code>CreateBatchPrediction</code> operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromRedshift</code> is an asynchronous operation. In response
        /// to <code>CreateDataSourceFromRedshift</code>, Amazon Machine Learning (Amazon ML)
        /// immediately returns and sets the <code>DataSource</code> status to <code>PENDING</code>.
        /// After the <code>DataSource</code> is created and ready for use, Amazon ML sets the
        /// <code>Status</code> parameter to <code>COMPLETED</code>. <code>DataSource</code> in
        /// <code>COMPLETED</code> or <code>PENDING</code> states can be used to perform only
        /// <code>CreateMLModel</code>, <code>CreateEvaluation</code>, or <code>CreateBatchPrediction</code>
        /// operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML can't accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <code>GetDataSource</code> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observations should be contained in the database hosted on an Amazon Redshift
        /// cluster and should be specified by a <code>SelectSqlQuery</code> query. Amazon ML
        /// executes an <code>Unload</code> command in Amazon Redshift to transfer the result
        /// set of the <code>SelectSqlQuery</code> query to <code>S3StagingLocation</code>.
        /// </para>
        ///  
        /// <para>
        /// After the <code>DataSource</code> has been created, it's ready for use in evaluations
        /// and batch predictions. If you plan to use the <code>DataSource</code> to train an
        /// <code>MLModel</code>, the <code>DataSource</code> also requires a recipe. A recipe
        /// describes how each input variable will be used in training an <code>MLModel</code>.
        /// Will the variable be included or excluded from training? Will the variable be manipulated;
        /// for example, will it be combined with another variable or will it be split apart into
        /// word combinations? The recipe provides answers to these questions.
        /// </para>
        ///  
        /// <para>
        /// You can't change an existing datasource, but you can copy and modify the settings
        /// from an existing Amazon Redshift datasource to create a new datasource. To do so,
        /// call <code>GetDataSource</code> for an existing datasource and copy the values to
        /// a <code>CreateDataSource</code> call. Change the settings that you want to change
        /// and make sure that all required fields have the appropriate values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift service method.</param>
        /// 
        /// <returns>The response from the CreateDataSourceFromRedshift service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRedshift">REST API Reference for CreateDataSourceFromRedshift Operation</seealso>
        public virtual CreateDataSourceFromRedshiftResponse CreateDataSourceFromRedshift(CreateDataSourceFromRedshiftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromRedshiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromRedshiftResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromRedshiftResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRedshift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSourceFromRedshift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRedshift">REST API Reference for CreateDataSourceFromRedshift Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSourceFromRedshift(CreateDataSourceFromRedshiftRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromRedshiftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromRedshiftResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSourceFromRedshift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSourceFromRedshift.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceFromRedshiftResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRedshift">REST API Reference for CreateDataSourceFromRedshift Operation</seealso>
        public virtual CreateDataSourceFromRedshiftResponse EndCreateDataSourceFromRedshift(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceFromRedshiftResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSourceFromS3

        /// <summary>
        /// Creates a <code>DataSource</code> object. A <code>DataSource</code> references data
        /// that can be used to perform <code>CreateMLModel</code>, <code>CreateEvaluation</code>,
        /// or <code>CreateBatchPrediction</code> operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromS3</code> is an asynchronous operation. In response to <code>CreateDataSourceFromS3</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>DataSource</code>
        /// status to <code>PENDING</code>. After the <code>DataSource</code> has been created
        /// and is ready for use, Amazon ML sets the <code>Status</code> parameter to <code>COMPLETED</code>.
        /// <code>DataSource</code> in the <code>COMPLETED</code> or <code>PENDING</code> state
        /// can be used to perform only <code>CreateMLModel</code>, <code>CreateEvaluation</code>
        /// or <code>CreateBatchPrediction</code> operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML can't accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <code>GetDataSource</code> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observation data used in a <code>DataSource</code> should be ready to use; that
        /// is, it should have a consistent structure, and missing data values should be kept
        /// to a minimum. The observation data must reside in one or more .csv files in an Amazon
        /// Simple Storage Service (Amazon S3) location, along with a schema that describes the
        /// data items by name and type. The same schema must be used for all of the data files
        /// referenced by the <code>DataSource</code>. 
        /// </para>
        ///  
        /// <para>
        /// After the <code>DataSource</code> has been created, it's ready to use in evaluations
        /// and batch predictions. If you plan to use the <code>DataSource</code> to train an
        /// <code>MLModel</code>, the <code>DataSource</code> also needs a recipe. A recipe describes
        /// how each input variable will be used in training an <code>MLModel</code>. Will the
        /// variable be included or excluded from training? Will the variable be manipulated;
        /// for example, will it be combined with another variable or will it be split apart into
        /// word combinations? The recipe provides answers to these questions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 service method.</param>
        /// 
        /// <returns>The response from the CreateDataSourceFromS3 service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromS3">REST API Reference for CreateDataSourceFromS3 Operation</seealso>
        public virtual CreateDataSourceFromS3Response CreateDataSourceFromS3(CreateDataSourceFromS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromS3ResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSourceFromS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromS3">REST API Reference for CreateDataSourceFromS3 Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSourceFromS3(CreateDataSourceFromS3Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceFromS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSourceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSourceFromS3.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceFromS3Result from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromS3">REST API Reference for CreateDataSourceFromS3 Operation</seealso>
        public virtual CreateDataSourceFromS3Response EndCreateDataSourceFromS3(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceFromS3Response>(asyncResult);
        }

        #endregion
        
        #region  CreateEvaluation

        /// <summary>
        /// Creates a new <code>Evaluation</code> of an <code>MLModel</code>. An <code>MLModel</code>
        /// is evaluated on a set of observations associated to a <code>DataSource</code>. Like
        /// a <code>DataSource</code> for an <code>MLModel</code>, the <code>DataSource</code>
        /// for an <code>Evaluation</code> contains values for the <code>Target Variable</code>.
        /// The <code>Evaluation</code> compares the predicted result for each observation to
        /// the actual outcome and provides a summary so that you know how effective the <code>MLModel</code>
        /// functions on the test data. Evaluation generates a relevant performance metric, such
        /// as BinaryAUC, RegressionRMSE or MulticlassAvgFScore based on the corresponding <code>MLModelType</code>:
        /// <code>BINARY</code>, <code>REGRESSION</code> or <code>MULTICLASS</code>. 
        /// 
        ///  
        /// <para>
        /// <code>CreateEvaluation</code> is an asynchronous operation. In response to <code>CreateEvaluation</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the evaluation status
        /// to <code>PENDING</code>. After the <code>Evaluation</code> is created and ready for
        /// use, Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>GetEvaluation</code> operation to check progress of the evaluation
        /// during the creation operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation service method.</param>
        /// 
        /// <returns>The response from the CreateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateEvaluation">REST API Reference for CreateEvaluation Operation</seealso>
        public virtual CreateEvaluationResponse CreateEvaluation(CreateEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationResponseUnmarshaller.Instance;

            return Invoke<CreateEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateEvaluation">REST API Reference for CreateEvaluation Operation</seealso>
        public virtual IAsyncResult BeginCreateEvaluation(CreateEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEvaluation.</param>
        /// 
        /// <returns>Returns a  CreateEvaluationResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateEvaluation">REST API Reference for CreateEvaluation Operation</seealso>
        public virtual CreateEvaluationResponse EndCreateEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMLModel

        /// <summary>
        /// Creates a new <code>MLModel</code> using the <code>DataSource</code> and the recipe
        /// as information sources. 
        /// 
        ///  
        /// <para>
        /// An <code>MLModel</code> is nearly immutable. Users can update only the <code>MLModelName</code>
        /// and the <code>ScoreThreshold</code> in an <code>MLModel</code> without creating a
        /// new <code>MLModel</code>. 
        /// </para>
        ///  
        /// <para>
        /// <code>CreateMLModel</code> is an asynchronous operation. In response to <code>CreateMLModel</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>MLModel</code>
        /// status to <code>PENDING</code>. After the <code>MLModel</code> has been created and
        /// ready is for use, Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>GetMLModel</code> operation to check the progress of the <code>MLModel</code>
        /// during the creation operation.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateMLModel</code> requires a <code>DataSource</code> with computed statistics,
        /// which can be created by setting <code>ComputeStatistics</code> to <code>true</code>
        /// in <code>CreateDataSourceFromRDS</code>, <code>CreateDataSourceFromS3</code>, or <code>CreateDataSourceFromRedshift</code>
        /// operations. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel service method.</param>
        /// 
        /// <returns>The response from the CreateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateMLModel">REST API Reference for CreateMLModel Operation</seealso>
        public virtual CreateMLModelResponse CreateMLModel(CreateMLModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLModelResponseUnmarshaller.Instance;

            return Invoke<CreateMLModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMLModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateMLModel">REST API Reference for CreateMLModel Operation</seealso>
        public virtual IAsyncResult BeginCreateMLModel(CreateMLModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMLModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMLModel.</param>
        /// 
        /// <returns>Returns a  CreateMLModelResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateMLModel">REST API Reference for CreateMLModel Operation</seealso>
        public virtual CreateMLModelResponse EndCreateMLModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMLModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRealtimeEndpoint

        /// <summary>
        /// Creates a real-time endpoint for the <code>MLModel</code>. The endpoint contains the
        /// URI of the <code>MLModel</code>; that is, the location to send real-time prediction
        /// requests for the specified <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// 
        /// <returns>The response from the CreateRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual CreateRealtimeEndpointResponse CreateRealtimeEndpoint(string mlModelId)
        {
            var request = new CreateRealtimeEndpointRequest();
            request.MLModelId = mlModelId;
            return CreateRealtimeEndpoint(request);
        }


        /// <summary>
        /// Creates a real-time endpoint for the <code>MLModel</code>. The endpoint contains the
        /// URI of the <code>MLModel</code>; that is, the location to send real-time prediction
        /// requests for the specified <code>MLModel</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual CreateRealtimeEndpointResponse CreateRealtimeEndpoint(CreateRealtimeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRealtimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRealtimeEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateRealtimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRealtimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateRealtimeEndpoint(CreateRealtimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRealtimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRealtimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRealtimeEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateRealtimeEndpointResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual CreateRealtimeEndpointResponse EndCreateRealtimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRealtimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBatchPrediction

        /// <summary>
        /// Assigns the DELETED status to a <code>BatchPrediction</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteBatchPrediction</code> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <code>BatchPrediction</code> changed to
        /// DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteBatchPrediction</code> operation is
        /// irreversible.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">A user-supplied ID that uniquely identifies the <code>BatchPrediction</code>.</param>
        /// 
        /// <returns>The response from the DeleteBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual DeleteBatchPredictionResponse DeleteBatchPrediction(string batchPredictionId)
        {
            var request = new DeleteBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            return DeleteBatchPrediction(request);
        }


        /// <summary>
        /// Assigns the DELETED status to a <code>BatchPrediction</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteBatchPrediction</code> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <code>BatchPrediction</code> changed to
        /// DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteBatchPrediction</code> operation is
        /// irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction service method.</param>
        /// 
        /// <returns>The response from the DeleteBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual DeleteBatchPredictionResponse DeleteBatchPrediction(DeleteBatchPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<DeleteBatchPredictionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBatchPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual IAsyncResult BeginDeleteBatchPrediction(DeleteBatchPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBatchPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBatchPrediction.</param>
        /// 
        /// <returns>Returns a  DeleteBatchPredictionResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual DeleteBatchPredictionResponse EndDeleteBatchPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBatchPredictionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The results of the <code>DeleteDataSource</code> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">A user-supplied ID that uniquely identifies the <code>DataSource</code>.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(string dataSourceId)
        {
            var request = new DeleteDataSourceRequest();
            request.DataSourceId = dataSourceId;
            return DeleteDataSource(request);
        }


        /// <summary>
        /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The results of the <code>DeleteDataSource</code> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEvaluation

        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
        /// unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <code>GetEvaluation</code>
        /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteEvaluation</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="evaluationId">A user-supplied ID that uniquely identifies the <code>Evaluation</code> to delete.</param>
        /// 
        /// <returns>The response from the DeleteEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual DeleteEvaluationResponse DeleteEvaluation(string evaluationId)
        {
            var request = new DeleteEvaluationRequest();
            request.EvaluationId = evaluationId;
            return DeleteEvaluation(request);
        }


        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
        /// unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <code>GetEvaluation</code>
        /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteEvaluation</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation service method.</param>
        /// 
        /// <returns>The response from the DeleteEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual DeleteEvaluationResponse DeleteEvaluation(DeleteEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResponseUnmarshaller.Instance;

            return Invoke<DeleteEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual IAsyncResult BeginDeleteEvaluation(DeleteEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvaluation.</param>
        /// 
        /// <returns>Returns a  DeleteEvaluationResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual DeleteEvaluationResponse EndDeleteEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMLModel

        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>MLModel</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteMLModel</code> operation, you can use the <code>GetMLModel</code>
        /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteMLModel</code> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">A user-supplied ID that uniquely identifies the <code>MLModel</code>.</param>
        /// 
        /// <returns>The response from the DeleteMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual DeleteMLModelResponse DeleteMLModel(string mlModelId)
        {
            var request = new DeleteMLModelRequest();
            request.MLModelId = mlModelId;
            return DeleteMLModel(request);
        }


        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>MLModel</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteMLModel</code> operation, you can use the <code>GetMLModel</code>
        /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteMLModel</code> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel service method.</param>
        /// 
        /// <returns>The response from the DeleteMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual DeleteMLModelResponse DeleteMLModel(DeleteMLModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLModelResponseUnmarshaller.Instance;

            return Invoke<DeleteMLModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMLModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteMLModel(DeleteMLModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMLModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMLModel.</param>
        /// 
        /// <returns>Returns a  DeleteMLModelResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual DeleteMLModelResponse EndDeleteMLModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMLModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRealtimeEndpoint

        /// <summary>
        /// Deletes a real time endpoint of an <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// 
        /// <returns>The response from the DeleteRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual DeleteRealtimeEndpointResponse DeleteRealtimeEndpoint(string mlModelId)
        {
            var request = new DeleteRealtimeEndpointRequest();
            request.MLModelId = mlModelId;
            return DeleteRealtimeEndpoint(request);
        }


        /// <summary>
        /// Deletes a real time endpoint of an <code>MLModel</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual DeleteRealtimeEndpointResponse DeleteRealtimeEndpoint(DeleteRealtimeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRealtimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRealtimeEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteRealtimeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRealtimeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteRealtimeEndpoint(DeleteRealtimeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRealtimeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRealtimeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRealtimeEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteRealtimeEndpointResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual DeleteRealtimeEndpointResponse EndDeleteRealtimeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRealtimeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes the specified tags associated with an ML object. After this operation is complete,
        /// you can't recover deleted tags.
        /// 
        ///  
        /// <para>
        /// If you specify a tag that doesn't exist, Amazon ML ignores it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidTagException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBatchPredictions

        /// <summary>
        /// Returns a list of <code>BatchPrediction</code> operations that match the search criteria
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions service method.</param>
        /// 
        /// <returns>The response from the DescribeBatchPredictions service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeBatchPredictions">REST API Reference for DescribeBatchPredictions Operation</seealso>
        public virtual DescribeBatchPredictionsResponse DescribeBatchPredictions(DescribeBatchPredictionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchPredictionsResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchPredictionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBatchPredictions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeBatchPredictions">REST API Reference for DescribeBatchPredictions Operation</seealso>
        public virtual IAsyncResult BeginDescribeBatchPredictions(DescribeBatchPredictionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchPredictionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBatchPredictions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBatchPredictions.</param>
        /// 
        /// <returns>Returns a  DescribeBatchPredictionsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeBatchPredictions">REST API Reference for DescribeBatchPredictions Operation</seealso>
        public virtual DescribeBatchPredictionsResponse EndDescribeBatchPredictions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBatchPredictionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSources

        /// <summary>
        /// Returns a list of <code>DataSource</code> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSources service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeDataSources">REST API Reference for DescribeDataSources Operation</seealso>
        public virtual DescribeDataSourcesResponse DescribeDataSources(DescribeDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeDataSources">REST API Reference for DescribeDataSources Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSources(DescribeDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSources.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourcesResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeDataSources">REST API Reference for DescribeDataSources Operation</seealso>
        public virtual DescribeDataSourcesResponse EndDescribeDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvaluations

        /// <summary>
        /// Returns a list of <code>DescribeEvaluations</code> that match the search criteria
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations service method.</param>
        /// 
        /// <returns>The response from the DescribeEvaluations service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeEvaluations">REST API Reference for DescribeEvaluations Operation</seealso>
        public virtual DescribeEvaluationsResponse DescribeEvaluations(DescribeEvaluationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEvaluationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEvaluationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvaluations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeEvaluations">REST API Reference for DescribeEvaluations Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvaluations(DescribeEvaluationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEvaluationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvaluations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvaluations.</param>
        /// 
        /// <returns>Returns a  DescribeEvaluationsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeEvaluations">REST API Reference for DescribeEvaluations Operation</seealso>
        public virtual DescribeEvaluationsResponse EndDescribeEvaluations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEvaluationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMLModels

        /// <summary>
        /// Returns a list of <code>MLModel</code> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels service method.</param>
        /// 
        /// <returns>The response from the DescribeMLModels service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeMLModels">REST API Reference for DescribeMLModels Operation</seealso>
        public virtual DescribeMLModelsResponse DescribeMLModels(DescribeMLModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMLModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMLModelsResponseUnmarshaller.Instance;

            return Invoke<DescribeMLModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMLModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMLModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeMLModels">REST API Reference for DescribeMLModels Operation</seealso>
        public virtual IAsyncResult BeginDescribeMLModels(DescribeMLModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMLModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMLModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMLModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMLModels.</param>
        /// 
        /// <returns>Returns a  DescribeMLModelsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeMLModels">REST API Reference for DescribeMLModels Operation</seealso>
        public virtual DescribeMLModelsResponse EndDescribeMLModels(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMLModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Describes one or more of the tags for your Amazon ML object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBatchPrediction

        /// <summary>
        /// Returns a <code>BatchPrediction</code> that includes detailed metadata, status, and
        /// data file information for a <code>Batch Prediction</code> request.
        /// </summary>
        /// <param name="batchPredictionId">An ID assigned to the <code>BatchPrediction</code> at creation.</param>
        /// 
        /// <returns>The response from the GetBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual GetBatchPredictionResponse GetBatchPrediction(string batchPredictionId)
        {
            var request = new GetBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            return GetBatchPrediction(request);
        }


        /// <summary>
        /// Returns a <code>BatchPrediction</code> that includes detailed metadata, status, and
        /// data file information for a <code>Batch Prediction</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction service method.</param>
        /// 
        /// <returns>The response from the GetBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual GetBatchPredictionResponse GetBatchPrediction(GetBatchPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<GetBatchPredictionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBatchPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual IAsyncResult BeginGetBatchPrediction(GetBatchPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBatchPrediction.</param>
        /// 
        /// <returns>Returns a  GetBatchPredictionResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual GetBatchPredictionResponse EndGetBatchPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBatchPredictionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(string dataSourceId)
        {
            var request = new GetDataSourceRequest();
            request.DataSourceId = dataSourceId;
            return GetDataSource(request);
        }


        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetDataSource</code> operation should return <code>DataSourceSchema</code>. If true, <code>DataSourceSchema</code> is returned. If false, <code>DataSourceSchema</code> is not returned.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(string dataSourceId, bool verbose)
        {
            var request = new GetDataSourceRequest();
            request.DataSourceId = dataSourceId;
            request.Verbose = verbose;
            return GetDataSource(request);
        }


        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvaluation

        /// <summary>
        /// Returns an <code>Evaluation</code> that includes metadata as well as the current status
        /// of the <code>Evaluation</code>.
        /// </summary>
        /// <param name="evaluationId">The ID of the <code>Evaluation</code> to retrieve. The evaluation of each <code>MLModel</code> is recorded and cataloged. The ID provides the means to access the information. </param>
        /// 
        /// <returns>The response from the GetEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual GetEvaluationResponse GetEvaluation(string evaluationId)
        {
            var request = new GetEvaluationRequest();
            request.EvaluationId = evaluationId;
            return GetEvaluation(request);
        }


        /// <summary>
        /// Returns an <code>Evaluation</code> that includes metadata as well as the current status
        /// of the <code>Evaluation</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation service method.</param>
        /// 
        /// <returns>The response from the GetEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual GetEvaluationResponse GetEvaluation(GetEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationResponseUnmarshaller.Instance;

            return Invoke<GetEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual IAsyncResult BeginGetEvaluation(GetEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvaluation.</param>
        /// 
        /// <returns>Returns a  GetEvaluationResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual GetEvaluationResponse EndGetEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLModel

        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
        /// and the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual GetMLModelResponse GetMLModel(string mlModelId)
        {
            var request = new GetMLModelRequest();
            request.MLModelId = mlModelId;
            return GetMLModel(request);
        }


        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
        /// and the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetMLModel</code> operation should return <code>Recipe</code>. If true, <code>Recipe</code> is returned. If false, <code>Recipe</code> is not returned.</param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual GetMLModelResponse GetMLModel(string mlModelId, bool verbose)
        {
            var request = new GetMLModelRequest();
            request.MLModelId = mlModelId;
            request.Verbose = verbose;
            return GetMLModel(request);
        }


        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
        /// and the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel service method.</param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual GetMLModelResponse GetMLModel(GetMLModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelResponseUnmarshaller.Instance;

            return Invoke<GetMLModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual IAsyncResult BeginGetMLModel(GetMLModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLModel.</param>
        /// 
        /// <returns>Returns a  GetMLModelResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual GetMLModelResponse EndGetMLModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLModelResponse>(asyncResult);
        }

        #endregion
        
        #region  Predict

        /// <summary>
        /// Generates a prediction for the observation using the specified <code>ML Model</code>.
        /// 
        ///  <note><title>Note</title> 
        /// <para>
        /// Not all response parameters will be populated. Whether a response parameter is populated
        /// depends on the type of model requested.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="mlModelId">A unique identifier of the <code>MLModel</code>.</param>
        /// <param name="predictEndpoint">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="record">A property of PredictRequest used to execute the Predict service method.</param>
        /// 
        /// <returns>The response from the Predict service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual PredictResponse Predict(string mlModelId, string predictEndpoint, Dictionary<string, string> record)
        {
            var request = new PredictRequest();
            request.MLModelId = mlModelId;
            request.PredictEndpoint = predictEndpoint;
            request.Record = record;
            return Predict(request);
        }


        /// <summary>
        /// Generates a prediction for the observation using the specified <code>ML Model</code>.
        /// 
        ///  <note><title>Note</title> 
        /// <para>
        /// Not all response parameters will be populated. Whether a response parameter is populated
        /// depends on the type of model requested.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Predict service method.</param>
        /// 
        /// <returns>The response from the Predict service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual PredictResponse Predict(PredictRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictResponseUnmarshaller.Instance;

            return Invoke<PredictResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Predict operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Predict operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPredict
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual IAsyncResult BeginPredict(PredictRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Predict operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPredict.</param>
        /// 
        /// <returns>Returns a  PredictResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual PredictResponse EndPredict(IAsyncResult asyncResult)
        {
            return EndInvoke<PredictResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBatchPrediction

        /// <summary>
        /// Updates the <code>BatchPredictionName</code> of a <code>BatchPrediction</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetBatchPrediction</code> operation to view the contents of
        /// the updated data element.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">The ID assigned to the <code>BatchPrediction</code> during creation.</param>
        /// <param name="batchPredictionName">A new user-supplied name or description of the <code>BatchPrediction</code>.</param>
        /// 
        /// <returns>The response from the UpdateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual UpdateBatchPredictionResponse UpdateBatchPrediction(string batchPredictionId, string batchPredictionName)
        {
            var request = new UpdateBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            request.BatchPredictionName = batchPredictionName;
            return UpdateBatchPrediction(request);
        }


        /// <summary>
        /// Updates the <code>BatchPredictionName</code> of a <code>BatchPrediction</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetBatchPrediction</code> operation to view the contents of
        /// the updated data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction service method.</param>
        /// 
        /// <returns>The response from the UpdateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual UpdateBatchPredictionResponse UpdateBatchPrediction(UpdateBatchPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<UpdateBatchPredictionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBatchPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual IAsyncResult BeginUpdateBatchPrediction(UpdateBatchPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBatchPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBatchPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBatchPrediction.</param>
        /// 
        /// <returns>Returns a  UpdateBatchPredictionResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual UpdateBatchPredictionResponse EndUpdateBatchPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBatchPredictionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates the <code>DataSourceName</code> of a <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetDataSource</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> during creation.</param>
        /// <param name="dataSourceName">A new user-supplied name or description of the <code>DataSource</code> that will replace the current description. </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(string dataSourceId, string dataSourceName)
        {
            var request = new UpdateDataSourceRequest();
            request.DataSourceId = dataSourceId;
            request.DataSourceName = dataSourceName;
            return UpdateDataSource(request);
        }


        /// <summary>
        /// Updates the <code>DataSourceName</code> of a <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetDataSource</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEvaluation

        /// <summary>
        /// Updates the <code>EvaluationName</code> of an <code>Evaluation</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetEvaluation</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="evaluationId">The ID assigned to the <code>Evaluation</code> during creation.</param>
        /// <param name="evaluationName">A new user-supplied name or description of the <code>Evaluation</code> that will replace the current content. </param>
        /// 
        /// <returns>The response from the UpdateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual UpdateEvaluationResponse UpdateEvaluation(string evaluationId, string evaluationName)
        {
            var request = new UpdateEvaluationRequest();
            request.EvaluationId = evaluationId;
            request.EvaluationName = evaluationName;
            return UpdateEvaluation(request);
        }


        /// <summary>
        /// Updates the <code>EvaluationName</code> of an <code>Evaluation</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetEvaluation</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation service method.</param>
        /// 
        /// <returns>The response from the UpdateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual UpdateEvaluationResponse UpdateEvaluation(UpdateEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEvaluationResponseUnmarshaller.Instance;

            return Invoke<UpdateEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual IAsyncResult BeginUpdateEvaluation(UpdateEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEvaluation.</param>
        /// 
        /// <returns>Returns a  UpdateEvaluationResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual UpdateEvaluationResponse EndUpdateEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMLModel

        /// <summary>
        /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetMLModel</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// <param name="mlModelName">A user-supplied name or description of the <code>MLModel</code>.</param>
        /// <param name="scoreThreshold">The <code>ScoreThreshold</code> used in binary classification <code>MLModel</code> that marks the boundary between a positive prediction and a negative prediction. Output values greater than or equal to the <code>ScoreThreshold</code> receive a positive result from the <code>MLModel</code>, such as <code>true</code>. Output values less than the <code>ScoreThreshold</code> receive a negative response from the <code>MLModel</code>, such as <code>false</code>.</param>
        /// 
        /// <returns>The response from the UpdateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual UpdateMLModelResponse UpdateMLModel(string mlModelId, string mlModelName, float scoreThreshold)
        {
            var request = new UpdateMLModelRequest();
            request.MLModelId = mlModelId;
            request.MLModelName = mlModelName;
            request.ScoreThreshold = scoreThreshold;
            return UpdateMLModel(request);
        }


        /// <summary>
        /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetMLModel</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel service method.</param>
        /// 
        /// <returns>The response from the UpdateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual UpdateMLModelResponse UpdateMLModel(UpdateMLModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLModelResponseUnmarshaller.Instance;

            return Invoke<UpdateMLModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel operation on AmazonMachineLearningClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMLModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateMLModel(UpdateMLModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMLModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMLModel.</param>
        /// 
        /// <returns>Returns a  UpdateMLModelResult from MachineLearning.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual UpdateMLModelResponse EndUpdateMLModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMLModelResponse>(asyncResult);
        }

        #endregion
        
    }
}