/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleEmailService.
    ///  
    /// Amazon Simple Email Service <para> This is the API Reference for Amazon Simple Email Service (Amazon SES). This documentation is intended to
    /// be used in conjunction with the Amazon SES Getting Started Guide and the Amazon SES Developer Guide. </para> <para> For specific details on
    /// how to construct a service request, please consult the Amazon SES Developer Guide. </para> <para><b>NOTE:</b>The endpoint for Amazon SES is
    /// located at: https://email.us-east-1.amazonaws.com </para>
    /// </summary>
    public class AmazonSimpleEmailServiceClient : AmazonWebServiceClient, AmazonSimpleEmailService
    {
    
        AbstractAWSSigner signer = new AWS3Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials defined in the App.config.
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
        public AmazonSimpleEmailServiceClient()
            : base(new EnvironmentAWSCredentials(), new AmazonSimpleEmailServiceConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials defined in the App.config.
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
        /// <param name="config">The AmazonSimpleEmailService Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region GetSendQuota

        /// <summary>
        /// <para>Returns the user's current sending limits.</para>
        /// </summary>
        /// 
        /// <param name="getSendQuotaRequest">Container for the necessary parameters to execute the GetSendQuota service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest getSendQuotaRequest)
        {
            IAsyncResult asyncResult = invokeGetSendQuota(getSendQuotaRequest, null, null, true);
            return EndGetSendQuota(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendQuota"/>
        /// </summary>
        /// 
        /// <param name="getSendQuotaRequest">Container for the necessary parameters to execute the GetSendQuota operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendQuota
        ///         operation.</returns>
        public IAsyncResult BeginGetSendQuota(GetSendQuotaRequest getSendQuotaRequest, AsyncCallback callback, object state)
        {
            return invokeGetSendQuota(getSendQuotaRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendQuota"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendQuota.</param>
        /// 
        /// <returns>Returns a GetSendQuotaResult from AmazonSimpleEmailService.</returns>
        public GetSendQuotaResponse EndGetSendQuota(IAsyncResult asyncResult)
        {
            return endOperation<GetSendQuotaResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSendQuota(GetSendQuotaRequest getSendQuotaRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSendQuotaRequestMarshaller().Marshall(getSendQuotaRequest);
            var unmarshaller = GetSendQuotaResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the user's current sending limits.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }
        

        #endregion
    
        #region ListVerifiedEmailAddresses

        /// <summary>
        /// <para>Returns a list containing all of the email addresses that have been verified.</para>
        /// </summary>
        /// 
        /// <param name="listVerifiedEmailAddressesRequest">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest)
        {
            IAsyncResult asyncResult = invokeListVerifiedEmailAddresses(listVerifiedEmailAddressesRequest, null, null, true);
            return EndListVerifiedEmailAddresses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListVerifiedEmailAddresses"/>
        /// </summary>
        /// 
        /// <param name="listVerifiedEmailAddressesRequest">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation
        ///          on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVerifiedEmailAddresses operation.</returns>
        public IAsyncResult BeginListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, AsyncCallback callback, object state)
        {
            return invokeListVerifiedEmailAddresses(listVerifiedEmailAddressesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListVerifiedEmailAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVerifiedEmailAddresses.</param>
        /// 
        /// <returns>Returns a ListVerifiedEmailAddressesResult from AmazonSimpleEmailService.</returns>
        public ListVerifiedEmailAddressesResponse EndListVerifiedEmailAddresses(IAsyncResult asyncResult)
        {
            return endOperation<ListVerifiedEmailAddressesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVerifiedEmailAddressesRequestMarshaller().Marshall(listVerifiedEmailAddressesRequest);
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list containing all of the email addresses that have been verified.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }
        

        #endregion
    
        #region GetSendStatistics

        /// <summary>
        /// <para>Returns the user's sending statistics. The result is a list of data points, representing the last two weeks of sending
        /// activity.</para> <para>Each data point in the list contains statistics for a 15-minute interval.</para>
        /// </summary>
        /// 
        /// <param name="getSendStatisticsRequest">Container for the necessary parameters to execute the GetSendStatistics service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest)
        {
            IAsyncResult asyncResult = invokeGetSendStatistics(getSendStatisticsRequest, null, null, true);
            return EndGetSendStatistics(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendStatistics"/>
        /// </summary>
        /// 
        /// <param name="getSendStatisticsRequest">Container for the necessary parameters to execute the GetSendStatistics operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendStatistics
        ///         operation.</returns>
        public IAsyncResult BeginGetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest, AsyncCallback callback, object state)
        {
            return invokeGetSendStatistics(getSendStatisticsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendStatistics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendStatistics.</param>
        /// 
        /// <returns>Returns a GetSendStatisticsResult from AmazonSimpleEmailService.</returns>
        public GetSendStatisticsResponse EndGetSendStatistics(IAsyncResult asyncResult)
        {
            return endOperation<GetSendStatisticsResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSendStatisticsRequestMarshaller().Marshall(getSendStatisticsRequest);
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the user's sending statistics. The result is a list of data points, representing the last two weeks of sending
        /// activity.</para> <para>Each data point in the list contains statistics for a 15-minute interval.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }
        

        #endregion
    
        #region SendEmail

        /// <summary>
        /// <para>Composes an email message based on input data, and then immediately queues the message for sending.</para> <para><b>IMPORTANT:</b>If
        /// you have not yet requested production access to Amazon SES, then you will only be able to send email to and from verified email addresses.
        /// For more information, go to the Amazon SES Developer Guide.</para> <para>The total size of the message cannot exceed 10 MB.</para>
        /// <para>Amazon SES has a limit on the total number of recipients per message: The combined number of To:, CC: and BCC: email addresses cannot
        /// exceed 50. If you need to send an email message to a larger audience, you can divide your recipient list into groups of 50 or fewer, and
        /// then call Amazon SES repeatedly to send the message to each group.</para> <para>For every message that you send, the total number of
        /// recipients (To:, CC: and BCC:) is counted against your <i>sending quota</i> - the maximum number of emails you can send in a 24-hour period.
        /// For information about your sending quota, go to the "Managing Your Sending Activity" section of the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="sendEmailRequest">Container for the necessary parameters to execute the SendEmail service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="MessageRejectedException"/>
        public SendEmailResponse SendEmail(SendEmailRequest sendEmailRequest)
        {
            IAsyncResult asyncResult = invokeSendEmail(sendEmailRequest, null, null, true);
            return EndSendEmail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendEmail"/>
        /// </summary>
        /// 
        /// <param name="sendEmailRequest">Container for the necessary parameters to execute the SendEmail operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendEmail(SendEmailRequest sendEmailRequest, AsyncCallback callback, object state)
        {
            return invokeSendEmail(sendEmailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendEmail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a SendEmailResult from AmazonSimpleEmailService.</returns>
        public SendEmailResponse EndSendEmail(IAsyncResult asyncResult)
        {
            return endOperation<SendEmailResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendEmail(SendEmailRequest sendEmailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendEmailRequestMarshaller().Marshall(sendEmailRequest);
            var unmarshaller = SendEmailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVerifiedEmailAddress

        /// <summary>
        /// <para>Deletes the specified email address from the list of verified addresses.</para>
        /// </summary>
        /// 
        /// <param name="deleteVerifiedEmailAddressRequest">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        public DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVerifiedEmailAddress(deleteVerifiedEmailAddressRequest, null, null, true);
            return EndDeleteVerifiedEmailAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteVerifiedEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="deleteVerifiedEmailAddressRequest">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation
        ///          on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVerifiedEmailAddress(deleteVerifiedEmailAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteVerifiedEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVerifiedEmailAddress.</param>
        public DeleteVerifiedEmailAddressResponse EndDeleteVerifiedEmailAddress(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVerifiedEmailAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVerifiedEmailAddressRequestMarshaller().Marshall(deleteVerifiedEmailAddressRequest);
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region VerifyEmailAddress

        /// <summary>
        /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para>
        /// </summary>
        /// 
        /// <param name="verifyEmailAddressRequest">Container for the necessary parameters to execute the VerifyEmailAddress service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        public VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest)
        {
            IAsyncResult asyncResult = invokeVerifyEmailAddress(verifyEmailAddressRequest, null, null, true);
            return EndVerifyEmailAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="verifyEmailAddressRequest">Container for the necessary parameters to execute the VerifyEmailAddress operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginVerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest, AsyncCallback callback, object state)
        {
            return invokeVerifyEmailAddress(verifyEmailAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailAddress.</param>
        public VerifyEmailAddressResponse EndVerifyEmailAddress(IAsyncResult asyncResult)
        {
            return endOperation<VerifyEmailAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeVerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new VerifyEmailAddressRequestMarshaller().Marshall(verifyEmailAddressRequest);
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SendRawEmail

        /// <summary>
        /// <para>Sends an email message, with header and content specified by the client. The <c>SendRawEmail</c> action is useful for sending
        /// multipart MIME emails. The raw text of the message must comply with Internet email standards; otherwise, the message cannot be sent.</para>
        /// <para><b>IMPORTANT:</b>If you have not yet requested production access to Amazon SES, then you will only be able to send email to and from
        /// verified email addresses. For more information, go to the Amazon SES Developer Guide.</para> <para>The total size of the message cannot
        /// exceed 10 MB. This includes any attachments that are part of the message.</para> <para>Amazon SES has a limit on the total number of
        /// recipients per message: The combined number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an email message to a
        /// larger audience, you can divide your recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to send the message to
        /// each group.</para> <para>For every message that you send, the total number of recipients (To:, CC: and BCC:) is counted against your
        /// <i>sending quota</i> - the maximum number of emails you can send in a 24-hour period. For information about your sending quota, go to the
        /// "Managing Your Sending Activity" section of the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="sendRawEmailRequest">Container for the necessary parameters to execute the SendRawEmail service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="MessageRejectedException"/>
        public SendRawEmailResponse SendRawEmail(SendRawEmailRequest sendRawEmailRequest)
        {
            IAsyncResult asyncResult = invokeSendRawEmail(sendRawEmailRequest, null, null, true);
            return EndSendRawEmail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendRawEmail"/>
        /// </summary>
        /// 
        /// <param name="sendRawEmailRequest">Container for the necessary parameters to execute the SendRawEmail operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendRawEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendRawEmail(SendRawEmailRequest sendRawEmailRequest, AsyncCallback callback, object state)
        {
            return invokeSendRawEmail(sendRawEmailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendRawEmail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendRawEmail.</param>
        /// 
        /// <returns>Returns a SendRawEmailResult from AmazonSimpleEmailService.</returns>
        public SendRawEmailResponse EndSendRawEmail(IAsyncResult asyncResult)
        {
            return endOperation<SendRawEmailResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendRawEmail(SendRawEmailRequest sendRawEmailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendRawEmailRequestMarshaller().Marshall(sendRawEmailRequest);
            var unmarshaller = SendRawEmailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
