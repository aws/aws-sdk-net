/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation allows you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. You can use AWS CloudFormation to leverage AWS products,
    /// such as Amazon Elastic Compute Cloud, Amazon Elastic Block Store, Amazon Simple Notification
    /// Service, Elastic Load Balancing, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost-effective applications without creating or configuring the underlying
    /// AWS infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With AWS CloudFormation, you declare all of your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// AWS CloudFormation creates and deletes all member resources of the stack together
    /// and manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">AWS
    /// CloudFormation Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/">http://docs.aws.amazon.com/</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonServiceClient, IAmazonCloudFormation
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudFormation.Internal.ProcessRequestHandler());
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

        
        #region  CancelUpdateStack

        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the UPDATE_IN_PROGRESS state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method.</param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        public CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return Invoke<CancelUpdateStackRequest,CancelUpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelUpdateStack
        ///         operation.</returns>
        public IAsyncResult BeginCancelUpdateStack(CancelUpdateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return BeginInvoke<CancelUpdateStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelUpdateStack.</param>
        /// 
        /// <returns>Returns a  CancelUpdateStackResult from CloudFormation.</returns>
        public  CancelUpdateStackResponse EndCancelUpdateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelUpdateStackResponse>(asyncResult);
        }

        #endregion
        
        #region  ContinueUpdateRollback

        /// <summary>
        /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
        /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
        /// cause of the failure, you can manually <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
        /// then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
        /// cannot roll back all changes after a failed stack update. For example, you might have
        /// a stack that is rolling back to an old database instance that was deleted outside
        /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
        /// it assumes that the database instance still exists and attempts to roll back to it,
        /// causing the update rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        public ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackRequest,ContinueUpdateRollbackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContinueUpdateRollback
        ///         operation.</returns>
        public IAsyncResult BeginContinueUpdateRollback(ContinueUpdateRollbackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return BeginInvoke<ContinueUpdateRollbackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginContinueUpdateRollback.</param>
        /// 
        /// <returns>Returns a  ContinueUpdateRollbackResult from CloudFormation.</returns>
        public  ContinueUpdateRollbackResponse EndContinueUpdateRollback(IAsyncResult asyncResult)
        {
            return EndInvoke<ContinueUpdateRollbackResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChangeSet

        /// <summary>
        /// Creates a list of changes for a stack. AWS CloudFormation generates the change set
        /// by comparing the template's information with the information that you submit. A change
        /// set can help you understand which resources AWS CloudFormation will change, and how
        /// it will change them, before you update your stack. Change sets allow you to check
        /// before making a change to avoid deleting or replacing critical resources.
        /// 
        ///  
        /// <para>
        /// AWS CloudFormation doesn't make any changes to the stack when you create a change
        /// set. To make the specified changes, you must execute the change set by using the <a>ExecuteChangeSet</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// After the call successfully completes, AWS CloudFormation starts creating the change
        /// set. To check the status of the change set, use the <a>DescribeChangeSet</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// Resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that were not specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// Quota for the resource has already been reached.
        /// </exception>
        public CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetRequest,CreateChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChangeSet
        ///         operation.</returns>
        public IAsyncResult BeginCreateChangeSet(CreateChangeSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateChangeSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChangeSet.</param>
        /// 
        /// <returns>Returns a  CreateChangeSetResult from CloudFormation.</returns>
        public  CreateChangeSetResponse EndCreateChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStack

        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// Resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that were not specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// Quota for the resource has already been reached.
        /// </exception>
        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        public IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from CloudFormation.</returns>
        public  CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStackResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChangeSet

        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, AWS CloudFormation successfully deleted the change
        /// set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set cannot be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code> or the stack status might be <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        public DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return Invoke<DeleteChangeSetRequest,DeleteChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChangeSet
        ///         operation.</returns>
        public IAsyncResult BeginDeleteChangeSet(DeleteChangeSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteChangeSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChangeSet.</param>
        /// 
        /// <returns>Returns a  DeleteChangeSetResult from CloudFormation.</returns>
        public  DeleteChangeSetResponse EndDeleteChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStack

        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
        /// been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        public DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        public IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from CloudFormation.</returns>
        public  DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStackResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountLimits

        /// <summary>
        /// Retrieves your account's AWS CloudFormation limits, such as the maximum number of
        /// stacks that you can create in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        public DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from CloudFormation.</returns>
        public  DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChangeSet

        /// <summary>
        /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
        /// will make if you execute the change set. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        public DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetRequest,DescribeChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChangeSet
        ///         operation.</returns>
        public IAsyncResult BeginDescribeChangeSet(DescribeChangeSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeChangeSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChangeSet.</param>
        /// 
        /// <returns>Returns a  DescribeChangeSetResult from CloudFormation.</returns>
        public  DescribeChangeSetResponse EndDescribeChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStackEvents

        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
        /// in the AWS CloudFormation User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        public DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsRequest,DescribeStackEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStackEvents(DescribeStackEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStackEventsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackEvents.</param>
        /// 
        /// <returns>Returns a  DescribeStackEventsResult from CloudFormation.</returns>
        public  DescribeStackEventsResponse EndDescribeStackEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStackEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStackResource

        /// <summary>
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        public DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceRequest,DescribeStackResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackResource
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStackResource(DescribeStackResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStackResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResource.</param>
        /// 
        /// <returns>Returns a  DescribeStackResourceResult from CloudFormation.</returns>
        public  DescribeStackResourceResponse EndDescribeStackResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStackResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStackResources

        /// <summary>
        /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
        /// is specified, all the associated resources that are part of the stack are returned.
        /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
        /// that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <code>ListStackResources</code> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
        /// for up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
        /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
        /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
        /// and <code>PhysicalResourceId</code>, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">AWS
        /// CloudFormation User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
        /// and <code>PhysicalResourceId</code> in the same request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        public DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesRequest,DescribeStackResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackResources
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStackResources(DescribeStackResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStackResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResources.</param>
        /// 
        /// <returns>Returns a  DescribeStackResourcesResult from CloudFormation.</returns>
        public  DescribeStackResourcesResponse EndDescribeStackResources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStackResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStacks

        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        public DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }

        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from CloudFormation.</returns>
        public  DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  EstimateTemplateCost

        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an AWS Simple
        /// Monthly Calculator URL with a query string that describes the resources required to
        /// run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        public EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostRequest,EstimateTemplateCostResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEstimateTemplateCost
        ///         operation.</returns>
        public IAsyncResult BeginEstimateTemplateCost(EstimateTemplateCostRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return BeginInvoke<EstimateTemplateCostRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEstimateTemplateCost.</param>
        /// 
        /// <returns>Returns a  EstimateTemplateCostResult from CloudFormation.</returns>
        public  EstimateTemplateCostResponse EndEstimateTemplateCost(IAsyncResult asyncResult)
        {
            return EndInvoke<EstimateTemplateCostResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteChangeSet

        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, AWS CloudFormation starts
        /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
        /// update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set cannot be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code> or the stack status might be <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        public ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetRequest,ExecuteChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteChangeSet
        ///         operation.</returns>
        public IAsyncResult BeginExecuteChangeSet(ExecuteChangeSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke<ExecuteChangeSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteChangeSet.</param>
        /// 
        /// <returns>Returns a  ExecuteChangeSetResult from CloudFormation.</returns>
        public  ExecuteChangeSetResponse EndExecuteChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStackPolicy

        /// <summary>
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        public GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<GetStackPolicyRequest,GetStackPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStackPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetStackPolicy(GetStackPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetStackPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStackPolicy.</param>
        /// 
        /// <returns>Returns a  GetStackPolicyResult from CloudFormation.</returns>
        public  GetStackPolicyResponse EndGetStackPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStackPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplate

        /// <summary>
        /// Returns the template body for a specified stack. You can get the template for running
        /// or deleted stacks.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, GetTemplate returns the template for up to 90 days after the stack
        /// has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the template does not exist, a <code>ValidationError</code> is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateRequest,GetTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        public IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<GetTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from CloudFormation.</returns>
        public  GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplateSummary

        /// <summary>
        /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
        /// or you can get template information for a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
        /// for up to 90 days after the stack has been deleted. If the template does not exist,
        /// a <code>ValidationError</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        public GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryRequest,GetTemplateSummaryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateSummary
        ///         operation.</returns>
        public IAsyncResult BeginGetTemplateSummary(GetTemplateSummaryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return BeginInvoke<GetTemplateSummaryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateSummary.</param>
        /// 
        /// <returns>Returns a  GetTemplateSummaryResult from CloudFormation.</returns>
        public  GetTemplateSummaryResponse EndGetTemplateSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChangeSets

        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, AWS
        /// CloudFormation lists change sets that are in the <code>CREATE_IN_PROGRESS</code> or
        /// <code>CREATE_PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        public ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsRequest,ListChangeSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangeSets
        ///         operation.</returns>
        public IAsyncResult BeginListChangeSets(ListChangeSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListChangeSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangeSets.</param>
        /// 
        /// <returns>Returns a  ListChangeSetsResult from CloudFormation.</returns>
        public  ListChangeSetsResponse EndListChangeSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChangeSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExports

        /// <summary>
        /// Lists all exported output values in the account and region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// AWS CloudFormation Export Stack Output Values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        public ListExportsResponse ListExports(ListExportsRequest request)
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsRequest,ListExportsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExports
        ///         operation.</returns>
        public IAsyncResult BeginListExports(ListExportsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return BeginInvoke<ListExportsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExports.</param>
        /// 
        /// <returns>Returns a  ListExportsResult from CloudFormation.</returns>
        public  ListExportsResponse EndListExports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStackResources

        /// <summary>
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return Invoke<ListStackResourcesRequest,ListStackResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackResources
        ///         operation.</returns>
        public IAsyncResult BeginListStackResources(ListStackResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListStackResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackResources.</param>
        /// 
        /// <returns>Returns a  ListStackResourcesResult from CloudFormation.</returns>
        public  ListStackResourcesResponse EndListStackResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStackResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStacks

        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        public ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }

        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        public ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksRequest,ListStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStacks
        ///         operation.</returns>
        public IAsyncResult BeginListStacks(ListStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return BeginInvoke<ListStacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStacks.</param>
        /// 
        /// <returns>Returns a  ListStacksResult from CloudFormation.</returns>
        public  ListStacksResponse EndListStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  SetStackPolicy

        /// <summary>
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        public SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<SetStackPolicyRequest,SetStackPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetStackPolicy
        ///         operation.</returns>
        public IAsyncResult BeginSetStackPolicy(SetStackPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<SetStackPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetStackPolicy.</param>
        /// 
        /// <returns>Returns a  SetStackPolicyResult from CloudFormation.</returns>
        public  SetStackPolicyResponse EndSetStackPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<SetStackPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  SignalResource

        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the SignalResource API in conjunction with a creation policy or update policy.
        /// AWS CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The SignalResource
        /// API is useful in cases where you want to send signals from anywhere other than an
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        public SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceRequest,SignalResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalResource operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalResource
        ///         operation.</returns>
        public IAsyncResult BeginSignalResource(SignalResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return BeginInvoke<SignalResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignalResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalResource.</param>
        /// 
        /// <returns>Returns a  SignalResourceResult from CloudFormation.</returns>
        public  SignalResourceResponse EndSignalResource(IAsyncResult asyncResult)
        {
            return EndInvoke<SignalResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStack

        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that were not specified in the Capabilities
        /// parameter.
        /// </exception>
        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from CloudFormation.</returns>
        public  UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStackResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateTemplate

        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        public ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }

        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateRequest,ValidateTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateTemplate
        ///         operation.</returns>
        public IAsyncResult BeginValidateTemplate(ValidateTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<ValidateTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateTemplate.</param>
        /// 
        /// <returns>Returns a  ValidateTemplateResult from CloudFormation.</returns>
        public  ValidateTemplateResponse EndValidateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateTemplateResponse>(asyncResult);
        }

        #endregion
        
    }
}