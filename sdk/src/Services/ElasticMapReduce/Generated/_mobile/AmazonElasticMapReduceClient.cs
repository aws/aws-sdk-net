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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// Amazon EMR is a web service that makes it easy to process large amounts of data efficiently.
    /// Amazon EMR uses Hadoop processing combined with several AWS products to do tasks such
    /// as web indexing, data mining, log file analysis, machine learning, scientific simulation,
    /// and data warehousing.
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        
        #region  AddInstanceFleet

        internal virtual AddInstanceFleetResponse AddInstanceFleet(AddInstanceFleetRequest request)
        {
            var marshaller = AddInstanceFleetRequestMarshaller.Instance;
            var unmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<AddInstanceFleetRequest,AddInstanceFleetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual Task<AddInstanceFleetResponse> AddInstanceFleetAsync(AddInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddInstanceFleetRequestMarshaller.Instance;
            var unmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceFleetRequest,AddInstanceFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddInstanceGroups

        internal virtual AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var marshaller = AddInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsRequest,AddInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceGroupsRequest,AddInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddJobFlowSteps

        internal virtual AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var marshaller = AddJobFlowStepsRequestMarshaller.Instance;
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsRequest,AddJobFlowStepsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddJobFlowStepsRequestMarshaller.Instance;
            var unmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<AddJobFlowStepsRequest,AddJobFlowStepsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSteps

        internal virtual CancelStepsResponse CancelSteps(CancelStepsRequest request)
        {
            var marshaller = CancelStepsRequestMarshaller.Instance;
            var unmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return Invoke<CancelStepsRequest,CancelStepsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual Task<CancelStepsResponse> CancelStepsAsync(CancelStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelStepsRequestMarshaller.Instance;
            var unmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelStepsRequest,CancelStepsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityConfiguration

        internal virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var marshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationRequest,CreateSecurityConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual Task<CreateSecurityConfigurationResponse> CreateSecurityConfigurationAsync(CreateSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityConfigurationRequest,CreateSecurityConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityConfiguration

        internal virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var marshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationRequest,DeleteSecurityConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual Task<DeleteSecurityConfigurationResponse> DeleteSecurityConfigurationAsync(DeleteSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityConfigurationRequest,DeleteSecurityConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }
        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var marshaller = DescribeClusterRequestMarshaller.Instance;
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on. For information about the cluster steps, see <a>ListSteps</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterAsync(new DescribeClusterRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeClusterRequestMarshaller.Instance;
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobFlows

        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var marshaller = DescribeJobFlowsRequestMarshaller.Instance;
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsRequest,DescribeJobFlowsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
        /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
        /// instead.
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
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeJobFlowsAsync(new DescribeJobFlowsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeJobFlowsRequestMarshaller.Instance;
            var unmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobFlowsRequest,DescribeJobFlowsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityConfiguration

        internal virtual DescribeSecurityConfigurationResponse DescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request)
        {
            var marshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityConfigurationRequest,DescribeSecurityConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual Task<DescribeSecurityConfigurationResponse> DescribeSecurityConfigurationAsync(DescribeSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityConfigurationRequest,DescribeSecurityConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStep

        internal virtual DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }
        internal virtual DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var marshaller = DescribeStepRequestMarshaller.Instance;
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepRequest,DescribeStepResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStepAsync(new DescribeStepRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeStepRequestMarshaller.Instance;
            var unmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStepRequest,DescribeStepResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBootstrapActions

        internal virtual ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }
        internal virtual ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var marshaller = ListBootstrapActionsRequestMarshaller.Instance;
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsRequest,ListBootstrapActionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBootstrapActionsAsync(new ListBootstrapActionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBootstrapActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListBootstrapActionsRequestMarshaller.Instance;
            var unmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBootstrapActionsRequest,ListBootstrapActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }
        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersRequest,ListClustersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides the status of all clusters visible to this AWS account. Allows you to filter
        /// the list of clusters based on certain criteria; for example, filtering by cluster
        /// creation date and time or by status. This call returns a maximum of 50 clusters per
        /// call, but returns a marker to track the paging of the cluster list across multiple
        /// ListClusters calls.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListClustersAsync(new ListClustersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListClustersRequestMarshaller.Instance;
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersRequest,ListClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceFleets

        internal virtual ListInstanceFleetsResponse ListInstanceFleets(ListInstanceFleetsRequest request)
        {
            var marshaller = ListInstanceFleetsRequestMarshaller.Instance;
            var unmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceFleetsRequest,ListInstanceFleetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual Task<ListInstanceFleetsResponse> ListInstanceFleetsAsync(ListInstanceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInstanceFleetsRequestMarshaller.Instance;
            var unmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceFleetsRequest,ListInstanceFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceGroups

        internal virtual ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }
        internal virtual ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var marshaller = ListInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsRequest,ListInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstanceGroupsAsync(new ListInstanceGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceGroupsRequest,ListInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }
        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var marshaller = ListInstancesRequestMarshaller.Instance;
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesRequest,ListInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstancesAsync(new ListInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInstancesRequestMarshaller.Instance;
            var unmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesRequest,ListInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityConfigurations

        internal virtual ListSecurityConfigurationsResponse ListSecurityConfigurations(ListSecurityConfigurationsRequest request)
        {
            var marshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigurationsRequest,ListSecurityConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual Task<ListSecurityConfigurationsResponse> ListSecurityConfigurationsAsync(ListSecurityConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityConfigurationsRequest,ListSecurityConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSteps

        internal virtual ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }
        internal virtual ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var marshaller = ListStepsRequestMarshaller.Instance;
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsRequest,ListStepsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify stepIds
        /// with the request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStepsAsync(new ListStepsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListStepsRequestMarshaller.Instance;
            var unmarshaller = ListStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStepsRequest,ListStepsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceFleet

        internal virtual ModifyInstanceFleetResponse ModifyInstanceFleet(ModifyInstanceFleetRequest request)
        {
            var marshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceFleetRequest,ModifyInstanceFleetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual Task<ModifyInstanceFleetResponse> ModifyInstanceFleetAsync(ModifyInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceFleetRequest,ModifyInstanceFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceGroups

        internal virtual ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var marshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsRequest,ModifyInstanceGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceGroupsRequest,ModifyInstanceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAutoScalingPolicy

        internal virtual PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request)
        {
            var marshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            var unmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoScalingPolicyRequest,PutAutoScalingPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyAsync(PutAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            var unmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutAutoScalingPolicyRequest,PutAutoScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveAutoScalingPolicy

        internal virtual RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request)
        {
            var marshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            var unmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoScalingPolicyRequest,RemoveAutoScalingPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAutoScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyAsync(RemoveAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            var unmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAutoScalingPolicyRequest,RemoveAutoScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunJobFlow

        internal virtual RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var marshaller = RunJobFlowRequestMarshaller.Instance;
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowRequest,RunJobFlowResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RunJobFlowRequestMarshaller.Instance;
            var unmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return InvokeAsync<RunJobFlowRequest,RunJobFlowResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTerminationProtection

        internal virtual SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var marshaller = SetTerminationProtectionRequestMarshaller.Instance;
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionRequest,SetTerminationProtectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetTerminationProtectionRequestMarshaller.Instance;
            var unmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<SetTerminationProtectionRequest,SetTerminationProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetVisibleToAllUsers

        internal virtual SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var marshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersRequest,SetVisibleToAllUsersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            var unmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SetVisibleToAllUsersRequest,SetVisibleToAllUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateJobFlows

        internal virtual TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var marshaller = TerminateJobFlowsRequestMarshaller.Instance;
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsRequest,TerminateJobFlowsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TerminateJobFlowsRequestMarshaller.Instance;
            var unmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateJobFlowsRequest,TerminateJobFlowsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}