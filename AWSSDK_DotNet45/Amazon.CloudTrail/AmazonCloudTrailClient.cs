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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudTrail.Model;
using Amazon.CloudTrail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Implementation for accessing CloudTrail
    ///
    /// AWS Cloud Trail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records AWS API calls for your AWS account and delivers
    /// log files to an Amazon S3 bucket. The recorded information includes the identity of
    /// the user, the start time of the AWS API call, the source IP address, the request parameters,
    /// and the response elements returned by the service.
    /// </para>
    ///  
    /// <para>
    /// See the CloudTrail User Guide for information about the data that is included with
    /// each AWS API call listed in the log files.
    /// </para>
    /// </summary>
    public partial class AmazonCloudTrailClient : AmazonServiceClient, IAmazonCloudTrail
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AmazonCloudTrailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudTrailClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials and an
        /// AmazonCloudTrailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, AmazonCloudTrailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateTrail

        /// <summary>
        /// From the command line, use <code>create-subscription</code>. 
        /// 
        ///  
        /// <para>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        public CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            var marshaller = new CreateTrailRequestMarshaller();
            var unmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return Invoke<CreateTrailRequest,CreateTrailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrailRequestMarshaller();
            var unmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrailRequest,CreateTrailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrail

        /// <summary>
        /// Deletes a trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        public DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            var marshaller = new DeleteTrailRequestMarshaller();
            var unmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return Invoke<DeleteTrailRequest,DeleteTrailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrailRequestMarshaller();
            var unmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrailRequest,DeleteTrailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrails

        /// <summary>
        /// Retrieves the settings for some or all trails associated with an account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        public DescribeTrailsResponse DescribeTrails()
        {
            return DescribeTrails(new DescribeTrailsRequest());
        }

        /// <summary>
        /// Retrieves the settings for some or all trails associated with an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        public DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            var marshaller = new DescribeTrailsRequestMarshaller();
            var unmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrailsRequest,DescribeTrailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrails operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrailsRequestMarshaller();
            var unmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrailsRequest,DescribeTrailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrailStatus

        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        public GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            var marshaller = new GetTrailStatusRequestMarshaller();
            var unmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return Invoke<GetTrailStatusRequest,GetTrailStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrailStatus operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrailStatusRequestMarshaller();
            var unmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailStatusRequest,GetTrailStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartLogging

        /// <summary>
        /// Starts the recording of AWS API calls and log file delivery for a trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        public StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            var marshaller = new StartLoggingRequestMarshaller();
            var unmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return Invoke<StartLoggingRequest,StartLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartLoggingRequestMarshaller();
            var unmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StartLoggingRequest,StartLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopLogging

        /// <summary>
        /// Suspends the recording of AWS API calls and log file delivery for the specified trail.
        /// Under most circumstances, there is no need to use this action. You can update a trail
        /// without stopping it first. This action is the only way to stop recording.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        public StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            var marshaller = new StopLoggingRequestMarshaller();
            var unmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return Invoke<StopLoggingRequest,StopLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopLoggingRequestMarshaller();
            var unmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StopLoggingRequest,StopLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrail

        /// <summary>
        /// From the command line, use <code>update-subscription</code>.
        /// 
        ///  
        /// <para>
        /// Updates the settings that specify delivery of log files. Changes to a trail do not
        /// require stopping the CloudTrail service. Use this action to designate an existing
        /// bucket for log delivery. If the existing bucket has previously been a target for CloudTrail
        /// log files, an IAM policy exists for the bucket. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid.
        /// </exception>
        /// <exception cref="S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        public UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            var marshaller = new UpdateTrailRequestMarshaller();
            var unmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return Invoke<UpdateTrailRequest,UpdateTrailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrailRequestMarshaller();
            var unmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrailRequest,UpdateTrailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}