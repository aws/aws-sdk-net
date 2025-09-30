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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.ElasticMapReduce.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// <para>Implementation for accessing ElasticMapReduce</para>
    ///
    /// Amazon EMR is a web service that makes it easier to process large amounts of data
    /// efficiently. Amazon EMR uses Hadoop processing combined with several Amazon Web Services
    /// services to do tasks such as web indexing, data mining, log file analysis, machine
    /// learning, scientific simulation, and data warehouse management.
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticMapReduceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IElasticMapReducePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticMapReducePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticMapReducePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        public AmazonElasticMapReduceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        public AmazonElasticMapReduceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AmazonElasticMapReduceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials and an
        /// AmazonElasticMapReduceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticMapReduceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticMapReduceEndpointResolver());
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


        #region  AddInstanceFleet

        /// <summary>
        /// Adds an instance fleet to a running cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet service method.</param>
        /// 
        /// <returns>The response from the AddInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual AddInstanceFleetResponse AddInstanceFleet(AddInstanceFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<AddInstanceFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddInstanceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual IAsyncResult BeginAddInstanceFleet(AddInstanceFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceFleet.</param>
        /// 
        /// <returns>Returns a  AddInstanceFleetResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual AddInstanceFleetResponse EndAddInstanceFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<AddInstanceFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  AddInstanceGroups

        /// <summary>
        /// Adds one or more instance groups to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddInstanceGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual IAsyncResult BeginAddInstanceGroups(AddInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceGroups.</param>
        /// 
        /// <returns>Returns a  AddInstanceGroupsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual AddInstanceGroupsResponse EndAddInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<AddInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddJobFlowSteps

        /// <summary>
        /// AddJobFlowSteps adds new steps to a running cluster. A maximum of 256 steps are allowed
        /// in each job flow.
        /// 
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using SSH to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// A step specifies the location of a JAR file stored either on the master node of the
        /// cluster or in Amazon S3. Each step is performed by the main function of the main class
        /// of the JAR file. The main class can be specified either in the manifest of the JAR
        /// or by using the MainFunction parameter of the step.
        /// </para>
        ///  
        /// <para>
        /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
        /// the main function must exit with a zero exit code and all Hadoop jobs started while
        /// the step was running must have completed and run successfully.
        /// </para>
        ///  
        /// <para>
        /// You can only add steps to a cluster that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        ///  <note> 
        /// <para>
        /// The string values passed into <c>HadoopJarStep</c> object cannot exceed a total of
        /// 10240 characters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddJobFlowSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual IAsyncResult BeginAddJobFlowSteps(AddJobFlowStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddJobFlowSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddJobFlowSteps.</param>
        /// 
        /// <returns>Returns a  AddJobFlowStepsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual AddJobFlowStepsResponse EndAddJobFlowSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<AddJobFlowStepsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTags

        /// <summary>
        /// Adds tags to an Amazon EMR resource, such as a cluster or an Amazon EMR Studio. Tags
        /// make it easier to associate resources in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  AddTagsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSteps

        /// <summary>
        /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
        /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
        /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
        /// guarantee that a step will be canceled, even if the request is successfully submitted.
        /// When you use Amazon EMR releases 5.28.0 and later, you can cancel steps that are in
        /// a <c>PENDING</c> or <c>RUNNING</c> state. In earlier versions of Amazon EMR, you can
        /// only cancel steps that are in a <c>PENDING</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps service method.</param>
        /// 
        /// <returns>The response from the CancelSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual CancelStepsResponse CancelSteps(CancelStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return Invoke<CancelStepsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual IAsyncResult BeginCancelSteps(CancelStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSteps.</param>
        /// 
        /// <returns>Returns a  CancelStepsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual CancelStepsResponse EndCancelSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelStepsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePersistentAppUI

        /// <summary>
        /// Creates a persistent application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePersistentAppUI service method.</param>
        /// 
        /// <returns>The response from the CreatePersistentAppUI service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreatePersistentAppUI">REST API Reference for CreatePersistentAppUI Operation</seealso>
        public virtual CreatePersistentAppUIResponse CreatePersistentAppUI(CreatePersistentAppUIRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePersistentAppUIResponseUnmarshaller.Instance;

            return Invoke<CreatePersistentAppUIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePersistentAppUI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePersistentAppUI operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePersistentAppUI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreatePersistentAppUI">REST API Reference for CreatePersistentAppUI Operation</seealso>
        public virtual IAsyncResult BeginCreatePersistentAppUI(CreatePersistentAppUIRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePersistentAppUIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePersistentAppUI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePersistentAppUI.</param>
        /// 
        /// <returns>Returns a  CreatePersistentAppUIResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreatePersistentAppUI">REST API Reference for CreatePersistentAppUI Operation</seealso>
        public virtual CreatePersistentAppUIResponse EndCreatePersistentAppUI(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePersistentAppUIResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityConfiguration

        /// <summary>
        /// Creates a security configuration, which is stored in the service and can be specified
        /// when a cluster is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityConfiguration(CreateSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSecurityConfigurationResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual CreateSecurityConfigurationResponse EndCreateSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStudio

        /// <summary>
        /// Creates a new Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        public virtual CreateStudioResponse CreateStudio(CreateStudioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioResponseUnmarshaller.Instance;

            return Invoke<CreateStudioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        public virtual IAsyncResult BeginCreateStudio(CreateStudioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStudio.</param>
        /// 
        /// <returns>Returns a  CreateStudioResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        public virtual CreateStudioResponse EndCreateStudio(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStudioResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStudioSessionMapping

        /// <summary>
        /// Maps a user or group to the Amazon EMR Studio specified by <c>StudioId</c>, and applies
        /// a session policy to refine Studio permissions for that user or group. Use <c>CreateStudioSessionMapping</c>
        /// to assign users to a Studio when you use IAM Identity Center authentication. For instructions
        /// on how to assign users to a Studio when you use IAM authentication, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-studio-manage-users.html#emr-studio-assign-users-groups">Assign
        /// a user or group to your EMR Studio</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the CreateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        public virtual CreateStudioSessionMappingResponse CreateStudioSessionMapping(CreateStudioSessionMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<CreateStudioSessionMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioSessionMapping operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStudioSessionMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateStudioSessionMapping(CreateStudioSessionMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioSessionMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStudioSessionMapping.</param>
        /// 
        /// <returns>Returns a  CreateStudioSessionMappingResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        public virtual CreateStudioSessionMappingResponse EndCreateStudioSessionMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStudioSessionMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityConfiguration

        /// <summary>
        /// Deletes a security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityConfigurationResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual DeleteSecurityConfigurationResponse EndDeleteSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStudio

        /// <summary>
        /// Removes an Amazon EMR Studio from the Studio metadata store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        public virtual DeleteStudioResponse DeleteStudio(DeleteStudioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioResponseUnmarshaller.Instance;

            return Invoke<DeleteStudioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        public virtual IAsyncResult BeginDeleteStudio(DeleteStudioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudio.</param>
        /// 
        /// <returns>Returns a  DeleteStudioResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        public virtual DeleteStudioResponse EndDeleteStudio(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStudioResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStudioSessionMapping

        /// <summary>
        /// Removes a user or group from an Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        public virtual DeleteStudioSessionMappingResponse DeleteStudioSessionMapping(DeleteStudioSessionMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteStudioSessionMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioSessionMapping operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudioSessionMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteStudioSessionMapping(DeleteStudioSessionMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioSessionMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudioSessionMapping.</param>
        /// 
        /// <returns>Returns a  DeleteStudioSessionMappingResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        public virtual DeleteStudioSessionMappingResponse EndDeleteStudioSessionMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStudioSessionMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }

        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobFlows

        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <c>RUNNING</c>, <c>WAITING</c>, <c>SHUTTING_DOWN</c>, <c>STARTING</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }

        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <c>RUNNING</c>, <c>WAITING</c>, <c>SHUTTING_DOWN</c>, <c>STARTING</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual IAsyncResult BeginDescribeJobFlows(DescribeJobFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobFlows.</param>
        /// 
        /// <returns>Returns a  DescribeJobFlowsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual DescribeJobFlowsResponse EndDescribeJobFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotebookExecution

        /// <summary>
        /// Provides details of a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        public virtual DescribeNotebookExecutionResponse DescribeNotebookExecution(DescribeNotebookExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookExecution operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotebookExecution(DescribeNotebookExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookExecution.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookExecutionResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        public virtual DescribeNotebookExecutionResponse EndDescribeNotebookExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotebookExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePersistentAppUI

        /// <summary>
        /// Describes a persistent application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePersistentAppUI service method.</param>
        /// 
        /// <returns>The response from the DescribePersistentAppUI service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribePersistentAppUI">REST API Reference for DescribePersistentAppUI Operation</seealso>
        public virtual DescribePersistentAppUIResponse DescribePersistentAppUI(DescribePersistentAppUIRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePersistentAppUIResponseUnmarshaller.Instance;

            return Invoke<DescribePersistentAppUIResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePersistentAppUI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePersistentAppUI operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePersistentAppUI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribePersistentAppUI">REST API Reference for DescribePersistentAppUI Operation</seealso>
        public virtual IAsyncResult BeginDescribePersistentAppUI(DescribePersistentAppUIRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePersistentAppUIResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePersistentAppUI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePersistentAppUI.</param>
        /// 
        /// <returns>Returns a  DescribePersistentAppUIResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribePersistentAppUI">REST API Reference for DescribePersistentAppUI Operation</seealso>
        public virtual DescribePersistentAppUIResponse EndDescribePersistentAppUI(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePersistentAppUIResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReleaseLabel

        /// <summary>
        /// Provides Amazon EMR release label details, such as the releases available the Region
        /// where the API request is run, and the available applications for a specific Amazon
        /// EMR release label. Can also list Amazon EMR releases that support a specified version
        /// of Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReleaseLabel service method.</param>
        /// 
        /// <returns>The response from the DescribeReleaseLabel service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        public virtual DescribeReleaseLabelResponse DescribeReleaseLabel(DescribeReleaseLabelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReleaseLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReleaseLabelResponseUnmarshaller.Instance;

            return Invoke<DescribeReleaseLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReleaseLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReleaseLabel operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReleaseLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        public virtual IAsyncResult BeginDescribeReleaseLabel(DescribeReleaseLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReleaseLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReleaseLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReleaseLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReleaseLabel.</param>
        /// 
        /// <returns>Returns a  DescribeReleaseLabelResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        public virtual DescribeReleaseLabelResponse EndDescribeReleaseLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReleaseLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSecurityConfiguration

        /// <summary>
        /// Provides the details of a security configuration by returning the configuration JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual DescribeSecurityConfigurationResponse DescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityConfigurationResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual DescribeSecurityConfigurationResponse EndDescribeSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStep

        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }

        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual IAsyncResult BeginDescribeStep(DescribeStepRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStep.</param>
        /// 
        /// <returns>Returns a  DescribeStepResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual DescribeStepResponse EndDescribeStep(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStepResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStudio

        /// <summary>
        /// Returns details for the specified Amazon EMR Studio including ID, Name, VPC, Studio
        /// access URL, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudio service method.</param>
        /// 
        /// <returns>The response from the DescribeStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        public virtual DescribeStudioResponse DescribeStudio(DescribeStudioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioResponseUnmarshaller.Instance;

            return Invoke<DescribeStudioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudio operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        public virtual IAsyncResult BeginDescribeStudio(DescribeStudioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStudio.</param>
        /// 
        /// <returns>Returns a  DescribeStudioResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        public virtual DescribeStudioResponse EndDescribeStudio(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStudioResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutoTerminationPolicy

        /// <summary>
        /// Returns the auto-termination policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        public virtual GetAutoTerminationPolicyResponse GetAutoTerminationPolicy(GetAutoTerminationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAutoTerminationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoTerminationPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoTerminationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetAutoTerminationPolicy(GetAutoTerminationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoTerminationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoTerminationPolicy.</param>
        /// 
        /// <returns>Returns a  GetAutoTerminationPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        public virtual GetAutoTerminationPolicyResponse EndGetAutoTerminationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutoTerminationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlockPublicAccessConfiguration

        /// <summary>
        /// Returns the Amazon EMR block public access configuration for your Amazon Web Services
        /// account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlockPublicAccessConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        public virtual GetBlockPublicAccessConfigurationResponse GetBlockPublicAccessConfiguration(GetBlockPublicAccessConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBlockPublicAccessConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlockPublicAccessConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlockPublicAccessConfiguration operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlockPublicAccessConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetBlockPublicAccessConfiguration(GetBlockPublicAccessConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlockPublicAccessConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlockPublicAccessConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBlockPublicAccessConfigurationResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        public virtual GetBlockPublicAccessConfigurationResponse EndGetBlockPublicAccessConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlockPublicAccessConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClusterSessionCredentials

        /// <summary>
        /// Provides temporary, HTTP basic credentials that are associated with a given runtime
        /// IAM role and used by a cluster with fine-grained access control activated. You can
        /// use these credentials to connect to cluster endpoints that support username and password
        /// authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSessionCredentials service method.</param>
        /// 
        /// <returns>The response from the GetClusterSessionCredentials service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        public virtual GetClusterSessionCredentialsResponse GetClusterSessionCredentials(GetClusterSessionCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSessionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSessionCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetClusterSessionCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterSessionCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSessionCredentials operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterSessionCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetClusterSessionCredentials(GetClusterSessionCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSessionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSessionCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterSessionCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterSessionCredentials.</param>
        /// 
        /// <returns>Returns a  GetClusterSessionCredentialsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        public virtual GetClusterSessionCredentialsResponse EndGetClusterSessionCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterSessionCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedScalingPolicy

        /// <summary>
        /// Fetches the attached managed scaling policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the GetManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        public virtual GetManagedScalingPolicyResponse GetManagedScalingPolicy(GetManagedScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetManagedScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedScalingPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetManagedScalingPolicy(GetManagedScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedScalingPolicy.</param>
        /// 
        /// <returns>Returns a  GetManagedScalingPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        public virtual GetManagedScalingPolicyResponse EndGetManagedScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOnClusterAppUIPresignedURL

        /// <summary>
        /// The presigned URL properties for the cluster's application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnClusterAppUIPresignedURL service method.</param>
        /// 
        /// <returns>The response from the GetOnClusterAppUIPresignedURL service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetOnClusterAppUIPresignedURL">REST API Reference for GetOnClusterAppUIPresignedURL Operation</seealso>
        public virtual GetOnClusterAppUIPresignedURLResponse GetOnClusterAppUIPresignedURL(GetOnClusterAppUIPresignedURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOnClusterAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnClusterAppUIPresignedURLResponseUnmarshaller.Instance;

            return Invoke<GetOnClusterAppUIPresignedURLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOnClusterAppUIPresignedURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOnClusterAppUIPresignedURL operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOnClusterAppUIPresignedURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetOnClusterAppUIPresignedURL">REST API Reference for GetOnClusterAppUIPresignedURL Operation</seealso>
        public virtual IAsyncResult BeginGetOnClusterAppUIPresignedURL(GetOnClusterAppUIPresignedURLRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOnClusterAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnClusterAppUIPresignedURLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOnClusterAppUIPresignedURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOnClusterAppUIPresignedURL.</param>
        /// 
        /// <returns>Returns a  GetOnClusterAppUIPresignedURLResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetOnClusterAppUIPresignedURL">REST API Reference for GetOnClusterAppUIPresignedURL Operation</seealso>
        public virtual GetOnClusterAppUIPresignedURLResponse EndGetOnClusterAppUIPresignedURL(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOnClusterAppUIPresignedURLResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPersistentAppUIPresignedURL

        /// <summary>
        /// The presigned URL properties for the cluster's application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersistentAppUIPresignedURL service method.</param>
        /// 
        /// <returns>The response from the GetPersistentAppUIPresignedURL service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetPersistentAppUIPresignedURL">REST API Reference for GetPersistentAppUIPresignedURL Operation</seealso>
        public virtual GetPersistentAppUIPresignedURLResponse GetPersistentAppUIPresignedURL(GetPersistentAppUIPresignedURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPersistentAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersistentAppUIPresignedURLResponseUnmarshaller.Instance;

            return Invoke<GetPersistentAppUIPresignedURLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersistentAppUIPresignedURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersistentAppUIPresignedURL operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPersistentAppUIPresignedURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetPersistentAppUIPresignedURL">REST API Reference for GetPersistentAppUIPresignedURL Operation</seealso>
        public virtual IAsyncResult BeginGetPersistentAppUIPresignedURL(GetPersistentAppUIPresignedURLRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPersistentAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersistentAppUIPresignedURLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPersistentAppUIPresignedURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPersistentAppUIPresignedURL.</param>
        /// 
        /// <returns>Returns a  GetPersistentAppUIPresignedURLResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetPersistentAppUIPresignedURL">REST API Reference for GetPersistentAppUIPresignedURL Operation</seealso>
        public virtual GetPersistentAppUIPresignedURLResponse EndGetPersistentAppUIPresignedURL(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPersistentAppUIPresignedURLResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStudioSessionMapping

        /// <summary>
        /// Fetches mapping details for the specified Amazon EMR Studio and identity (user or
        /// group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the GetStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        public virtual GetStudioSessionMappingResponse GetStudioSessionMapping(GetStudioSessionMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<GetStudioSessionMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStudioSessionMapping operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStudioSessionMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        public virtual IAsyncResult BeginGetStudioSessionMapping(GetStudioSessionMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStudioSessionMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStudioSessionMapping.</param>
        /// 
        /// <returns>Returns a  GetStudioSessionMappingResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        public virtual GetStudioSessionMappingResponse EndGetStudioSessionMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStudioSessionMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBootstrapActions

        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }

        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBootstrapActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual IAsyncResult BeginListBootstrapActions(ListBootstrapActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBootstrapActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBootstrapActions.</param>
        /// 
        /// <returns>Returns a  ListBootstrapActionsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual ListBootstrapActionsResponse EndListBootstrapActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBootstrapActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }

        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceFleets

        /// <summary>
        /// Lists all available details about the instance fleets in a cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets service method.</param>
        /// 
        /// <returns>The response from the ListInstanceFleets service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual ListInstanceFleetsResponse ListInstanceFleets(ListInstanceFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual IAsyncResult BeginListInstanceFleets(ListInstanceFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceFleets.</param>
        /// 
        /// <returns>Returns a  ListInstanceFleetsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual ListInstanceFleetsResponse EndListInstanceFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceGroups

        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }

        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual IAsyncResult BeginListInstanceGroups(ListInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ListInstanceGroupsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual ListInstanceGroupsResponse EndListInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Provides information for all active Amazon EC2 instances and Amazon EC2 instances
        /// terminated in the last 30 days, up to a maximum of 2,000. Amazon EC2 instances in
        /// any of the following states are considered active: AWAITING_FULFILLMENT, PROVISIONING,
        /// BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }

        /// <summary>
        /// Provides information for all active Amazon EC2 instances and Amazon EC2 instances
        /// terminated in the last 30 days, up to a maximum of 2,000. Amazon EC2 instances in
        /// any of the following states are considered active: AWAITING_FULFILLMENT, PROVISIONING,
        /// BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotebookExecutions

        /// <summary>
        /// Provides summaries of all notebook executions. You can filter the list based on multiple
        /// criteria such as status, time range, and editor id. Returns a maximum of 50 notebook
        /// executions and a marker to track the paging of a longer notebook execution list across
        /// multiple <c>ListNotebookExecutions</c> calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookExecutions service method.</param>
        /// 
        /// <returns>The response from the ListNotebookExecutions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        public virtual ListNotebookExecutionsResponse ListNotebookExecutions(ListNotebookExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotebookExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookExecutions operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        public virtual IAsyncResult BeginListNotebookExecutions(ListNotebookExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotebookExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookExecutions.</param>
        /// 
        /// <returns>Returns a  ListNotebookExecutionsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        public virtual ListNotebookExecutionsResponse EndListNotebookExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotebookExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReleaseLabels

        /// <summary>
        /// Retrieves release labels of Amazon EMR services in the Region where the API is called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReleaseLabels service method.</param>
        /// 
        /// <returns>The response from the ListReleaseLabels service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        public virtual ListReleaseLabelsResponse ListReleaseLabels(ListReleaseLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReleaseLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReleaseLabelsResponseUnmarshaller.Instance;

            return Invoke<ListReleaseLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReleaseLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReleaseLabels operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReleaseLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        public virtual IAsyncResult BeginListReleaseLabels(ListReleaseLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReleaseLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReleaseLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReleaseLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReleaseLabels.</param>
        /// 
        /// <returns>Returns a  ListReleaseLabelsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        public virtual ListReleaseLabelsResponse EndListReleaseLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReleaseLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityConfigurations

        /// <summary>
        /// Lists all the security configurations visible to this account, providing their creation
        /// dates and times, and their names. This call returns a maximum of 50 clusters per call,
        /// but returns a marker to track the paging of the cluster list across multiple ListSecurityConfigurations
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListSecurityConfigurations service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual ListSecurityConfigurationsResponse ListSecurityConfigurations(ListSecurityConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListSecurityConfigurations(ListSecurityConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityConfigurations.</param>
        /// 
        /// <returns>Returns a  ListSecurityConfigurationsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual ListSecurityConfigurationsResponse EndListSecurityConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSteps

        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <c>stepIds</c>
        /// with the request or filter by <c>StepStates</c>. You can specify a maximum of 10 <c>stepIDs</c>.
        /// The CLI automatically paginates results to return a list greater than 50 steps. To
        /// return more than 50 steps using the CLI, specify a <c>Marker</c>, which is a pagination
        /// token that indicates the next set of steps to retrieve.
        /// </summary>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }

        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <c>stepIds</c>
        /// with the request or filter by <c>StepStates</c>. You can specify a maximum of 10 <c>stepIDs</c>.
        /// The CLI automatically paginates results to return a list greater than 50 steps. To
        /// return more than 50 steps using the CLI, specify a <c>Marker</c>, which is a pagination
        /// token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual IAsyncResult BeginListSteps(ListStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a  ListStepsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual ListStepsResponse EndListSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStepsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStudios

        /// <summary>
        /// Returns a list of all Amazon EMR Studios associated with the Amazon Web Services account.
        /// The list includes details such as ID, Studio Access URL, and creation time for each
        /// Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        public virtual ListStudiosResponse ListStudios(ListStudiosRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStudiosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudiosResponseUnmarshaller.Instance;

            return Invoke<ListStudiosResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStudios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudios operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudios
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        public virtual IAsyncResult BeginListStudios(ListStudiosRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStudiosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudiosResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudios.</param>
        /// 
        /// <returns>Returns a  ListStudiosResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        public virtual ListStudiosResponse EndListStudios(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStudiosResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStudioSessionMappings

        /// <summary>
        /// Returns a list of all user or group session mappings for the Amazon EMR Studio specified
        /// by <c>StudioId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioSessionMappings service method.</param>
        /// 
        /// <returns>The response from the ListStudioSessionMappings service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        public virtual ListStudioSessionMappingsResponse ListStudioSessionMappings(ListStudioSessionMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStudioSessionMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioSessionMappingsResponseUnmarshaller.Instance;

            return Invoke<ListStudioSessionMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStudioSessionMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudioSessionMappings operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudioSessionMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        public virtual IAsyncResult BeginListStudioSessionMappings(ListStudioSessionMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStudioSessionMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioSessionMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudioSessionMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudioSessionMappings.</param>
        /// 
        /// <returns>Returns a  ListStudioSessionMappingsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        public virtual ListStudioSessionMappingsResponse EndListStudioSessionMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStudioSessionMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSupportedInstanceTypes

        /// <summary>
        /// A list of the instance types that Amazon EMR supports. You can filter the list by
        /// Amazon Web Services Region and Amazon EMR release.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListSupportedInstanceTypes service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSupportedInstanceTypes">REST API Reference for ListSupportedInstanceTypes Operation</seealso>
        public virtual ListSupportedInstanceTypesResponse ListSupportedInstanceTypes(ListSupportedInstanceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListSupportedInstanceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSupportedInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedInstanceTypes operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSupportedInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSupportedInstanceTypes">REST API Reference for ListSupportedInstanceTypes Operation</seealso>
        public virtual IAsyncResult BeginListSupportedInstanceTypes(ListSupportedInstanceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedInstanceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSupportedInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSupportedInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListSupportedInstanceTypesResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSupportedInstanceTypes">REST API Reference for ListSupportedInstanceTypes Operation</seealso>
        public virtual ListSupportedInstanceTypesResponse EndListSupportedInstanceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSupportedInstanceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyCluster

        /// <summary>
        /// Modifies the number of steps that can be executed concurrently for the cluster specified
        /// using ClusterID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a  ModifyClusterResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyInstanceFleet

        /// <summary>
        /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
        /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
        /// either succeeds or fails atomically.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual ModifyInstanceFleetResponse ModifyInstanceFleet(ModifyInstanceFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual IAsyncResult BeginModifyInstanceFleet(ModifyInstanceFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceFleet.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceFleetResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual ModifyInstanceFleetResponse EndModifyInstanceFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstanceFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyInstanceGroups

        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance group. The input parameters include the new target instance count for the
        /// group and the instance group ID. The call will either succeed or fail atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual IAsyncResult BeginModifyInstanceGroups(ModifyInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceGroupsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual ModifyInstanceGroupsResponse EndModifyInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAutoScalingPolicy

        /// <summary>
        /// Creates or updates an automatic scaling policy for a core instance group or task instance
        /// group in an Amazon EMR cluster. The automatic scaling policy defines how an instance
        /// group dynamically adds and terminates Amazon EC2 instances in response to the value
        /// of a CloudWatch metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAutoScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutAutoScalingPolicy(PutAutoScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAutoScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutAutoScalingPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual PutAutoScalingPolicyResponse EndPutAutoScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAutoScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAutoTerminationPolicy

        /// <summary>
        /// <note> 
        /// <para>
        /// Auto-termination is supported in Amazon EMR releases 5.30.0 and 6.1.0 and later. For
        /// more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-auto-termination-policy.html">Using
        /// an auto-termination policy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or updates an auto-termination policy for an Amazon EMR cluster. An auto-termination
        /// policy defines the amount of idle time in seconds after which a cluster automatically
        /// terminates. For alternative cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
        /// cluster termination</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        public virtual PutAutoTerminationPolicyResponse PutAutoTerminationPolicy(PutAutoTerminationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoTerminationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAutoTerminationPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAutoTerminationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutAutoTerminationPolicy(PutAutoTerminationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoTerminationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAutoTerminationPolicy.</param>
        /// 
        /// <returns>Returns a  PutAutoTerminationPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        public virtual PutAutoTerminationPolicyResponse EndPutAutoTerminationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAutoTerminationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBlockPublicAccessConfiguration

        /// <summary>
        /// Creates or updates an Amazon EMR block public access configuration for your Amazon
        /// Web Services account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBlockPublicAccessConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        public virtual PutBlockPublicAccessConfigurationResponse PutBlockPublicAccessConfiguration(PutBlockPublicAccessConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBlockPublicAccessConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBlockPublicAccessConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBlockPublicAccessConfiguration operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBlockPublicAccessConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutBlockPublicAccessConfiguration(PutBlockPublicAccessConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBlockPublicAccessConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBlockPublicAccessConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBlockPublicAccessConfigurationResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        public virtual PutBlockPublicAccessConfigurationResponse EndPutBlockPublicAccessConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBlockPublicAccessConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutManagedScalingPolicy

        /// <summary>
        /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed
        /// scaling policy defines the limits for resources, such as Amazon EC2 instances that
        /// can be added or terminated from a cluster. The policy only applies to the core and
        /// task nodes. The master node cannot be scaled after initial configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        public virtual PutManagedScalingPolicyResponse PutManagedScalingPolicy(PutManagedScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutManagedScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutManagedScalingPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutManagedScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutManagedScalingPolicy(PutManagedScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutManagedScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutManagedScalingPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        public virtual PutManagedScalingPolicyResponse EndPutManagedScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutManagedScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAutoScalingPolicy

        /// <summary>
        /// Removes an automatic scaling policy from a specified instance group within an Amazon
        /// EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAutoScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginRemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAutoScalingPolicy.</param>
        /// 
        /// <returns>Returns a  RemoveAutoScalingPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual RemoveAutoScalingPolicyResponse EndRemoveAutoScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAutoScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAutoTerminationPolicy

        /// <summary>
        /// Removes an auto-termination policy from an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        public virtual RemoveAutoTerminationPolicyResponse RemoveAutoTerminationPolicy(RemoveAutoTerminationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoTerminationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoTerminationPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAutoTerminationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        public virtual IAsyncResult BeginRemoveAutoTerminationPolicy(RemoveAutoTerminationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoTerminationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAutoTerminationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAutoTerminationPolicy.</param>
        /// 
        /// <returns>Returns a  RemoveAutoTerminationPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        public virtual RemoveAutoTerminationPolicyResponse EndRemoveAutoTerminationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAutoTerminationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveManagedScalingPolicy

        /// <summary>
        /// Removes a managed scaling policy from a specified Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        public virtual RemoveManagedScalingPolicyResponse RemoveManagedScalingPolicy(RemoveManagedScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveManagedScalingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveManagedScalingPolicy operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveManagedScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginRemoveManagedScalingPolicy(RemoveManagedScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveManagedScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveManagedScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveManagedScalingPolicy.</param>
        /// 
        /// <returns>Returns a  RemoveManagedScalingPolicyResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        public virtual RemoveManagedScalingPolicyResponse EndRemoveManagedScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveManagedScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTags

        /// <summary>
        /// Removes tags from an Amazon EMR resource, such as a cluster or Amazon EMR Studio.
        /// Tags make it easier to associate resources in various ways, such as grouping clusters
        /// to track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>. 
        /// 
        ///  
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  RunJobFlow

        /// <summary>
        /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
        /// steps specified. After the steps complete, the cluster stops and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <c>KeepJobFlowAliveWhenNoSteps</c>
        /// parameter is set to <c>TRUE</c>, the cluster transitions to the WAITING state rather
        /// than shutting down after the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <c>TerminationProtected</c>
        /// parameter to <c>TRUE</c> to lock the cluster and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// For long-running clusters, we recommend that you periodically store your results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleets configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
        /// parameters or InstanceGroups parameters, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunJobFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual IAsyncResult BeginRunJobFlow(RunJobFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunJobFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunJobFlow.</param>
        /// 
        /// <returns>Returns a  RunJobFlowResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual RunJobFlowResponse EndRunJobFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<RunJobFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  SetKeepJobFlowAliveWhenNoSteps

        /// <summary>
        /// You can use the <c>SetKeepJobFlowAliveWhenNoSteps</c> to configure a cluster (job
        /// flow) to terminate after the step execution, i.e., all your steps are executed. If
        /// you want a transient cluster that shuts down after the last of the current executing
        /// steps are completed, you can configure <c>SetKeepJobFlowAliveWhenNoSteps</c> to false.
        /// If you want a long running cluster, configure <c>SetKeepJobFlowAliveWhenNoSteps</c>
        /// to true.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetKeepJobFlowAliveWhenNoSteps service method.</param>
        /// 
        /// <returns>The response from the SetKeepJobFlowAliveWhenNoSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetKeepJobFlowAliveWhenNoSteps">REST API Reference for SetKeepJobFlowAliveWhenNoSteps Operation</seealso>
        public virtual SetKeepJobFlowAliveWhenNoStepsResponse SetKeepJobFlowAliveWhenNoSteps(SetKeepJobFlowAliveWhenNoStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetKeepJobFlowAliveWhenNoStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetKeepJobFlowAliveWhenNoStepsResponseUnmarshaller.Instance;

            return Invoke<SetKeepJobFlowAliveWhenNoStepsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetKeepJobFlowAliveWhenNoSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetKeepJobFlowAliveWhenNoSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetKeepJobFlowAliveWhenNoSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetKeepJobFlowAliveWhenNoSteps">REST API Reference for SetKeepJobFlowAliveWhenNoSteps Operation</seealso>
        public virtual IAsyncResult BeginSetKeepJobFlowAliveWhenNoSteps(SetKeepJobFlowAliveWhenNoStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetKeepJobFlowAliveWhenNoStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetKeepJobFlowAliveWhenNoStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetKeepJobFlowAliveWhenNoSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetKeepJobFlowAliveWhenNoSteps.</param>
        /// 
        /// <returns>Returns a  SetKeepJobFlowAliveWhenNoStepsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetKeepJobFlowAliveWhenNoSteps">REST API Reference for SetKeepJobFlowAliveWhenNoSteps Operation</seealso>
        public virtual SetKeepJobFlowAliveWhenNoStepsResponse EndSetKeepJobFlowAliveWhenNoSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<SetKeepJobFlowAliveWhenNoStepsResponse>(asyncResult);
        }

        #endregion
        
        #region  SetTerminationProtection

        /// <summary>
        /// SetTerminationProtection locks a cluster (job flow) so the Amazon EC2 instances in
        /// the cluster cannot be terminated by user intervention, an API call, or in the event
        /// of a job-flow error. The cluster still terminates upon successful completion of the
        /// job flow. Calling <c>SetTerminationProtection</c> on a cluster is similar to calling
        /// the Amazon EC2 <c>DisableAPITermination</c> API on all Amazon EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  <c>SetTerminationProtection</c> is used to prevent accidental termination of a cluster
        /// and to ensure that in the event of an error, the instances persist so that you can
        /// recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a cluster that has been locked by setting <c>SetTerminationProtection</c>
        /// to <c>true</c>, you must first unlock the job flow by a subsequent call to <c>SetTerminationProtection</c>
        /// in which you set the value to <c>false</c>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTerminationProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual IAsyncResult BeginSetTerminationProtection(SetTerminationProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTerminationProtection.</param>
        /// 
        /// <returns>Returns a  SetTerminationProtectionResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual SetTerminationProtectionResponse EndSetTerminationProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTerminationProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  SetUnhealthyNodeReplacement

        /// <summary>
        /// Specify whether to enable unhealthy node replacement, which lets Amazon EMR gracefully
        /// replace core nodes on a cluster if any nodes become unhealthy. For example, a node
        /// becomes unhealthy if disk usage is above 90%. If unhealthy node replacement is on
        /// and <c>TerminationProtected</c> are off, Amazon EMR immediately terminates the unhealthy
        /// core nodes. To use unhealthy node replacement and retain unhealthy core nodes, use
        /// to turn on termination protection. In such cases, Amazon EMR adds the unhealthy nodes
        /// to a denylist, reducing job interruptions and failures.
        /// 
        ///  
        /// <para>
        /// If unhealthy node replacement is on, Amazon EMR notifies YARN and other applications
        /// on the cluster to stop scheduling tasks with these nodes, moves the data, and then
        /// terminates the nodes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-node-replacement.html">graceful
        /// node replacement</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUnhealthyNodeReplacement service method.</param>
        /// 
        /// <returns>The response from the SetUnhealthyNodeReplacement service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetUnhealthyNodeReplacement">REST API Reference for SetUnhealthyNodeReplacement Operation</seealso>
        public virtual SetUnhealthyNodeReplacementResponse SetUnhealthyNodeReplacement(SetUnhealthyNodeReplacementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetUnhealthyNodeReplacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUnhealthyNodeReplacementResponseUnmarshaller.Instance;

            return Invoke<SetUnhealthyNodeReplacementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUnhealthyNodeReplacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUnhealthyNodeReplacement operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetUnhealthyNodeReplacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetUnhealthyNodeReplacement">REST API Reference for SetUnhealthyNodeReplacement Operation</seealso>
        public virtual IAsyncResult BeginSetUnhealthyNodeReplacement(SetUnhealthyNodeReplacementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetUnhealthyNodeReplacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUnhealthyNodeReplacementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetUnhealthyNodeReplacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetUnhealthyNodeReplacement.</param>
        /// 
        /// <returns>Returns a  SetUnhealthyNodeReplacementResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetUnhealthyNodeReplacement">REST API Reference for SetUnhealthyNodeReplacement Operation</seealso>
        public virtual SetUnhealthyNodeReplacementResponse EndSetUnhealthyNodeReplacement(IAsyncResult asyncResult)
        {
            return EndInvoke<SetUnhealthyNodeReplacementResponse>(asyncResult);
        }

        #endregion
        
        #region  SetVisibleToAllUsers

        /// <summary>
        /// <important> 
        /// <para>
        /// The SetVisibleToAllUsers parameter is no longer supported. Your cluster may be visible
        /// to all users in your account. To restrict cluster access using an IAM policy, see
        /// <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-access-IAM.html">Identity
        /// and Access Management for Amazon EMR</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Sets the <a>Cluster$VisibleToAllUsers</a> value for an Amazon EMR cluster. When <c>true</c>,
        /// IAM principals in the Amazon Web Services account can perform Amazon EMR cluster actions
        /// that their IAM policies allow. When <c>false</c>, only the IAM principal that created
        /// the cluster and the Amazon Web Services account root user can perform Amazon EMR actions
        /// on the cluster, regardless of IAM permissions policies attached to other IAM principals.
        /// </para>
        ///  
        /// <para>
        /// This action works on running clusters. When you create a cluster, use the <a>RunJobFlowInput$VisibleToAllUsers</a>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_IAM_emr-with-IAM.html#security_set_visible_to_all_users">Understanding
        /// the Amazon EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMR Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetVisibleToAllUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual IAsyncResult BeginSetVisibleToAllUsers(SetVisibleToAllUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetVisibleToAllUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVisibleToAllUsers.</param>
        /// 
        /// <returns>Returns a  SetVisibleToAllUsersResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual SetVisibleToAllUsersResponse EndSetVisibleToAllUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<SetVisibleToAllUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  StartNotebookExecution

        /// <summary>
        /// Starts a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the StartNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        public virtual StartNotebookExecutionResponse StartNotebookExecution(StartNotebookExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<StartNotebookExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookExecution operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNotebookExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        public virtual IAsyncResult BeginStartNotebookExecution(StartNotebookExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNotebookExecution.</param>
        /// 
        /// <returns>Returns a  StartNotebookExecutionResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        public virtual StartNotebookExecutionResponse EndStartNotebookExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartNotebookExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopNotebookExecution

        /// <summary>
        /// Stops a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the StopNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        public virtual StopNotebookExecutionResponse StopNotebookExecution(StopNotebookExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<StopNotebookExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookExecution operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopNotebookExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        public virtual IAsyncResult BeginStopNotebookExecution(StopNotebookExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopNotebookExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopNotebookExecution.</param>
        /// 
        /// <returns>Returns a  StopNotebookExecutionResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        public virtual StopNotebookExecutionResponse EndStopNotebookExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopNotebookExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateJobFlows

        /// <summary>
        /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
        /// down, any step not yet completed is canceled and the Amazon EC2 instances on which
        /// the cluster is running are stopped. Any log files not already saved are uploaded to
        /// Amazon S3 if a LogUri was specified when the cluster was created.
        /// 
        ///  
        /// <para>
        /// The maximum number of clusters allowed is 10. The call to <c>TerminateJobFlows</c>
        /// is asynchronous. Depending on the configuration of the cluster, it may take up to
        /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
        /// such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateJobFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual IAsyncResult BeginTerminateJobFlows(TerminateJobFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateJobFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJobFlows.</param>
        /// 
        /// <returns>Returns a  TerminateJobFlowsResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual TerminateJobFlowsResponse EndTerminateJobFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateJobFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStudio

        /// <summary>
        /// Updates an Amazon EMR Studio configuration, including attributes such as name, description,
        /// and subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        public virtual UpdateStudioResponse UpdateStudio(UpdateStudioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioResponseUnmarshaller.Instance;

            return Invoke<UpdateStudioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        public virtual IAsyncResult BeginUpdateStudio(UpdateStudioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStudio.</param>
        /// 
        /// <returns>Returns a  UpdateStudioResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        public virtual UpdateStudioResponse EndUpdateStudio(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStudioResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStudioSessionMapping

        /// <summary>
        /// Updates the session policy attached to the user or group for the specified Amazon
        /// EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        public virtual UpdateStudioSessionMappingResponse UpdateStudioSessionMapping(UpdateStudioSessionMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateStudioSessionMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioSessionMapping operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStudioSessionMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateStudioSessionMapping(UpdateStudioSessionMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioSessionMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStudioSessionMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStudioSessionMapping.</param>
        /// 
        /// <returns>Returns a  UpdateStudioSessionMappingResult from ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        public virtual UpdateStudioSessionMappingResponse EndUpdateStudioSessionMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStudioSessionMappingResponse>(asyncResult);
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
            var resolver = new AmazonElasticMapReduceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}