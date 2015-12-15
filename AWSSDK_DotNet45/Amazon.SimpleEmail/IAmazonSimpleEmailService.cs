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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleEmail.Model;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Interface for accessing SimpleEmailService
    ///
    /// Amazon Simple Email Service 
    /// <para>
    ///  This is the API Reference for Amazon Simple Email Service (Amazon SES). This documentation
    /// is intended to be used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>. 
    /// </para>
    ///  <note>For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions
    /// and Amazon SES</a> in the Amazon SES Developer Guide. </note>
    /// </summary>
    public partial interface IAmazonSimpleEmailService : IDisposable
    {

        
        #region  CloneReceiptRuleSet

        /// <summary>
        /// Creates a receipt rule set by cloning an existing one. All receipt rules and configurations
        /// are copied to the new receipt rule set and are completely independent of the source
        /// rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rule-set.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the CloneReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created due to a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created due to service limits. For a list of
        /// Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        CloneReceiptRuleSetResponse CloneReceiptRuleSet(CloneReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CloneReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CloneReceiptRuleSetResponse> CloneReceiptRuleSetAsync(CloneReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptFilter

        /// <summary>
        /// Creates a new IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about setting up IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-ip-filters.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created due to a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created due to service limits. For a list of
        /// Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        CreateReceiptFilterResponse CreateReceiptFilter(CreateReceiptFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReceiptFilterResponse> CreateReceiptFilterAsync(CreateReceiptFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptRule

        /// <summary>
        /// Creates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rules.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created due to a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided AWS Lambda function is invalid, or that Amazon SES could
        /// not execute the provided function, possibly due to permissions issues. For information
        /// about giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or AWS KMS encryption key is invalid,
        /// or that Amazon SES could not publish to the bucket, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created due to service limits. For a list of
        /// Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        CreateReceiptRuleResponse CreateReceiptRule(CreateReceiptRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReceiptRuleResponse> CreateReceiptRuleAsync(CreateReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptRuleSet

        /// <summary>
        /// Creates an empty receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rule-set.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created due to a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created due to service limits. For a list of
        /// Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        CreateReceiptRuleSetResponse CreateReceiptRuleSet(CreateReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReceiptRuleSetResponse> CreateReceiptRuleSetAsync(CreateReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentity

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
        DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentityPolicy

        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (email address
        /// or domain). This API returns successfully even if a policy with the specified name
        /// does not exist.
        /// 
        ///  <note>This API is for the identity owner only. If you have not verified the identity,
        /// this API will return an error.</note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        DeleteIdentityPolicyResponse DeleteIdentityPolicy(DeleteIdentityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIdentityPolicyResponse> DeleteIdentityPolicyAsync(DeleteIdentityPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptFilter

        /// <summary>
        /// Deletes the specified IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-ip-filters.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptFilter service method, as returned by SimpleEmailService.</returns>
        DeleteReceiptFilterResponse DeleteReceiptFilter(DeleteReceiptFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReceiptFilterResponse> DeleteReceiptFilterAsync(DeleteReceiptFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptRule

        /// <summary>
        /// Deletes the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rules.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        DeleteReceiptRuleResponse DeleteReceiptRule(DeleteReceiptRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReceiptRuleResponse> DeleteReceiptRuleAsync(DeleteReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptRuleSet

        /// <summary>
        /// Deletes the specified receipt rule set and all of the receipt rules it contains.
        /// 
        ///  <note>The currently active rule set cannot be deleted.</note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CannotDeleteException">
        /// Indicates that the delete operation could not be completed.
        /// </exception>
        DeleteReceiptRuleSetResponse DeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReceiptRuleSetResponse> DeleteReceiptRuleSetAsync(DeleteReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        /// <summary>
        /// Deletes the specified email address from the list of verified addresses.
        /// 
        ///  <important>The DeleteVerifiedEmailAddress action is deprecated as of the May 15,
        /// 2012 release of Domain Verification. The DeleteIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeActiveReceiptRuleSet

        /// <summary>
        /// Returns the metadata and receipt rules for the receipt rule set that is currently
        /// active.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rule-set.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DescribeActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        DescribeActiveReceiptRuleSetResponse DescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeActiveReceiptRuleSetResponse> DescribeActiveReceiptRuleSetAsync(DescribeActiveReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReceiptRule

        /// <summary>
        /// Returns the details of the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rules.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule service method.</param>
        /// 
        /// <returns>The response from the DescribeReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        DescribeReceiptRuleResponse DescribeReceiptRule(DescribeReceiptRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReceiptRuleResponse> DescribeReceiptRuleAsync(DescribeReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReceiptRuleSet

        /// <summary>
        /// Returns the details of the specified receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DescribeReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        DescribeReceiptRuleSetResponse DescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReceiptRuleSetResponse> DescribeReceiptRuleSetAsync(DescribeReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityDkimAttributes

        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name identities,
        /// this action also returns the DKIM tokens that are required for Easy DKIM signing,
        /// and whether Amazon SES has successfully verified that these tokens have been published.
        /// 
        ///  
        /// <para>
        /// This action takes a list of identities as input and returns the following information
        /// for each:
        /// </para>
        ///  <ul> <li>Whether Easy DKIM signing is enabled or disabled.</li> <li>A set of DKIM
        /// tokens that represent the identity. If the identity is an email address, the tokens
        /// represent the domain of that address.</li> <li>Whether Amazon SES has successfully
        /// verified the DKIM tokens published in the domain's DNS. This information is only returned
        /// for domain name identities, not for email addresses.</li> </ul> 
        /// <para>
        /// This action is throttled at one request per second and can only get DKIM attributes
        /// for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityNotificationAttributes

        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity notification attributes.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second and can only get notification attributes
        /// for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityPolicies

        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (email
        /// address or domain). The policies are returned as a map of policy names to policy contents.
        /// You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note>This API is for the identity owner only. If you have not verified the identity,
        /// this API will return an error.</note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        GetIdentityPoliciesResponse GetIdentityPolicies(GetIdentityPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdentityPoliciesResponse> GetIdentityPoliciesAsync(GetIdentityPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityVerificationAttributes

        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        /// status and (for domain identities) the verification token for each identity.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second and can only get verification attributes
        /// for up to 100 identities at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSendQuota

        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        GetSendQuotaResponse GetSendQuota();

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
        GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSendStatistics

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of sending activity. 
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
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        GetSendStatisticsResponse GetSendStatistics();

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of sending activity. 
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
        GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// a specific AWS Account, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        ListIdentitiesResponse ListIdentities();

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
        ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityPolicies

        /// <summary>
        /// Returns a list of sending authorization policies that are attached to the given identity
        /// (email address or domain). This API returns only a list. If you want the actual policy
        /// content, you can use <code>GetIdentityPolicies</code>.
        /// 
        ///  <note>This API is for the identity owner only. If you have not verified the identity,
        /// this API will return an error.</note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        ListIdentityPoliciesResponse ListIdentityPolicies(ListIdentityPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListIdentityPoliciesResponse> ListIdentityPoliciesAsync(ListIdentityPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceiptFilters

        /// <summary>
        /// Lists the IP address filters associated with your account.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-ip-filters.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters service method.</param>
        /// 
        /// <returns>The response from the ListReceiptFilters service method, as returned by SimpleEmailService.</returns>
        ListReceiptFiltersResponse ListReceiptFilters(ListReceiptFiltersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListReceiptFiltersResponse> ListReceiptFiltersAsync(ListReceiptFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceiptRuleSets

        /// <summary>
        /// Lists the receipt rule sets that exist under your AWS account. If there are additional
        /// receipt rule sets to be retrieved, you will receive a <code>NextToken</code> that
        /// you can provide to the next call to <code>ListReceiptRuleSets</code> to retrieve the
        /// additional entries.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListReceiptRuleSets service method, as returned by SimpleEmailService.</returns>
        ListReceiptRuleSetsResponse ListReceiptRuleSets(ListReceiptRuleSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListReceiptRuleSetsResponse> ListReceiptRuleSetsAsync(ListReceiptRuleSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVerifiedEmailAddresses

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        ///  <important>The ListVerifiedEmailAddresses action is deprecated as of the May 15,
        /// 2012 release of Domain Verification. The ListIdentities action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses();

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        ///  <important>The ListVerifiedEmailAddresses action is deprecated as of the May 15,
        /// 2012 release of Domain Verification. The ListIdentities action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIdentityPolicy

        /// <summary>
        /// Adds or updates a sending authorization policy for the specified identity (email address
        /// or domain).
        /// 
        ///  <note>This API is for the identity owner only. If you have not verified the identity,
        /// this API will return an error.</note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the PutIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidPolicyException">
        /// Indicates that the provided policy is invalid. Check the error stack for more information
        /// about what caused the error.
        /// </exception>
        PutIdentityPolicyResponse PutIdentityPolicy(PutIdentityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutIdentityPolicyResponse> PutIdentityPolicyAsync(PutIdentityPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReorderReceiptRuleSet

        /// <summary>
        /// Reorders the receipt rules within a receipt rule set.
        /// 
        ///  <note>All of the rules in the rule set must be represented in this request. That
        /// is, this API will return an error if the reorder request doesn’t explicitly position
        /// all of the rules.</note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the ReorderReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        ReorderReceiptRuleSetResponse ReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReorderReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReorderReceiptRuleSetResponse> ReorderReceiptRuleSetAsync(ReorderReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendBounce

        /// <summary>
        /// Generates and sends a bounce message to the sender of an email you received through
        /// Amazon SES. You can only use this API on an email up to 24 hours after you receive
        /// it.
        /// 
        ///  <note>You cannot use this API to send generic bounces for mail that was not received
        /// by Amazon SES.</note> 
        /// <para>
        /// For information about receiving email through Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBounce service method.</param>
        /// 
        /// <returns>The response from the SendBounce service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        SendBounceResponse SendBounce(SendBounceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendBounce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBounce operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendBounceResponse> SendBounceAsync(SendBounceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendEmail

        /// <summary>
        /// Composes an email message based on input data, and then immediately queues the message
        /// for sending. 
        /// 
        ///  
        /// <para>
        /// There are several important points to know about <code>SendEmail</code>:
        /// </para>
        ///  <ul> <li>You can only send email from verified email addresses and domains; otherwise,
        /// you will get an "Email address not verified" error. If your account is still in the
        /// Amazon SES sandbox, you must also verify every recipient email address except for
        /// the recipients provided by the Amazon SES mailbox simulator. For more information,
        /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES Developer Guide</a>.</li> <li>The total size of the message cannot exceed 10 MB.
        /// This includes any attachments that are part of the message.</li> <li>Amazon SES has
        /// a limit on the total number of recipients per message. The combined number of To:,
        /// CC: and BCC: email addresses cannot exceed 50. If you need to send an email message
        /// to a larger audience, you can divide your recipient list into groups of 50 or fewer,
        /// and then call Amazon SES repeatedly to send the message to each group.</li> <li>For
        /// every message that you send, the total number of recipients (To:, CC: and BCC:) is
        /// counted against your sending quota - the maximum number of emails you can send in
        /// a 24-hour period. For information about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES Developer Guide</a>.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        SendEmailResponse SendEmail(SendEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendRawEmail

        /// <summary>
        /// Sends an email message, with header and content specified by the client. The <code>SendRawEmail</code>
        /// action is useful for sending multipart MIME emails. The raw text of the message must
        /// comply with Internet email standards; otherwise, the message cannot be sent. 
        /// 
        ///  
        /// <para>
        /// There are several important points to know about <code>SendRawEmail</code>:
        /// </para>
        ///  <ul> <li>You can only send email from verified email addresses and domains; otherwise,
        /// you will get an "Email address not verified" error. If your account is still in the
        /// Amazon SES sandbox, you must also verify every recipient email address except for
        /// the recipients provided by the Amazon SES mailbox simulator. For more information,
        /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES Developer Guide</a>.</li> <li>The total size of the message cannot exceed 10 MB.
        /// This includes any attachments that are part of the message.</li> <li>Amazon SES has
        /// a limit on the total number of recipients per message. The combined number of To:,
        /// CC: and BCC: email addresses cannot exceed 50. If you need to send an email message
        /// to a larger audience, you can divide your recipient list into groups of 50 or fewer,
        /// and then call Amazon SES repeatedly to send the message to each group.</li> <li>The
        /// To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
        /// each recipient in a group list counts towards the 50-recipient limit.</li> <li>For
        /// every message that you send, the total number of recipients (To:, CC: and BCC:) is
        /// counted against your sending quota - the maximum number of emails you can send in
        /// a 24-hour period. For information about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES Developer Guide</a>.</li> <li>If you are using sending authorization to send on
        /// behalf of another user, <code>SendRawEmail</code> enables you to specify the cross-account
        /// identity for the email's "Source," "From," and "Return-Path" parameters in one of
        /// two ways: you can pass optional parameters <code>SourceArn</code>, <code>FromArn</code>,
        /// and/or <code>ReturnPathArn</code> to the API, or you can include the following X-headers
        /// in the header of your raw email: <ul> <li><code>X-SES-SOURCE-ARN</code></li> <li><code>X-SES-FROM-ARN</code></li>
        /// <li><code>X-SES-RETURN-PATH-ARN</code></li> </ul> <important>Do not include these
        /// X-headers in the DKIM signature, because they are removed by Amazon SES before sending
        /// the email.</important> For the most common sending authorization use case, we recommend
        /// that you specify the <code>SourceIdentityArn</code> and do not specify either the
        /// <code>FromIdentityArn</code> or <code>ReturnPathIdentityArn</code>. (The same note
        /// applies to the corresponding X-headers.) If you only specify the <code>SourceIdentityArn</code>,
        /// Amazon SES will simply set the "From" address and the "Return Path" address to the
        /// identity specified in <code>SourceIdentityArn</code>. For more information about sending
        /// authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        SendRawEmailResponse SendRawEmail(SendRawEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetActiveReceiptRuleSet

        /// <summary>
        /// Sets the specified receipt rule set as the active receipt rule set.
        /// 
        ///  <note>To disable your email-receiving through Amazon SES completely, you can call
        /// this API with RuleSetName set to null.</note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the SetActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        SetActiveReceiptRuleSetResponse SetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetActiveReceiptRuleSetResponse> SetActiveReceiptRuleSetAsync(SetActiveReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityDkimEnabled

        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity:
        /// 
        ///  <ul> <li>If Easy DKIM signing is enabled for a domain name identity (e.g., <code>example.com</code>),
        /// then Amazon SES will DKIM-sign all email sent by addresses under that domain name
        /// (e.g., <code>user@example.com</code>).</li> <li>If Easy DKIM signing is enabled for
        /// an email address, then Amazon SES will DKIM-sign all email sent by that email address.</li>
        /// </ul> 
        /// <para>
        /// For email addresses (e.g., <code>user@example.com</code>), you can only enable Easy
        /// DKIM signing if the corresponding domain (e.g., <code>example.com</code>) has been
        /// set up for Easy DKIM using the AWS Console or the <code>VerifyDomainDkim</code> action.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about Easy DKIM signing, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled

        /// <summary>
        /// Given an identity (email address or domain), enables or disables whether Amazon SES
        /// forwards bounce and complaint notifications as email. Feedback forwarding can only
        /// be disabled when Amazon Simple Notification Service (Amazon SNS) topics are specified
        /// for both bounces and complaints.
        /// 
        ///  <note>Feedback forwarding does not apply to delivery notifications. Delivery notifications
        /// are only available through Amazon SNS.</note> 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityNotificationTopic

        /// <summary>
        /// Given an identity (email address or domain), sets the Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon SES will publish bounce, complaint, and/or delivery
        /// notifications for emails sent with that identity as the <code>Source</code>.
        /// 
        ///  <note>Unless feedback forwarding is enabled, you must specify Amazon SNS topics for
        /// bounce and complaint notifications. For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
        /// </note> 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about feedback notification, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetReceiptRulePosition

        /// <summary>
        /// Sets the position of the specified receipt rule in the receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rules.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition service method.</param>
        /// 
        /// <returns>The response from the SetReceiptRulePosition service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        SetReceiptRulePositionResponse SetReceiptRulePosition(SetReceiptRulePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetReceiptRulePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetReceiptRulePositionResponse> SetReceiptRulePositionAsync(SetReceiptRulePositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReceiptRule

        /// <summary>
        /// Updates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rules.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule service method.</param>
        /// 
        /// <returns>The response from the UpdateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided AWS Lambda function is invalid, or that Amazon SES could
        /// not execute the provided function, possibly due to permissions issues. For information
        /// about giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or AWS KMS encryption key is invalid,
        /// or that Amazon SES could not publish to the bucket, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created due to service limits. For a list of
        /// Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        UpdateReceiptRuleResponse UpdateReceiptRule(UpdateReceiptRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateReceiptRuleResponse> UpdateReceiptRuleAsync(UpdateReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyDomainDkim

        /// <summary>
        /// Returns a set of DKIM tokens for a domain. DKIM <i>tokens</i> are character strings
        /// that represent your domain's identity. Using these tokens, you will need to create
        /// DNS CNAME records that point to DKIM public keys hosted by Amazon SES. Amazon Web
        /// Services will eventually detect that you have updated your DNS records; this detection
        /// process may take up to 72 hours. Upon successful detection, Amazon SES will be able
        /// to DKIM-sign email originating from that domain.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///  
        /// <para>
        /// To enable or disable Easy DKIM signing for a domain, use the <code>SetIdentityDkimEnabled</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyDomainIdentity

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
        VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyEmailAddress

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message to be sent
        /// to the specified address.
        /// 
        ///  <important>The VerifyEmailAddress action is deprecated as of the May 15, 2012 release
        /// of Domain Verification. The VerifyEmailIdentity action is now preferred.</important>
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyEmailIdentity

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message to be sent
        /// to the specified address.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}