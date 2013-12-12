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
using System.Threading.Tasks;

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
	public partial class AmazonElasticMapReduceClient : AmazonWebServiceClient, Amazon.ElasticMapReduce.IAmazonElasticMapReduce
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticMapReduceConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonElasticMapReduceConfig(){RegionEndpoint=region})
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
        /// AmazonElasticMapReduceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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

 
        /// <summary>
        /// <para>AddInstanceGroups adds an instance group to a running cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var task = AddInstanceGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddInstanceGroupsRequestMarshaller();
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddInstanceGroupsRequest, AddInstanceGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed in each job flow. </para> <para>If your job
        /// flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data. You can bypass
        /// the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries directly to the
        /// software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add More than 256 Steps to a Job Flow</a>
        /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para> A step specifies the location of a JAR file stored either on the
        /// master node of the job flow or in Amazon S3. Each step is performed by the main function of the main class of the JAR file. The main class
        /// can be specified either in the manifest of the JAR or by using the MainFunction parameter of the step. </para> <para> Elastic MapReduce
        /// executes each step in the order listed. For a step to be considered complete, the main function must exit with a zero exit code and all
        /// Hadoop jobs started while the step was running must have completed and run successfully. </para> <para> You can only add steps to a job flow
        /// that is in one of the following states: STARTING, BOOTSTRAPPING, RUNNING, or WAITING.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var task = AddJobFlowStepsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddJobFlowSteps"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddJobFlowStepsRequestMarshaller();
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddJobFlowStepsRequest, AddJobFlowStepsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in various ways, such as grouping clusters to track
        /// your Amazon EMR resource allocation costs. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging Amazon EMR Resources</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method on AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public AddTagsResponse AddTags(AddTagsRequest request)
        {
            var task = AddTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.AddTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddTagsRequest, AddTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides cluster-level details including status, hardware and software configuration, VPC settings, and so on. For information about
        /// the cluster steps, see ListSteps.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var task = DescribeClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterRequest, DescribeClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides cluster-level details including status, hardware and software configuration, VPC settings, and so on. For information about
        /// the cluster steps, see ListSteps.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public DescribeClusterResponse DescribeCluster()
        {
            return this.DescribeCluster(new DescribeClusterRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var task = DescribeJobFlowsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeJobFlows"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeJobFlowsRequestMarshaller();
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeJobFlowsRequest, DescribeJobFlowsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
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
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public DescribeJobFlowsResponse DescribeJobFlows()
        {
            return this.DescribeJobFlows(new DescribeJobFlowsRequest());
        }
 
        /// <summary>
        /// <para>Provides more detail about the cluster step.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var task = DescribeStepAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.DescribeStep"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStepRequestMarshaller();
            var unmarshaller = DescribeStepResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStepRequest, DescribeStepResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides more detail about the cluster step.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public DescribeStepResponse DescribeStep()
        {
            return this.DescribeStep(new DescribeStepRequest());
        }
 
        /// <summary>
        /// <para>Provides information about the bootstrap actions associated with a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var task = ListBootstrapActionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListBootstrapActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBootstrapActionsRequestMarshaller();
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListBootstrapActionsRequest, ListBootstrapActionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides information about the bootstrap actions associated with a cluster.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListBootstrapActionsResponse ListBootstrapActions()
        {
            return this.ListBootstrapActions(new ListBootstrapActionsRequest());
        }
 
        /// <summary>
        /// <para>Provides the status of all clusters visible to this AWS account. Allows you to filter the list of clusters based on certain criteria;
        /// for example, filtering by cluster creation date and time or by status. This call returns a maximum of 50 clusters per call, but returns a
        /// marker to track the paging of the cluster list across multiple ListClusters calls. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var task = ListClustersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListClusters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListClustersRequest, ListClustersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides the status of all clusters visible to this AWS account. Allows you to filter the list of clusters based on certain criteria;
        /// for example, filtering by cluster creation date and time or by status. This call returns a maximum of 50 clusters per call, but returns a
        /// marker to track the paging of the cluster list across multiple ListClusters calls. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListClusters service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListClustersResponse ListClusters()
        {
            return this.ListClusters(new ListClustersRequest());
        }
 
        /// <summary>
        /// <para>Provides all available details about the instance groups in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var task = ListInstanceGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstanceGroupsRequestMarshaller();
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListInstanceGroupsRequest, ListInstanceGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides all available details about the instance groups in a cluster.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListInstanceGroupsResponse ListInstanceGroups()
        {
            return this.ListInstanceGroups(new ListInstanceGroupsRequest());
        }
 
        /// <summary>
        /// <para>Provides information about the cluster instances that Amazon EMR provisions on behalf of a user when it creates the cluster. For
        /// example, this operation indicates when the EC2 instances reach the Ready state, when instances become available to Amazon EMR to use for
        /// jobs, and the IP addresses for cluster instances, etc. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var task = ListInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstancesRequestMarshaller();
            var unmarshaller = ListInstancesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListInstancesRequest, ListInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides information about the cluster instances that Amazon EMR provisions on behalf of a user when it creates the cluster. For
        /// example, this operation indicates when the EC2 instances reach the Ready state, when instances become available to Amazon EMR to use for
        /// jobs, and the IP addresses for cluster instances, etc. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListInstances service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListInstancesResponse ListInstances()
        {
            return this.ListInstances(new ListInstancesRequest());
        }
 
        /// <summary>
        /// <para>Provides a list of steps for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var task = ListStepsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ListSteps"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStepsRequestMarshaller();
            var unmarshaller = ListStepsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListStepsRequest, ListStepsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Provides a list of steps for the cluster. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListSteps service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public ListStepsResponse ListSteps()
        {
            return this.ListSteps(new ListStepsRequest());
        }
 
        /// <summary>
        /// <para>ModifyInstanceGroups modifies the number of nodes and configuration settings of an instance group. The input parameters include the
        /// new target instance count for the group and the instance group ID. The call will either succeed or fail atomically.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var task = ModifyInstanceGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.ModifyInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceGroupsRequestMarshaller();
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyInstanceGroupsRequest, ModifyInstanceGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging Amazon EMR Resources</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerException" />
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InvalidRequestException" />
		public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var task = RemoveTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RemoveTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RemoveTagsRequest, RemoveTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
        /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
        /// Amazon S3. If the JobFlowInstancesConfig <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
        /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
        /// JobFlowInstancesConfig <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
        /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
        /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
        /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
        /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add More than 256 Steps to a Job Flow</a>
        /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend that you periodically store
        /// your results.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var task = RunJobFlowAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.RunJobFlow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunJobFlowRequestMarshaller();
            var unmarshaller = RunJobFlowResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RunJobFlowRequest, RunJobFlowResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster cannot be terminated by user intervention, an
        /// API call, or in the event of a job-flow error. The cluster still terminates upon successful completion of the job flow. Calling
        /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination API on all of the EC2 instances in a
        /// cluster.</para> <para> SetTerminationProtection is used to prevent accidental termination of a job flow and to ensure that in the event of
        /// an error, the instances will persist so you can recover any data stored in their ephemeral instance storage.</para> <para> To terminate a
        /// job flow that has been locked by setting SetTerminationProtection to <c>true</c> ,
        /// you must first unlock the job flow by a subsequent call to SetTerminationProtection in which you set the value to <c>false</c> .
        /// </para> <para> For more information, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/UsingEMR_TerminationProtection.html">Protecting a Job Flow from
        /// Termination</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method
        /// on AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var task = SetTerminationProtectionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetTerminationProtection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTerminationProtectionRequestMarshaller();
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetTerminationProtectionRequest, SetTerminationProtectionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Sets whether all AWS Identity and Access Management (IAM) users under your account can access the specified job flows. This action
        /// works on running job flows. You can also set the visibility of a job flow when you launch it using the <c>VisibleToAllUsers</c> parameter of
        /// RunJobFlow. The SetVisibleToAllUsers action can be called only by an IAM user who created the job flow or the AWS account that owns the job
        /// flow.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var task = SetVisibleToAllUsersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.SetVisibleToAllUsers"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetVisibleToAllUsersRequestMarshaller();
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetVisibleToAllUsersRequest, SetVisibleToAllUsersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any step not yet completed is canceled and the EC2
        /// instances on which the job flow is running are stopped. Any log files not already saved are uploaded to Amazon S3 if a LogUri was specified
        /// when the job flow was created. </para> <para> The call to TerminateJobFlows is asynchronous. Depending on the configuration of the job flow,
        /// it may take up to 5-20 minutes for the job flow to completely terminate and release allocated resources, such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method on
        /// AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticMapReduce.Model.InternalServerErrorException" />
		public TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var task = TerminateJobFlowsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.IAmazonElasticMapReduce.TerminateJobFlows"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateJobFlowsRequestMarshaller();
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, TerminateJobFlowsRequest, TerminateJobFlowsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
