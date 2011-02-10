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

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Interface for accessing AmazonSimpleEmailService.
    ///  
    ///  Amazon Simple Email Service <para> This is the API Reference for
    /// Amazon Simple Email Service (Amazon SES). This documentation is
    /// intended to be used in conjunction with the Amazon SES Getting Started
    /// Guide and the Amazon SES Developer Guide. </para> <para> For specific
    /// details on how to construct a service request, please consult the
    /// Amazon SES Developer Guide. </para>
    /// </summary>
    public interface AmazonSimpleEmailService : IDisposable
    {
        

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
        GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest getSendQuotaRequest); 

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
        ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest); 

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
        GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest); 

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
        SendEmailResponse SendEmail(SendEmailRequest sendEmailRequest); 

         /// <summary>
         /// <para>Deletes the specified email address from the list of verified
         /// addresses.</para>
         /// </summary>
         /// 
         /// <param name="deleteVerifiedEmailAddressRequest">Container for the
         ///           necessary parameters to execute the DeleteVerifiedEmailAddress service
         ///           method on AmazonSimpleEmailService.</param>
         /// 
        DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest); 

         /// <summary>
         /// <para>Verifies an email address. This action causes a confirmation
         /// email message to be sent to the specified address.</para>
         /// </summary>
         /// 
         /// <param name="verifyEmailAddressRequest">Container for the necessary
         ///           parameters to execute the VerifyEmailAddress service method on
         ///           AmazonSimpleEmailService.</param>
         /// 
        VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest); 

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
        SendRawEmailResponse SendRawEmail(SendRawEmailRequest sendRawEmailRequest); 
    }
}
    
