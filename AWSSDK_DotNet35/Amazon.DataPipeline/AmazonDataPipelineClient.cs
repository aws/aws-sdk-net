/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.DataPipeline.Model;
using Amazon.DataPipeline.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.DataPipeline
{
    /// <summary>
    /// Implementation for accessing AmazonDataPipeline.
    ///  
    /// <para> This is the <i>AWS Data Pipeline API Reference</i> . This guide provides descriptions and samples of the AWS Data Pipeline API.
    /// </para> <para> AWS Data Pipeline is a web service that configures and manages a data-driven workflow called a pipeline. AWS Data Pipeline
    /// handles the details of scheduling and ensuring that data dependencies are met so your application can focus on processing the data.</para>
    /// <para> The AWS Data Pipeline API implements two main sets of functionality. The first set of actions configure the pipeline in the web
    /// service. You call these actions to create a pipeline and define data sources, schedules, dependencies, and the transforms to be performed on
    /// the data. </para> <para> The second set of actions are used by a task runner application that calls the AWS Data Pipeline API to receive the
    /// next task ready for processing. The logic for performing the task, such as querying the data, running data analysis, or converting the data
    /// from one format to another, is contained within the task runner. The task runner performs the task assigned to it by the web service,
    /// reporting progress to the web service as it does so. When the task is done, the task runner reports the final success or failure of the task
    /// to the web service. </para> <para> AWS Data Pipeline provides an open-source implementation of a task runner called AWS Data Pipeline Task
    /// Runner. AWS Data Pipeline Task Runner provides logic for common data management scenarios, such as performing database queries and running
    /// data analysis using Amazon Elastic MapReduce (Amazon EMR). You can use AWS Data Pipeline Task Runner as your task runner, or you can write
    /// your own task runner to provide custom data management. </para> <para> The AWS Data Pipeline API uses the Signature Version 4 protocol for
    /// signing requests. For more information about how to sign a request with this protocol, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html" >Signature Version 4 Signing Process</a> . In the code examples
    /// in this reference, the Signature Version 4 Request parameters are represented as AuthParams. </para>
    /// </summary>
    public partial class AmazonDataPipelineClient : AmazonWebServiceClient, IAmazonDataPipeline
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDataPipelineClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataPipelineConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataPipelineConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDataPipeline Configuration Object</param>
        public AmazonDataPipelineClient(AmazonDataPipelineConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataPipelineClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataPipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials and an
        /// AmazonDataPipelineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(AWSCredentials credentials, AmazonDataPipelineConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataPipelineConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataPipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataPipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataPipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataPipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataPipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region ActivatePipeline

        /// <summary>
        /// <para> Validates a pipeline and initiates processing. If the pipeline does not pass validation, activation fails. </para> <para> Call this
        /// action to start processing pipeline tasks of a pipeline you've created using the CreatePipeline and PutPipelineDefinition actions. A
        /// pipeline cannot be modified after it has been successfully activated. </para>
        /// </summary>
        /// 
        /// <param name="activatePipelineRequest">Container for the necessary parameters to execute the ActivatePipeline service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public ActivatePipelineResponse ActivatePipeline(ActivatePipelineRequest activatePipelineRequest)
        {
            IAsyncResult asyncResult = invokeActivatePipeline(activatePipelineRequest, null, null, true);
            return EndActivatePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ActivatePipeline"/>
        /// </summary>
        /// 
        /// <param name="activatePipelineRequest">Container for the necessary parameters to execute the ActivatePipeline operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginActivatePipeline(ActivatePipelineRequest activatePipelineRequest, AsyncCallback callback, object state)
        {
            return invokeActivatePipeline(activatePipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ActivatePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivatePipeline.</param>
        /// 
        /// <returns>Returns a ActivatePipelineResult from AmazonDataPipeline.</returns>
        public ActivatePipelineResponse EndActivatePipeline(IAsyncResult asyncResult)
        {
            return endOperation<ActivatePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeActivatePipeline(ActivatePipelineRequest activatePipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ActivatePipelineRequestMarshaller().Marshall(activatePipelineRequest);
            var unmarshaller = ActivatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreatePipeline

        /// <summary>
        /// <para>Creates a new empty pipeline. When this action succeeds, you can then use the PutPipelineDefinition action to populate the
        /// pipeline.</para>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest createPipelineRequest)
        {
            IAsyncResult asyncResult = invokeCreatePipeline(createPipelineRequest, null, null, true);
            return EndCreatePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginCreatePipeline(CreatePipelineRequest createPipelineRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePipeline(createPipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a CreatePipelineResult from AmazonDataPipeline.</returns>
        public CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return endOperation<CreatePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePipeline(CreatePipelineRequest createPipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePipelineRequestMarshaller().Marshall(createPipelineRequest);
            var unmarshaller = CreatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeletePipeline

        /// <summary>
        /// <para> Permanently deletes a pipeline, its pipeline definition and its run history. You cannot query or restore a deleted pipeline. AWS Data
        /// Pipeline will attempt to cancel instances associated with the pipeline that are currently being processed by task runners. Deleting a
        /// pipeline cannot be undone. </para> <para> To temporarily pause a pipeline instead of deleting it, call SetStatus with the status set to
        /// Pause on individual components. Components that are paused by SetStatus can be resumed. </para>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest deletePipelineRequest)
        {
            IAsyncResult asyncResult = invokeDeletePipeline(deletePipelineRequest, null, null, true);
            return EndDeletePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeletePipeline(DeletePipelineRequest deletePipelineRequest, AsyncCallback callback, object state)
        {
            return invokeDeletePipeline(deletePipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        public DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return endOperation<DeletePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeletePipeline(DeletePipelineRequest deletePipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePipelineRequestMarshaller().Marshall(deletePipelineRequest);
            var unmarshaller = DeletePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeObjects

        /// <summary>
        /// <para> Returns the object definitions for a set of objects associated with the pipeline. Object definitions are composed of a set of fields
        /// that define the properties of the object. </para>
        /// </summary>
        /// 
        /// <param name="describeObjectsRequest">Container for the necessary parameters to execute the DescribeObjects service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest describeObjectsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeObjects(describeObjectsRequest, null, null, true);
            return EndDescribeObjects(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribeObjects"/>
        /// </summary>
        /// 
        /// <param name="describeObjectsRequest">Container for the necessary parameters to execute the DescribeObjects operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObjects
        ///         operation.</returns>
        public IAsyncResult BeginDescribeObjects(DescribeObjectsRequest describeObjectsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeObjects(describeObjectsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribeObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObjects.</param>
        /// 
        /// <returns>Returns a DescribeObjectsResult from AmazonDataPipeline.</returns>
        public DescribeObjectsResponse EndDescribeObjects(IAsyncResult asyncResult)
        {
            return endOperation<DescribeObjectsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeObjects(DescribeObjectsRequest describeObjectsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeObjectsRequestMarshaller().Marshall(describeObjectsRequest);
            var unmarshaller = DescribeObjectsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribePipelines

        /// <summary>
        /// <para> Retrieve metadata about one or more pipelines. The information retrieved includes the name of the pipeline, the pipeline identifier,
        /// its current state, and the user account that owns the pipeline. Using account credentials, you can retrieve metadata about pipelines that
        /// you or your IAM users have created. If you are using an IAM user account, you can retrieve metadata about only those pipelines you have read
        /// permission for. </para> <para> To retrieve the full pipeline definition instead of metadata about the pipeline, call the
        /// GetPipelineDefinition action. </para>
        /// </summary>
        /// 
        /// <param name="describePipelinesRequest">Container for the necessary parameters to execute the DescribePipelines service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest describePipelinesRequest)
        {
            IAsyncResult asyncResult = invokeDescribePipelines(describePipelinesRequest, null, null, true);
            return EndDescribePipelines(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribePipelines"/>
        /// </summary>
        /// 
        /// <param name="describePipelinesRequest">Container for the necessary parameters to execute the DescribePipelines operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipelines
        ///         operation.</returns>
        public IAsyncResult BeginDescribePipelines(DescribePipelinesRequest describePipelinesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribePipelines(describePipelinesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribePipelines"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipelines.</param>
        /// 
        /// <returns>Returns a DescribePipelinesResult from AmazonDataPipeline.</returns>
        public DescribePipelinesResponse EndDescribePipelines(IAsyncResult asyncResult)
        {
            return endOperation<DescribePipelinesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribePipelines(DescribePipelinesRequest describePipelinesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePipelinesRequestMarshaller().Marshall(describePipelinesRequest);
            var unmarshaller = DescribePipelinesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EvaluateExpression

        /// <summary>
        /// <para>Evaluates a string in the context of a specified object. A task runner can use this action to evaluate SQL queries stored in Amazon
        /// S3. </para>
        /// </summary>
        /// 
        /// <param name="evaluateExpressionRequest">Container for the necessary parameters to execute the EvaluateExpression service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="TaskNotFoundException"/>
        /// <exception cref="PipelineDeletedException"/>
        public EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest evaluateExpressionRequest)
        {
            IAsyncResult asyncResult = invokeEvaluateExpression(evaluateExpressionRequest, null, null, true);
            return EndEvaluateExpression(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.EvaluateExpression"/>
        /// </summary>
        /// 
        /// <param name="evaluateExpressionRequest">Container for the necessary parameters to execute the EvaluateExpression operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEvaluateExpression operation.</returns>
        public IAsyncResult BeginEvaluateExpression(EvaluateExpressionRequest evaluateExpressionRequest, AsyncCallback callback, object state)
        {
            return invokeEvaluateExpression(evaluateExpressionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.EvaluateExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateExpression.</param>
        /// 
        /// <returns>Returns a EvaluateExpressionResult from AmazonDataPipeline.</returns>
        public EvaluateExpressionResponse EndEvaluateExpression(IAsyncResult asyncResult)
        {
            return endOperation<EvaluateExpressionResponse>(asyncResult);
        }
        
        IAsyncResult invokeEvaluateExpression(EvaluateExpressionRequest evaluateExpressionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EvaluateExpressionRequestMarshaller().Marshall(evaluateExpressionRequest);
            var unmarshaller = EvaluateExpressionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetPipelineDefinition

        /// <summary>
        /// <para>Returns the definition of the specified pipeline. You can call GetPipelineDefinition to retrieve the pipeline definition you provided
        /// using PutPipelineDefinition.</para>
        /// </summary>
        /// 
        /// <param name="getPipelineDefinitionRequest">Container for the necessary parameters to execute the GetPipelineDefinition service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest getPipelineDefinitionRequest)
        {
            IAsyncResult asyncResult = invokeGetPipelineDefinition(getPipelineDefinitionRequest, null, null, true);
            return EndGetPipelineDefinition(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.GetPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="getPipelineDefinitionRequest">Container for the necessary parameters to execute the GetPipelineDefinition operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetPipelineDefinition operation.</returns>
        public IAsyncResult BeginGetPipelineDefinition(GetPipelineDefinitionRequest getPipelineDefinitionRequest, AsyncCallback callback, object state)
        {
            return invokeGetPipelineDefinition(getPipelineDefinitionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.GetPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineDefinition.</param>
        /// 
        /// <returns>Returns a GetPipelineDefinitionResult from AmazonDataPipeline.</returns>
        public GetPipelineDefinitionResponse EndGetPipelineDefinition(IAsyncResult asyncResult)
        {
            return endOperation<GetPipelineDefinitionResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetPipelineDefinition(GetPipelineDefinitionRequest getPipelineDefinitionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetPipelineDefinitionRequestMarshaller().Marshall(getPipelineDefinitionRequest);
            var unmarshaller = GetPipelineDefinitionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListPipelines

        /// <summary>
        /// <para>Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned only for pipelines you have permission to
        /// access. </para>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest listPipelinesRequest)
        {
            IAsyncResult asyncResult = invokeListPipelines(listPipelinesRequest, null, null, true);
            return EndListPipelines(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        public IAsyncResult BeginListPipelines(ListPipelinesRequest listPipelinesRequest, AsyncCallback callback, object state)
        {
            return invokeListPipelines(listPipelinesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a ListPipelinesResult from AmazonDataPipeline.</returns>
        public ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return endOperation<ListPipelinesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListPipelines(ListPipelinesRequest listPipelinesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPipelinesRequestMarshaller().Marshall(listPipelinesRequest);
            var unmarshaller = ListPipelinesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned only for pipelines you have permission to
        /// access. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }
        

        #endregion
    
        #region PollForTask

        /// <summary>
        /// <para> Task runners call this action to receive a task to perform from AWS Data Pipeline. The task runner specifies which tasks it can
        /// perform by setting a value for the workerGroup parameter of the PollForTask call. The task returned by PollForTask may come from any of the
        /// pipelines that match the workerGroup value passed in by the task runner and that was launched using the IAM user credentials specified by
        /// the task runner. </para> <para> If tasks are ready in the work queue, PollForTask returns a response immediately. If no tasks are available
        /// in the queue, PollForTask uses long-polling and holds on to a poll connection for up to a 90 seconds during which time the first newly
        /// scheduled task is handed to the task runner. To accomodate this, set the socket timeout in your task runner to 90 seconds. The task runner
        /// should not call PollForTask again on the same <c>workerGroup</c> until it receives a response, and this may take up to 90 seconds. </para>
        /// </summary>
        /// 
        /// <param name="pollForTaskRequest">Container for the necessary parameters to execute the PollForTask service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="TaskNotFoundException"/>
        public PollForTaskResponse PollForTask(PollForTaskRequest pollForTaskRequest)
        {
            IAsyncResult asyncResult = invokePollForTask(pollForTaskRequest, null, null, true);
            return EndPollForTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PollForTask"/>
        /// </summary>
        /// 
        /// <param name="pollForTaskRequest">Container for the necessary parameters to execute the PollForTask operation on AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForTask
        ///         operation.</returns>
        public IAsyncResult BeginPollForTask(PollForTaskRequest pollForTaskRequest, AsyncCallback callback, object state)
        {
            return invokePollForTask(pollForTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PollForTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForTask.</param>
        /// 
        /// <returns>Returns a PollForTaskResult from AmazonDataPipeline.</returns>
        public PollForTaskResponse EndPollForTask(IAsyncResult asyncResult)
        {
            return endOperation<PollForTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokePollForTask(PollForTaskRequest pollForTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PollForTaskRequestMarshaller().Marshall(pollForTaskRequest);
            var unmarshaller = PollForTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutPipelineDefinition

        /// <summary>
        /// <para>Adds tasks, schedules, and preconditions that control the behavior of the pipeline. You can use PutPipelineDefinition to populate a
        /// new pipeline. </para> <para> PutPipelineDefinition also validates the configuration as it adds it to the pipeline. Changes to the pipeline
        /// are saved unless one of the following three validation errors exists in the pipeline. <ol> <li>An object is missing a name or identifier
        /// field.</li>
        /// <li>A string or reference field is empty.</li>
        /// <li>The number of objects in the pipeline exceeds the maximum allowed objects.</li>
        /// </ol> </para> <para> Pipeline object definitions are passed to the PutPipelineDefinition action and returned by the GetPipelineDefinition
        /// action. </para>
        /// </summary>
        /// 
        /// <param name="putPipelineDefinitionRequest">Container for the necessary parameters to execute the PutPipelineDefinition service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest putPipelineDefinitionRequest)
        {
            IAsyncResult asyncResult = invokePutPipelineDefinition(putPipelineDefinitionRequest, null, null, true);
            return EndPutPipelineDefinition(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PutPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="putPipelineDefinitionRequest">Container for the necessary parameters to execute the PutPipelineDefinition operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPutPipelineDefinition operation.</returns>
        public IAsyncResult BeginPutPipelineDefinition(PutPipelineDefinitionRequest putPipelineDefinitionRequest, AsyncCallback callback, object state)
        {
            return invokePutPipelineDefinition(putPipelineDefinitionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PutPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPipelineDefinition.</param>
        /// 
        /// <returns>Returns a PutPipelineDefinitionResult from AmazonDataPipeline.</returns>
        public PutPipelineDefinitionResponse EndPutPipelineDefinition(IAsyncResult asyncResult)
        {
            return endOperation<PutPipelineDefinitionResponse>(asyncResult);
        }
        
        IAsyncResult invokePutPipelineDefinition(PutPipelineDefinitionRequest putPipelineDefinitionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutPipelineDefinitionRequestMarshaller().Marshall(putPipelineDefinitionRequest);
            var unmarshaller = PutPipelineDefinitionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region QueryObjects

        /// <summary>
        /// <para>Queries a pipeline for the names of objects that match a specified set of conditions.</para> <para>The objects returned by
        /// QueryObjects are paginated and then filtered by the value you set for query. This means the action may return an empty result set with a
        /// value set for marker. If <c>HasMoreResults</c> is set to <c>True</c> , you should continue to call QueryObjects, passing in the returned
        /// value for marker, until <c>HasMoreResults</c> returns <c>False</c> .</para>
        /// </summary>
        /// 
        /// <param name="queryObjectsRequest">Container for the necessary parameters to execute the QueryObjects service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public QueryObjectsResponse QueryObjects(QueryObjectsRequest queryObjectsRequest)
        {
            IAsyncResult asyncResult = invokeQueryObjects(queryObjectsRequest, null, null, true);
            return EndQueryObjects(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.QueryObjects"/>
        /// </summary>
        /// 
        /// <param name="queryObjectsRequest">Container for the necessary parameters to execute the QueryObjects operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryObjects
        ///         operation.</returns>
        public IAsyncResult BeginQueryObjects(QueryObjectsRequest queryObjectsRequest, AsyncCallback callback, object state)
        {
            return invokeQueryObjects(queryObjectsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.QueryObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryObjects.</param>
        /// 
        /// <returns>Returns a QueryObjectsResult from AmazonDataPipeline.</returns>
        public QueryObjectsResponse EndQueryObjects(IAsyncResult asyncResult)
        {
            return endOperation<QueryObjectsResponse>(asyncResult);
        }
        
        IAsyncResult invokeQueryObjects(QueryObjectsRequest queryObjectsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new QueryObjectsRequestMarshaller().Marshall(queryObjectsRequest);
            var unmarshaller = QueryObjectsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReportTaskProgress

        /// <summary>
        /// <para> Updates the AWS Data Pipeline service on the progress of the calling task runner. When the task runner is assigned a task, it should
        /// call ReportTaskProgress to acknowledge that it has the task within 2 minutes. If the web service does not recieve this acknowledgement
        /// within the 2 minute window, it will assign the task in a subsequent PollForTask call. After this initial acknowledgement, the task runner
        /// only needs to report progress every 15 minutes to maintain its ownership of the task. You can change this reporting time from 15 minutes by
        /// specifying a <c>reportProgressTimeout</c> field in your pipeline. If a task runner does not report its status after 5 minutes, AWS Data
        /// Pipeline will assume that the task runner is unable to process the task and will reassign the task in a subsequent response to PollForTask.
        /// task runners should call ReportTaskProgress every 60 seconds. </para>
        /// </summary>
        /// 
        /// <param name="reportTaskProgressRequest">Container for the necessary parameters to execute the ReportTaskProgress service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="TaskNotFoundException"/>
        /// <exception cref="PipelineDeletedException"/>
        public ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest reportTaskProgressRequest)
        {
            IAsyncResult asyncResult = invokeReportTaskProgress(reportTaskProgressRequest, null, null, true);
            return EndReportTaskProgress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskProgress"/>
        /// </summary>
        /// 
        /// <param name="reportTaskProgressRequest">Container for the necessary parameters to execute the ReportTaskProgress operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReportTaskProgress operation.</returns>
        public IAsyncResult BeginReportTaskProgress(ReportTaskProgressRequest reportTaskProgressRequest, AsyncCallback callback, object state)
        {
            return invokeReportTaskProgress(reportTaskProgressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskProgress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportTaskProgress.</param>
        /// 
        /// <returns>Returns a ReportTaskProgressResult from AmazonDataPipeline.</returns>
        public ReportTaskProgressResponse EndReportTaskProgress(IAsyncResult asyncResult)
        {
            return endOperation<ReportTaskProgressResponse>(asyncResult);
        }
        
        IAsyncResult invokeReportTaskProgress(ReportTaskProgressRequest reportTaskProgressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReportTaskProgressRequestMarshaller().Marshall(reportTaskProgressRequest);
            var unmarshaller = ReportTaskProgressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReportTaskRunnerHeartbeat

        /// <summary>
        /// <para>Task runners call ReportTaskRunnerHeartbeat every 15 minutes to indicate that they are operational. In the case of AWS Data Pipeline
        /// Task Runner launched on a resource managed by AWS Data Pipeline, the web service can use this call to detect when the task runner
        /// application has failed and restart a new instance.</para>
        /// </summary>
        /// 
        /// <param name="reportTaskRunnerHeartbeatRequest">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service
        ///          method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        public ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest reportTaskRunnerHeartbeatRequest)
        {
            IAsyncResult asyncResult = invokeReportTaskRunnerHeartbeat(reportTaskRunnerHeartbeatRequest, null, null, true);
            return EndReportTaskRunnerHeartbeat(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskRunnerHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="reportTaskRunnerHeartbeatRequest">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReportTaskRunnerHeartbeat operation.</returns>
        public IAsyncResult BeginReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest reportTaskRunnerHeartbeatRequest, AsyncCallback callback, object state)
        {
            return invokeReportTaskRunnerHeartbeat(reportTaskRunnerHeartbeatRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskRunnerHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportTaskRunnerHeartbeat.</param>
        /// 
        /// <returns>Returns a ReportTaskRunnerHeartbeatResult from AmazonDataPipeline.</returns>
        public ReportTaskRunnerHeartbeatResponse EndReportTaskRunnerHeartbeat(IAsyncResult asyncResult)
        {
            return endOperation<ReportTaskRunnerHeartbeatResponse>(asyncResult);
        }
        
        IAsyncResult invokeReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest reportTaskRunnerHeartbeatRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReportTaskRunnerHeartbeatRequestMarshaller().Marshall(reportTaskRunnerHeartbeatRequest);
            var unmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetStatus

        /// <summary>
        /// <para>Requests that the status of an array of physical or logical pipeline objects be updated in the pipeline. This update may not occur
        /// immediately, but is eventually consistent. The status that can be set depends on the type of object.</para>
        /// </summary>
        /// 
        /// <param name="setStatusRequest">Container for the necessary parameters to execute the SetStatus service method on AmazonDataPipeline.</param>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public SetStatusResponse SetStatus(SetStatusRequest setStatusRequest)
        {
            IAsyncResult asyncResult = invokeSetStatus(setStatusRequest, null, null, true);
            return EndSetStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetStatus"/>
        /// </summary>
        /// 
        /// <param name="setStatusRequest">Container for the necessary parameters to execute the SetStatus operation on AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetStatus(SetStatusRequest setStatusRequest, AsyncCallback callback, object state)
        {
            return invokeSetStatus(setStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetStatus.</param>
        public SetStatusResponse EndSetStatus(IAsyncResult asyncResult)
        {
            return endOperation<SetStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetStatus(SetStatusRequest setStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetStatusRequestMarshaller().Marshall(setStatusRequest);
            var unmarshaller = SetStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetTaskStatus

        /// <summary>
        /// <para> Notifies AWS Data Pipeline that a task is completed and provides information about the final status. The task runner calls this
        /// action regardless of whether the task was sucessful. The task runner does not need to call SetTaskStatus for tasks that are canceled by the
        /// web service during a call to ReportTaskProgress. </para>
        /// </summary>
        /// 
        /// <param name="setTaskStatusRequest">Container for the necessary parameters to execute the SetTaskStatus service method on
        ///          AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="TaskNotFoundException"/>
        /// <exception cref="PipelineDeletedException"/>
        public SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest setTaskStatusRequest)
        {
            IAsyncResult asyncResult = invokeSetTaskStatus(setTaskStatusRequest, null, null, true);
            return EndSetTaskStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetTaskStatus"/>
        /// </summary>
        /// 
        /// <param name="setTaskStatusRequest">Container for the necessary parameters to execute the SetTaskStatus operation on
        ///          AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTaskStatus
        ///         operation.</returns>
        public IAsyncResult BeginSetTaskStatus(SetTaskStatusRequest setTaskStatusRequest, AsyncCallback callback, object state)
        {
            return invokeSetTaskStatus(setTaskStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetTaskStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTaskStatus.</param>
        /// 
        /// <returns>Returns a SetTaskStatusResult from AmazonDataPipeline.</returns>
        public SetTaskStatusResponse EndSetTaskStatus(IAsyncResult asyncResult)
        {
            return endOperation<SetTaskStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetTaskStatus(SetTaskStatusRequest setTaskStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTaskStatusRequestMarshaller().Marshall(setTaskStatusRequest);
            var unmarshaller = SetTaskStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ValidatePipelineDefinition

        /// <summary>
        /// <para>Tests the pipeline definition with a set of validation checks to ensure that it is well formed and can run without error. </para>
        /// </summary>
        /// 
        /// <param name="validatePipelineDefinitionRequest">Container for the necessary parameters to execute the ValidatePipelineDefinition service
        ///          method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="PipelineNotFoundException"/>
        /// <exception cref="InternalServiceErrorException"/>
        /// <exception cref="InvalidRequestException"/>
        /// <exception cref="PipelineDeletedException"/>
        public ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest)
        {
            IAsyncResult asyncResult = invokeValidatePipelineDefinition(validatePipelineDefinitionRequest, null, null, true);
            return EndValidatePipelineDefinition(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ValidatePipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="validatePipelineDefinitionRequest">Container for the necessary parameters to execute the ValidatePipelineDefinition operation
        ///          on AmazonDataPipeline.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndValidatePipelineDefinition operation.</returns>
        public IAsyncResult BeginValidatePipelineDefinition(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest, AsyncCallback callback, object state)
        {
            return invokeValidatePipelineDefinition(validatePipelineDefinitionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ValidatePipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidatePipelineDefinition.</param>
        /// 
        /// <returns>Returns a ValidatePipelineDefinitionResult from AmazonDataPipeline.</returns>
        public ValidatePipelineDefinitionResponse EndValidatePipelineDefinition(IAsyncResult asyncResult)
        {
            return endOperation<ValidatePipelineDefinitionResponse>(asyncResult);
        }
        
        IAsyncResult invokeValidatePipelineDefinition(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ValidatePipelineDefinitionRequestMarshaller().Marshall(validatePipelineDefinitionRequest);
            var unmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
