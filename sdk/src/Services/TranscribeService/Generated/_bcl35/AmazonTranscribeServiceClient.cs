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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.TranscribeService.Model;
using Amazon.TranscribeService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Implementation for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial class AmazonTranscribeServiceClient : AmazonServiceClient, IAmazonTranscribeService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        public AmazonTranscribeServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        public AmazonTranscribeServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AmazonTranscribeServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials and an
        /// AmazonTranscribeServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, AmazonTranscribeServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranscribeServiceConfig clientConfig)
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

        
        #region  GetTranscriptionJob

        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>Status</code> field. If the status is <code>COMPLETE</code>, the job is
        /// finished and you can find the results at the location specified in the <code>TranscriptionFileUri</code>
        /// field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested job. Check the job name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
        {
            var marshaller = GetTranscriptionJobRequestMarshaller.Instance;
            var unmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptionJobRequest,GetTranscriptionJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginGetTranscriptionJob(GetTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTranscriptionJobRequestMarshaller.Instance;
            var unmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke<GetTranscriptionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  GetTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual GetTranscriptionJobResponse EndGetTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTranscriptionJobs

        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
        {
            var marshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTranscriptionJobsRequest,ListTranscriptionJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTranscriptionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual IAsyncResult BeginListTranscriptionJobs(ListTranscriptionJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTranscriptionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTranscriptionJobs.</param>
        /// 
        /// <returns>Returns a  ListTranscriptionJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual ListTranscriptionJobsResponse EndListTranscriptionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTranscriptionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTranscriptionJob

        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// The <code>JobName</code> field is a duplicate of a previously entered job name. Resend
        /// your request with a different name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
        {
            var marshaller = StartTranscriptionJobRequestMarshaller.Instance;
            var unmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartTranscriptionJobRequest,StartTranscriptionJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual IAsyncResult BeginStartTranscriptionJob(StartTranscriptionJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartTranscriptionJobRequestMarshaller.Instance;
            var unmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartTranscriptionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  StartTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual StartTranscriptionJobResponse EndStartTranscriptionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTranscriptionJobResponse>(asyncResult);
        }

        #endregion
        
    }
}