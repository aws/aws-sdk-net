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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

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
    /// Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to process
    /// large amounts of data efficiently. Amazon EMR uses Hadoop processing combined with
    /// several AWS products to do tasks such as web indexing, data mining, log file analysis,
    /// machine learning, scientific simulation, and data warehousing.
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        
        #region  AddInstanceGroups

        /// <summary>
        /// AddInstanceGroups adds an instance group to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var marshaller = new AddInstanceGroupsRequestMarshaller();
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsRequest,AddInstanceGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAddInstanceGroups(AddInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddInstanceGroupsRequestMarshaller();
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<AddInstanceGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceGroups.</param>
        /// 
        /// <returns>Returns a  AddInstanceGroupsResult from ElasticMapReduce.</returns>
        public  AddInstanceGroupsResponse EndAddInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<AddInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddJobFlowSteps

        /// <summary>
        /// AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are
        /// allowed in each job flow. 
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
        /// job flow or in Amazon S3. Each step is performed by the main function of the main
        /// class of the JAR file. The main class can be specified either in the manifest of the
        /// JAR or by using the MainFunction parameter of the step. 
        /// </para>
        ///  
        /// <para>
        ///  Elastic MapReduce executes each step in the order listed. For a step to be considered
        /// complete, the main function must exit with a zero exit code and all Hadoop jobs started
        /// while the step was running must have completed and run successfully. 
        /// </para>
        ///  
        /// <para>
        ///  You can only add steps to a job flow that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var marshaller = new AddJobFlowStepsRequestMarshaller();
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsRequest,AddJobFlowStepsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAddJobFlowSteps(AddJobFlowStepsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddJobFlowStepsRequestMarshaller();
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return BeginInvoke<AddJobFlowStepsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddJobFlowSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddJobFlowSteps.</param>
        /// 
        /// <returns>Returns a  AddJobFlowStepsResult from ElasticMapReduce.</returns>
        public  AddJobFlowStepsResponse EndAddJobFlowSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<AddJobFlowStepsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTags

        /// <summary>
        /// Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in
        /// various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
        /// Amazon EMR Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from ElasticMapReduce.</returns>
        public  AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on. For information about the cluster steps, see <a>ListSteps</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from ElasticMapReduce.</returns>
        public  DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobFlows

        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        /// instead.
        /// 
        ///  
        /// <para>
        ///  DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        ///  Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        ///  If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li>Job flows created and completed in the last two weeks</li> <li> Job flows
        /// created within the last two months that are in one of the following states: <code>RUNNING</code>,
        /// <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code> </li> </ul>
        /// 
        /// <para>
        ///  Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }

        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        /// instead.
        /// 
        ///  
        /// <para>
        ///  DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        ///  Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        ///  If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li>Job flows created and completed in the last two weeks</li> <li> Job flows
        /// created within the last two months that are in one of the following states: <code>RUNNING</code>,
        /// <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code> </li> </ul>
        /// 
        /// <para>
        ///  Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var marshaller = new DescribeJobFlowsRequestMarshaller();
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsRequest,DescribeJobFlowsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeJobFlows(DescribeJobFlowsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeJobFlowsRequestMarshaller();
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeJobFlowsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobFlows.</param>
        /// 
        /// <returns>Returns a  DescribeJobFlowsResult from ElasticMapReduce.</returns>
        public  DescribeJobFlowsResponse EndDescribeJobFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStep

        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var marshaller = new DescribeStepRequestMarshaller();
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepRequest,DescribeStepResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeStep(DescribeStepRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStepRequestMarshaller();
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStepRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStep.</param>
        /// 
        /// <returns>Returns a  DescribeStepResult from ElasticMapReduce.</returns>
        public  DescribeStepResponse EndDescribeStep(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStepResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBootstrapActions

        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var marshaller = new ListBootstrapActionsRequestMarshaller();
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsRequest,ListBootstrapActionsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListBootstrapActions(ListBootstrapActionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListBootstrapActionsRequestMarshaller();
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListBootstrapActionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBootstrapActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBootstrapActions.</param>
        /// 
        /// <returns>Returns a  ListBootstrapActionsResult from ElasticMapReduce.</returns>
        public  ListBootstrapActionsResponse EndListBootstrapActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBootstrapActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status. This call returns a maximum of 50 clusters per
        /// call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }

        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status. This call returns a maximum of 50 clusters per
        /// call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersRequest,ListClustersResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke<ListClustersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from ElasticMapReduce.</returns>
        public  ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstanceGroups

        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var marshaller = new ListInstanceGroupsRequestMarshaller();
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsRequest,ListInstanceGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListInstanceGroups(ListInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListInstanceGroupsRequestMarshaller();
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListInstanceGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ListInstanceGroupsResult from ElasticMapReduce.</returns>
        public  ListInstanceGroupsResponse EndListInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Provides information about the cluster instances that Amazon EMR provisions on behalf
        /// of a user when it creates the cluster. For example, this operation indicates when
        /// the EC2 instances reach the Ready state, when instances become available to Amazon
        /// EMR to use for jobs, and the IP addresses for cluster instances, etc.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }

        /// <summary>
        /// Provides information about the cluster instances that Amazon EMR provisions on behalf
        /// of a user when it creates the cluster. For example, this operation indicates when
        /// the EC2 instances reach the Ready state, when instances become available to Amazon
        /// EMR to use for jobs, and the IP addresses for cluster instances, etc.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var marshaller = new ListInstancesRequestMarshaller();
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesRequest,ListInstancesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListInstancesRequestMarshaller();
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<ListInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from ElasticMapReduce.</returns>
        public  ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSteps

        /// <summary>
        /// Provides a list of steps for the cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var marshaller = new ListStepsRequestMarshaller();
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsRequest,ListStepsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListSteps(ListStepsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListStepsRequestMarshaller();
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return BeginInvoke<ListStepsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a  ListStepsResult from ElasticMapReduce.</returns>
        public  ListStepsResponse EndListSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStepsResponse>(asyncResult);
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
        public ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var marshaller = new ModifyInstanceGroupsRequestMarshaller();
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsRequest,ModifyInstanceGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginModifyInstanceGroups(ModifyInstanceGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyInstanceGroupsRequestMarshaller();
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyInstanceGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceGroups.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceGroupsResult from ElasticMapReduce.</returns>
        public  ModifyInstanceGroupsResponse EndModifyInstanceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstanceGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTags

        /// <summary>
        /// Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters
        /// in various ways, such as grouping clusters to track your Amazon EMR resource allocation
        /// costs. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from ElasticMapReduce.</returns>
        public  RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  RunJobFlow

        /// <summary>
        /// RunJobFlow creates and starts running a new job flow. The job flow will run the steps
        /// specified. Once the job flow completes, the cluster is stopped and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
        /// parameter is set to <code>TRUE</code>, the job flow will transition to the WAITING
        /// state rather than shutting down once the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
        /// parameter to <code>TRUE</code> to lock the job flow and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
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
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var marshaller = new RunJobFlowRequestMarshaller();
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowRequest,RunJobFlowResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRunJobFlow(RunJobFlowRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RunJobFlowRequestMarshaller();
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return BeginInvoke<RunJobFlowRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunJobFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunJobFlow.</param>
        /// 
        /// <returns>Returns a  RunJobFlowResult from ElasticMapReduce.</returns>
        public  RunJobFlowResponse EndRunJobFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<RunJobFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  SetTerminationProtection

        /// <summary>
        /// SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster
        /// cannot be terminated by user intervention, an API call, or in the event of a job-flow
        /// error. The cluster still terminates upon successful completion of the job flow. Calling
        /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination
        /// API on all of the EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  SetTerminationProtection is used to prevent accidental termination of a job flow
        /// and to ensure that in the event of an error, the instances will persist so you can
        /// recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a job flow that has been locked by setting SetTerminationProtection
        /// to <code>true</code>, you must first unlock the job flow by a subsequent call to SetTerminationProtection
        /// in which you set the value to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/UsingEMR_TerminationProtection.html">Protecting
        /// a Job Flow from Termination</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var marshaller = new SetTerminationProtectionRequestMarshaller();
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionRequest,SetTerminationProtectionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetTerminationProtection(SetTerminationProtectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetTerminationProtectionRequestMarshaller();
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return BeginInvoke<SetTerminationProtectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTerminationProtection.</param>
        /// 
        /// <returns>Returns a  SetTerminationProtectionResult from ElasticMapReduce.</returns>
        public  SetTerminationProtectionResponse EndSetTerminationProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTerminationProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  SetVisibleToAllUsers

        /// <summary>
        /// Sets whether all AWS Identity and Access Management (IAM) users under your account
        /// can access the specified job flows. This action works on running job flows. You can
        /// also set the visibility of a job flow when you launch it using the <code>VisibleToAllUsers</code>
        /// parameter of <a>RunJobFlow</a>. The SetVisibleToAllUsers action can be called only
        /// by an IAM user who created the job flow or the AWS account that owns the job flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var marshaller = new SetVisibleToAllUsersRequestMarshaller();
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersRequest,SetVisibleToAllUsersResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetVisibleToAllUsers(SetVisibleToAllUsersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetVisibleToAllUsersRequestMarshaller();
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return BeginInvoke<SetVisibleToAllUsersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetVisibleToAllUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVisibleToAllUsers.</param>
        /// 
        /// <returns>Returns a  SetVisibleToAllUsersResult from ElasticMapReduce.</returns>
        public  SetVisibleToAllUsersResponse EndSetVisibleToAllUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<SetVisibleToAllUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateJobFlows

        /// <summary>
        /// TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any
        /// step not yet completed is canceled and the EC2 instances on which the job flow is
        /// running are stopped. Any log files not already saved are uploaded to Amazon S3 if
        /// a LogUri was specified when the job flow was created. 
        /// 
        ///  
        /// <para>
        ///  The maximum number of JobFlows allowed is 10. The call to TerminateJobFlows is asynchronous.
        /// Depending on the configuration of the job flow, it may take up to 5-20 minutes for
        /// the job flow to completely terminate and release allocated resources, such as Amazon
        /// EC2 instances. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        public TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var marshaller = new TerminateJobFlowsRequestMarshaller();
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsRequest,TerminateJobFlowsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginTerminateJobFlows(TerminateJobFlowsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateJobFlowsRequestMarshaller();
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateJobFlowsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateJobFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJobFlows.</param>
        /// 
        /// <returns>Returns a  TerminateJobFlowsResult from ElasticMapReduce.</returns>
        public  TerminateJobFlowsResponse EndTerminateJobFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateJobFlowsResponse>(asyncResult);
        }

        #endregion
        
    }
}