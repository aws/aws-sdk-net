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

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Implementation for accessing AmazonElasticMapReduce.
    ///  
    /// <para> This is the <i>Amazon Elastic MapReduce API Reference</i> . This guide provides descriptions and samples of the Amazon Elastic
    /// MapReduce APIs.</para> <para>Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to process large amounts of data
    /// efficiently. Amazon EMR uses Hadoop processing combined with several AWS products to do tasks such as web indexing, data mining, log file
    /// analysis, machine learning, scientific simulation, and data warehousing.</para>
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticMapReduce Configuration Object</param>
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


        #region AddInstanceGroups

        /// <summary>
        /// <para>AddInstanceGroups adds an instance group to a running cluster.</para>
        /// </summary>
        /// 
        /// <param name="addInstanceGroupsRequest">Container for the necessary parameters to execute the AddInstanceGroups service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest)
        {
            IAsyncResult asyncResult = invokeAddInstanceGroups(addInstanceGroupsRequest, null, null, true);
            return EndAddInstanceGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="addInstanceGroupsRequest">Container for the necessary parameters to execute the AddInstanceGroups operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddInstanceGroups
        ///         operation.</returns>
        public IAsyncResult BeginAddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeAddInstanceGroups(addInstanceGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceGroups.</param>
        /// 
        /// <returns>Returns a AddInstanceGroupsResult from AmazonElasticMapReduce.</returns>
        public AddInstanceGroupsResponse EndAddInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation<AddInstanceGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddInstanceGroupsRequestMarshaller().Marshall(addInstanceGroupsRequest);
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddJobFlowSteps

        /// <summary>
        /// <para> AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed in each job flow. </para> <para>If your job
        /// flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data. You can bypass
        /// the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries directly to the
        /// software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html" >Add More than 256 Steps to a Job Flow</a>
        /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para> A step specifies the location of a JAR file stored either on the
        /// master node of the job flow or in Amazon S3. Each step is performed by the main function of the main class of the JAR file. The main class
        /// can be specified either in the manifest of the JAR or by using the MainFunction parameter of the step. </para> <para> Elastic MapReduce
        /// executes each step in the order listed. For a step to be considered complete, the main function must exit with a zero exit code and all
        /// Hadoop jobs started while the step was running must have completed and run successfully. </para> <para> You can only add steps to a job flow
        /// that is in one of the following states: STARTING, BOOTSTRAPPING, RUNNING, or WAITING.</para>
        /// </summary>
        /// 
        /// <param name="addJobFlowStepsRequest">Container for the necessary parameters to execute the AddJobFlowSteps service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest)
        {
            IAsyncResult asyncResult = invokeAddJobFlowSteps(addJobFlowStepsRequest, null, null, true);
            return EndAddJobFlowSteps(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddJobFlowSteps"/>
        /// </summary>
        /// 
        /// <param name="addJobFlowStepsRequest">Container for the necessary parameters to execute the AddJobFlowSteps operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddJobFlowSteps
        ///         operation.</returns>
        public IAsyncResult BeginAddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest, AsyncCallback callback, object state)
        {
            return invokeAddJobFlowSteps(addJobFlowStepsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddJobFlowSteps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddJobFlowSteps.</param>
        /// 
        /// <returns>Returns a AddJobFlowStepsResult from AmazonElasticMapReduce.</returns>
        public AddJobFlowStepsResponse EndAddJobFlowSteps(IAsyncResult asyncResult)
        {
            return endOperation<AddJobFlowStepsResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddJobFlowStepsRequestMarshaller().Marshall(addJobFlowStepsRequest);
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddTags

        /// <summary>
        /// <para>Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in various ways, such as grouping clusters to track
        /// your Amazon EMR resource allocation costs. For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html" >Tagging Amazon EMR Resources</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="addTagsRequest">Container for the necessary parameters to execute the AddTags service method on AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public AddTagsResponse AddTags(AddTagsRequest addTagsRequest)
        {
            IAsyncResult asyncResult = invokeAddTags(addTagsRequest, null, null, true);
            return EndAddTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddTags"/>
        /// </summary>
        /// 
        /// <param name="addTagsRequest">Container for the necessary parameters to execute the AddTags operation on AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        public IAsyncResult BeginAddTags(AddTagsRequest addTagsRequest, AsyncCallback callback, object state)
        {
            return invokeAddTags(addTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a AddTagsResult from AmazonElasticMapReduce.</returns>
        public AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return endOperation<AddTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddTags(AddTagsRequest addTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddTagsRequestMarshaller().Marshall(addTagsRequest);
            var unmarshaller = AddTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCluster

        /// <summary>
        /// <para>Provides cluster-level details including status, hardware and software configuration, VPC settings, and so on. For information about
        /// the cluster steps, see ListSteps.</para>
        /// </summary>
        /// 
        /// <param name="describeClusterRequest">Container for the necessary parameters to execute the DescribeCluster service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public DescribeClusterResponse DescribeCluster(DescribeClusterRequest describeClusterRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCluster(describeClusterRequest, null, null, true);
            return EndDescribeCluster(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeCluster"/>
        /// </summary>
        /// 
        /// <param name="describeClusterRequest">Container for the necessary parameters to execute the DescribeCluster operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCluster(DescribeClusterRequest describeClusterRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCluster(describeClusterRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a DescribeClusterResult from AmazonElasticMapReduce.</returns>
        public DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return endOperation<DescribeClusterResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCluster(DescribeClusterRequest describeClusterRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeClusterRequestMarshaller().Marshall(describeClusterRequest);
            var unmarshaller = DescribeClusterResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides cluster-level details including status, hardware and software configuration, VPC settings, and so on. For information about
        /// the cluster steps, see ListSteps.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }
        

        #endregion
    
        #region DescribeJobFlows

        /// <summary>
        /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
        /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
        /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
        /// following criteria are returned:</para>
        /// <ul>
        /// <li>Job flows created and completed in the last two weeks</li>
        /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
        /// <c>WAITING</c> ,
        /// <c>SHUTTING_DOWN</c> ,
        /// 
        /// <c>STARTING</c> </li>
        /// 
        /// </ul>
        /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
        /// </summary>
        /// 
        /// <param name="describeJobFlowsRequest">Container for the necessary parameters to execute the DescribeJobFlows service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeJobFlows(describeJobFlowsRequest, null, null, true);
            return EndDescribeJobFlows(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeJobFlows"/>
        /// </summary>
        /// 
        /// <param name="describeJobFlowsRequest">Container for the necessary parameters to execute the DescribeJobFlows operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobFlows
        ///         operation.</returns>
        public IAsyncResult BeginDescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeJobFlows(describeJobFlowsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeJobFlows"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobFlows.</param>
        /// 
        /// <returns>Returns a DescribeJobFlowsResult from AmazonElasticMapReduce.</returns>
        public DescribeJobFlowsResponse EndDescribeJobFlows(IAsyncResult asyncResult)
        {
            return endOperation<DescribeJobFlowsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeJobFlowsRequestMarshaller().Marshall(describeJobFlowsRequest);
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
        /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
        /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
        /// following criteria are returned:</para>
        /// <ul>
        /// <li>Job flows created and completed in the last two weeks</li>
        /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
        /// <c>WAITING</c> ,
        /// <c>SHUTTING_DOWN</c> ,
        /// 
        /// <c>STARTING</c> </li>
        /// 
        /// </ul>
        /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }
        

        #endregion
    
        #region DescribeStep

        /// <summary>
        /// <para>Provides more detail about the cluster step.</para>
        /// </summary>
        /// 
        /// <param name="describeStepRequest">Container for the necessary parameters to execute the DescribeStep service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public DescribeStepResponse DescribeStep(DescribeStepRequest describeStepRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStep(describeStepRequest, null, null, true);
            return EndDescribeStep(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeStep"/>
        /// </summary>
        /// 
        /// <param name="describeStepRequest">Container for the necessary parameters to execute the DescribeStep operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStep
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStep(DescribeStepRequest describeStepRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStep(describeStepRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeStep"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStep.</param>
        /// 
        /// <returns>Returns a DescribeStepResult from AmazonElasticMapReduce.</returns>
        public DescribeStepResponse EndDescribeStep(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStepResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStep(DescribeStepRequest describeStepRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStepRequestMarshaller().Marshall(describeStepRequest);
            var unmarshaller = DescribeStepResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides more detail about the cluster step.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }
        

        #endregion
    
        #region ListBootstrapActions

        /// <summary>
        /// <para>Provides information about the bootstrap actions associated with a cluster.</para>
        /// </summary>
        /// 
        /// <param name="listBootstrapActionsRequest">Container for the necessary parameters to execute the ListBootstrapActions service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest listBootstrapActionsRequest)
        {
            IAsyncResult asyncResult = invokeListBootstrapActions(listBootstrapActionsRequest, null, null, true);
            return EndListBootstrapActions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListBootstrapActions"/>
        /// </summary>
        /// 
        /// <param name="listBootstrapActionsRequest">Container for the necessary parameters to execute the ListBootstrapActions operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListBootstrapActions operation.</returns>
        public IAsyncResult BeginListBootstrapActions(ListBootstrapActionsRequest listBootstrapActionsRequest, AsyncCallback callback, object state)
        {
            return invokeListBootstrapActions(listBootstrapActionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListBootstrapActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBootstrapActions.</param>
        /// 
        /// <returns>Returns a ListBootstrapActionsResult from AmazonElasticMapReduce.</returns>
        public ListBootstrapActionsResponse EndListBootstrapActions(IAsyncResult asyncResult)
        {
            return endOperation<ListBootstrapActionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListBootstrapActions(ListBootstrapActionsRequest listBootstrapActionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListBootstrapActionsRequestMarshaller().Marshall(listBootstrapActionsRequest);
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides information about the bootstrap actions associated with a cluster.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }
        

        #endregion
    
        #region ListClusters

        /// <summary>
        /// <para>Provides the status of all clusters visible to this AWS account. Allows you to filter the list of clusters based on certain criteria;
        /// for example, filtering by cluster creation date and time or by status. This call returns a maximum of 50 clusters per call, but returns a
        /// marker to track the paging of the cluster list across multiple ListClusters calls. </para>
        /// </summary>
        /// 
        /// <param name="listClustersRequest">Container for the necessary parameters to execute the ListClusters service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListClustersResponse ListClusters(ListClustersRequest listClustersRequest)
        {
            IAsyncResult asyncResult = invokeListClusters(listClustersRequest, null, null, true);
            return EndListClusters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListClusters"/>
        /// </summary>
        /// 
        /// <param name="listClustersRequest">Container for the necessary parameters to execute the ListClusters operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        public IAsyncResult BeginListClusters(ListClustersRequest listClustersRequest, AsyncCallback callback, object state)
        {
            return invokeListClusters(listClustersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListClusters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a ListClustersResult from AmazonElasticMapReduce.</returns>
        public ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return endOperation<ListClustersResponse>(asyncResult);
        }
        
        IAsyncResult invokeListClusters(ListClustersRequest listClustersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListClustersRequestMarshaller().Marshall(listClustersRequest);
            var unmarshaller = ListClustersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides the status of all clusters visible to this AWS account. Allows you to filter the list of clusters based on certain criteria;
        /// for example, filtering by cluster creation date and time or by status. This call returns a maximum of 50 clusters per call, but returns a
        /// marker to track the paging of the cluster list across multiple ListClusters calls. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }
        

        #endregion
    
        #region ListInstanceGroups

        /// <summary>
        /// <para>Provides all available details about the instance groups in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceGroupsRequest">Container for the necessary parameters to execute the ListInstanceGroups service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest listInstanceGroupsRequest)
        {
            IAsyncResult asyncResult = invokeListInstanceGroups(listInstanceGroupsRequest, null, null, true);
            return EndListInstanceGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="listInstanceGroupsRequest">Container for the necessary parameters to execute the ListInstanceGroups operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListInstanceGroups operation.</returns>
        public IAsyncResult BeginListInstanceGroups(ListInstanceGroupsRequest listInstanceGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeListInstanceGroups(listInstanceGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceGroups.</param>
        /// 
        /// <returns>Returns a ListInstanceGroupsResult from AmazonElasticMapReduce.</returns>
        public ListInstanceGroupsResponse EndListInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation<ListInstanceGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListInstanceGroups(ListInstanceGroupsRequest listInstanceGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstanceGroupsRequestMarshaller().Marshall(listInstanceGroupsRequest);
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides all available details about the instance groups in a cluster.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }
        

        #endregion
    
        #region ListInstances

        /// <summary>
        /// <para>Provides information about the cluster instances that Amazon EMR provisions on behalf of a user when it creates the cluster. For
        /// example, this operation indicates when the EC2 instances reach the Ready state, when instances become available to Amazon EMR to use for
        /// jobs, and the IP addresses for cluster instances, etc. </para>
        /// </summary>
        /// 
        /// <param name="listInstancesRequest">Container for the necessary parameters to execute the ListInstances service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            IAsyncResult asyncResult = invokeListInstances(listInstancesRequest, null, null, true);
            return EndListInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstances"/>
        /// </summary>
        /// 
        /// <param name="listInstancesRequest">Container for the necessary parameters to execute the ListInstances operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        public IAsyncResult BeginListInstances(ListInstancesRequest listInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeListInstances(listInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a ListInstancesResult from AmazonElasticMapReduce.</returns>
        public ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return endOperation<ListInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListInstances(ListInstancesRequest listInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstancesRequestMarshaller().Marshall(listInstancesRequest);
            var unmarshaller = ListInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides information about the cluster instances that Amazon EMR provisions on behalf of a user when it creates the cluster. For
        /// example, this operation indicates when the EC2 instances reach the Ready state, when instances become available to Amazon EMR to use for
        /// jobs, and the IP addresses for cluster instances, etc. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }
        

        #endregion
    
        #region ListSteps

        /// <summary>
        /// <para>Provides a list of steps for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="listStepsRequest">Container for the necessary parameters to execute the ListSteps service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListStepsResponse ListSteps(ListStepsRequest listStepsRequest)
        {
            IAsyncResult asyncResult = invokeListSteps(listStepsRequest, null, null, true);
            return EndListSteps(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListSteps"/>
        /// </summary>
        /// 
        /// <param name="listStepsRequest">Container for the necessary parameters to execute the ListSteps operation on AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSteps
        ///         operation.</returns>
        public IAsyncResult BeginListSteps(ListStepsRequest listStepsRequest, AsyncCallback callback, object state)
        {
            return invokeListSteps(listStepsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListSteps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a ListStepsResult from AmazonElasticMapReduce.</returns>
        public ListStepsResponse EndListSteps(IAsyncResult asyncResult)
        {
            return endOperation<ListStepsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListSteps(ListStepsRequest listStepsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStepsRequestMarshaller().Marshall(listStepsRequest);
            var unmarshaller = ListStepsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Provides a list of steps for the cluster. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }
        

        #endregion
    
        #region ModifyInstanceGroups

        /// <summary>
        /// <para>ModifyInstanceGroups modifies the number of nodes and configuration settings of an instance group. The input parameters include the
        /// new target instance count for the group and the instance group ID. The call will either succeed or fail atomically.</para>
        /// </summary>
        /// 
        /// <param name="modifyInstanceGroupsRequest">Container for the necessary parameters to execute the ModifyInstanceGroups service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest)
        {
            IAsyncResult asyncResult = invokeModifyInstanceGroups(modifyInstanceGroupsRequest, null, null, true);
            return EndModifyInstanceGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ModifyInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="modifyInstanceGroupsRequest">Container for the necessary parameters to execute the ModifyInstanceGroups operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeModifyInstanceGroups(modifyInstanceGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ModifyInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceGroups.</param>
        public ModifyInstanceGroupsResponse EndModifyInstanceGroups(IAsyncResult asyncResult)
        {
            return endOperation<ModifyInstanceGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyInstanceGroupsRequestMarshaller().Marshall(modifyInstanceGroupsRequest);
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemoveTags

        /// <summary>
        /// <para>Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html" >Tagging Amazon EMR Resources</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="removeTagsRequest">Container for the necessary parameters to execute the RemoveTags service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerException"/>
        /// <exception cref="InvalidRequestException"/>
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest removeTagsRequest)
        {
            IAsyncResult asyncResult = invokeRemoveTags(removeTagsRequest, null, null, true);
            return EndRemoveTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RemoveTags"/>
        /// </summary>
        /// 
        /// <param name="removeTagsRequest">Container for the necessary parameters to execute the RemoveTags operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        public IAsyncResult BeginRemoveTags(RemoveTagsRequest removeTagsRequest, AsyncCallback callback, object state)
        {
            return invokeRemoveTags(removeTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RemoveTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a RemoveTagsResult from AmazonElasticMapReduce.</returns>
        public RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return endOperation<RemoveTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemoveTags(RemoveTagsRequest removeTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveTagsRequestMarshaller().Marshall(removeTagsRequest);
            var unmarshaller = RemoveTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RunJobFlow

        /// <summary>
        /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
        /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
        /// Amazon S3. If the JobFlowInstancesConfig <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
        /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
        /// JobFlowInstancesConfig <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
        /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
        /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
        /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
        /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html" >Add More than 256 Steps to a Job Flow</a>
        /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend that you periodically store
        /// your results.</para>
        /// </summary>
        /// 
        /// <param name="runJobFlowRequest">Container for the necessary parameters to execute the RunJobFlow service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public RunJobFlowResponse RunJobFlow(RunJobFlowRequest runJobFlowRequest)
        {
            IAsyncResult asyncResult = invokeRunJobFlow(runJobFlowRequest, null, null, true);
            return EndRunJobFlow(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RunJobFlow"/>
        /// </summary>
        /// 
        /// <param name="runJobFlowRequest">Container for the necessary parameters to execute the RunJobFlow operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunJobFlow
        ///         operation.</returns>
        public IAsyncResult BeginRunJobFlow(RunJobFlowRequest runJobFlowRequest, AsyncCallback callback, object state)
        {
            return invokeRunJobFlow(runJobFlowRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RunJobFlow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunJobFlow.</param>
        /// 
        /// <returns>Returns a RunJobFlowResult from AmazonElasticMapReduce.</returns>
        public RunJobFlowResponse EndRunJobFlow(IAsyncResult asyncResult)
        {
            return endOperation<RunJobFlowResponse>(asyncResult);
        }
        
        IAsyncResult invokeRunJobFlow(RunJobFlowRequest runJobFlowRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RunJobFlowRequestMarshaller().Marshall(runJobFlowRequest);
            var unmarshaller = RunJobFlowResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetTerminationProtection

        /// <summary>
        /// <para> SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster cannot be terminated by user intervention, an
        /// API call, or in the event of a job-flow error. The cluster still terminates upon successful completion of the job flow. Calling
        /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination API on all of the EC2 instances in a
        /// cluster.</para> <para> SetTerminationProtection is used to prevent accidental termination of a job flow and to ensure that in the event of
        /// an error, the instances will persist so you can recover any data stored in their ephemeral instance storage.</para> <para> To terminate a
        /// job flow that has been locked by setting SetTerminationProtection to <c>true</c> ,
        /// you must first unlock the job flow by a subsequent call to SetTerminationProtection in which you set the value to <c>false</c> .
        /// </para> <para> For more information, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/UsingEMR_TerminationProtection.html" >Protecting a Job Flow from
        /// Termination</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i> </para>
        /// </summary>
        /// 
        /// <param name="setTerminationProtectionRequest">Container for the necessary parameters to execute the SetTerminationProtection service method
        ///          on AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest)
        {
            IAsyncResult asyncResult = invokeSetTerminationProtection(setTerminationProtectionRequest, null, null, true);
            return EndSetTerminationProtection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetTerminationProtection"/>
        /// </summary>
        /// 
        /// <param name="setTerminationProtectionRequest">Container for the necessary parameters to execute the SetTerminationProtection operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest, AsyncCallback callback, object state)
        {
            return invokeSetTerminationProtection(setTerminationProtectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetTerminationProtection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTerminationProtection.</param>
        public SetTerminationProtectionResponse EndSetTerminationProtection(IAsyncResult asyncResult)
        {
            return endOperation<SetTerminationProtectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTerminationProtectionRequestMarshaller().Marshall(setTerminationProtectionRequest);
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetVisibleToAllUsers

        /// <summary>
        /// <para>Sets whether all AWS Identity and Access Management (IAM) users under your account can access the specified job flows. This action
        /// works on running job flows. You can also set the visibility of a job flow when you launch it using the <c>VisibleToAllUsers</c> parameter of
        /// RunJobFlow. The SetVisibleToAllUsers action can be called only by an IAM user who created the job flow or the AWS account that owns the job
        /// flow.</para>
        /// </summary>
        /// 
        /// <param name="setVisibleToAllUsersRequest">Container for the necessary parameters to execute the SetVisibleToAllUsers service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest)
        {
            IAsyncResult asyncResult = invokeSetVisibleToAllUsers(setVisibleToAllUsersRequest, null, null, true);
            return EndSetVisibleToAllUsers(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetVisibleToAllUsers"/>
        /// </summary>
        /// 
        /// <param name="setVisibleToAllUsersRequest">Container for the necessary parameters to execute the SetVisibleToAllUsers operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetVisibleToAllUsers(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest, AsyncCallback callback, object state)
        {
            return invokeSetVisibleToAllUsers(setVisibleToAllUsersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetVisibleToAllUsers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVisibleToAllUsers.</param>
        public SetVisibleToAllUsersResponse EndSetVisibleToAllUsers(IAsyncResult asyncResult)
        {
            return endOperation<SetVisibleToAllUsersResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetVisibleToAllUsers(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetVisibleToAllUsersRequestMarshaller().Marshall(setVisibleToAllUsersRequest);
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TerminateJobFlows

        /// <summary>
        /// <para> TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any step not yet completed is canceled and the EC2
        /// instances on which the job flow is running are stopped. Any log files not already saved are uploaded to Amazon S3 if a LogUri was specified
        /// when the job flow was created. </para> <para> The call to TerminateJobFlows is asynchronous. Depending on the configuration of the job flow,
        /// it may take up to 5-20 minutes for the job flow to completely terminate and release allocated resources, such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// 
        /// <param name="terminateJobFlowsRequest">Container for the necessary parameters to execute the TerminateJobFlows service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest)
        {
            IAsyncResult asyncResult = invokeTerminateJobFlows(terminateJobFlowsRequest, null, null, true);
            return EndTerminateJobFlows(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.TerminateJobFlows"/>
        /// </summary>
        /// 
        /// <param name="terminateJobFlowsRequest">Container for the necessary parameters to execute the TerminateJobFlows operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginTerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest, AsyncCallback callback, object state)
        {
            return invokeTerminateJobFlows(terminateJobFlowsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.TerminateJobFlows"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJobFlows.</param>
        public TerminateJobFlowsResponse EndTerminateJobFlows(IAsyncResult asyncResult)
        {
            return endOperation<TerminateJobFlowsResponse>(asyncResult);
        }
        
        IAsyncResult invokeTerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateJobFlowsRequestMarshaller().Marshall(terminateJobFlowsRequest);
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
