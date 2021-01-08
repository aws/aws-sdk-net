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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleWorkflow.Model;
using Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations;
using Amazon.SimpleWorkflow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Implementation for accessing SimpleWorkflow
    ///
    /// Amazon Simple Workflow Service 
    /// <para>
    /// The Amazon Simple Workflow Service (Amazon SWF) makes it easy to build applications
    /// that use Amazon's cloud to coordinate work across distributed components. In Amazon
    /// SWF, a <i>task</i> represents a logical unit of work that is performed by a component
    /// of your workflow. Coordinating tasks in a workflow involves managing intertask dependencies,
    /// scheduling, and concurrency in accordance with the logical flow of the application.
    /// </para>
    ///  
    /// <para>
    /// Amazon SWF gives you full control over implementing tasks and coordinating them without
    /// worrying about underlying complexities such as tracking their progress and maintaining
    /// their state.
    /// </para>
    ///  
    /// <para>
    /// This documentation serves as reference only. For a broader overview of the Amazon
    /// SWF programming model, see the <i> <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/">Amazon
    /// SWF Developer Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial class AmazonSimpleWorkflowClient : AmazonServiceClient, IAmazonSimpleWorkflow
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleWorkflowMetadata();
        private ISimpleWorkflowPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimpleWorkflowPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimpleWorkflowPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        public AmazonSimpleWorkflowClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        public AmazonSimpleWorkflowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials and an
        /// AmazonSimpleWorkflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleWorkflowConfig clientConfig)
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


        #region  CountClosedWorkflowExecutions


        /// <summary>
        /// Returns the number of closed workflow executions within the given domain that meet
        /// the specified filtering criteria.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        public virtual CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountClosedWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of closed workflow executions within the given domain that meet
        /// the specified filtering criteria.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        public virtual Task<CountClosedWorkflowExecutionsResponse> CountClosedWorkflowExecutionsAsync(CountClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CountClosedWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountOpenWorkflowExecutions


        /// <summary>
        /// Returns the number of open workflow executions within the given domain that meet the
        /// specified filtering criteria.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        public virtual CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountOpenWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of open workflow executions within the given domain that meet the
        /// specified filtering criteria.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        public virtual Task<CountOpenWorkflowExecutionsResponse> CountOpenWorkflowExecutionsAsync(CountOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CountOpenWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountPendingActivityTasks


        /// <summary>
        /// Returns the estimated number of activity tasks in the specified task list. The count
        /// returned is an approximation and isn't guaranteed to be exact. If you specify a task
        /// list that no activity task was ever scheduled in then <code>0</code> is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        public virtual CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingActivityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingActivityTasksResponse>(request, options);
        }


        /// <summary>
        /// Returns the estimated number of activity tasks in the specified task list. The count
        /// returned is an approximation and isn't guaranteed to be exact. If you specify a task
        /// list that no activity task was ever scheduled in then <code>0</code> is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        public virtual Task<CountPendingActivityTasksResponse> CountPendingActivityTasksAsync(CountPendingActivityTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingActivityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<CountPendingActivityTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountPendingDecisionTasks


        /// <summary>
        /// Returns the estimated number of decision tasks in the specified task list. The count
        /// returned is an approximation and isn't guaranteed to be exact. If you specify a task
        /// list that no decision task was ever scheduled in then <code>0</code> is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        public virtual CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingDecisionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingDecisionTasksResponse>(request, options);
        }


        /// <summary>
        /// Returns the estimated number of decision tasks in the specified task list. The count
        /// returned is an approximation and isn't guaranteed to be exact. If you specify a task
        /// list that no decision task was ever scheduled in then <code>0</code> is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        public virtual Task<CountPendingDecisionTasksResponse> CountPendingDecisionTasksAsync(CountPendingDecisionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingDecisionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<CountPendingDecisionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateActivityType


        /// <summary>
        /// Deprecates the specified <i>activity type</i>. After an activity type has been deprecated,
        /// you cannot create new tasks of that activity type. Tasks of this type that were scheduled
        /// before the type was deprecated continue to run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType service method.</param>
        /// 
        /// <returns>The response from the DeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        public virtual DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Deprecates the specified <i>activity type</i>. After an activity type has been deprecated,
        /// you cannot create new tasks of that activity type. Tasks of this type that were scheduled
        /// before the type was deprecated continue to run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        public virtual Task<DeprecateActivityTypeResponse> DeprecateActivityTypeAsync(DeprecateActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeprecateActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateDomain


        /// <summary>
        /// Deprecates the specified domain. After a domain has been deprecated it cannot be used
        /// to create new workflow executions or register new types. However, you can still use
        /// visibility actions on this domain. Deprecating a domain also deprecates all activity
        /// and workflow types registered in the domain. Executions that were started before the
        /// domain was deprecated continues to run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain service method.</param>
        /// 
        /// <returns>The response from the DeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainDeprecatedException">
        /// Returned when the specified domain has been deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        public virtual DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return Invoke<DeprecateDomainResponse>(request, options);
        }


        /// <summary>
        /// Deprecates the specified domain. After a domain has been deprecated it cannot be used
        /// to create new workflow executions or register new types. However, you can still use
        /// visibility actions on this domain. Deprecating a domain also deprecates all activity
        /// and workflow types registered in the domain. Executions that were started before the
        /// domain was deprecated continues to run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainDeprecatedException">
        /// Returned when the specified domain has been deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        public virtual Task<DeprecateDomainResponse> DeprecateDomainAsync(DeprecateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeprecateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateWorkflowType


        /// <summary>
        /// Deprecates the specified <i>workflow type</i>. After a workflow type has been deprecated,
        /// you cannot create new executions of that type. Executions that were started before
        /// the type was deprecated continues to run. A deprecated workflow type may still be
        /// used when calling visibility actions.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        public virtual DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Deprecates the specified <i>workflow type</i>. After a workflow type has been deprecated,
        /// you cannot create new executions of that type. Executions that were started before
        /// the type was deprecated continues to run. A deprecated workflow type may still be
        /// used when calling visibility actions.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        public virtual Task<DeprecateWorkflowTypeResponse> DeprecateWorkflowTypeAsync(DeprecateWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeprecateWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivityType


        /// <summary>
        /// Returns information about the specified activity type. This includes configuration
        /// settings provided when the type was registered and other general information about
        /// the type.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType service method.</param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        public virtual DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified activity type. This includes configuration
        /// settings provided when the type was registered and other general information about
        /// the type.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        public virtual Task<DescribeActivityTypeResponse> DescribeActivityTypeAsync(DescribeActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain


        /// <summary>
        /// Returns information about the specified domain, including description and status.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified domain, including description and status.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowExecution


        /// <summary>
        /// Returns information about the specified workflow execution including its type and
        /// some statistics.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        public virtual DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified workflow execution including its type and
        /// some statistics.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        public virtual Task<DescribeWorkflowExecutionResponse> DescribeWorkflowExecutionAsync(DescribeWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowType


        /// <summary>
        /// Returns information about the specified <i>workflow type</i>. This includes configuration
        /// settings specified when the type was registered and other information such as creation
        /// date, current status, etc.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        public virtual DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified <i>workflow type</i>. This includes configuration
        /// settings specified when the type was registered and other information such as creation
        /// date, current status, etc.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        public virtual Task<DescribeWorkflowTypeResponse> DescribeWorkflowTypeAsync(DescribeWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowExecutionHistory


        /// <summary>
        /// Returns the history of the specified workflow execution. The results may be split
        /// into multiple pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        public virtual GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowExecutionHistoryResponse>(request, options);
        }


        /// <summary>
        /// Returns the history of the specified workflow execution. The results may be split
        /// into multiple pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        public virtual Task<GetWorkflowExecutionHistoryResponse> GetWorkflowExecutionHistoryAsync(GetWorkflowExecutionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkflowExecutionHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActivityTypes


        /// <summary>
        /// Returns information about all activities registered in the specified domain that match
        /// the specified name and registration status. The result includes information like creation
        /// date, current status of the activity, etc. The results may be split into multiple
        /// pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes service method.</param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        public virtual ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return Invoke<ListActivityTypesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about all activities registered in the specified domain that match
        /// the specified name and registration status. The result includes information like creation
        /// date, current status of the activity, etc. The results may be split into multiple
        /// pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        public virtual Task<ListActivityTypesResponse> ListActivityTypesAsync(ListActivityTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivityTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActivityTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClosedWorkflowExecutions


        /// <summary>
        /// Returns a list of closed workflow executions in the specified domain that meet the
        /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
        /// pages, make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        public virtual ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListClosedWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of closed workflow executions in the specified domain that meet the
        /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
        /// pages, make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        public virtual Task<ListClosedWorkflowExecutionsResponse> ListClosedWorkflowExecutionsAsync(ListClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClosedWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns the list of domains registered in the account. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken
        /// returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains. The element must be set to <code>arn:aws:swf::AccountID:domain/*</code>,
        /// where <i>AccountID</i> is the account ID, with no dashes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of domains registered in the account. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken
        /// returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains. The element must be set to <code>arn:aws:swf::AccountID:domain/*</code>,
        /// where <i>AccountID</i> is the account ID, with no dashes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpenWorkflowExecutions


        /// <summary>
        /// Returns a list of open workflow executions in the specified domain that meet the filtering
        /// criteria. The results may be split into multiple pages. To retrieve subsequent pages,
        /// make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        public virtual ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListOpenWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of open workflow executions in the specified domain that meet the filtering
        /// criteria. The results may be split into multiple pages. To retrieve subsequent pages,
        /// make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        public virtual Task<ListOpenWorkflowExecutionsResponse> ListOpenWorkflowExecutionsAsync(ListOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOpenWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags for a given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflowTypes


        /// <summary>
        /// Returns information about workflow types in the specified domain. The results may
        /// be split into multiple pages that can be retrieved by making the call repeatedly.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        public virtual ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowTypesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about workflow types in the specified domain. The results may
        /// be split into multiple pages that can be retrieved by making the call repeatedly.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        public virtual Task<ListWorkflowTypesResponse> ListWorkflowTypesAsync(ListWorkflowTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkflowTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForActivityTask


        /// <summary>
        /// Used by workers to get an <a>ActivityTask</a> from the specified activity <code>taskList</code>.
        /// This initiates a long poll, where the service holds the HTTP connection open and responds
        /// as soon as a task becomes available. The maximum time the service holds on to the
        /// request before responding is 60 seconds. If no task is available within 60 seconds,
        /// the poll returns an empty result. An empty result, in this context, means that an
        /// ActivityTask is returned, but that the value of taskToken is an empty string. If a
        /// task is returned, the worker should use its type to identify and process it correctly.
        /// 
        ///  <important> 
        /// <para>
        /// Workers should set their client side socket timeout to at least 70 seconds (10 seconds
        /// higher than the maximum time service may hold the poll request).
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask service method.</param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        public virtual PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return Invoke<PollForActivityTaskResponse>(request, options);
        }


        /// <summary>
        /// Used by workers to get an <a>ActivityTask</a> from the specified activity <code>taskList</code>.
        /// This initiates a long poll, where the service holds the HTTP connection open and responds
        /// as soon as a task becomes available. The maximum time the service holds on to the
        /// request before responding is 60 seconds. If no task is available within 60 seconds,
        /// the poll returns an empty result. An empty result, in this context, means that an
        /// ActivityTask is returned, but that the value of taskToken is an empty string. If a
        /// task is returned, the worker should use its type to identify and process it correctly.
        /// 
        ///  <important> 
        /// <para>
        /// Workers should set their client side socket timeout to at least 70 seconds (10 seconds
        /// higher than the maximum time service may hold the poll request).
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        public virtual Task<PollForActivityTaskResponse> PollForActivityTaskAsync(PollForActivityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<PollForActivityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForDecisionTask


        /// <summary>
        /// Used by deciders to get a <a>DecisionTask</a> from the specified decision <code>taskList</code>.
        /// A decision task may be returned for any open workflow execution that is using the
        /// specified task list. The task includes a paginated view of the history of the workflow
        /// execution. The decider should use the workflow type and the history to determine how
        /// to properly handle the task.
        /// 
        ///  
        /// <para>
        /// This action initiates a long poll, where the service holds the HTTP connection open
        /// and responds as soon a task becomes available. If no decision task is available in
        /// the specified task list before the timeout of 60 seconds expires, an empty result
        /// is returned. An empty result, in this context, means that a DecisionTask is returned,
        /// but that the value of taskToken is an empty string.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deciders should set their client side socket timeout to at least 70 seconds (10 seconds
        /// higher than the timeout).
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Because the number of workflow history events for a single workflow execution might
        /// be very large, the result returned might be split up across a number of pages. To
        /// retrieve subsequent pages, make additional calls to <code>PollForDecisionTask</code>
        /// using the <code>nextPageToken</code> returned by the initial call. Note that you do
        /// <i>not</i> call <code>GetWorkflowExecutionHistory</code> with this <code>nextPageToken</code>.
        /// Instead, call <code>PollForDecisionTask</code> again.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask service method.</param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        public virtual PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForDecisionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return Invoke<PollForDecisionTaskResponse>(request, options);
        }


        /// <summary>
        /// Used by deciders to get a <a>DecisionTask</a> from the specified decision <code>taskList</code>.
        /// A decision task may be returned for any open workflow execution that is using the
        /// specified task list. The task includes a paginated view of the history of the workflow
        /// execution. The decider should use the workflow type and the history to determine how
        /// to properly handle the task.
        /// 
        ///  
        /// <para>
        /// This action initiates a long poll, where the service holds the HTTP connection open
        /// and responds as soon a task becomes available. If no decision task is available in
        /// the specified task list before the timeout of 60 seconds expires, an empty result
        /// is returned. An empty result, in this context, means that a DecisionTask is returned,
        /// but that the value of taskToken is an empty string.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deciders should set their client side socket timeout to at least 70 seconds (10 seconds
        /// higher than the timeout).
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Because the number of workflow history events for a single workflow execution might
        /// be very large, the result returned might be split up across a number of pages. To
        /// retrieve subsequent pages, make additional calls to <code>PollForDecisionTask</code>
        /// using the <code>nextPageToken</code> returned by the initial call. Note that you do
        /// <i>not</i> call <code>GetWorkflowExecutionHistory</code> with this <code>nextPageToken</code>.
        /// Instead, call <code>PollForDecisionTask</code> again.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
        /// element with the <code>swf:taskList.name</code> key to allow the action to access
        /// only certain task lists.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        public virtual Task<PollForDecisionTaskResponse> PollForDecisionTaskAsync(PollForDecisionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForDecisionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<PollForDecisionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecordActivityTaskHeartbeat


        /// <summary>
        /// Used by activity workers to report to the service that the <a>ActivityTask</a> represented
        /// by the specified <code>taskToken</code> is still making progress. The worker can also
        /// specify details of the progress, for example percent complete, using the <code>details</code>
        /// parameter. This action can also be used by the worker as a mechanism to check if cancellation
        /// is being requested for the activity task. If a cancellation is being attempted for
        /// the specified task, then the boolean <code>cancelRequested</code> flag returned by
        /// the service is set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// This action resets the <code>taskHeartbeatTimeout</code> clock. The <code>taskHeartbeatTimeout</code>
        /// is specified in <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// This action doesn't in itself create an event in the workflow execution history. However,
        /// if the task times out, the workflow execution history contains a <code>ActivityTaskTimedOut</code>
        /// event that contains the information from the last heartbeat generated by the activity
        /// worker.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>taskStartToCloseTimeout</code> of an activity type is the maximum duration
        /// of an activity task, regardless of the number of <a>RecordActivityTaskHeartbeat</a>
        /// requests received. The <code>taskStartToCloseTimeout</code> is also specified in <a>RegisterActivityType</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This operation is only useful for long-lived activities to report liveliness of the
        /// task and to determine if a cancellation is being attempted.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If the <code>cancelRequested</code> flag returns <code>true</code>, a cancellation
        /// is being attempted. If the worker can cancel the activity, it should respond with
        /// <a>RespondActivityTaskCanceled</a>. Otherwise, it should ignore the cancellation request.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        public virtual RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordActivityTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordActivityTaskHeartbeatResponse>(request, options);
        }


        /// <summary>
        /// Used by activity workers to report to the service that the <a>ActivityTask</a> represented
        /// by the specified <code>taskToken</code> is still making progress. The worker can also
        /// specify details of the progress, for example percent complete, using the <code>details</code>
        /// parameter. This action can also be used by the worker as a mechanism to check if cancellation
        /// is being requested for the activity task. If a cancellation is being attempted for
        /// the specified task, then the boolean <code>cancelRequested</code> flag returned by
        /// the service is set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// This action resets the <code>taskHeartbeatTimeout</code> clock. The <code>taskHeartbeatTimeout</code>
        /// is specified in <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// This action doesn't in itself create an event in the workflow execution history. However,
        /// if the task times out, the workflow execution history contains a <code>ActivityTaskTimedOut</code>
        /// event that contains the information from the last heartbeat generated by the activity
        /// worker.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>taskStartToCloseTimeout</code> of an activity type is the maximum duration
        /// of an activity task, regardless of the number of <a>RecordActivityTaskHeartbeat</a>
        /// requests received. The <code>taskStartToCloseTimeout</code> is also specified in <a>RegisterActivityType</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This operation is only useful for long-lived activities to report liveliness of the
        /// task and to determine if a cancellation is being attempted.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If the <code>cancelRequested</code> flag returns <code>true</code>, a cancellation
        /// is being attempted. If the worker can cancel the activity, it should respond with
        /// <a>RespondActivityTaskCanceled</a>. Otherwise, it should ignore the cancellation request.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        public virtual Task<RecordActivityTaskHeartbeatResponse> RecordActivityTaskHeartbeatAsync(RecordActivityTaskHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordActivityTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecordActivityTaskHeartbeatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterActivityType


        /// <summary>
        /// Registers a new <i>activity type</i> along with its configuration settings in the
        /// specified domain.
        /// 
        ///  <important> 
        /// <para>
        /// A <code>TypeAlreadyExists</code> fault is returned if the type already exists in the
        /// domain. You cannot change any configuration settings of the type after its registration,
        /// and it must be registered as a new version.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>defaultTaskList.name</code>: String constraint. The key is <code>swf:defaultTaskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code>: String constraint. The key is <code>swf:name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code>: String constraint. The key is <code>swf:version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType service method.</param>
        /// 
        /// <returns>The response from the RegisterActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        public virtual RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Registers a new <i>activity type</i> along with its configuration settings in the
        /// specified domain.
        /// 
        ///  <important> 
        /// <para>
        /// A <code>TypeAlreadyExists</code> fault is returned if the type already exists in the
        /// domain. You cannot change any configuration settings of the type after its registration,
        /// and it must be registered as a new version.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>defaultTaskList.name</code>: String constraint. The key is <code>swf:defaultTaskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code>: String constraint. The key is <code>swf:name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code>: String constraint. The key is <code>swf:version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        public virtual Task<RegisterActivityTypeResponse> RegisterActivityTypeAsync(RegisterActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// Registers a new domain.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot use an IAM policy to control domain access for this action. The name of
        /// the domain being registered is available as the resource of this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException">
        /// Returned if the domain already exists. You may get this fault if you are registering
        /// a domain that is either already registered or deprecated, or if you undeprecate a
        /// domain that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainResponse>(request, options);
        }


        /// <summary>
        /// Registers a new domain.
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot use an IAM policy to control domain access for this action. The name of
        /// the domain being registered is available as the resource of this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException">
        /// Returned if the domain already exists. You may get this fault if you are registering
        /// a domain that is either already registered or deprecated, or if you undeprecate a
        /// domain that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterWorkflowType


        /// <summary>
        /// Registers a new <i>workflow type</i> and its configuration settings in the specified
        /// domain.
        /// 
        ///  
        /// <para>
        /// The retention period for the workflow history is set by the <a>RegisterDomain</a>
        /// action.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the type already exists, then a <code>TypeAlreadyExists</code> fault is returned.
        /// You cannot change the configuration settings of a workflow type once it is registered
        /// and it must be registered as a new version.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>defaultTaskList.name</code>: String constraint. The key is <code>swf:defaultTaskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code>: String constraint. The key is <code>swf:name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code>: String constraint. The key is <code>swf:version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType service method.</param>
        /// 
        /// <returns>The response from the RegisterWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        public virtual RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Registers a new <i>workflow type</i> and its configuration settings in the specified
        /// domain.
        /// 
        ///  
        /// <para>
        /// The retention period for the workflow history is set by the <a>RegisterDomain</a>
        /// action.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the type already exists, then a <code>TypeAlreadyExists</code> fault is returned.
        /// You cannot change the configuration settings of a workflow type once it is registered
        /// and it must be registered as a new version.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>defaultTaskList.name</code>: String constraint. The key is <code>swf:defaultTaskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code>: String constraint. The key is <code>swf:name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code>: String constraint. The key is <code>swf:version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        public virtual Task<RegisterWorkflowTypeResponse> RegisterWorkflowTypeAsync(RegisterWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestCancelWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionCancelRequested</code> event in the currently running
        /// workflow execution identified by the given domain, workflowId, and runId. This logically
        /// requests the cancellation of the workflow execution as a whole. It is up to the decider
        /// to take appropriate actions when it receives an execution history with this event.
        /// 
        ///  <note> 
        /// <para>
        /// If the runId isn't specified, the <code>WorkflowExecutionCancelRequested</code> event
        /// is recorded in the history of the current open workflow execution with the specified
        /// workflowId in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Because this action allows the workflow to properly clean up and gracefully close,
        /// it should be used instead of <a>TerminateWorkflowExecution</a> when possible.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the RequestCancelWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        public virtual RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCancelWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<RequestCancelWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Records a <code>WorkflowExecutionCancelRequested</code> event in the currently running
        /// workflow execution identified by the given domain, workflowId, and runId. This logically
        /// requests the cancellation of the workflow execution as a whole. It is up to the decider
        /// to take appropriate actions when it receives an execution history with this event.
        /// 
        ///  <note> 
        /// <para>
        /// If the runId isn't specified, the <code>WorkflowExecutionCancelRequested</code> event
        /// is recorded in the history of the current open workflow execution with the specified
        /// workflowId in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Because this action allows the workflow to properly clean up and gracefully close,
        /// it should be used instead of <a>TerminateWorkflowExecution</a> when possible.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCancelWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        public virtual Task<RequestCancelWorkflowExecutionResponse> RequestCancelWorkflowExecutionAsync(RequestCancelWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCancelWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RequestCancelWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCanceled


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> was successfully canceled. Additional <code>details</code>
        /// can be provided using the <code>details</code> argument.
        /// 
        ///  
        /// <para>
        /// These <code>details</code> (if provided) appear in the <code>ActivityTaskCanceled</code>
        /// event added to the workflow history.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only use this operation if the <code>canceled</code> flag of a <a>RecordActivityTaskHeartbeat</a>
        /// request returns <code>true</code> and if the activity can be safely undone or abandoned.
        /// </para>
        ///  </important> 
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, RespondActivityTaskCanceled,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCanceled service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        public virtual RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCanceledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCanceledResponse>(request, options);
        }


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> was successfully canceled. Additional <code>details</code>
        /// can be provided using the <code>details</code> argument.
        /// 
        ///  
        /// <para>
        /// These <code>details</code> (if provided) appear in the <code>ActivityTaskCanceled</code>
        /// event added to the workflow history.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only use this operation if the <code>canceled</code> flag of a <a>RecordActivityTaskHeartbeat</a>
        /// request returns <code>true</code> and if the activity can be safely undone or abandoned.
        /// </para>
        ///  </important> 
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, RespondActivityTaskCanceled,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RespondActivityTaskCanceled service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        public virtual Task<RespondActivityTaskCanceledResponse> RespondActivityTaskCanceledAsync(RespondActivityTaskCanceledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCanceledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;
            
            return InvokeAsync<RespondActivityTaskCanceledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCompleted


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> completed successfully with a <code>result</code> (if provided).
        /// The <code>result</code> appears in the <code>ActivityTaskCompleted</code> event in
        /// the workflow history.
        /// 
        ///  <important> 
        /// <para>
        /// If the requested task doesn't complete successfully, use <a>RespondActivityTaskFailed</a>
        /// instead. If the worker finds that the task is canceled through the <code>canceled</code>
        /// flag returned by <a>RecordActivityTaskHeartbeat</a>, it should cancel the task, clean
        /// up and then call <a>RespondActivityTaskCanceled</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to RespondActivityTaskCompleted, <a>RespondActivityTaskCanceled</a>,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        public virtual RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCompletedResponse>(request, options);
        }


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> completed successfully with a <code>result</code> (if provided).
        /// The <code>result</code> appears in the <code>ActivityTaskCompleted</code> event in
        /// the workflow history.
        /// 
        ///  <important> 
        /// <para>
        /// If the requested task doesn't complete successfully, use <a>RespondActivityTaskFailed</a>
        /// instead. If the worker finds that the task is canceled through the <code>canceled</code>
        /// flag returned by <a>RecordActivityTaskHeartbeat</a>, it should cancel the task, clean
        /// up and then call <a>RespondActivityTaskCanceled</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to RespondActivityTaskCompleted, <a>RespondActivityTaskCanceled</a>,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RespondActivityTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        public virtual Task<RespondActivityTaskCompletedResponse> RespondActivityTaskCompletedAsync(RespondActivityTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;
            
            return InvokeAsync<RespondActivityTaskCompletedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskFailed


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> has failed with <code>reason</code> (if specified). The <code>reason</code>
        /// and <code>details</code> appear in the <code>ActivityTaskFailed</code> event added
        /// to the workflow history.
        /// 
        ///  
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, <a>RespondActivityTaskCanceled</a>,
        /// RespondActivityTaskFailed, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskFailed service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        public virtual RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskFailedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskFailedResponse>(request, options);
        }


        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> has failed with <code>reason</code> (if specified). The <code>reason</code>
        /// and <code>details</code> appear in the <code>ActivityTaskFailed</code> event added
        /// to the workflow history.
        /// 
        ///  
        /// <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, <a>RespondActivityTaskCanceled</a>,
        /// RespondActivityTaskFailed, or the task has <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RespondActivityTaskFailed service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        public virtual Task<RespondActivityTaskFailedResponse> RespondActivityTaskFailedAsync(RespondActivityTaskFailedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskFailedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;
            
            return InvokeAsync<RespondActivityTaskFailedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondDecisionTaskCompleted


        /// <summary>
        /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
        /// <code>taskToken</code> has successfully completed. The <code>decisions</code> argument
        /// specifies the list of decisions made while processing the task.
        /// 
        ///  
        /// <para>
        /// A <code>DecisionTaskCompleted</code> event is added to the workflow history. The <code>executionContext</code>
        /// specified is attached to the event in the workflow execution history.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// If an IAM policy grants permission to use <code>RespondDecisionTaskCompleted</code>,
        /// it can express permissions for the list of decisions in the <code>decisions</code>
        /// parameter. Each of the decisions has one or more parameters, much like a regular API
        /// call. To allow for policies to be as readable as possible, you can express permissions
        /// on decisions as if they were actual API calls, including applying conditions to some
        /// parameters. For more information, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service method.</param>
        /// 
        /// <returns>The response from the RespondDecisionTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        public virtual RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondDecisionTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondDecisionTaskCompletedResponse>(request, options);
        }


        /// <summary>
        /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
        /// <code>taskToken</code> has successfully completed. The <code>decisions</code> argument
        /// specifies the list of decisions made while processing the task.
        /// 
        ///  
        /// <para>
        /// A <code>DecisionTaskCompleted</code> event is added to the workflow history. The <code>executionContext</code>
        /// specified is attached to the event in the workflow execution history.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// If an IAM policy grants permission to use <code>RespondDecisionTaskCompleted</code>,
        /// it can express permissions for the list of decisions in the <code>decisions</code>
        /// parameter. Each of the decisions has one or more parameters, much like a regular API
        /// call. To allow for policies to be as readable as possible, you can express permissions
        /// on decisions as if they were actual API calls, including applying conditions to some
        /// parameters. For more information, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RespondDecisionTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        public virtual Task<RespondDecisionTaskCompletedResponse> RespondDecisionTaskCompletedAsync(RespondDecisionTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondDecisionTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;
            
            return InvokeAsync<RespondDecisionTaskCompletedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignalWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionSignaled</code> event in the workflow execution history
        /// and creates a decision task for the workflow execution identified by the given domain,
        /// workflowId and runId. The event is recorded with the specified user defined signalName
        /// and input (if provided).
        /// 
        ///  <note> 
        /// <para>
        /// If a runId isn't specified, then the <code>WorkflowExecutionSignaled</code> event
        /// is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If the specified workflow execution isn't open, this method fails with <code>UnknownResource</code>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the SignalWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        public virtual SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<SignalWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Records a <code>WorkflowExecutionSignaled</code> event in the workflow execution history
        /// and creates a decision task for the workflow execution identified by the given domain,
        /// workflowId and runId. The event is recorded with the specified user defined signalName
        /// and input (if provided).
        /// 
        ///  <note> 
        /// <para>
        /// If a runId isn't specified, then the <code>WorkflowExecutionSignaled</code> event
        /// is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If the specified workflow execution isn't open, this method fails with <code>UnknownResource</code>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignalWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        public virtual Task<SignalWorkflowExecutionResponse> SignalWorkflowExecutionAsync(SignalWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SignalWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkflowExecution


        /// <summary>
        /// Starts an execution of the workflow type in the specified domain using the provided
        /// <code>workflowId</code> and input data.
        /// 
        ///  
        /// <para>
        /// This action returns the newly started workflow execution.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagList.member.0</code>: The key is <code>swf:tagList.member.0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.1</code>: The key is <code>swf:tagList.member.1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.2</code>: The key is <code>swf:tagList.member.2</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.3</code>: The key is <code>swf:tagList.member.3</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.4</code>: The key is <code>swf:tagList.member.4</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>taskList</code>: String constraint. The key is <code>swf:taskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the StartWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DefaultUndefinedException">
        /// The <code>StartWorkflowExecution</code> API action was called without the required
        /// parameters set.
        /// 
        ///  
        /// <para>
        /// Some workflow execution parameters, such as the decision <code>taskList</code>, must
        /// be set to start the execution. However, these parameters might have been set as defaults
        /// when the workflow type was registered. In this case, you can omit these parameters
        /// from the <code>StartWorkflowExecution</code> call and Amazon SWF uses the values defined
        /// in the workflow type.
        /// </para>
        ///  <note> 
        /// <para>
        /// If these parameters aren't set and no default parameters were defined in the workflow
        /// type, this error is displayed.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.WorkflowExecutionAlreadyStartedException">
        /// Returned by <a>StartWorkflowExecution</a> when an open execution with the same workflowId
        /// is already running in the specified domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        public virtual StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Starts an execution of the workflow type in the specified domain using the provided
        /// <code>workflowId</code> and input data.
        /// 
        ///  
        /// <para>
        /// This action returns the newly started workflow execution.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tagList.member.0</code>: The key is <code>swf:tagList.member.0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.1</code>: The key is <code>swf:tagList.member.1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.2</code>: The key is <code>swf:tagList.member.2</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.3</code>: The key is <code>swf:tagList.member.3</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tagList.member.4</code>: The key is <code>swf:tagList.member.4</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>taskList</code>: String constraint. The key is <code>swf:taskList.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DefaultUndefinedException">
        /// The <code>StartWorkflowExecution</code> API action was called without the required
        /// parameters set.
        /// 
        ///  
        /// <para>
        /// Some workflow execution parameters, such as the decision <code>taskList</code>, must
        /// be set to start the execution. However, these parameters might have been set as defaults
        /// when the workflow type was registered. In this case, you can omit these parameters
        /// from the <code>StartWorkflowExecution</code> call and Amazon SWF uses the values defined
        /// in the workflow type.
        /// </para>
        ///  <note> 
        /// <para>
        /// If these parameters aren't set and no default parameters were defined in the workflow
        /// type, this error is displayed.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.WorkflowExecutionAlreadyStartedException">
        /// Returned by <a>StartWorkflowExecution</a> when an open execution with the same workflowId
        /// is already running in the specified domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        public virtual Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a tag to a Amazon SWF domain.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon SWF supports a maximum of 50 tags per resource.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Add a tag to a Amazon SWF domain.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon SWF supports a maximum of 50 tags per resource.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionTerminated</code> event and forces closure of the
        /// workflow execution identified by the given domain, runId, and workflowId. The child
        /// policy, registered with the workflow type or specified when starting this execution,
        /// is applied to any open child workflow executions of this workflow execution.
        /// 
        ///  <important> 
        /// <para>
        /// If the identified workflow execution was in progress, it is terminated immediately.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If a runId isn't specified, then the <code>WorkflowExecutionTerminated</code> event
        /// is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// You should consider using <a>RequestCancelWorkflowExecution</a> action instead because
        /// it allows the workflow to gracefully close while <a>TerminateWorkflowExecution</a>
        /// doesn't.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        public virtual TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Records a <code>WorkflowExecutionTerminated</code> event and forces closure of the
        /// workflow execution identified by the given domain, runId, and workflowId. The child
        /// policy, registered with the workflow type or specified when starting this execution,
        /// is applied to any open child workflow executions of this workflow execution.
        /// 
        ///  <important> 
        /// <para>
        /// If the identified workflow execution was in progress, it is terminated immediately.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If a runId isn't specified, then the <code>WorkflowExecutionTerminated</code> event
        /// is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// You should consider using <a>RequestCancelWorkflowExecution</a> action instead because
        /// it allows the workflow to gracefully close while <a>TerminateWorkflowExecution</a>
        /// doesn't.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        public virtual Task<TerminateWorkflowExecutionResponse> TerminateWorkflowExecutionAsync(TerminateWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UndeprecateActivityType


        /// <summary>
        /// Undeprecates a previously deprecated <i>activity type</i>. After an activity type
        /// has been undeprecated, you can create new tasks of that activity type.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateActivityType service method.</param>
        /// 
        /// <returns>The response from the UndeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateActivityType">REST API Reference for UndeprecateActivityType Operation</seealso>
        public virtual UndeprecateActivityTypeResponse UndeprecateActivityType(UndeprecateActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateActivityTypeResponseUnmarshaller.Instance;

            return Invoke<UndeprecateActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Undeprecates a previously deprecated <i>activity type</i>. After an activity type
        /// has been undeprecated, you can create new tasks of that activity type.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activityType.name</code>: String constraint. The key is <code>swf:activityType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>activityType.version</code>: String constraint. The key is <code>swf:activityType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateActivityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UndeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateActivityType">REST API Reference for UndeprecateActivityType Operation</seealso>
        public virtual Task<UndeprecateActivityTypeResponse> UndeprecateActivityTypeAsync(UndeprecateActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateActivityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UndeprecateActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UndeprecateDomain


        /// <summary>
        /// Undeprecates a previously deprecated domain. After a domain has been undeprecated
        /// it can be used to create new workflow executions or register new types.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateDomain service method.</param>
        /// 
        /// <returns>The response from the UndeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException">
        /// Returned if the domain already exists. You may get this fault if you are registering
        /// a domain that is either already registered or deprecated, or if you undeprecate a
        /// domain that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateDomain">REST API Reference for UndeprecateDomain Operation</seealso>
        public virtual UndeprecateDomainResponse UndeprecateDomain(UndeprecateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateDomainResponseUnmarshaller.Instance;

            return Invoke<UndeprecateDomainResponse>(request, options);
        }


        /// <summary>
        /// Undeprecates a previously deprecated domain. After a domain has been undeprecated
        /// it can be used to create new workflow executions or register new types.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use an IAM policy to constrain this action's parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UndeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException">
        /// Returned if the domain already exists. You may get this fault if you are registering
        /// a domain that is either already registered or deprecated, or if you undeprecate a
        /// domain that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateDomain">REST API Reference for UndeprecateDomain Operation</seealso>
        public virtual Task<UndeprecateDomainResponse> UndeprecateDomainAsync(UndeprecateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<UndeprecateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UndeprecateWorkflowType


        /// <summary>
        /// Undeprecates a previously deprecated <i>workflow type</i>. After a workflow type has
        /// been undeprecated, you can create new executions of that type. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateWorkflowType service method.</param>
        /// 
        /// <returns>The response from the UndeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateWorkflowType">REST API Reference for UndeprecateWorkflowType Operation</seealso>
        public virtual UndeprecateWorkflowTypeResponse UndeprecateWorkflowType(UndeprecateWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<UndeprecateWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Undeprecates a previously deprecated <i>workflow type</i>. After a workflow type has
        /// been undeprecated, you can create new executions of that type. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not exactly
        /// reflect recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
        /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeprecateWorkflowType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UndeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You may get this fault
        /// if you are registering a type that is either already registered or deprecated, or
        /// if you undeprecate a type that is currently registered.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UndeprecateWorkflowType">REST API Reference for UndeprecateWorkflowType Operation</seealso>
        public virtual Task<UndeprecateWorkflowTypeResponse> UndeprecateWorkflowTypeAsync(UndeprecateWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeprecateWorkflowTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UndeprecateWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove a tag from a Amazon SWF domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove a tag from a Amazon SWF domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller doesn't have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}