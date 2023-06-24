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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ComputeOptimizer.Model;
using Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations;
using Amazon.ComputeOptimizer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ComputeOptimizer
{
    /// <summary>
    /// Implementation for accessing ComputeOptimizer
    ///
    /// Compute Optimizer is a service that analyzes the configuration and utilization metrics
    /// of your Amazon Web Services compute resources, such as Amazon EC2 instances, Amazon
    /// EC2 Auto Scaling groups, Lambda functions, Amazon EBS volumes, and Amazon ECS services
    /// on Fargate. It reports whether your resources are optimal, and generates optimization
    /// recommendations to reduce the cost and improve the performance of your workloads.
    /// Compute Optimizer also provides recent utilization metric data, in addition to projected
    /// utilization metric data for the recommendations, which you can use to evaluate which
    /// recommendation provides the best price-performance trade-off. The analysis of your
    /// usage patterns can help you decide when to move or resize your running resources,
    /// and still meet your performance and capacity requirements. For more information about
    /// Compute Optimizer, including the required permissions to use the service, see the
    /// <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/">Compute Optimizer
    /// User Guide</a>.
    /// </summary>
    public partial class AmazonComputeOptimizerClient : AmazonServiceClient, IAmazonComputeOptimizer
    {
        private static IServiceMetadata serviceMetadata = new AmazonComputeOptimizerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IComputeOptimizerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IComputeOptimizerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ComputeOptimizerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
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
        public AmazonComputeOptimizerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComputeOptimizerConfig()) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
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
        public AmazonComputeOptimizerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComputeOptimizerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(AmazonComputeOptimizerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials)
            : this(credentials, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComputeOptimizerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials and an
        /// AmazonComputeOptimizerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials, AmazonComputeOptimizerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComputeOptimizerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComputeOptimizerConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonComputeOptimizerEndpointResolver());
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


        #region  DeleteRecommendationPreferences

        /// <summary>
        /// Deletes a recommendation preference, such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationPreferences service method.</param>
        /// 
        /// <returns>The response from the DeleteRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DeleteRecommendationPreferences">REST API Reference for DeleteRecommendationPreferences Operation</seealso>
        public virtual DeleteRecommendationPreferencesResponse DeleteRecommendationPreferences(DeleteRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommendationPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationPreferences operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommendationPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DeleteRecommendationPreferences">REST API Reference for DeleteRecommendationPreferences Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecommendationPreferences(DeleteRecommendationPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommendationPreferences.</param>
        /// 
        /// <returns>Returns a  DeleteRecommendationPreferencesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DeleteRecommendationPreferences">REST API Reference for DeleteRecommendationPreferences Operation</seealso>
        public virtual DeleteRecommendationPreferencesResponse EndDeleteRecommendationPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecommendationPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecommendationExportJobs

        /// <summary>
        /// Describes recommendation export jobs created in the last seven days.
        /// 
        ///  
        /// <para>
        /// Use the <a>ExportAutoScalingGroupRecommendations</a> or <a>ExportEC2InstanceRecommendations</a>
        /// actions to request an export of your recommendations. Then use the <a>DescribeRecommendationExportJobs</a>
        /// action to view your export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendationExportJobs service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        public virtual DescribeRecommendationExportJobsResponse DescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendationExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendationExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendationExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendationExportJobs.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationExportJobsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        public virtual DescribeRecommendationExportJobsResponse EndDescribeRecommendationExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecommendationExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportAutoScalingGroupRecommendations

        /// <summary>
        /// Exports optimization recommendations for Auto Scaling groups.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Auto Scaling group export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        public virtual ExportAutoScalingGroupRecommendationsResponse ExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportAutoScalingGroupRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportAutoScalingGroupRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        public virtual IAsyncResult BeginExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportAutoScalingGroupRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportAutoScalingGroupRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        public virtual ExportAutoScalingGroupRecommendationsResponse EndExportAutoScalingGroupRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportAutoScalingGroupRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportEBSVolumeRecommendations

        /// <summary>
        /// Exports optimization recommendations for Amazon EBS volumes.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EBS volume export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEBSVolumeRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEBSVolumeRecommendations">REST API Reference for ExportEBSVolumeRecommendations Operation</seealso>
        public virtual ExportEBSVolumeRecommendationsResponse ExportEBSVolumeRecommendations(ExportEBSVolumeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportEBSVolumeRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportEBSVolumeRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportEBSVolumeRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEBSVolumeRecommendations">REST API Reference for ExportEBSVolumeRecommendations Operation</seealso>
        public virtual IAsyncResult BeginExportEBSVolumeRecommendations(ExportEBSVolumeRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportEBSVolumeRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportEBSVolumeRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEBSVolumeRecommendations">REST API Reference for ExportEBSVolumeRecommendations Operation</seealso>
        public virtual ExportEBSVolumeRecommendationsResponse EndExportEBSVolumeRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportEBSVolumeRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportEC2InstanceRecommendations

        /// <summary>
        /// Exports optimization recommendations for Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EC2 instance export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        public virtual ExportEC2InstanceRecommendationsResponse ExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportEC2InstanceRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportEC2InstanceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        public virtual IAsyncResult BeginExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportEC2InstanceRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportEC2InstanceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        public virtual ExportEC2InstanceRecommendationsResponse EndExportEC2InstanceRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportEC2InstanceRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportECSServiceRecommendations

        /// <summary>
        /// Exports optimization recommendations for Amazon ECS services on Fargate. 
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a CSV file, and its metadata in a JSON file, to an
        /// existing Amazon Simple Storage Service (Amazon S3) bucket that you specify. For more
        /// information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can only have one Amazon ECS service export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportECSServiceRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportECSServiceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportECSServiceRecommendations">REST API Reference for ExportECSServiceRecommendations Operation</seealso>
        public virtual ExportECSServiceRecommendationsResponse ExportECSServiceRecommendations(ExportECSServiceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportECSServiceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportECSServiceRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportECSServiceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportECSServiceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportECSServiceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportECSServiceRecommendations">REST API Reference for ExportECSServiceRecommendations Operation</seealso>
        public virtual IAsyncResult BeginExportECSServiceRecommendations(ExportECSServiceRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportECSServiceRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportECSServiceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportECSServiceRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportECSServiceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportECSServiceRecommendations">REST API Reference for ExportECSServiceRecommendations Operation</seealso>
        public virtual ExportECSServiceRecommendationsResponse EndExportECSServiceRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportECSServiceRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportLambdaFunctionRecommendations

        /// <summary>
        /// Exports optimization recommendations for Lambda functions.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Lambda function export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLambdaFunctionRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportLambdaFunctionRecommendations">REST API Reference for ExportLambdaFunctionRecommendations Operation</seealso>
        public virtual ExportLambdaFunctionRecommendationsResponse ExportLambdaFunctionRecommendations(ExportLambdaFunctionRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportLambdaFunctionRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportLambdaFunctionRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportLambdaFunctionRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportLambdaFunctionRecommendations">REST API Reference for ExportLambdaFunctionRecommendations Operation</seealso>
        public virtual IAsyncResult BeginExportLambdaFunctionRecommendations(ExportLambdaFunctionRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportLambdaFunctionRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportLambdaFunctionRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportLambdaFunctionRecommendations">REST API Reference for ExportLambdaFunctionRecommendations Operation</seealso>
        public virtual ExportLambdaFunctionRecommendationsResponse EndExportLambdaFunctionRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportLambdaFunctionRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutoScalingGroupRecommendations

        /// <summary>
        /// Returns Auto Scaling group recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon EC2 Auto Scaling groups that
        /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        public virtual GetAutoScalingGroupRecommendationsResponse GetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetAutoScalingGroupRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoScalingGroupRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoScalingGroupRecommendations.</param>
        /// 
        /// <returns>Returns a  GetAutoScalingGroupRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        public virtual GetAutoScalingGroupRecommendationsResponse EndGetAutoScalingGroupRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutoScalingGroupRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEBSVolumeRecommendations

        /// <summary>
        /// Returns Amazon Elastic Block Store (Amazon EBS) volume recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon EBS volumes that meet a specific
        /// set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        public virtual GetEBSVolumeRecommendationsResponse GetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEBSVolumeRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEBSVolumeRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEBSVolumeRecommendations.</param>
        /// 
        /// <returns>Returns a  GetEBSVolumeRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        public virtual GetEBSVolumeRecommendationsResponse EndGetEBSVolumeRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEBSVolumeRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEC2InstanceRecommendations

        /// <summary>
        /// Returns Amazon EC2 instance recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon Elastic Compute Cloud (Amazon
        /// EC2) instances that meet a specific set of requirements. For more information, see
        /// the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        public virtual GetEC2InstanceRecommendationsResponse GetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEC2InstanceRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEC2InstanceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEC2InstanceRecommendations.</param>
        /// 
        /// <returns>Returns a  GetEC2InstanceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        public virtual GetEC2InstanceRecommendationsResponse EndGetEC2InstanceRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEC2InstanceRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEC2RecommendationProjectedMetrics

        /// <summary>
        /// Returns the projected utilization metrics of Amazon EC2 instance recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Cpu</code> and <code>Memory</code> metrics are the only projected utilization
        /// metrics returned when you run this action. Additionally, the <code>Memory</code> metric
        /// is returned only for resources that have the unified CloudWatch agent installed on
        /// them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2RecommendationProjectedMetrics service method.</param>
        /// 
        /// <returns>The response from the GetEC2RecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        public virtual GetEC2RecommendationProjectedMetricsResponse GetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetEC2RecommendationProjectedMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEC2RecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEC2RecommendationProjectedMetrics operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEC2RecommendationProjectedMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEC2RecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEC2RecommendationProjectedMetrics.</param>
        /// 
        /// <returns>Returns a  GetEC2RecommendationProjectedMetricsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        public virtual GetEC2RecommendationProjectedMetricsResponse EndGetEC2RecommendationProjectedMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEC2RecommendationProjectedMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetECSServiceRecommendationProjectedMetrics

        /// <summary>
        /// Returns the projected metrics of Amazon ECS service recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendationProjectedMetrics service method.</param>
        /// 
        /// <returns>The response from the GetECSServiceRecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendationProjectedMetrics">REST API Reference for GetECSServiceRecommendationProjectedMetrics Operation</seealso>
        public virtual GetECSServiceRecommendationProjectedMetricsResponse GetECSServiceRecommendationProjectedMetrics(GetECSServiceRecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetECSServiceRecommendationProjectedMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetECSServiceRecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendationProjectedMetrics operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetECSServiceRecommendationProjectedMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendationProjectedMetrics">REST API Reference for GetECSServiceRecommendationProjectedMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetECSServiceRecommendationProjectedMetrics(GetECSServiceRecommendationProjectedMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetECSServiceRecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetECSServiceRecommendationProjectedMetrics.</param>
        /// 
        /// <returns>Returns a  GetECSServiceRecommendationProjectedMetricsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendationProjectedMetrics">REST API Reference for GetECSServiceRecommendationProjectedMetrics Operation</seealso>
        public virtual GetECSServiceRecommendationProjectedMetricsResponse EndGetECSServiceRecommendationProjectedMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetECSServiceRecommendationProjectedMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetECSServiceRecommendations

        /// <summary>
        /// Returns Amazon ECS service recommendations. 
        /// 
        ///  
        /// <para>
        ///  Compute Optimizer generates recommendations for Amazon ECS services on Fargate that
        /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetECSServiceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendations">REST API Reference for GetECSServiceRecommendations Operation</seealso>
        public virtual GetECSServiceRecommendationsResponse GetECSServiceRecommendations(GetECSServiceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetECSServiceRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetECSServiceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetECSServiceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendations">REST API Reference for GetECSServiceRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetECSServiceRecommendations(GetECSServiceRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetECSServiceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetECSServiceRecommendations.</param>
        /// 
        /// <returns>Returns a  GetECSServiceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendations">REST API Reference for GetECSServiceRecommendations Operation</seealso>
        public virtual GetECSServiceRecommendationsResponse EndGetECSServiceRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetECSServiceRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEffectiveRecommendationPreferences

        /// <summary>
        /// Returns the recommendation preferences that are in effect for a given resource, such
        /// as enhanced infrastructure metrics. Considers all applicable preferences that you
        /// might have set at the resource, account, and organization level.
        /// 
        ///  
        /// <para>
        /// When you create a recommendation preference, you can set its status to <code>Active</code>
        /// or <code>Inactive</code>. Use this action to view the recommendation preferences that
        /// are in effect, or <code>Active</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectiveRecommendationPreferences service method.</param>
        /// 
        /// <returns>The response from the GetEffectiveRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEffectiveRecommendationPreferences">REST API Reference for GetEffectiveRecommendationPreferences Operation</seealso>
        public virtual GetEffectiveRecommendationPreferencesResponse GetEffectiveRecommendationPreferences(GetEffectiveRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectiveRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectiveRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetEffectiveRecommendationPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEffectiveRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectiveRecommendationPreferences operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEffectiveRecommendationPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEffectiveRecommendationPreferences">REST API Reference for GetEffectiveRecommendationPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetEffectiveRecommendationPreferences(GetEffectiveRecommendationPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectiveRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectiveRecommendationPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEffectiveRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEffectiveRecommendationPreferences.</param>
        /// 
        /// <returns>Returns a  GetEffectiveRecommendationPreferencesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEffectiveRecommendationPreferences">REST API Reference for GetEffectiveRecommendationPreferences Operation</seealso>
        public virtual GetEffectiveRecommendationPreferencesResponse EndGetEffectiveRecommendationPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEffectiveRecommendationPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnrollmentStatus

        /// <summary>
        /// Returns the enrollment (opt in) status of an account to the Compute Optimizer service.
        /// 
        ///  
        /// <para>
        /// If the account is the management account of an organization, this action also confirms
        /// the enrollment status of member accounts of the organization. Use the <a>GetEnrollmentStatusesForOrganization</a>
        /// action to get detailed information about the enrollment status of member accounts
        /// of an organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the GetEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        public virtual GetEnrollmentStatusResponse GetEnrollmentStatus(GetEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnrollmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        public virtual IAsyncResult BeginGetEnrollmentStatus(GetEnrollmentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnrollmentStatus.</param>
        /// 
        /// <returns>Returns a  GetEnrollmentStatusResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        public virtual GetEnrollmentStatusResponse EndGetEnrollmentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnrollmentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnrollmentStatusesForOrganization

        /// <summary>
        /// Returns the Compute Optimizer enrollment (opt-in) status of organization member accounts,
        /// if your account is an organization management account.
        /// 
        ///  
        /// <para>
        /// To get the enrollment status of standalone accounts, use the <a>GetEnrollmentStatus</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatusesForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetEnrollmentStatusesForOrganization service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatusesForOrganization">REST API Reference for GetEnrollmentStatusesForOrganization Operation</seealso>
        public virtual GetEnrollmentStatusesForOrganizationResponse GetEnrollmentStatusesForOrganization(GetEnrollmentStatusesForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentStatusesForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnrollmentStatusesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatusesForOrganization operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnrollmentStatusesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatusesForOrganization">REST API Reference for GetEnrollmentStatusesForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetEnrollmentStatusesForOrganization(GetEnrollmentStatusesForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusesForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnrollmentStatusesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnrollmentStatusesForOrganization.</param>
        /// 
        /// <returns>Returns a  GetEnrollmentStatusesForOrganizationResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatusesForOrganization">REST API Reference for GetEnrollmentStatusesForOrganization Operation</seealso>
        public virtual GetEnrollmentStatusesForOrganizationResponse EndGetEnrollmentStatusesForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnrollmentStatusesForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLambdaFunctionRecommendations

        /// <summary>
        /// Returns Lambda function recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for functions that meet a specific set
        /// of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        public virtual GetLambdaFunctionRecommendationsResponse GetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetLambdaFunctionRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLambdaFunctionRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        public virtual IAsyncResult BeginGetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLambdaFunctionRecommendations.</param>
        /// 
        /// <returns>Returns a  GetLambdaFunctionRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        public virtual GetLambdaFunctionRecommendationsResponse EndGetLambdaFunctionRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLambdaFunctionRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendationPreferences

        /// <summary>
        /// Returns existing recommendation preferences, such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// Use the <code>scope</code> parameter to specify which preferences to return. You can
        /// specify to return preferences for an organization, a specific account ID, or a specific
        /// EC2 instance or Auto Scaling group Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationPreferences service method.</param>
        /// 
        /// <returns>The response from the GetRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationPreferences">REST API Reference for GetRecommendationPreferences Operation</seealso>
        public virtual GetRecommendationPreferencesResponse GetRecommendationPreferences(GetRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationPreferences operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendationPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationPreferences">REST API Reference for GetRecommendationPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendationPreferences(GetRecommendationPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendationPreferences.</param>
        /// 
        /// <returns>Returns a  GetRecommendationPreferencesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationPreferences">REST API Reference for GetRecommendationPreferences Operation</seealso>
        public virtual GetRecommendationPreferencesResponse EndGetRecommendationPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommendationSummaries

        /// <summary>
        /// Returns the optimization findings for an account.
        /// 
        ///  
        /// <para>
        /// It returns the number of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon EC2 instances in an account that are <code>Underprovisioned</code>, <code>Overprovisioned</code>,
        /// or <code>Optimized</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto Scaling groups in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon EBS volumes in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda functions in an account that are <code>NotOptimized</code>, or <code>Optimized</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS services in an account that are <code>Underprovisioned</code>, <code>Overprovisioned</code>,
        /// or <code>Optimized</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries service method.</param>
        /// 
        /// <returns>The response from the GetRecommendationSummaries service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        public virtual GetRecommendationSummariesResponse GetRecommendationSummaries(GetRecommendationSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendationSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendationSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        public virtual IAsyncResult BeginGetRecommendationSummaries(GetRecommendationSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendationSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendationSummaries.</param>
        /// 
        /// <returns>Returns a  GetRecommendationSummariesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        public virtual GetRecommendationSummariesResponse EndGetRecommendationSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommendationSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecommendationPreferences

        /// <summary>
        /// Creates a new recommendation preference or updates an existing recommendation preference,
        /// such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationPreferences service method.</param>
        /// 
        /// <returns>The response from the PutRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/PutRecommendationPreferences">REST API Reference for PutRecommendationPreferences Operation</seealso>
        public virtual PutRecommendationPreferencesResponse PutRecommendationPreferences(PutRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutRecommendationPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationPreferences operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecommendationPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/PutRecommendationPreferences">REST API Reference for PutRecommendationPreferences Operation</seealso>
        public virtual IAsyncResult BeginPutRecommendationPreferences(PutRecommendationPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecommendationPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecommendationPreferences.</param>
        /// 
        /// <returns>Returns a  PutRecommendationPreferencesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/PutRecommendationPreferences">REST API Reference for PutRecommendationPreferences Operation</seealso>
        public virtual PutRecommendationPreferencesResponse EndPutRecommendationPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecommendationPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnrollmentStatus

        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account of an organization, this action can also be
        /// used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Compute Optimizer, to view
        /// its recommendations, and to opt out. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/security-iam.html">Controlling
        /// access with Amazon Web Services Identity and Access Management</a> in the <i>Compute
        /// Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you opt in, Compute Optimizer automatically creates a service-linked role in
        /// your account to access its data. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Compute Optimizer</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateEnrollmentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnrollmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnrollmentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateEnrollmentStatusResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual UpdateEnrollmentStatusResponse EndUpdateEnrollmentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnrollmentStatusResponse>(asyncResult);
        }

        #endregion
        
    }
}