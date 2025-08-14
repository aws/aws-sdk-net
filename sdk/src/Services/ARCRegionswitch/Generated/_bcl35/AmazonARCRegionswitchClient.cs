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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ARCRegionswitch.Model;
using Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations;
using Amazon.ARCRegionswitch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ARCRegionswitch
{
    /// <summary>
    /// <para>Implementation for accessing ARCRegionswitch</para>
    ///
    /// Amazon Application Recovery Controller (ARC) Region switch helps you to quickly and
    /// reliably shift traffic away from an impaired Amazon Web Services Region to a healthy
    /// Region. With Region switch, you can create plans that define the steps to shift traffic
    /// for your application from one Amazon Web Services Region to another. You can test
    /// your plans in practice mode before using them in a real recovery scenario.
    /// 
    ///  
    /// <para>
    /// Region switch provides a structured approach to multi-Region failover, helping you
    /// to meet your recovery time objectives (RTOs) and maintain business continuity during
    /// regional disruptions.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/region-switch.html">Region
    /// switch in ARC</a> in the <i>Amazon Application Recovery Controller User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonARCRegionswitchClient : AmazonServiceClient, IAmazonARCRegionswitch
    {
        private static IServiceMetadata serviceMetadata = new AmazonARCRegionswitchMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IARCRegionswitchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IARCRegionswitchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ARCRegionswitchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        public AmazonARCRegionswitchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonARCRegionswitchConfig()) { }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        public AmazonARCRegionswitchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonARCRegionswitchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(AmazonARCRegionswitchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials)
            : this(credentials, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonARCRegionswitchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials and an
        /// AmazonARCRegionswitchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials, AmazonARCRegionswitchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCRegionswitchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCRegionswitchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonARCRegionswitchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCRegionswitchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCRegionswitchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonARCRegionswitchConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCRegionswitchEndpointResolver());
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


        #region  ApprovePlanExecutionStep

        /// <summary>
        /// Approves a step in a plan execution that requires manual approval. When you create
        /// a plan, you can include approval steps that require manual intervention before the
        /// execution can proceed. This operation allows you to provide that approval.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN, execution ID, step name, and approval status. You can
        /// also provide an optional comment explaining the approval decision.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApprovePlanExecutionStep service method.</param>
        /// 
        /// <returns>The response from the ApprovePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ApprovePlanExecutionStep">REST API Reference for ApprovePlanExecutionStep Operation</seealso>
        public virtual ApprovePlanExecutionStepResponse ApprovePlanExecutionStep(ApprovePlanExecutionStepRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApprovePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePlanExecutionStepResponseUnmarshaller.Instance;

            return Invoke<ApprovePlanExecutionStepResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApprovePlanExecutionStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApprovePlanExecutionStep operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApprovePlanExecutionStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ApprovePlanExecutionStep">REST API Reference for ApprovePlanExecutionStep Operation</seealso>
        public virtual IAsyncResult BeginApprovePlanExecutionStep(ApprovePlanExecutionStepRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApprovePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePlanExecutionStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApprovePlanExecutionStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApprovePlanExecutionStep.</param>
        /// 
        /// <returns>Returns a  ApprovePlanExecutionStepResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ApprovePlanExecutionStep">REST API Reference for ApprovePlanExecutionStep Operation</seealso>
        public virtual ApprovePlanExecutionStepResponse EndApprovePlanExecutionStep(IAsyncResult asyncResult)
        {
            return EndInvoke<ApprovePlanExecutionStepResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelPlanExecution

        /// <summary>
        /// Cancels an in-progress plan execution. This operation stops the execution of the plan
        /// and prevents any further steps from being processed.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN and execution ID. You can also provide an optional comment
        /// explaining why the execution was canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPlanExecution service method.</param>
        /// 
        /// <returns>The response from the CancelPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CancelPlanExecution">REST API Reference for CancelPlanExecution Operation</seealso>
        public virtual CancelPlanExecutionResponse CancelPlanExecution(CancelPlanExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelPlanExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPlanExecution operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelPlanExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CancelPlanExecution">REST API Reference for CancelPlanExecution Operation</seealso>
        public virtual IAsyncResult BeginCancelPlanExecution(CancelPlanExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPlanExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelPlanExecution.</param>
        /// 
        /// <returns>Returns a  CancelPlanExecutionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CancelPlanExecution">REST API Reference for CancelPlanExecution Operation</seealso>
        public virtual CancelPlanExecutionResponse EndCancelPlanExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelPlanExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlan

        /// <summary>
        /// Creates a new Region switch plan. A plan defines the steps required to shift traffic
        /// from one Amazon Web Services Region to another.
        /// 
        ///  
        /// <para>
        /// You must specify a name for the plan, the primary Region, and at least one additional
        /// Region. You can also provide a description, execution role, recovery time objective,
        /// associated alarms, triggers, and workflows that define the steps to execute during
        /// a Region switch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlan service method.</param>
        /// 
        /// <returns>The response from the CreatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        public virtual CreatePlanResponse CreatePlan(CreatePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlanResponseUnmarshaller.Instance;

            return Invoke<CreatePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlan operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        public virtual IAsyncResult BeginCreatePlan(CreatePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlan.</param>
        /// 
        /// <returns>Returns a  CreatePlanResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        public virtual CreatePlanResponse EndCreatePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlan

        /// <summary>
        /// Deletes a Region switch plan. You must specify the ARN of the plan to delete.
        /// 
        ///  
        /// <para>
        /// You cannot delete a plan that has an active execution in progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlan service method.</param>
        /// 
        /// <returns>The response from the DeletePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/DeletePlan">REST API Reference for DeletePlan Operation</seealso>
        public virtual DeletePlanResponse DeletePlan(DeletePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlanResponseUnmarshaller.Instance;

            return Invoke<DeletePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlan operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/DeletePlan">REST API Reference for DeletePlan Operation</seealso>
        public virtual IAsyncResult BeginDeletePlan(DeletePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlan.</param>
        /// 
        /// <returns>Returns a  DeletePlanResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/DeletePlan">REST API Reference for DeletePlan Operation</seealso>
        public virtual DeletePlanResponse EndDeletePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlan

        /// <summary>
        /// Retrieves detailed information about a Region switch plan. You must specify the ARN
        /// of the plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual IAsyncResult BeginGetPlan(GetPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlan.</param>
        /// 
        /// <returns>Returns a  GetPlanResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse EndGetPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlanEvaluationStatus

        /// <summary>
        /// Retrieves the evaluation status of a Region switch plan. The evaluation status provides
        /// information about the last time the plan was evaluated and any warnings or issues
        /// detected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the GetPlanEvaluationStatus service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanEvaluationStatus">REST API Reference for GetPlanEvaluationStatus Operation</seealso>
        public virtual GetPlanEvaluationStatusResponse GetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<GetPlanEvaluationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlanEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlanEvaluationStatus operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlanEvaluationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanEvaluationStatus">REST API Reference for GetPlanEvaluationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanEvaluationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlanEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlanEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  GetPlanEvaluationStatusResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanEvaluationStatus">REST API Reference for GetPlanEvaluationStatus Operation</seealso>
        public virtual GetPlanEvaluationStatusResponse EndGetPlanEvaluationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanEvaluationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlanExecution

        /// <summary>
        /// Retrieves detailed information about a specific plan execution. You must specify the
        /// plan ARN and execution ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanExecution service method.</param>
        /// 
        /// <returns>The response from the GetPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanExecution">REST API Reference for GetPlanExecution Operation</seealso>
        public virtual GetPlanExecutionResponse GetPlanExecution(GetPlanExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPlanExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlanExecution operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlanExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanExecution">REST API Reference for GetPlanExecution Operation</seealso>
        public virtual IAsyncResult BeginGetPlanExecution(GetPlanExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlanExecution.</param>
        /// 
        /// <returns>Returns a  GetPlanExecutionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanExecution">REST API Reference for GetPlanExecution Operation</seealso>
        public virtual GetPlanExecutionResponse EndGetPlanExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlanInRegion

        /// <summary>
        /// Retrieves information about a Region switch plan in a specific Amazon Web Services
        /// Region. This operation is useful for getting Region-specific information about a plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanInRegion service method.</param>
        /// 
        /// <returns>The response from the GetPlanInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanInRegion">REST API Reference for GetPlanInRegion Operation</seealso>
        public virtual GetPlanInRegionResponse GetPlanInRegion(GetPlanInRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanInRegionResponseUnmarshaller.Instance;

            return Invoke<GetPlanInRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlanInRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlanInRegion operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlanInRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanInRegion">REST API Reference for GetPlanInRegion Operation</seealso>
        public virtual IAsyncResult BeginGetPlanInRegion(GetPlanInRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanInRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlanInRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlanInRegion.</param>
        /// 
        /// <returns>Returns a  GetPlanInRegionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanInRegion">REST API Reference for GetPlanInRegion Operation</seealso>
        public virtual GetPlanInRegionResponse EndGetPlanInRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanInRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlanExecutionEvents

        /// <summary>
        /// Lists the events that occurred during a plan execution. These events provide a detailed
        /// timeline of the execution process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutionEvents service method.</param>
        /// 
        /// <returns>The response from the ListPlanExecutionEvents service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutionEvents">REST API Reference for ListPlanExecutionEvents Operation</seealso>
        public virtual ListPlanExecutionEventsResponse ListPlanExecutionEvents(ListPlanExecutionEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionEventsResponseUnmarshaller.Instance;

            return Invoke<ListPlanExecutionEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlanExecutionEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutionEvents operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlanExecutionEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutionEvents">REST API Reference for ListPlanExecutionEvents Operation</seealso>
        public virtual IAsyncResult BeginListPlanExecutionEvents(ListPlanExecutionEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlanExecutionEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlanExecutionEvents.</param>
        /// 
        /// <returns>Returns a  ListPlanExecutionEventsResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutionEvents">REST API Reference for ListPlanExecutionEvents Operation</seealso>
        public virtual ListPlanExecutionEventsResponse EndListPlanExecutionEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlanExecutionEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlanExecutions

        /// <summary>
        /// Lists the executions of a Region switch plan. This operation returns information about
        /// both current and historical executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutions service method.</param>
        /// 
        /// <returns>The response from the ListPlanExecutions service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutions">REST API Reference for ListPlanExecutions Operation</seealso>
        public virtual ListPlanExecutionsResponse ListPlanExecutions(ListPlanExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPlanExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlanExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutions operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlanExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutions">REST API Reference for ListPlanExecutions Operation</seealso>
        public virtual IAsyncResult BeginListPlanExecutions(ListPlanExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlanExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlanExecutions.</param>
        /// 
        /// <returns>Returns a  ListPlanExecutionsResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutions">REST API Reference for ListPlanExecutions Operation</seealso>
        public virtual ListPlanExecutionsResponse EndListPlanExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlanExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlans

        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlans service method.</param>
        /// 
        /// <returns>The response from the ListPlans service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlans">REST API Reference for ListPlans Operation</seealso>
        public virtual ListPlansResponse ListPlans(ListPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansResponseUnmarshaller.Instance;

            return Invoke<ListPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlans operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlans">REST API Reference for ListPlans Operation</seealso>
        public virtual IAsyncResult BeginListPlans(ListPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlans.</param>
        /// 
        /// <returns>Returns a  ListPlansResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlans">REST API Reference for ListPlans Operation</seealso>
        public virtual ListPlansResponse EndListPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlansInRegion

        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account that are available
        /// in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlansInRegion service method.</param>
        /// 
        /// <returns>The response from the ListPlansInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlansInRegion">REST API Reference for ListPlansInRegion Operation</seealso>
        public virtual ListPlansInRegionResponse ListPlansInRegion(ListPlansInRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlansInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansInRegionResponseUnmarshaller.Instance;

            return Invoke<ListPlansInRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlansInRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlansInRegion operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlansInRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlansInRegion">REST API Reference for ListPlansInRegion Operation</seealso>
        public virtual IAsyncResult BeginListPlansInRegion(ListPlansInRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlansInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansInRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlansInRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlansInRegion.</param>
        /// 
        /// <returns>Returns a  ListPlansInRegionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlansInRegion">REST API Reference for ListPlansInRegion Operation</seealso>
        public virtual ListPlansInRegionResponse EndListPlansInRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlansInRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoute53HealthChecks

        /// <summary>
        /// List the Amazon Route 53 health checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoute53HealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListRoute53HealthChecks service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListRoute53HealthChecks">REST API Reference for ListRoute53HealthChecks Operation</seealso>
        public virtual ListRoute53HealthChecksResponse ListRoute53HealthChecks(ListRoute53HealthChecksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoute53HealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListRoute53HealthChecksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoute53HealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoute53HealthChecks operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoute53HealthChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListRoute53HealthChecks">REST API Reference for ListRoute53HealthChecks Operation</seealso>
        public virtual IAsyncResult BeginListRoute53HealthChecks(ListRoute53HealthChecksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoute53HealthChecksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoute53HealthChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoute53HealthChecks.</param>
        /// 
        /// <returns>Returns a  ListRoute53HealthChecksResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListRoute53HealthChecks">REST API Reference for ListRoute53HealthChecks Operation</seealso>
        public virtual ListRoute53HealthChecksResponse EndListRoute53HealthChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoute53HealthChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags attached to a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartPlanExecution

        /// <summary>
        /// Starts the execution of a Region switch plan. You can execute a plan in either PRACTICE
        /// or RECOVERY mode.
        /// 
        ///  
        /// <para>
        /// In PRACTICE mode, the execution simulates the steps without making actual changes
        /// to your application's traffic routing. In RECOVERY mode, the execution performs actual
        /// changes to shift traffic between Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPlanExecution service method.</param>
        /// 
        /// <returns>The response from the StartPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalArgumentException">
        /// The request processing has an invalid argument.
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/StartPlanExecution">REST API Reference for StartPlanExecution Operation</seealso>
        public virtual StartPlanExecutionResponse StartPlanExecution(StartPlanExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPlanExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPlanExecution operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPlanExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/StartPlanExecution">REST API Reference for StartPlanExecution Operation</seealso>
        public virtual IAsyncResult BeginStartPlanExecution(StartPlanExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPlanExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPlanExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPlanExecution.</param>
        /// 
        /// <returns>Returns a  StartPlanExecutionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/StartPlanExecution">REST API Reference for StartPlanExecution Operation</seealso>
        public virtual StartPlanExecutionResponse EndStartPlanExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPlanExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a Region switch resource. You can assign metadata to your
        /// resources in the form of tags, which are key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePlan

        /// <summary>
        /// Updates an existing Region switch plan. You can modify the plan's description, workflows,
        /// execution role, recovery time objective, associated alarms, and triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlan service method.</param>
        /// 
        /// <returns>The response from the UpdatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlan">REST API Reference for UpdatePlan Operation</seealso>
        public virtual UpdatePlanResponse UpdatePlan(UpdatePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlan operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlan">REST API Reference for UpdatePlan Operation</seealso>
        public virtual IAsyncResult BeginUpdatePlan(UpdatePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlan.</param>
        /// 
        /// <returns>Returns a  UpdatePlanResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlan">REST API Reference for UpdatePlan Operation</seealso>
        public virtual UpdatePlanResponse EndUpdatePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePlanExecution

        /// <summary>
        /// Updates an in-progress plan execution. This operation allows you to modify certain
        /// aspects of the execution, such as adding a comment or changing the action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecution service method.</param>
        /// 
        /// <returns>The response from the UpdatePlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecution">REST API Reference for UpdatePlanExecution Operation</seealso>
        public virtual UpdatePlanExecutionResponse UpdatePlanExecution(UpdatePlanExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlanExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecution operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlanExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecution">REST API Reference for UpdatePlanExecution Operation</seealso>
        public virtual IAsyncResult BeginUpdatePlanExecution(UpdatePlanExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlanExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlanExecution.</param>
        /// 
        /// <returns>Returns a  UpdatePlanExecutionResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecution">REST API Reference for UpdatePlanExecution Operation</seealso>
        public virtual UpdatePlanExecutionResponse EndUpdatePlanExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePlanExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePlanExecutionStep

        /// <summary>
        /// Updates a specific step in an in-progress plan execution. This operation allows you
        /// to modify the step's comment or action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecutionStep service method.</param>
        /// 
        /// <returns>The response from the UpdatePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecutionStep">REST API Reference for UpdatePlanExecutionStep Operation</seealso>
        public virtual UpdatePlanExecutionStepResponse UpdatePlanExecutionStep(UpdatePlanExecutionStepRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionStepResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanExecutionStepResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlanExecutionStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecutionStep operation on AmazonARCRegionswitchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlanExecutionStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecutionStep">REST API Reference for UpdatePlanExecutionStep Operation</seealso>
        public virtual IAsyncResult BeginUpdatePlanExecutionStep(UpdatePlanExecutionStepRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlanExecutionStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlanExecutionStep.</param>
        /// 
        /// <returns>Returns a  UpdatePlanExecutionStepResult from ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecutionStep">REST API Reference for UpdatePlanExecutionStep Operation</seealso>
        public virtual UpdatePlanExecutionStepResponse EndUpdatePlanExecutionStep(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePlanExecutionStepResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonARCRegionswitchEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}