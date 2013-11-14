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
    public partial class AmazonCloudTrailClient : AmazonWebServiceClient, IAmazonCloudTrail
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
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudTrail Configuration Object</param>
        public AmazonCloudTrailClient(AmazonCloudTrailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// AmazonCloudTrailClient Configuration object. 
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region CreateTrail

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
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="S3BucketDoesNotExistException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidS3PrefixException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="TrailAlreadyExistsException"/>
        /// <exception cref="MaximumNumberOfTrailsExceededException"/>
        /// <exception cref="InvalidS3BucketNameException"/>
        /// <exception cref="TrailNotProvidedException"/>
        /// <exception cref="InsufficientSnsTopicPolicyException"/>
        /// <exception cref="InvalidSnsTopicNameException"/>
        /// <exception cref="InsufficientS3BucketPolicyException"/>
        public CreateTrailResponse CreateTrail(CreateTrailRequest createTrailRequest)
        {
            IAsyncResult asyncResult = invokeCreateTrail(createTrailRequest, null, null, true);
            return EndCreateTrail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.CreateTrail"/>
        /// </summary>
        /// 
        /// <param name="createTrailRequest">Container for the necessary parameters to execute the CreateTrail operation on AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrail
        ///         operation.</returns>
        public IAsyncResult BeginCreateTrail(CreateTrailRequest createTrailRequest, AsyncCallback callback, object state)
        {
            return invokeCreateTrail(createTrailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.CreateTrail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrail.</param>
        /// 
        /// <returns>Returns a CreateTrailResult from AmazonCloudTrail.</returns>
        public CreateTrailResponse EndCreateTrail(IAsyncResult asyncResult)
        {
            return endOperation<CreateTrailResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateTrail(CreateTrailRequest createTrailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateTrailRequestMarshaller().Marshall(createTrailRequest);
            var unmarshaller = CreateTrailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteTrail

        /// <summary>
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <param name="deleteTrailRequest">Container for the necessary parameters to execute the DeleteTrail service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="TrailNotFoundException"/>
        public DeleteTrailResponse DeleteTrail(DeleteTrailRequest deleteTrailRequest)
        {
            IAsyncResult asyncResult = invokeDeleteTrail(deleteTrailRequest, null, null, true);
            return EndDeleteTrail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.DeleteTrail"/>
        /// </summary>
        /// 
        /// <param name="deleteTrailRequest">Container for the necessary parameters to execute the DeleteTrail operation on AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrail
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTrail(DeleteTrailRequest deleteTrailRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteTrail(deleteTrailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.DeleteTrail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrail.</param>
        /// 
        /// <returns>Returns a DeleteTrailResult from AmazonCloudTrail.</returns>
        public DeleteTrailResponse EndDeleteTrail(IAsyncResult asyncResult)
        {
            return endOperation<DeleteTrailResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteTrail(DeleteTrailRequest deleteTrailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTrailRequestMarshaller().Marshall(deleteTrailRequest);
            var unmarshaller = DeleteTrailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTrails

        /// <summary>
        /// <para>Retrieves the settings for some or all trails associated with an account. Returns a list of Trail structures in JSON format.</para>
        /// </summary>
        /// 
        /// <param name="describeTrailsRequest">Container for the necessary parameters to execute the DescribeTrails service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="InternalErrorException"/>
        public DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest describeTrailsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTrails(describeTrailsRequest, null, null, true);
            return EndDescribeTrails(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrails operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.DescribeTrails"/>
        /// </summary>
        /// 
        /// <param name="describeTrailsRequest">Container for the necessary parameters to execute the DescribeTrails operation on
        ///          AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrails
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTrails(DescribeTrailsRequest describeTrailsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTrails(describeTrailsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTrails operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.DescribeTrails"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrails.</param>
        /// 
        /// <returns>Returns a DescribeTrailsResult from AmazonCloudTrail.</returns>
        public DescribeTrailsResponse EndDescribeTrails(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTrailsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTrails(DescribeTrailsRequest describeTrailsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTrailsRequestMarshaller().Marshall(describeTrailsRequest);
            var unmarshaller = DescribeTrailsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Retrieves the settings for some or all trails associated with an account. Returns a list of Trail structures in JSON format.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="InternalErrorException"/>
        public DescribeTrailsResponse DescribeTrails()
        {
            return DescribeTrails(new DescribeTrailsRequest());
        }
        

        #endregion
    
        #region GetTrailStatus

        /// <summary>
        /// <para>Returns a JSON-formatted list of information about the specified trail. Fields include information such as delivery errors, Amazon SNS
        /// and Amazon S3 errors, and times that logging started and stopped for each trail.</para>
        /// </summary>
        /// 
        /// <param name="getTrailStatusRequest">Container for the necessary parameters to execute the GetTrailStatus service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="TrailNotFoundException"/>
        public GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest getTrailStatusRequest)
        {
            IAsyncResult asyncResult = invokeGetTrailStatus(getTrailStatusRequest, null, null, true);
            return EndGetTrailStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrailStatus operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.GetTrailStatus"/>
        /// </summary>
        /// 
        /// <param name="getTrailStatusRequest">Container for the necessary parameters to execute the GetTrailStatus operation on
        ///          AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrailStatus
        ///         operation.</returns>
        public IAsyncResult BeginGetTrailStatus(GetTrailStatusRequest getTrailStatusRequest, AsyncCallback callback, object state)
        {
            return invokeGetTrailStatus(getTrailStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetTrailStatus operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.GetTrailStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrailStatus.</param>
        /// 
        /// <returns>Returns a GetTrailStatusResult from AmazonCloudTrail.</returns>
        public GetTrailStatusResponse EndGetTrailStatus(IAsyncResult asyncResult)
        {
            return endOperation<GetTrailStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetTrailStatus(GetTrailStatusRequest getTrailStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetTrailStatusRequestMarshaller().Marshall(getTrailStatusRequest);
            var unmarshaller = GetTrailStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartLogging

        /// <summary>
        /// <para>Starts the recording of AWS API calls and log file delivery for a trail.</para>
        /// </summary>
        /// 
        /// <param name="startLoggingRequest">Container for the necessary parameters to execute the StartLogging service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="S3BucketDoesNotExistException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="InsufficientSnsTopicPolicyException"/>
        /// <exception cref="InsufficientS3BucketPolicyException"/>
        /// <exception cref="TrailNotFoundException"/>
        public StartLoggingResponse StartLogging(StartLoggingRequest startLoggingRequest)
        {
            IAsyncResult asyncResult = invokeStartLogging(startLoggingRequest, null, null, true);
            return EndStartLogging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.StartLogging"/>
        /// </summary>
        /// 
        /// <param name="startLoggingRequest">Container for the necessary parameters to execute the StartLogging operation on AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLogging
        ///         operation.</returns>
        public IAsyncResult BeginStartLogging(StartLoggingRequest startLoggingRequest, AsyncCallback callback, object state)
        {
            return invokeStartLogging(startLoggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.StartLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLogging.</param>
        /// 
        /// <returns>Returns a StartLoggingResult from AmazonCloudTrail.</returns>
        public StartLoggingResponse EndStartLogging(IAsyncResult asyncResult)
        {
            return endOperation<StartLoggingResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartLogging(StartLoggingRequest startLoggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartLoggingRequestMarshaller().Marshall(startLoggingRequest);
            var unmarshaller = StartLoggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StopLogging

        /// <summary>
        /// <para>Suspends the recording of AWS API calls and log file delivery for the specified trail. Under most circumstances, there is no need to
        /// use this action. You can update a trail without stopping it first. This action is the only way to stop recording.</para>
        /// </summary>
        /// 
        /// <param name="stopLoggingRequest">Container for the necessary parameters to execute the StopLogging service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="TrailNotFoundException"/>
        public StopLoggingResponse StopLogging(StopLoggingRequest stopLoggingRequest)
        {
            IAsyncResult asyncResult = invokeStopLogging(stopLoggingRequest, null, null, true);
            return EndStopLogging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StopLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.StopLogging"/>
        /// </summary>
        /// 
        /// <param name="stopLoggingRequest">Container for the necessary parameters to execute the StopLogging operation on AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLogging
        ///         operation.</returns>
        public IAsyncResult BeginStopLogging(StopLoggingRequest stopLoggingRequest, AsyncCallback callback, object state)
        {
            return invokeStopLogging(stopLoggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StopLogging operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.StopLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLogging.</param>
        /// 
        /// <returns>Returns a StopLoggingResult from AmazonCloudTrail.</returns>
        public StopLoggingResponse EndStopLogging(IAsyncResult asyncResult)
        {
            return endOperation<StopLoggingResponse>(asyncResult);
        }
        
        IAsyncResult invokeStopLogging(StopLoggingRequest stopLoggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopLoggingRequestMarshaller().Marshall(stopLoggingRequest);
            var unmarshaller = StopLoggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateTrail

        /// <summary>
        /// <para>From the command line, use update-subscription.</para> <para>Updates the settings that specify delivery of log files. Changes to a
        /// trail do not require stopping the CloudTrail service. You use this action to designate an existing bucket for log delivery. If the existing
        /// bucket has previously been a target for CloudTrail log files, an IAM policy exists for the bucket. Use a Trail data type to pass updated
        /// bucket or topic names.</para>
        /// </summary>
        /// 
        /// <param name="updateTrailRequest">Container for the necessary parameters to execute the UpdateTrail service method on
        ///          AmazonCloudTrail.</param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by AmazonCloudTrail.</returns>
        /// 
        /// <exception cref="S3BucketDoesNotExistException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidS3PrefixException"/>
        /// <exception cref="InvalidTrailNameException"/>
        /// <exception cref="InvalidS3BucketNameException"/>
        /// <exception cref="TrailNotProvidedException"/>
        /// <exception cref="InsufficientSnsTopicPolicyException"/>
        /// <exception cref="InvalidSnsTopicNameException"/>
        /// <exception cref="InsufficientS3BucketPolicyException"/>
        /// <exception cref="TrailNotFoundException"/>
        public UpdateTrailResponse UpdateTrail(UpdateTrailRequest updateTrailRequest)
        {
            IAsyncResult asyncResult = invokeUpdateTrail(updateTrailRequest, null, null, true);
            return EndUpdateTrail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.UpdateTrail"/>
        /// </summary>
        /// 
        /// <param name="updateTrailRequest">Container for the necessary parameters to execute the UpdateTrail operation on AmazonCloudTrail.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrail
        ///         operation.</returns>
        public IAsyncResult BeginUpdateTrail(UpdateTrailRequest updateTrailRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateTrail(updateTrailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateTrail operation.
        /// <seealso cref="Amazon.CloudTrail.IAmazonCloudTrail.UpdateTrail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrail.</param>
        /// 
        /// <returns>Returns a UpdateTrailResult from AmazonCloudTrail.</returns>
        public UpdateTrailResponse EndUpdateTrail(IAsyncResult asyncResult)
        {
            return endOperation<UpdateTrailResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateTrail(UpdateTrailRequest updateTrailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateTrailRequestMarshaller().Marshall(updateTrailRequest);
            var unmarshaller = UpdateTrailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
