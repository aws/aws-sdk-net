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

using Amazon.CloudTrail.Model;
using Amazon.CloudTrail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Implementation for accessing AmazonCloudTrail.
    /// 
    /// AWS Cloud Trail <para>This is the CloudTrail API Reference. It provides descriptions of actions, data types, common parameters, and common
    /// errors for CloudTrail.</para> <para>CloudTrail is a web service that records AWS API calls for your AWS account and delivers log files to an
    /// Amazon S3 bucket. The recorded information includes the identity of the user, the start time of the AWS API call, the source IP address, the
    /// request parameters, and the response elements returned by the service.</para> <para><b>NOTE:</b> As an alternative to using the API, you can
    /// use one of the AWS SDKs, which consist of libraries and sample code for various programming languages and platforms (Java, Ruby, .NET, iOS,
    /// Android, etc.). The SDKs provide a convenient way to create programmatic access to AWSCloudTrail. For example, the SDKs take care of
    /// cryptographically signing requests, managing errors, and retrying requests automatically. For information about the AWS SDKs, including how
    /// to download and install them, see the Tools for Amazon Web Services page. </para> <para>See the CloudTrail User Guide for information about
    /// the data that is included with each AWS API call listed in the log files.</para>
    /// </summary>
	public partial class AmazonCloudTrailClient : AmazonWebServiceClient, Amazon.CloudTrail.IAmazonCloudTrail
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

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
            : this(credentials, new AmazonCloudTrailConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials and an
        /// AmazonCloudTrailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, AmazonCloudTrailConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonCloudTrailClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            var task = CreateTrailAsync(request);
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
        /// <para>From the command line, use create-subscription. </para> <para>Creates a trail that specifies the settings for delivery of log data to
        /// an Amazon S3 bucket. The request includes a Trail structure that specifies the following:</para>
        /// <ul>
        /// <li>Trail name.</li>
        /// <li>The name of an existing Amazon S3 bucket to which CloudTrail delivers your log files.</li>
        /// <li>The name of the Amazon S3 key prefix that precedes each log file.</li>
        /// <li>The name of an existing Amazon SNS topic that notifies you that a new file is available in your bucket.</li>
        /// <li>Whether the log file should include AWS API calls from global services. Currently, the only global AWS API calls included in CloudTrail
        /// log files are from IAM and AWS STS.</li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="createTrailRequest">Container for the necessary parameters to execute the CreateTrail service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.S3BucketDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidS3PrefixException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailAlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidS3BucketNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotProvidedException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidSnsTopicNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest createTrailRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrailRequestMarshaller();
            var unmarshaller = CreateTrailResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateTrailRequest, CreateTrailResponse>(createTrailRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            var task = DeleteTrailAsync(request);
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
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <param name="deleteTrailRequest">Container for the necessary parameters to execute the DeleteTrail service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest deleteTrailRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrailRequestMarshaller();
            var unmarshaller = DeleteTrailResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteTrailRequest, DeleteTrailResponse>(deleteTrailRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            var task = DescribeTrailsAsync(request);
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
        /// <para>Retrieves the settings for some or all trails associated with an account. Returns a list of Trail structures in JSON format.</para>
        /// </summary>
        /// 
        /// <param name="describeTrailsRequest">Container for the necessary parameters to execute the DescribeTrails service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest describeTrailsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrailsRequestMarshaller();
            var unmarshaller = DescribeTrailsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeTrailsRequest, DescribeTrailsResponse>(describeTrailsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            var task = GetTrailStatusAsync(request);
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
        /// <para>Returns a JSON-formatted list of information about the specified trail. Fields include information such as delivery errors, Amazon SNS
        /// and Amazon S3 errors, and times that logging started and stopped for each trail.</para>
        /// </summary>
        /// 
        /// <param name="getTrailStatusRequest">Container for the necessary parameters to execute the GetTrailStatus service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest getTrailStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrailStatusRequestMarshaller();
            var unmarshaller = GetTrailStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetTrailStatusRequest, GetTrailStatusResponse>(getTrailStatusRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            var task = StartLoggingAsync(request);
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
        /// <para>Starts the recording of AWS API calls and log file delivery for a trail.</para>
        /// </summary>
        /// 
        /// <param name="startLoggingRequest">Container for the necessary parameters to execute the StartLogging service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.S3BucketDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest startLoggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartLoggingRequestMarshaller();
            var unmarshaller = StartLoggingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StartLoggingRequest, StartLoggingResponse>(startLoggingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            var task = StopLoggingAsync(request);
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
        /// <para>Suspends the recording of AWS API calls and log file delivery for the specified trail. Under most circumstances, there is no need to
        /// use this action. You can update a trail without stopping it first. This action is the only way to stop recording.</para>
        /// </summary>
        /// 
        /// <param name="stopLoggingRequest">Container for the necessary parameters to execute the StopLogging service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest stopLoggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopLoggingRequestMarshaller();
            var unmarshaller = StopLoggingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StopLoggingRequest, StopLoggingResponse>(stopLoggingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            var task = UpdateTrailAsync(request);
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
        /// <para>From the command line, use update-subscription.</para> <para>Updates the settings that specify delivery of log files. Changes to a
        /// trail do not require stopping the CloudTrail service. You use this action to designate an existing bucket for log delivery. If the existing
        /// bucket has previously been a target for CloudTrail log files, an IAM policy exists for the bucket. Use a Trail data type to pass updated
        /// bucket or topic names.</para>
        /// </summary>
        /// 
        /// <param name="updateTrailRequest">Container for the necessary parameters to execute the UpdateTrail service method on
        /// AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudTrail.Model.S3BucketDoesNotExistException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidS3PrefixException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidTrailNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidS3BucketNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotProvidedException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InvalidSnsTopicNameException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException" />
        /// <exception cref="T:Amazon.CloudTrail.Model.TrailNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest updateTrailRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrailRequestMarshaller();
            var unmarshaller = UpdateTrailResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateTrailRequest, UpdateTrailResponse>(updateTrailRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
