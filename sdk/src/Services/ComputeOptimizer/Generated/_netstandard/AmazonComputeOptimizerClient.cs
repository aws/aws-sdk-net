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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// AWS Compute Optimizer is a service that analyzes the configuration and utilization
    /// metrics of your AWS compute resources, such as EC2 instances, Auto Scaling groups,
    /// AWS Lambda functions, and Amazon EBS volumes. It reports whether your resources are
    /// optimal, and generates optimization recommendations to reduce the cost and improve
    /// the performance of your workloads. Compute Optimizer also provides recent utilization
    /// metric data, as well as projected utilization metric data for the recommendations,
    /// which you can use to evaluate which recommendation provides the best price-performance
    /// trade-off. The analysis of your usage patterns can help you decide when to move or
    /// resize your running resources, and still meet your performance and capacity requirements.
    /// For more information about Compute Optimizer, including the required permissions to
    /// use the service, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/">AWS
    /// Compute Optimizer User Guide</a>.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonComputeOptimizerClient : AmazonServiceClient, IAmazonComputeOptimizer
    {
        private static IServiceMetadata serviceMetadata = new AmazonComputeOptimizerMetadata();
        
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


        #region  DescribeRecommendationExportJobs

        internal virtual DescribeRecommendationExportJobsResponse DescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Describes recommendation export jobs created in the last seven days.
        /// 
        ///  
        /// <para>
        /// Use the <code>ExportAutoScalingGroupRecommendations</code> or <code>ExportEC2InstanceRecommendations</code>
        /// actions to request an export of your recommendations. Then use the <code>DescribeRecommendationExportJobs</code>
        /// action to view your export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommendationExportJobs service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
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
        public virtual Task<DescribeRecommendationExportJobsResponse> DescribeRecommendationExportJobsAsync(DescribeRecommendationExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecommendationExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportAutoScalingGroupRecommendations

        internal virtual ExportAutoScalingGroupRecommendationsResponse ExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportAutoScalingGroupRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Auto Scaling groups.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (.json) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Auto Scaling group export job in progress per AWS Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        public virtual Task<ExportAutoScalingGroupRecommendationsResponse> ExportAutoScalingGroupRecommendationsAsync(ExportAutoScalingGroupRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportAutoScalingGroupRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportEC2InstanceRecommendations

        internal virtual ExportEC2InstanceRecommendationsResponse ExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportEC2InstanceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (.json) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EC2 instance export job in progress per AWS Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        public virtual Task<ExportEC2InstanceRecommendationsResponse> ExportEC2InstanceRecommendationsAsync(ExportEC2InstanceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportEC2InstanceRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutoScalingGroupRecommendations

        internal virtual GetAutoScalingGroupRecommendationsResponse GetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetAutoScalingGroupRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Auto Scaling group recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon EC2 Auto Scaling groups
        /// that meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
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
        public virtual Task<GetAutoScalingGroupRecommendationsResponse> GetAutoScalingGroupRecommendationsAsync(GetAutoScalingGroupRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoScalingGroupRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEBSVolumeRecommendations

        internal virtual GetEBSVolumeRecommendationsResponse GetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEBSVolumeRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon Elastic Block Store (Amazon EBS) volume recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon EBS volumes that meet a
        /// specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
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
        public virtual Task<GetEBSVolumeRecommendationsResponse> GetEBSVolumeRecommendationsAsync(GetEBSVolumeRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEBSVolumeRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEC2InstanceRecommendations

        internal virtual GetEC2InstanceRecommendationsResponse GetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEC2InstanceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon EC2 instance recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon Elastic Compute Cloud (Amazon
        /// EC2) instances that meet a specific set of requirements. For more information, see
        /// the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
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
        public virtual Task<GetEC2InstanceRecommendationsResponse> GetEC2InstanceRecommendationsAsync(GetEC2InstanceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEC2InstanceRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEC2RecommendationProjectedMetrics

        internal virtual GetEC2RecommendationProjectedMetricsResponse GetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetEC2RecommendationProjectedMetricsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEC2RecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
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
        public virtual Task<GetEC2RecommendationProjectedMetricsResponse> GetEC2RecommendationProjectedMetricsAsync(GetEC2RecommendationProjectedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEC2RecommendationProjectedMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnrollmentStatus

        internal virtual GetEnrollmentStatusResponse GetEnrollmentStatus(GetEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the enrollment (opt in) status of an account to the AWS Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is the management account of an organization, this action also confirms
        /// the enrollment status of member accounts within the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        public virtual Task<GetEnrollmentStatusResponse> GetEnrollmentStatusAsync(GetEnrollmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnrollmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLambdaFunctionRecommendations

        internal virtual GetLambdaFunctionRecommendationsResponse GetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetLambdaFunctionRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns AWS Lambda function recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for functions that meet a specific
        /// set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        public virtual Task<GetLambdaFunctionRecommendationsResponse> GetLambdaFunctionRecommendationsAsync(GetLambdaFunctionRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLambdaFunctionRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecommendationSummaries

        internal virtual GetRecommendationSummariesResponse GetRecommendationSummaries(GetRecommendationSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns the optimization findings for an account.
        /// 
        ///  
        /// <para>
        /// For example, it returns the number of Amazon EC2 instances in an account that are
        /// under-provisioned, over-provisioned, or optimized. It also returns the number of Auto
        /// Scaling groups in an account that are not optimized, or optimized.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendationSummaries service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        public virtual Task<GetRecommendationSummariesResponse> GetRecommendationSummariesAsync(GetRecommendationSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnrollmentStatus

        internal virtual UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateEnrollmentStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the enrollment (opt in) status of an account to the AWS Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account of an organization, this action can also be
        /// used to enroll member accounts within the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual Task<UpdateEnrollmentStatusResponse> UpdateEnrollmentStatusAsync(UpdateEnrollmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnrollmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}