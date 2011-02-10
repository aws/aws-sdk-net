/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implemenation for accessing AmazonSimpleEmailService.
    ///  
    /// Amazon Simple Email Service <para> This is the API Reference for
    /// Amazon Simple Email Service (Amazon SES). This documentation is
    /// intended to be used in conjunction with the Amazon SES Getting Started
    /// Guide and the Amazon SES Developer Guide. </para> <para> For specific
    /// details on how to construct a service request, please consult the
    /// Amazon SES Developer Guide. </para>
    /// </summary>
    public class AmazonSimpleEmailServiceClient : AmazonWebServiceClient, AmazonSimpleEmailService
    {
    
    
        AbstractAWSSigner signer = new AWS3Signer();

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
        /// AmazonS3 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para>Returns the user's current activity limits.</para>
         /// </summary>
         /// 
         /// <param name="getSendQuotaRequest">Container for the necessary
         ///           parameters to execute the GetSendQuota service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
         /// <returns>The response from the GetSendQuota service method, as
         ///         returned by AmazonSimpleEmailService.</returns>
         /// 
        public GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest getSendQuotaRequest) 
        {           
            IRequest<GetSendQuotaRequest> request = new GetSendQuotaRequestMarshaller().Marshall(getSendQuotaRequest);
            GetSendQuotaResponse response = Invoke<GetSendQuotaRequest, GetSendQuotaResponse> (request, this.signer, GetSendQuotaResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns a list containing all of the email addresses that have
         /// been verified.</para>
         /// </summary>
         /// 
         /// <param name="listVerifiedEmailAddressesRequest">Container for the
         ///           necessary parameters to execute the ListVerifiedEmailAddresses service
         ///           method on AmazonSimpleEmailService.</param>
         /// 
         /// <returns>The response from the ListVerifiedEmailAddresses service
         ///         method, as returned by AmazonSimpleEmailService.</returns>
         /// 
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest) 
        {           
            IRequest<ListVerifiedEmailAddressesRequest> request = new ListVerifiedEmailAddressesRequestMarshaller().Marshall(listVerifiedEmailAddressesRequest);
            ListVerifiedEmailAddressesResponse response = Invoke<ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse> (request, this.signer, ListVerifiedEmailAddressesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns the user's sending statistics. The result is a list of
         /// data points, representing the last two weeks of sending
         /// activity.</para> <para>Each data point in the list contains statistics
         /// for a 15-minute interval.</para>
         /// </summary>
         /// 
         /// <param name="getSendStatisticsRequest">Container for the necessary
         ///           parameters to execute the GetSendStatistics service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
         /// <returns>The response from the GetSendStatistics service method, as
         ///         returned by AmazonSimpleEmailService.</returns>
         /// 
        public GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest) 
        {           
            IRequest<GetSendStatisticsRequest> request = new GetSendStatisticsRequestMarshaller().Marshall(getSendStatisticsRequest);
            GetSendStatisticsResponse response = Invoke<GetSendStatisticsRequest, GetSendStatisticsResponse> (request, this.signer, GetSendStatisticsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Composes an email message, based on input data, and then
         /// immediately queues the message for sending.</para>
         /// </summary>
         /// 
         /// <param name="sendEmailRequest">Container for the necessary parameters
         ///           to execute the SendEmail service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
         /// <returns>The response from the SendEmail service method, as returned
         ///         by AmazonSimpleEmailService.</returns>
         /// 
         /// <exception cref="MessageRejectedException"/>
        public SendEmailResponse SendEmail(SendEmailRequest sendEmailRequest) 
        {           
            IRequest<SendEmailRequest> request = new SendEmailRequestMarshaller().Marshall(sendEmailRequest);
            SendEmailResponse response = Invoke<SendEmailRequest, SendEmailResponse> (request, this.signer, SendEmailResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified email address from the list of verified
         /// addresses.</para>
         /// </summary>
         /// 
         /// <param name="deleteVerifiedEmailAddressRequest">Container for the
         ///           necessary parameters to execute the DeleteVerifiedEmailAddress service
         ///           method on AmazonSimpleEmailService.</param>
         /// 
        public DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest) 
        {           
            IRequest<DeleteVerifiedEmailAddressRequest> request = new DeleteVerifiedEmailAddressRequestMarshaller().Marshall(deleteVerifiedEmailAddressRequest);
            DeleteVerifiedEmailAddressResponse response = Invoke<DeleteVerifiedEmailAddressRequest, DeleteVerifiedEmailAddressResponse> (request, this.signer, DeleteVerifiedEmailAddressResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Verifies an email address. This action causes a confirmation
         /// email message to be sent to the specified address.</para>
         /// </summary>
         /// 
         /// <param name="verifyEmailAddressRequest">Container for the necessary
         ///           parameters to execute the VerifyEmailAddress service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
        public VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest) 
        {           
            IRequest<VerifyEmailAddressRequest> request = new VerifyEmailAddressRequestMarshaller().Marshall(verifyEmailAddressRequest);
            VerifyEmailAddressResponse response = Invoke<VerifyEmailAddressRequest, VerifyEmailAddressResponse> (request, this.signer, VerifyEmailAddressResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Sends an email message, with header and content specified by the
         /// client. The <c>SendRawEmail</c> action is useful for sending multipart
         /// MIME emails, with attachments or inline content.</para> <para>The raw
         /// text of the message must comply with Internet email standards;
         /// otherwise, the message cannot be sent. For more information, go to
         /// the Amazon SES Developer Guide.</para>
         /// </summary>
         /// 
         /// <param name="sendRawEmailRequest">Container for the necessary
         ///           parameters to execute the SendRawEmail service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
         /// <returns>The response from the SendRawEmail service method, as
         ///         returned by AmazonSimpleEmailService.</returns>
         /// 
         /// <exception cref="MessageRejectedException"/>
        public SendRawEmailResponse SendRawEmail(SendRawEmailRequest sendRawEmailRequest) 
        {           
            IRequest<SendRawEmailRequest> request = new SendRawEmailRequestMarshaller().Marshall(sendRawEmailRequest);
            SendRawEmailResponse response = Invoke<SendRawEmailRequest, SendRawEmailResponse> (request, this.signer, SendRawEmailResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
