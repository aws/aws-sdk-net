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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Signer.Model;
using Amazon.Signer.Model.Internal.MarshallTransformations;
using Amazon.Signer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Signer
{
    /// <summary>
    /// Implementation for accessing Signer
    ///
    /// You can use Code Signing for Amazon FreeRTOS (AWS Signer) to sign code that you created
    /// for any of the IoT devices that Amazon Web Services supports. AWS Signer is integrated
    /// with Amazon FreeRTOS, AWS Certificate Manager, and AWS CloudTrail. Amazon FreeRTOS
    /// customers can use AWS Signer to sign code images before making them available for
    /// microcontrollers. You can use ACM to import third-party certificates to be used by
    /// AWS Signer. For general information about using AWS Signer, see the <a href="http://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">Code
    /// Signing for Amazon FreeRTOS Developer Guide</a>.
    /// </summary>
    public partial class AmazonSignerClient : AmazonServiceClient, IAmazonSigner
    {
        private static IServiceMetadata serviceMetadata = new AmazonSignerMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        public AmazonSignerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig()) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        public AmazonSignerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AmazonSignerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSignerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials and an
        /// AmazonSignerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AWSCredentials credentials, AmazonSignerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSignerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSignerConfig clientConfig)
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

        
        #region  CancelSigningProfile

        /// <summary>
        /// Changes the state of an <code>ACTIVE</code> signing profile to <code>CANCELED</code>.
        /// A canceled profile is still viewable with the <code>ListSigningProfiles</code> operation,
        /// but it cannot perform new signing jobs, and is deleted two years after cancelation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile service method.</param>
        /// 
        /// <returns>The response from the CancelSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual CancelSigningProfileResponse CancelSigningProfile(CancelSigningProfileRequest request)
        {
            var marshaller = CancelSigningProfileRequestMarshaller.Instance;
            var unmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return Invoke<CancelSigningProfileRequest,CancelSigningProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginCancelSigningProfile(CancelSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CancelSigningProfileRequestMarshaller.Instance;
            var unmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CancelSigningProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSigningProfile.</param>
        /// 
        /// <returns>Returns a  CancelSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual CancelSigningProfileResponse EndCancelSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSigningJob

        /// <summary>
        /// Returns information about a specific code signing job. You specify the job by using
        /// the <code>jobId</code> value that is returned by the <a>StartSigningJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual DescribeSigningJobResponse DescribeSigningJob(DescribeSigningJobRequest request)
        {
            var marshaller = DescribeSigningJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSigningJobRequest,DescribeSigningJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSigningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeSigningJob(DescribeSigningJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeSigningJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSigningJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSigningJob.</param>
        /// 
        /// <returns>Returns a  DescribeSigningJobResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual DescribeSigningJobResponse EndDescribeSigningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSigningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSigningPlatform

        /// <summary>
        /// Returns information on a specific signing platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform service method.</param>
        /// 
        /// <returns>The response from the GetSigningPlatform service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual GetSigningPlatformResponse GetSigningPlatform(GetSigningPlatformRequest request)
        {
            var marshaller = GetSigningPlatformRequestMarshaller.Instance;
            var unmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return Invoke<GetSigningPlatformRequest,GetSigningPlatformResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSigningPlatform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual IAsyncResult BeginGetSigningPlatform(GetSigningPlatformRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSigningPlatformRequestMarshaller.Instance;
            var unmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return BeginInvoke<GetSigningPlatformRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningPlatform.</param>
        /// 
        /// <returns>Returns a  GetSigningPlatformResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual GetSigningPlatformResponse EndGetSigningPlatform(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSigningPlatformResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSigningProfile

        /// <summary>
        /// Returns information on a specific signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile service method.</param>
        /// 
        /// <returns>The response from the GetSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual GetSigningProfileResponse GetSigningProfile(GetSigningProfileRequest request)
        {
            var marshaller = GetSigningProfileRequestMarshaller.Instance;
            var unmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return Invoke<GetSigningProfileRequest,GetSigningProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginGetSigningProfile(GetSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSigningProfileRequestMarshaller.Instance;
            var unmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetSigningProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningProfile.</param>
        /// 
        /// <returns>Returns a  GetSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual GetSigningProfileResponse EndGetSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningJobs

        /// <summary>
        /// Lists all your signing jobs. You can use the <code>maxResults</code> parameter to
        /// limit the number of signing jobs that are returned in the response. If additional
        /// jobs remain to be listed, AWS Signer returns a <code>nextToken</code> value. Use this
        /// value in subsequent calls to <code>ListSigningJobs</code> to fetch the remaining values.
        /// You can continue calling <code>ListSigningJobs</code> with your <code>maxResults</code>
        /// parameter and with new values that AWS Signer returns in the <code>nextToken</code>
        /// parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs service method.</param>
        /// 
        /// <returns>The response from the ListSigningJobs service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual ListSigningJobsResponse ListSigningJobs(ListSigningJobsRequest request)
        {
            var marshaller = ListSigningJobsRequestMarshaller.Instance;
            var unmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return Invoke<ListSigningJobsRequest,ListSigningJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual IAsyncResult BeginListSigningJobs(ListSigningJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListSigningJobsRequestMarshaller.Instance;
            var unmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSigningJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningJobs.</param>
        /// 
        /// <returns>Returns a  ListSigningJobsResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual ListSigningJobsResponse EndListSigningJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningPlatforms

        /// <summary>
        /// Lists all signing platforms available in AWS Signer that match the request parameters.
        /// If additional jobs remain to be listed, AWS Signer returns a <code>nextToken</code>
        /// value. Use this value in subsequent calls to <code>ListSigningJobs</code> to fetch
        /// the remaining values. You can continue calling <code>ListSigningJobs</code> with your
        /// <code>maxResults</code> parameter and with new values that AWS Signer returns in the
        /// <code>nextToken</code> parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms service method.</param>
        /// 
        /// <returns>The response from the ListSigningPlatforms service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual ListSigningPlatformsResponse ListSigningPlatforms(ListSigningPlatformsRequest request)
        {
            var marshaller = ListSigningPlatformsRequestMarshaller.Instance;
            var unmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return Invoke<ListSigningPlatformsRequest,ListSigningPlatformsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningPlatforms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual IAsyncResult BeginListSigningPlatforms(ListSigningPlatformsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListSigningPlatformsRequestMarshaller.Instance;
            var unmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSigningPlatformsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningPlatforms.</param>
        /// 
        /// <returns>Returns a  ListSigningPlatformsResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual ListSigningPlatformsResponse EndListSigningPlatforms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningPlatformsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningProfiles

        /// <summary>
        /// Lists all available signing profiles in your AWS account. Returns only profiles with
        /// an <code>ACTIVE</code> status unless the <code>includeCanceled</code> request field
        /// is set to <code>true</code>. If additional jobs remain to be listed, AWS Signer returns
        /// a <code>nextToken</code> value. Use this value in subsequent calls to <code>ListSigningJobs</code>
        /// to fetch the remaining values. You can continue calling <code>ListSigningJobs</code>
        /// with your <code>maxResults</code> parameter and with new values that AWS Signer returns
        /// in the <code>nextToken</code> parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSigningProfiles service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual ListSigningProfilesResponse ListSigningProfiles(ListSigningProfilesRequest request)
        {
            var marshaller = ListSigningProfilesRequestMarshaller.Instance;
            var unmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSigningProfilesRequest,ListSigningProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual IAsyncResult BeginListSigningProfiles(ListSigningProfilesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListSigningProfilesRequestMarshaller.Instance;
            var unmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<ListSigningProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningProfiles.</param>
        /// 
        /// <returns>Returns a  ListSigningProfilesResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual ListSigningProfilesResponse EndListSigningProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSigningProfile

        /// <summary>
        /// Creates a signing profile. A signing profile is an AWS Signer template that can be
        /// used to carry out a pre-defined signing job. For more information, see <a href="http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html">http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile service method.</param>
        /// 
        /// <returns>The response from the PutSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual PutSigningProfileResponse PutSigningProfile(PutSigningProfileRequest request)
        {
            var marshaller = PutSigningProfileRequestMarshaller.Instance;
            var unmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return Invoke<PutSigningProfileRequest,PutSigningProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginPutSigningProfile(PutSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutSigningProfileRequestMarshaller.Instance;
            var unmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke<PutSigningProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSigningProfile.</param>
        /// 
        /// <returns>Returns a  PutSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual PutSigningProfileResponse EndPutSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSigningJob

        /// <summary>
        /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
        /// by the <code>ListSigningJobs</code> operation for two years after they are performed.
        /// Note the following requirements: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Create
        /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your S3 source bucket must be version enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must create an S3 destination bucket. AWS Signer uses your S3 destination bucket
        /// to write your signed code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify the name of the source and destination buckets when calling the <code>StartSigningJob</code>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify a request token that identifies your request to AWS Signer.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
        /// after you call <code>StartSigningJob</code>.
        /// </para>
        ///  
        /// <para>
        /// For a Java example that shows how to use this action, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/">http://docs.aws.amazon.com/acm/latest/userguide/</a>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob service method.</param>
        /// 
        /// <returns>The response from the StartSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual StartSigningJobResponse StartSigningJob(StartSigningJobRequest request)
        {
            var marshaller = StartSigningJobRequestMarshaller.Instance;
            var unmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return Invoke<StartSigningJobRequest,StartSigningJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSigningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual IAsyncResult BeginStartSigningJob(StartSigningJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartSigningJobRequestMarshaller.Instance;
            var unmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartSigningJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSigningJob.</param>
        /// 
        /// <returns>Returns a  StartSigningJobResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual StartSigningJobResponse EndStartSigningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSigningJobResponse>(asyncResult);
        }

        #endregion
        
    }
}