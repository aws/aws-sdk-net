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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing SimpleEmailService
    /// 
    /// Amazon Simple Email Service
    /// <para>
    /// This is the API Reference for Amazon Simple Email Service (Amazon SES).
    /// This documentation is intended to be            used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// <note>For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions and
    /// Amazon SES</a>             in the Amazon SES Developer Guide.         </note>
    /// </summary>
	public partial class AmazonSimpleEmailServiceClient : AmazonWebServiceClient, Amazon.SimpleEmail.IAmazonSimpleEmailService
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleEmailServiceConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request)
        {
            var task = DeleteIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Deletes the specified identity (email address or domain) from the list of verified
        /// identities.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest deleteIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIdentityRequestMarshaller();
            var unmarshaller = DeleteIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteIdentityRequest, DeleteIdentityResponse>(deleteIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request)
        {
            var task = DeleteVerifiedEmailAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Deletes the specified email address from the list of verified addresses.
        /// 
        /// <important>The DeleteVerifiedEmailAddress action is deprecated as of the May
        /// 15, 2012 release        of Domain Verification. The DeleteIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVerifiedEmailAddressRequestMarshaller();
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVerifiedEmailAddressRequest, DeleteVerifiedEmailAddressResponse>(deleteVerifiedEmailAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request)
        {
            var task = GetIdentityDkimAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name
        /// identities, this action also returns the DKIM tokens that are required for
        /// Easy DKIM            signing, and whether Amazon SES has successfully verified that
        /// these tokens have been            published.
        /// 
        /// 
        /// <para>
        /// This action takes a list of identities as input and returns the following
        /// information for each:
        /// </para>
        /// <ul>            <li>Whether Easy DKIM signing is enabled or disabled.</li>
        /// <li>A set of DKIM tokens that represent the identity. If the identity is
        /// an email                address, the tokens represent the domain of that address.</li>
        /// <li>Whether Amazon SES has successfully verified the DKIM tokens published
        /// in the                domain's DNS.  This information is only returned for domain
        /// name identities, not for                email addresses.</li>        </ul>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdentityDkimAttributesRequestMarshaller();
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetIdentityDkimAttributesRequest, GetIdentityDkimAttributesResponse>(getIdentityDkimAttributesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request)
        {
            var task = GetIdentityNotificationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity         notification attributes.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about using notifications with Amazon SES, see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdentityNotificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetIdentityNotificationAttributesRequest, GetIdentityNotificationAttributesResponse>(getIdentityNotificationAttributesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request)
        {
            var task = GetIdentityVerificationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        /// status and (for domain identities) the verification token for each identity.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIdentityVerificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetIdentityVerificationAttributesRequest, GetIdentityVerificationAttributesResponse>(getIdentityVerificationAttributesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request)
        {
            var task = GetSendQuotaAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota service method.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest getSendQuotaRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSendQuotaRequestMarshaller();
            var unmarshaller = GetSendQuotaResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetSendQuotaRequest, GetSendQuotaResponse>(getSendQuotaRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request)
        {
            var task = GetSendStatisticsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of            sending activity.
        /// 
        /// 
        /// <para>
        /// Each data point in the list contains statistics for a 15-minute interval.
        /// </para>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest getSendStatisticsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSendStatisticsRequestMarshaller();
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetSendStatisticsRequest, GetSendStatisticsResponse>(getSendStatisticsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var task = ListIdentitiesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// a specific AWS Account, regardless of verification status.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest listIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListIdentitiesRequest, ListIdentitiesResponse>(listIdentitiesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request)
        {
            var task = ListVerifiedEmailAddressesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        /// <important>The ListVerifiedEmailAddresses action is deprecated as of the May
        /// 15, 2012 release of         Domain Verification. The ListIdentities action is now
        /// preferred.</important>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVerifiedEmailAddressesRequestMarshaller();
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse>(listVerifiedEmailAddressesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var task = SendEmailAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Composes an email message based on input data, and then immediately queues the message
        /// for sending.
        /// 
        /// <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>
        /// <para>
        /// The total size of the message cannot exceed 10 MB.
        /// </para>
        /// 
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.
        /// </para>
        /// 
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SendEmailResponse> SendEmailAsync(SendEmailRequest sendEmailRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendEmailRequestMarshaller();
            var unmarshaller = SendEmailResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SendEmailRequest, SendEmailResponse>(sendEmailRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SendRawEmailResponse SendRawEmail(SendRawEmailRequest request)
        {
            var task = SendRawEmailAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Sends an email message, with header and content specified by the client. The
        /// <code>SendRawEmail</code>            action is useful for sending multipart
        /// MIME emails. The raw text of the message must comply with Internet            email
        /// standards; otherwise, the message cannot be sent.
        /// 
        /// <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>
        /// <para>
        /// The total size of the message cannot exceed 10 MB. This includes any attachments that
        /// are part of the message.
        /// </para>
        /// 
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.
        /// </para>
        /// 
        /// <para>
        /// The To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
        /// each recipient in a group list         counts towards the 50-recipient limit.
        /// 
        /// </para>
        /// 
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest sendRawEmailRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendRawEmailRequestMarshaller();
            var unmarshaller = SendRawEmailResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SendRawEmailRequest, SendRawEmailResponse>(sendRawEmailRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request)
        {
            var task = SetIdentityDkimEnabledAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity:
        /// 
        /// <ul>                <li>If Easy DKIM            signing is enabled for
        /// a domain name identity (e.g., <code>example.com</code>), then Amazon SES will DKIM-sign
        /// all email sent by addresses under that domain name (e.g.,
        /// <code>user@example.com</code>).</li>                <li>If Easy DKIM signing
        /// is enabled for an email address, then Amazon SES will DKIM-sign            all email
        /// sent by that email address.</li>            </ul>
        /// <para>
        /// For email addresses (e.g., <code>user@example.com</code>), you can only enable Easy
        /// DKIM signing  if the        corresponding domain (e.g., <code>example.com</code>)
        /// has been set up for Easy DKIM using the AWS Console or             the <code>VerifyDomainDkim</code>
        /// action.
        /// </para>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about Easy DKIM signing, go to the             <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetIdentityDkimEnabledRequestMarshaller();
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetIdentityDkimEnabledRequest, SetIdentityDkimEnabledResponse>(setIdentityDkimEnabledRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request)
        {
            var task = SetIdentityFeedbackForwardingEnabledAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Given an identity (email address or domain), enables or disables whether Amazon SES
        /// forwards            bounce and complaint notifications as email. Feedback forwarding
        /// can only be disabled when            Amazon Simple Notification Service (Amazon SNS)
        /// topics are specified for both bounces and complaints.
        /// 
        /// <note>Feedback forwarding does not apply to delivery notifications.
        /// Delivery notifications are only available through Amazon SNS.</note>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about using notifications with Amazon SES,            see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetIdentityFeedbackForwardingEnabledRequestMarshaller();
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetIdentityFeedbackForwardingEnabledRequest, SetIdentityFeedbackForwardingEnabledResponse>(setIdentityFeedbackForwardingEnabledRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request)
        {
            var task = SetIdentityNotificationTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Given an identity (email address or domain), sets the Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon SES will publish        bounce, complaint, and/or
        /// delivery notifications for emails sent with that identity as the <code>Source</code>.
        /// 
        /// <note>Unless feedback forwarding is enabled, you must specify Amazon SNS topics
        /// for bounce and complaint notifications.            For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
        /// </note>
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// For more information about feedback notification, see the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetIdentityNotificationTopicRequestMarshaller();
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetIdentityNotificationTopicRequest, SetIdentityNotificationTopicResponse>(setIdentityNotificationTopicRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request)
        {
            var task = VerifyDomainDkimAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Returns a set of DKIM tokens for a domain. DKIM <i>tokens</i> are character strings
        /// that            represent your domain's identity. Using these tokens, you will need
        /// to create DNS CNAME            records that point to DKIM public keys hosted by Amazon
        /// SES. Amazon Web Services will            eventually detect that you have updated your
        /// DNS records; this detection process may            take up to 72 hours. Upon successful
        /// detection, Amazon SES will be able to DKIM-sign            email originating from
        /// that domain.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// 
        /// <para>
        /// To enable or disable Easy DKIM signing for            a domain, use the <code>SetIdentityDkimEnabled</code>
        /// action.
        /// </para>
        /// 
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest verifyDomainDkimRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new VerifyDomainDkimRequestMarshaller();
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, VerifyDomainDkimRequest, VerifyDomainDkimResponse>(verifyDomainDkimRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request)
        {
            var task = VerifyDomainIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Verifies a domain.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest verifyDomainIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new VerifyDomainIdentityRequestMarshaller();
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, VerifyDomainIdentityRequest, VerifyDomainIdentityResponse>(verifyDomainIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request)
        {
            var task = VerifyEmailAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message to be
        /// sent to the specified address.
        /// 
        /// <important>The VerifyEmailAddress action is deprecated as of the May 15, 2012
        /// release        of Domain Verification. The VerifyEmailIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest verifyEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new VerifyEmailAddressRequestMarshaller();
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, VerifyEmailAddressRequest, VerifyEmailAddressResponse>(verifyEmailAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request)
        {
            var task = VerifyEmailIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message
        /// to be sent to the specified address.
        /// 
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest verifyEmailIdentityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new VerifyEmailIdentityRequestMarshaller();
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, VerifyEmailIdentityRequest, VerifyEmailIdentityResponse>(verifyEmailIdentityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
