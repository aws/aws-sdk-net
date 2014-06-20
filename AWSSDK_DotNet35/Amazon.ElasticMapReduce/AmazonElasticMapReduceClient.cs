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


using System;
using System.Threading;

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Implementation for accessing ElasticMapReduce
    ///
    /// This is the <i>Amazon Elastic MapReduce API Reference</i>. This guide provides descriptions
    /// and         samples of the Amazon Elastic MapReduce APIs.
    /// 
    ///       
    /// <para>
    /// Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to process
    /// large amounts of         data efficiently. Amazon EMR uses Hadoop processing combined
    /// with several AWS         products to do tasks such as web indexing, data mining, log
    /// file analysis, machine         learning, scientific simulation, and data warehousing.
    /// </para>
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonWebServiceClient, IAmazonElasticMapReduce
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AddInstanceGroups


        /// <summary>
        /// AddInstanceGroups adds an instance group to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeAddInstanceGroups(request, null, null, true);
            return EndAddInstanceGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddInstanceGroups
        ///         operation.</returns>
        public IAsyncResult BeginAddInstanceGroups(AddInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeAddInstanceGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceGroups.</param>
        /// 
        /// <returns>Returns a  AddInstanceGroupsResult from ElasticMapReduce.</returns>
        public  AddInstanceGroupsResponse EndAddInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation< AddInstanceGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeAddInstanceGroups(AddInstanceGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddInstanceGroupsRequestMarshaller().Marshall(request);
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  AddJobFlowSteps


        /// <summary>
        /// AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are
        /// allowed      in each job flow. 
        /// 
        ///       
        /// <para>
        /// If your job flow is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add
        /// More than 256 Steps to a Job Flow</a> in the <i>Amazon Elastic MapReduce Developer's
        /// Guide</i>.
        /// </para>
        ///       
        /// <para>
        ///  A step specifies the location of a JAR file stored either on the master node of the
        /// job         flow or in Amazon S3. Each step is performed by the main function of the
        /// main class of the         JAR file. The main class can be specified either in the
        /// manifest of the JAR or by using the         MainFunction parameter of the step. 
        /// </para>
        ///       
        /// <para>
        ///  Elastic MapReduce executes each step in the order listed. For a step to be considered
        ///         complete, the main function must exit with a zero exit code and all Hadoop
        /// jobs started         while the step was running must have completed and run successfully.
        /// 
        /// </para>
        ///       
        /// <para>
        ///  You can only add steps to a job flow that is in one of the following states: STARTING,
        ///      BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            IAsyncResult asyncResult = invokeAddJobFlowSteps(request, null, null, true);
            return EndAddJobFlowSteps(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddJobFlowSteps
        ///         operation.</returns>
        public IAsyncResult BeginAddJobFlowSteps(AddJobFlowStepsRequest request, AsyncCallback callback, object state)
        {
            return invokeAddJobFlowSteps(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddJobFlowSteps.</param>
        /// 
        /// <returns>Returns a  AddJobFlowStepsResult from ElasticMapReduce.</returns>
        public  AddJobFlowStepsResponse EndAddJobFlowSteps(IAsyncResult asyncResult)
        {
            return endOperation< AddJobFlowStepsResponse>(asyncResult);
        }

        IAsyncResult invokeAddJobFlowSteps(AddJobFlowStepsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddJobFlowStepsRequestMarshaller().Marshall(request);
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in
        /// various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs.                  For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
        /// Amazon EMR Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            IAsyncResult asyncResult = invokeAddTags(request, null, null, true);
            return EndAddTags(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        public IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            return invokeAddTags(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from ElasticMapReduce.</returns>
        public  AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return endOperation< AddTagsResponse>(asyncResult);
        }

        IAsyncResult invokeAddTags(AddTagsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddTagsRequestMarshaller().Marshall(request);
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on. For information about the cluster steps, see <a>ListSteps</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }

        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on. For information about the cluster steps, see <a>ListSteps</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCluster(request, null, null, true);
            return EndDescribeCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from ElasticMapReduce.</returns>
        public  DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeClusterRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeJobFlows

        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        ///         <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        ///         instead.
        /// 
        ///       
        /// <para>
        ///  DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        ///         The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job         flow creation date and time.
        /// </para>
        ///       
        /// <para>
        ///  Regardless of supplied parameters, only job flows created within the last two months
        /// are         returned.
        /// </para>
        ///       
        /// <para>
        ///  If no parameters are supplied, then job flows matching either of the following criteria
        ///         are returned:
        /// </para>
        ///       <ul>         <li>Job flows created and completed in the last two weeks</li>
        ///         <li> Job flows created within the last two months that are in one of the following
        /// states:               <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>,
        ///               <code>STARTING</code>         </li>      </ul>      
        /// <para>
        ///  Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }

        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        ///         <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        ///         instead.
        /// 
        ///       
        /// <para>
        ///  DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        ///         The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job         flow creation date and time.
        /// </para>
        ///       
        /// <para>
        ///  Regardless of supplied parameters, only job flows created within the last two months
        /// are         returned.
        /// </para>
        ///       
        /// <para>
        ///  If no parameters are supplied, then job flows matching either of the following criteria
        ///         are returned:
        /// </para>
        ///       <ul>         <li>Job flows created and completed in the last two weeks</li>
        ///         <li> Job flows created within the last two months that are in one of the following
        /// states:               <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>,
        ///               <code>STARTING</code>         </li>      </ul>      
        /// <para>
        ///  Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeJobFlows(request, null, null, true);
            return EndDescribeJobFlows(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobFlows
        ///         operation.</returns>
        public IAsyncResult BeginDescribeJobFlows(DescribeJobFlowsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeJobFlows(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobFlows.</param>
        /// 
        /// <returns>Returns a  DescribeJobFlowsResult from ElasticMapReduce.</returns>
        public  DescribeJobFlowsResponse EndDescribeJobFlows(IAsyncResult asyncResult)
        {
            return endOperation< DescribeJobFlowsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeJobFlows(DescribeJobFlowsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeJobFlowsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeStep

        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }

        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeStep(request, null, null, true);
            return EndDescribeStep(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStep
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStep(DescribeStepRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeStep(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStep.</param>
        /// 
        /// <returns>Returns a  DescribeStepResult from ElasticMapReduce.</returns>
        public  DescribeStepResponse EndDescribeStep(IAsyncResult asyncResult)
        {
            return endOperation< DescribeStepResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeStep(DescribeStepRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStepRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListBootstrapActions

        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }

        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            IAsyncResult asyncResult = invokeListBootstrapActions(request, null, null, true);
            return EndListBootstrapActions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBootstrapActions
        ///         operation.</returns>
        public IAsyncResult BeginListBootstrapActions(ListBootstrapActionsRequest request, AsyncCallback callback, object state)
        {
            return invokeListBootstrapActions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBootstrapActions.</param>
        /// 
        /// <returns>Returns a  ListBootstrapActionsResult from ElasticMapReduce.</returns>
        public  ListBootstrapActionsResponse EndListBootstrapActions(IAsyncResult asyncResult)
        {
            return endOperation< ListBootstrapActionsResponse>(asyncResult);
        }

        IAsyncResult invokeListBootstrapActions(ListBootstrapActionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListBootstrapActionsRequestMarshaller().Marshall(request);
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status.         This call returns a maximum of 50 clusters
        /// per call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }

        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status.         This call returns a maximum of 50 clusters
        /// per call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            IAsyncResult asyncResult = invokeListClusters(request, null, null, true);
            return EndListClusters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        public IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            return invokeListClusters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from ElasticMapReduce.</returns>
        public  ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return endOperation< ListClustersResponse>(asyncResult);
        }

        IAsyncResult invokeListClusters(ListClustersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListClustersRequestMarshaller().Marshall(request);
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListInstanceGroups

        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }

        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeListInstanceGroups(request, null, null, true);
            return EndListInstanceGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceGroups
        ///         operation.</returns>
        public IAsyncResult BeginListInstanceGroups(ListInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeListInstanceGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ListInstanceGroupsResult from ElasticMapReduce.</returns>
        public  ListInstanceGroupsResponse EndListInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation< ListInstanceGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeListInstanceGroups(ListInstanceGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstanceGroupsRequestMarshaller().Marshall(request);
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Provides information about the cluster instances that Amazon EMR provisions on behalf
        /// of a user when it creates the cluster.          For example, this operation indicates
        /// when the EC2 instances reach the Ready state, when instances become available to Amazon
        /// EMR to use for jobs, and the IP addresses for cluster instances, etc.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }

        /// <summary>
        /// Provides information about the cluster instances that Amazon EMR provisions on behalf
        /// of a user when it creates the cluster.          For example, this operation indicates
        /// when the EC2 instances reach the Ready state, when instances become available to Amazon
        /// EMR to use for jobs, and the IP addresses for cluster instances, etc.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeListInstances(request, null, null, true);
            return EndListInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        public IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeListInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from ElasticMapReduce.</returns>
        public  ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return endOperation< ListInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeListInstances(ListInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListSteps

        /// <summary>
        /// Provides a list of steps for the cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }

        /// <summary>
        /// Provides a list of steps for the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListStepsResponse ListSteps(ListStepsRequest request)
        {
            IAsyncResult asyncResult = invokeListSteps(request, null, null, true);
            return EndListSteps(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSteps
        ///         operation.</returns>
        public IAsyncResult BeginListSteps(ListStepsRequest request, AsyncCallback callback, object state)
        {
            return invokeListSteps(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a  ListStepsResult from ElasticMapReduce.</returns>
        public  ListStepsResponse EndListSteps(IAsyncResult asyncResult)
        {
            return endOperation< ListStepsResponse>(asyncResult);
        }

        IAsyncResult invokeListSteps(ListStepsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStepsRequestMarshaller().Marshall(request);
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ModifyInstanceGroups


        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance         group. The input parameters include the new target instance count
        /// for the group and the         instance group ID. The call will either succeed or fail
        /// atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeModifyInstanceGroups(request, null, null, true);
            return EndModifyInstanceGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceGroups
        ///         operation.</returns>
        public IAsyncResult BeginModifyInstanceGroups(ModifyInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyInstanceGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceGroupsResult from ElasticMapReduce.</returns>
        public  ModifyInstanceGroupsResponse EndModifyInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation< ModifyInstanceGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeModifyInstanceGroups(ModifyInstanceGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyInstanceGroupsRequestMarshaller().Marshall(request);
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters
        /// in various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs.             For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
        /// Amazon EMR Resources</a>.                                  
        /// 
        ///       
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            IAsyncResult asyncResult = invokeRemoveTags(request, null, null, true);
            return EndRemoveTags(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        public IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state)
        {
            return invokeRemoveTags(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from ElasticMapReduce.</returns>
        public  RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return endOperation< RemoveTagsResponse>(asyncResult);
        }

        IAsyncResult invokeRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveTagsRequestMarshaller().Marshall(request);
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RunJobFlow


        /// <summary>
        /// RunJobFlow creates and starts running a new job flow. The job flow will run the steps
        ///         specified. Once the job flow completes, the cluster is stopped and the HDFS
        /// partition is         lost. To prevent loss of data, configure the last step of the
        /// job flow to store results in         Amazon S3. If the <a>JobFlowInstancesConfig</a>
        /// <code>KeepJobFlowAliveWhenNoSteps</code> parameter is         set to <code>TRUE</code>,
        /// the job flow will transition to the WAITING state rather than         shutting down
        /// once the steps have completed. 
        /// 
        ///             
        /// <para>
        /// For additional protection, you can set the          <a>JobFlowInstancesConfig</a>
        /// <code>TerminationProtected</code> parameter to <code>TRUE</code> to lock the     
        ///     job flow and prevent it from being          terminated by API call, user intervention,
        /// or in the event of a job flow error.
        /// </para>
        ///       
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///             
        /// <para>
        /// If your job flow is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add
        /// More than 256 Steps to a Job Flow</a> in the <i>Amazon Elastic MapReduce Developer's
        /// Guide</i>.
        /// </para>
        ///       
        /// <para>
        /// For long running job flows, we recommend that you periodically store your results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            IAsyncResult asyncResult = invokeRunJobFlow(request, null, null, true);
            return EndRunJobFlow(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunJobFlow
        ///         operation.</returns>
        public IAsyncResult BeginRunJobFlow(RunJobFlowRequest request, AsyncCallback callback, object state)
        {
            return invokeRunJobFlow(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunJobFlow.</param>
        /// 
        /// <returns>Returns a  RunJobFlowResult from ElasticMapReduce.</returns>
        public  RunJobFlowResponse EndRunJobFlow(IAsyncResult asyncResult)
        {
            return endOperation< RunJobFlowResponse>(asyncResult);
        }

        IAsyncResult invokeRunJobFlow(RunJobFlowRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RunJobFlowRequestMarshaller().Marshall(request);
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  SetTerminationProtection


        /// <summary>
        /// SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster
        ///          cannot be terminated by user intervention, an API call, or in the event of
        /// a job-flow error.          The cluster still terminates upon successful completion
        /// of the job flow. Calling          SetTerminationProtection on a job flow is analogous
        /// to calling the          Amazon EC2 DisableAPITermination API on all of the EC2 instances
        /// in a cluster.
        /// 
        ///             
        /// <para>
        ///  SetTerminationProtection is used to prevent accidental termination of a job flow
        /// and to          ensure that in the event of an error, the instances will persist so
        /// you can recover          any data stored in their ephemeral instance storage.
        /// </para>
        ///             
        /// <para>
        ///  To terminate a job flow that has been locked by setting SetTerminationProtection
        /// to <code>true</code>,          you must first unlock the job flow by a subsequent
        /// call to SetTerminationProtection          in which you set the value to <code>false</code>.
        /// 
        /// </para>
        ///             
        /// <para>
        ///  For more information, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/UsingEMR_TerminationProtection.html">Protecting
        /// a Job Flow from Termination</a> in the          <i>Amazon Elastic MapReduce Developer's
        /// Guide.</i>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            IAsyncResult asyncResult = invokeSetTerminationProtection(request, null, null, true);
            return EndSetTerminationProtection(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTerminationProtection
        ///         operation.</returns>
        public IAsyncResult BeginSetTerminationProtection(SetTerminationProtectionRequest request, AsyncCallback callback, object state)
        {
            return invokeSetTerminationProtection(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTerminationProtection.</param>
        /// 
        /// <returns>Returns a  SetTerminationProtectionResult from ElasticMapReduce.</returns>
        public  SetTerminationProtectionResponse EndSetTerminationProtection(IAsyncResult asyncResult)
        {
            return endOperation< SetTerminationProtectionResponse>(asyncResult);
        }

        IAsyncResult invokeSetTerminationProtection(SetTerminationProtectionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTerminationProtectionRequestMarshaller().Marshall(request);
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  SetVisibleToAllUsers


        /// <summary>
        /// Sets whether all AWS Identity and Access Management (IAM) users under your account
        /// can access the specified job flows. This action works on running job flows. You can
        /// also set the visibility of       a job flow when you launch it using the <code>VisibleToAllUsers</code>
        /// parameter of <a>RunJobFlow</a>. The SetVisibleToAllUsers action can  be called only
        /// by an IAM user who created the job flow or the AWS account that owns the job flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            IAsyncResult asyncResult = invokeSetVisibleToAllUsers(request, null, null, true);
            return EndSetVisibleToAllUsers(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetVisibleToAllUsers
        ///         operation.</returns>
        public IAsyncResult BeginSetVisibleToAllUsers(SetVisibleToAllUsersRequest request, AsyncCallback callback, object state)
        {
            return invokeSetVisibleToAllUsers(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVisibleToAllUsers.</param>
        /// 
        /// <returns>Returns a  SetVisibleToAllUsersResult from ElasticMapReduce.</returns>
        public  SetVisibleToAllUsersResponse EndSetVisibleToAllUsers(IAsyncResult asyncResult)
        {
            return endOperation< SetVisibleToAllUsersResponse>(asyncResult);
        }

        IAsyncResult invokeSetVisibleToAllUsers(SetVisibleToAllUsersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetVisibleToAllUsersRequestMarshaller().Marshall(request);
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  TerminateJobFlows


        /// <summary>
        /// TerminateJobFlows shuts a list of job flows down. When a job flow is shut
        /// down, any step         not yet completed is canceled and the EC2 instances on which
        /// the job flow is running are         stopped. Any log files not already saved are uploaded
        /// to Amazon S3 if a LogUri was         specified when the job flow was created.    
        ///   
        /// 
        ///       
        /// <para>
        ///         The call to TerminateJobFlows is asynchronous. Depending on the configuration
        /// of the job flow,         it may take up to 5-20 minutes for the job flow to      
        ///   completely terminate and release allocated resources, such as Amazon EC2 instances.
        ///      
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not         completed.
        /// </exception>
        public TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            IAsyncResult asyncResult = invokeTerminateJobFlows(request, null, null, true);
            return EndTerminateJobFlows(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows operation on AmazonElasticMapReduceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateJobFlows
        ///         operation.</returns>
        public IAsyncResult BeginTerminateJobFlows(TerminateJobFlowsRequest request, AsyncCallback callback, object state)
        {
            return invokeTerminateJobFlows(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJobFlows.</param>
        /// 
        /// <returns>Returns a  TerminateJobFlowsResult from ElasticMapReduce.</returns>
        public  TerminateJobFlowsResponse EndTerminateJobFlows(IAsyncResult asyncResult)
        {
            return endOperation< TerminateJobFlowsResponse>(asyncResult);
        }

        IAsyncResult invokeTerminateJobFlows(TerminateJobFlowsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateJobFlowsRequestMarshaller().Marshall(request);
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}