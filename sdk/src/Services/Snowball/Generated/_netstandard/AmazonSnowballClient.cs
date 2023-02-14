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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Snowball.Model;
using Amazon.Snowball.Model.Internal.MarshallTransformations;
using Amazon.Snowball.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Snowball
{
    /// <summary>
    /// Implementation for accessing Snowball
    ///
    /// The Amazon Web Services Snow Family provides a petabyte-scale data transport solution
    /// that uses secure devices to transfer large amounts of data between your on-premises
    /// data centers and Amazon Simple Storage Service (Amazon S3). The Snow Family commands
    /// described here provide access to the same functionality that is available in the Amazon
    /// Web Services Snow Family Management Console, which enables you to create and manage
    /// jobs for a Snow Family device. To transfer data locally with a Snow Family device,
    /// you'll need to use the Snowball Edge client or the Amazon S3 API Interface for Snowball
    /// or OpsHub for Snow Family. For more information, see the <a href="https://docs.aws.amazon.com/AWSImportExport/latest/ug/api-reference.html">User
    /// Guide</a>.
    /// </summary>
    public partial class AmazonSnowballClient : AmazonServiceClient, IAmazonSnowball
    {
        private static IServiceMetadata serviceMetadata = new AmazonSnowballMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
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
        public AmazonSnowballClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSnowballConfig()) { }

        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
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
        public AmazonSnowballClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSnowballConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(AmazonSnowballConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSnowballClient(AWSCredentials credentials)
            : this(credentials, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSnowballConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials and an
        /// AmazonSnowballClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(AWSCredentials credentials, AmazonSnowballConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowballConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowballClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSnowballConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowballConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowballClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSnowballConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISnowballPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISnowballPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SnowballPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSnowballEndpointResolver());
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


        #region  CancelCluster

        internal virtual CancelClusterResponse CancelCluster(CancelClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelClusterResponseUnmarshaller.Instance;

            return Invoke<CancelClusterResponse>(request, options);
        }



        /// <summary>
        /// Cancels a cluster job. You can only cancel a cluster job while it's in the <code>AwaitingQuorum</code>
        /// status. You'll have at least an hour after creating a cluster job to cancel it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelCluster">REST API Reference for CancelCluster Operation</seealso>
        public virtual Task<CancelClusterResponse> CancelClusterAsync(CancelClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CancelClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelJob

        internal virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified job. You can only cancel a job before its <code>JobState</code>
        /// value changes to <code>PreparingAppliance</code>. Requesting the <code>ListJobs</code>
        /// or <code>DescribeJob</code> action returns a job's <code>JobState</code> as part of
        /// the response element data returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAddress

        internal virtual CreateAddressResponse CreateAddress(CreateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressResponseUnmarshaller.Instance;

            return Invoke<CreateAddressResponse>(request, options);
        }



        /// <summary>
        /// Creates an address for a Snow device to be shipped to. In most regions, addresses
        /// are validated at the time of creation. The address you provide must be located within
        /// the serviceable area of your region. If the address is invalid or unsupported, then
        /// an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidAddressException">
        /// The address provided was invalid. Check the address with your region's carrier, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.UnsupportedAddressException">
        /// The address is either outside the serviceable area for your region, or an error occurred.
        /// Check the address with your region's carrier and try again. If the issue persists,
        /// contact Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateAddress">REST API Reference for CreateAddress Operation</seealso>
        public virtual Task<CreateAddressResponse> CreateAddressAsync(CreateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty cluster. Each cluster supports five nodes. You use the <a>CreateJob</a>
        /// action separately to create the jobs for each of these nodes. The cluster does not
        /// ship until these five node jobs have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a job to import or export data between Amazon S3 and your on-premises data
        /// center. Your Amazon Web Services account must have the right trust policies and permissions
        /// in place to create a job for a Snow device. If you're creating a job for a node in
        /// a cluster, you only need to provide the <code>clusterId</code> value; the other job
        /// attributes are inherited from the cluster. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the Snowball; Edge device type is supported when ordering clustered jobs.
        /// </para>
        ///  
        /// <para>
        /// The device capacity is optional.
        /// </para>
        ///  
        /// <para>
        /// Availability of device types differ by Amazon Web Services Region. For more information
        /// about Region availability, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/regional-product-services/?p=ngi&amp;loc=4">Amazon
        /// Web Services Regional Services</a>.
        /// </para>
        ///  </note>  <p class="title"> <b>Snow Family devices and their capacities.</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Snow Family device type: <b>SNC1_SSD</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T14
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowcone 
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Snow Family device type: <b>SNC1_HDD</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowcone 
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>EDGE_S</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T98
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowball Edge Storage Optimized for data transfer only 
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>EDGE_CG</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T42
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowball Edge Compute Optimized with GPU
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>EDGE_C</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T42
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowball Edge Compute Optimized without GPU
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>EDGE</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Snowball Edge Storage Optimized with EC2 Compute
        /// </para>
        ///  </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>STANDARD</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Original Snowball device
        /// </para>
        ///  <note> 
        /// <para>
        /// This device is only available in the Ningxia, Beijing, and Singapore Amazon Web Services
        /// Region 
        /// </para>
        ///  </note> </li> </ul>  </li> <li> 
        /// <para>
        /// Device type: <b>STANDARD</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Capacity: T80
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description: Original Snowball device
        /// </para>
        ///  <note> 
        /// <para>
        /// This device is only available in the Ningxia, Beijing, and Singapore Amazon Web Services
        /// Region. 
        /// </para>
        ///  </note> </li> </ul>  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ClusterLimitExceededException">
        /// Job creation failed. Currently, clusters support five nodes. If you have fewer than
        /// five nodes for your cluster and you have more nodes to create for this cluster, try
        /// again and create jobs until your cluster has exactly five nodes.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLongTermPricing

        internal virtual CreateLongTermPricingResponse CreateLongTermPricing(CreateLongTermPricingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLongTermPricingResponseUnmarshaller.Instance;

            return Invoke<CreateLongTermPricingResponse>(request, options);
        }



        /// <summary>
        /// Creates a job with the long-term usage option for a device. The long-term usage is
        /// a 1-year or 3-year long-term pricing type for the device. You are billed upfront,
        /// and Amazon Web Services provides discounts for long-term pricing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLongTermPricing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLongTermPricing service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateLongTermPricing">REST API Reference for CreateLongTermPricing Operation</seealso>
        public virtual Task<CreateLongTermPricingResponse> CreateLongTermPricingAsync(CreateLongTermPricingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLongTermPricingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLongTermPricingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReturnShippingLabel

        internal virtual CreateReturnShippingLabelResponse CreateReturnShippingLabel(CreateReturnShippingLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReturnShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReturnShippingLabelResponseUnmarshaller.Instance;

            return Invoke<CreateReturnShippingLabelResponse>(request, options);
        }



        /// <summary>
        /// Creates a shipping label that will be used to return the Snow device to Amazon Web
        /// Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReturnShippingLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReturnShippingLabel service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ConflictException">
        /// You get this exception when you call <code>CreateReturnShippingLabel</code> more than
        /// once when other requests are not completed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.ReturnShippingLabelAlreadyExistsException">
        /// You get this exception if you call <code>CreateReturnShippingLabel</code> and a valid
        /// return shipping label already exists. In this case, use <code>DescribeReturnShippingLabel</code>
        /// to get the URL.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateReturnShippingLabel">REST API Reference for CreateReturnShippingLabel Operation</seealso>
        public virtual Task<CreateReturnShippingLabelResponse> CreateReturnShippingLabelAsync(CreateReturnShippingLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReturnShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReturnShippingLabelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReturnShippingLabelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddress

        internal virtual DescribeAddressResponse DescribeAddress(DescribeAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressResponse>(request, options);
        }



        /// <summary>
        /// Takes an <code>AddressId</code> and returns specific details about that address in
        /// the form of an <code>Address</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddress">REST API Reference for DescribeAddress Operation</seealso>
        public virtual Task<DescribeAddressResponse> DescribeAddressAsync(DescribeAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal virtual DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesResponse>(request, options);
        }



        /// <summary>
        /// Returns a specified number of <code>ADDRESS</code> objects. Calling this API in one
        /// of the US regions will return addresses from the list of all addresses associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific cluster including shipping information, cluster
        /// status, and other important metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific job including shipping information, job status,
        /// and other important metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReturnShippingLabel

        internal virtual DescribeReturnShippingLabelResponse DescribeReturnShippingLabel(DescribeReturnShippingLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReturnShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReturnShippingLabelResponseUnmarshaller.Instance;

            return Invoke<DescribeReturnShippingLabelResponse>(request, options);
        }



        /// <summary>
        /// Information on the shipping label of a Snow device that is being returned to Amazon
        /// Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReturnShippingLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReturnShippingLabel service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ConflictException">
        /// You get this exception when you call <code>CreateReturnShippingLabel</code> more than
        /// once when other requests are not completed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeReturnShippingLabel">REST API Reference for DescribeReturnShippingLabel Operation</seealso>
        public virtual Task<DescribeReturnShippingLabelResponse> DescribeReturnShippingLabelAsync(DescribeReturnShippingLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReturnShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReturnShippingLabelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReturnShippingLabelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobManifest

        internal virtual GetJobManifestResponse GetJobManifest(GetJobManifestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobManifestResponseUnmarshaller.Instance;

            return Invoke<GetJobManifestResponse>(request, options);
        }



        /// <summary>
        /// Returns a link to an Amazon S3 presigned URL for the manifest file associated with
        /// the specified <code>JobId</code> value. You can access the manifest file for up to
        /// 60 minutes after this request has been made. To access the manifest file after 60
        /// minutes have passed, you'll have to make another call to the <code>GetJobManifest</code>
        /// action.
        /// 
        ///  
        /// <para>
        /// The manifest is an encrypted file that you can download after your job enters the
        /// <code>WithCustomer</code> status. This is the only valid status for calling this API
        /// as the manifest and <code>UnlockCode</code> code value are used for securing your
        /// device and should only be used when you have the device. The manifest is decrypted
        /// by using the <code>UnlockCode</code> code value, when you pass both values to the
        /// Snow device through the Snowball client when the client is started for the first time.
        /// 
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of an <code>UnlockCode</code>
        /// value in the same location as the manifest file for that job. Saving these separately
        /// helps prevent unauthorized parties from gaining access to the Snow device associated
        /// with that job.
        /// </para>
        ///  
        /// <para>
        /// The credentials of a given job, including its manifest file and unlock code, expire
        /// 360 days after the job is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobManifest service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobManifest">REST API Reference for GetJobManifest Operation</seealso>
        public virtual Task<GetJobManifestResponse> GetJobManifestAsync(GetJobManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobManifestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobManifestResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobManifestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobUnlockCode

        internal virtual GetJobUnlockCodeResponse GetJobUnlockCode(GetJobUnlockCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobUnlockCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobUnlockCodeResponseUnmarshaller.Instance;

            return Invoke<GetJobUnlockCodeResponse>(request, options);
        }



        /// <summary>
        /// Returns the <code>UnlockCode</code> code value for the specified job. A particular
        /// <code>UnlockCode</code> value can be accessed for up to 360 days after the associated
        /// job has been created.
        /// 
        ///  
        /// <para>
        /// The <code>UnlockCode</code> value is a 29-character code with 25 alphanumeric characters
        /// and 4 hyphens. This code is used to decrypt the manifest file when it is passed along
        /// with the manifest to the Snow device through the Snowball client when the client is
        /// started for the first time. The only valid status for calling this API is <code>WithCustomer</code>
        /// as the manifest and <code>Unlock</code> code values are used for securing your device
        /// and should only be used when you have the device.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of the <code>UnlockCode</code>
        /// in the same location as the manifest file for that job. Saving these separately helps
        /// prevent unauthorized parties from gaining access to the Snow device associated with
        /// that job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobUnlockCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobUnlockCode service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobUnlockCode">REST API Reference for GetJobUnlockCode Operation</seealso>
        public virtual Task<GetJobUnlockCodeResponse> GetJobUnlockCodeAsync(GetJobUnlockCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobUnlockCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobUnlockCodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobUnlockCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnowballUsage

        internal virtual GetSnowballUsageResponse GetSnowballUsage(GetSnowballUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnowballUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnowballUsageResponseUnmarshaller.Instance;

            return Invoke<GetSnowballUsageResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the Snow Family service limit for your account, and also
        /// the number of Snow devices your account has in use.
        /// 
        ///  
        /// <para>
        /// The default service limit for the number of Snow devices that you can have at one
        /// time is 1. If you want to increase your service limit, contact Amazon Web Services
        /// Support.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnowballUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnowballUsage service method, as returned by Snowball.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetSnowballUsage">REST API Reference for GetSnowballUsage Operation</seealso>
        public virtual Task<GetSnowballUsageResponse> GetSnowballUsageAsync(GetSnowballUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnowballUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnowballUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnowballUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSoftwareUpdates

        internal virtual GetSoftwareUpdatesResponse GetSoftwareUpdates(GetSoftwareUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSoftwareUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSoftwareUpdatesResponseUnmarshaller.Instance;

            return Invoke<GetSoftwareUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Returns an Amazon S3 presigned URL for an update file associated with a specified
        /// <code>JobId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSoftwareUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSoftwareUpdates service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetSoftwareUpdates">REST API Reference for GetSoftwareUpdates Operation</seealso>
        public virtual Task<GetSoftwareUpdatesResponse> GetSoftwareUpdatesAsync(GetSoftwareUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSoftwareUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSoftwareUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSoftwareUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusterJobs

        internal virtual ListClusterJobsResponse ListClusterJobs(ListClusterJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClusterJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterJobsResponseUnmarshaller.Instance;

            return Invoke<ListClusterJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>JobListEntry</code> objects of the specified length. Each
        /// <code>JobListEntry</code> object is for a job in the specified cluster and contains
        /// a job's state, a job's ID, and other information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterJobs service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusterJobs">REST API Reference for ListClusterJobs Operation</seealso>
        public virtual Task<ListClusterJobsResponse> ListClusterJobsAsync(ListClusterJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClusterJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListClusterJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>ClusterListEntry</code> objects of the specified length.
        /// Each <code>ClusterListEntry</code> object contains a cluster's state, a cluster's
        /// ID, and other important status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCompatibleImages

        internal virtual ListCompatibleImagesResponse ListCompatibleImages(ListCompatibleImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompatibleImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompatibleImagesResponseUnmarshaller.Instance;

            return Invoke<ListCompatibleImagesResponse>(request, options);
        }



        /// <summary>
        /// This action returns a list of the different Amazon EC2 Amazon Machine Images (AMIs)
        /// that are owned by your Amazon Web Services accountthat would be supported for use
        /// on a Snow device. Currently, supported AMIs are based on the CentOS 7 (x86_64) - with
        /// Updates HVM, Ubuntu Server 14.04 LTS (HVM), and Ubuntu 16.04 LTS - Xenial (HVM) images,
        /// available on the Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompatibleImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompatibleImages service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListCompatibleImages">REST API Reference for ListCompatibleImages Operation</seealso>
        public virtual Task<ListCompatibleImagesResponse> ListCompatibleImagesAsync(ListCompatibleImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompatibleImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompatibleImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCompatibleImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>JobListEntry</code> objects of the specified length. Each
        /// <code>JobListEntry</code> object contains a job's state, a job's ID, and a value that
        /// indicates whether the job is a job part, in the case of export jobs. Calling this
        /// API action in one of the US regions will return jobs from the list of all jobs associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLongTermPricing

        internal virtual ListLongTermPricingResponse ListLongTermPricing(ListLongTermPricingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLongTermPricingResponseUnmarshaller.Instance;

            return Invoke<ListLongTermPricingResponse>(request, options);
        }



        /// <summary>
        /// Lists all long-term pricing types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLongTermPricing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLongTermPricing service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListLongTermPricing">REST API Reference for ListLongTermPricing Operation</seealso>
        public virtual Task<ListLongTermPricingResponse> ListLongTermPricingAsync(ListLongTermPricingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLongTermPricingResponseUnmarshaller.Instance;

            return InvokeAsync<ListLongTermPricingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceVersions

        internal virtual ListServiceVersionsResponse ListServiceVersions(ListServiceVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceVersionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all supported versions for Snow on-device services. Returns an array of <code>ServiceVersion</code>
        /// object containing the supported versions for a particular service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceVersions service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListServiceVersions">REST API Reference for ListServiceVersions Operation</seealso>
        public virtual Task<ListServiceVersionsResponse> ListServiceVersionsAsync(ListServiceVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster

        internal virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }



        /// <summary>
        /// While a cluster's <code>ClusterState</code> value is in the <code>AwaitingQuorum</code>
        /// state, you can update some of the information associated with a cluster. Once the
        /// cluster changes to a different job state, usually 60 minutes after the cluster being
        /// created, this action is no longer available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob

        internal virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }



        /// <summary>
        /// While a job's <code>JobState</code> value is <code>New</code>, you can update some
        /// of the information associated with a job. Once the job changes to a different job
        /// state, usually within 60 minutes of the job being created, this action is no longer
        /// available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ClusterLimitExceededException">
        /// Job creation failed. Currently, clusters support five nodes. If you have fewer than
        /// five nodes for your cluster and you have more nodes to create for this cluster, try
        /// again and create jobs until your cluster has exactly five nodes.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJobShipmentState

        internal virtual UpdateJobShipmentStateResponse UpdateJobShipmentState(UpdateJobShipmentStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobShipmentStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobShipmentStateResponseUnmarshaller.Instance;

            return Invoke<UpdateJobShipmentStateResponse>(request, options);
        }



        /// <summary>
        /// Updates the state when a shipment state changes to a different state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobShipmentState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobShipmentState service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateJobShipmentState">REST API Reference for UpdateJobShipmentState Operation</seealso>
        public virtual Task<UpdateJobShipmentStateResponse> UpdateJobShipmentStateAsync(UpdateJobShipmentStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobShipmentStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobShipmentStateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobShipmentStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLongTermPricing

        internal virtual UpdateLongTermPricingResponse UpdateLongTermPricing(UpdateLongTermPricingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLongTermPricingResponseUnmarshaller.Instance;

            return Invoke<UpdateLongTermPricingResponse>(request, options);
        }



        /// <summary>
        /// Updates the long-term pricing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLongTermPricing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLongTermPricing service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateLongTermPricing">REST API Reference for UpdateLongTermPricing Operation</seealso>
        public virtual Task<UpdateLongTermPricingResponse> UpdateLongTermPricingAsync(UpdateLongTermPricingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLongTermPricingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLongTermPricingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLongTermPricingResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}