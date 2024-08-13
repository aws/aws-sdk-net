/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.SimpleEmail.Model;

#pragma warning disable CS1570
namespace Amazon.SimpleEmail
{
    /// <summary>
    /// <para>Interface for accessing SimpleEmailService</para>
    ///
    /// Amazon Simple Email Service 
    /// <para>
    ///  This document contains reference information for the <a href="https://aws.amazon.com/ses/">Amazon
    /// Simple Email Service</a> (Amazon SES) API, version 2010-12-01. This document is best
    /// used in conjunction with the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  For a list of Amazon SES endpoints to use in service requests, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions
    /// and Amazon SES</a> in the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This documentation contains reference information related to the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_Operations.html">Amazon
    /// SES API Actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_Types.html">Amazon
    /// SES API Data Types</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ses/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ses/latest/APIReference/CommonErrors.html">Common
    /// Errors</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSimpleEmailService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleEmailPaginatorFactory Paginators { get; }

        
        #region  CloneReceiptRuleSet


        /// <summary>
        /// Creates a receipt rule set by cloning an existing one. All receipt rules and configurations
        /// are copied to the new receipt rule set and are completely independent of the source
        /// rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the CloneReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        CloneReceiptRuleSetResponse CloneReceiptRuleSet(CloneReceiptRuleSetRequest request);



        /// <summary>
        /// Creates a receipt rule set by cloning an existing one. All receipt rules and configurations
        /// are copied to the new receipt rule set and are completely independent of the source
        /// rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloneReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        Task<CloneReceiptRuleSetResponse> CloneReceiptRuleSetAsync(CloneReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfigurationSet


        /// <summary>
        /// Creates a configuration set.
        /// 
        ///  
        /// <para>
        /// Configuration sets enable you to publish email sending events. For information about
        /// using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetAlreadyExistsException">
        /// Indicates that the configuration set could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidConfigurationSetException">
        /// Indicates that the configuration set is invalid. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);



        /// <summary>
        /// Creates a configuration set.
        /// 
        ///  
        /// <para>
        /// Configuration sets enable you to publish email sending events. For information about
        /// using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetAlreadyExistsException">
        /// Indicates that the configuration set could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidConfigurationSetException">
        /// Indicates that the configuration set is invalid. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Creates a configuration set event destination.
        /// 
        ///  <note> 
        /// <para>
        /// When you create or update an event destination, you must provide one, and only one,
        /// destination. The destination can be CloudWatch, Amazon Kinesis Firehose, or Amazon
        /// Simple Notification Service (Amazon SNS).
        /// </para>
        ///  </note> 
        /// <para>
        /// An event destination is the Amazon Web Services service to which Amazon SES publishes
        /// the email sending events associated with a configuration set. For information about
        /// using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationAlreadyExistsException">
        /// Indicates that the event destination could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidCloudWatchDestinationException">
        /// Indicates that the Amazon CloudWatch destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidFirehoseDestinationException">
        /// Indicates that the Amazon Kinesis Firehose destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSNSDestinationException">
        /// Indicates that the Amazon Simple Notification Service (Amazon SNS) destination is
        /// invalid. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request);



        /// <summary>
        /// Creates a configuration set event destination.
        /// 
        ///  <note> 
        /// <para>
        /// When you create or update an event destination, you must provide one, and only one,
        /// destination. The destination can be CloudWatch, Amazon Kinesis Firehose, or Amazon
        /// Simple Notification Service (Amazon SNS).
        /// </para>
        ///  </note> 
        /// <para>
        /// An event destination is the Amazon Web Services service to which Amazon SES publishes
        /// the email sending events associated with a configuration set. For information about
        /// using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationAlreadyExistsException">
        /// Indicates that the event destination could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidCloudWatchDestinationException">
        /// Indicates that the Amazon CloudWatch destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidFirehoseDestinationException">
        /// Indicates that the Amazon Kinesis Firehose destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSNSDestinationException">
        /// Indicates that the Amazon Simple Notification Service (Amazon SNS) destination is
        /// invalid. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfigurationSetTrackingOptions


        /// <summary>
        /// Creates an association between a configuration set and a custom domain for open and
        /// click event tracking. 
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTrackingOptionsException">
        /// Indicates that the custom domain to be used for open and click tracking redirects
        /// is invalid. This error appears most often in the following situations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// When the tracking domain you specified is not verified in Amazon SES.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the tracking domain you specified is not a valid domain or subdomain.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsAlreadyExistsException">
        /// Indicates that the configuration set you specified already contains a TrackingOptions
        /// object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        CreateConfigurationSetTrackingOptionsResponse CreateConfigurationSetTrackingOptions(CreateConfigurationSetTrackingOptionsRequest request);



        /// <summary>
        /// Creates an association between a configuration set and a custom domain for open and
        /// click event tracking. 
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTrackingOptionsException">
        /// Indicates that the custom domain to be used for open and click tracking redirects
        /// is invalid. This error appears most often in the following situations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// When the tracking domain you specified is not verified in Amazon SES.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the tracking domain you specified is not a valid domain or subdomain.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsAlreadyExistsException">
        /// Indicates that the configuration set you specified already contains a TrackingOptions
        /// object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        Task<CreateConfigurationSetTrackingOptionsResponse> CreateConfigurationSetTrackingOptionsAsync(CreateConfigurationSetTrackingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate


        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailInvalidContentException">
        /// Indicates that custom verification email template provided content is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateAlreadyExistsException">
        /// Indicates that a custom verification email template with the name you specified already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request);



        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailInvalidContentException">
        /// Indicates that custom verification email template provided content is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateAlreadyExistsException">
        /// Indicates that a custom verification email template with the name you specified already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        Task<CreateCustomVerificationEmailTemplateResponse> CreateCustomVerificationEmailTemplateAsync(CreateCustomVerificationEmailTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptFilter


        /// <summary>
        /// Creates a new IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about setting up IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        CreateReceiptFilterResponse CreateReceiptFilter(CreateReceiptFilterRequest request);



        /// <summary>
        /// Creates a new IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about setting up IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        Task<CreateReceiptFilterResponse> CreateReceiptFilterAsync(CreateReceiptFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptRule


        /// <summary>
        /// Creates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided Amazon Web Services Lambda function is invalid, or that
        /// Amazon SES could not execute the provided function, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or Amazon Web Services KMS encryption
        /// key is invalid, or that Amazon SES could not publish to the bucket, possibly due to
        /// permissions issues. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        CreateReceiptRuleResponse CreateReceiptRule(CreateReceiptRuleRequest request);



        /// <summary>
        /// Creates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided Amazon Web Services Lambda function is invalid, or that
        /// Amazon SES could not execute the provided function, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or Amazon Web Services KMS encryption
        /// key is invalid, or that Amazon SES could not publish to the bucket, possibly due to
        /// permissions issues. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        Task<CreateReceiptRuleResponse> CreateReceiptRuleAsync(CreateReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReceiptRuleSet


        /// <summary>
        /// Creates an empty receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        CreateReceiptRuleSetResponse CreateReceiptRuleSet(CreateReceiptRuleSetRequest request);



        /// <summary>
        /// Creates an empty receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        Task<CreateReceiptRuleSetResponse> CreateReceiptRuleSetAsync(CreateReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single operation. For more information, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTemplateException">
        /// Indicates that the template that you specified could not be rendered. This issue may
        /// occur when a template refers to a partial that does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);



        /// <summary>
        /// Creates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single operation. For more information, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AlreadyExistsException">
        /// Indicates that a resource could not be created because of a naming conflict.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTemplateException">
        /// Indicates that the template that you specified could not be rendered. This issue may
        /// occur when a template refers to a partial that does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Deletes a configuration set. Configuration sets enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);



        /// <summary>
        /// Deletes a configuration set. Configuration sets enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Deletes a configuration set event destination. Configuration set event destinations
        /// are associated with configuration sets, which enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationDoesNotExistException">
        /// Indicates that the event destination does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request);



        /// <summary>
        /// Deletes a configuration set event destination. Configuration set event destinations
        /// are associated with configuration sets, which enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationDoesNotExistException">
        /// Indicates that the event destination does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationSetTrackingOptions


        /// <summary>
        /// Deletes an association between a configuration set and a custom domain for open and
        /// click event tracking.
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleting this kind of association results in emails sent using the specified configuration
        /// set to capture open and click events using the standard, Amazon SES-operated domains.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsDoesNotExistException">
        /// Indicates that the TrackingOptions object you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        DeleteConfigurationSetTrackingOptionsResponse DeleteConfigurationSetTrackingOptions(DeleteConfigurationSetTrackingOptionsRequest request);



        /// <summary>
        /// Deletes an association between a configuration set and a custom domain for open and
        /// click event tracking.
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleting this kind of association results in emails sent using the specified configuration
        /// set to capture open and click events using the standard, Amazon SES-operated domains.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsDoesNotExistException">
        /// Indicates that the TrackingOptions object you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        Task<DeleteConfigurationSetTrackingOptionsResponse> DeleteConfigurationSetTrackingOptionsAsync(DeleteConfigurationSetTrackingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate


        /// <summary>
        /// Deletes an existing custom verification email template. 
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request);



        /// <summary>
        /// Deletes an existing custom verification email template. 
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        Task<DeleteCustomVerificationEmailTemplateResponse> DeleteCustomVerificationEmailTemplateAsync(DeleteCustomVerificationEmailTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentity


        /// <summary>
        /// Deletes the specified identity (an email address or a domain) from the list of verified
        /// identities.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request);



        /// <summary>
        /// Deletes the specified identity (an email address or a domain) from the list of verified
        /// identities.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIdentityPolicy


        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (an email
        /// address or a domain). This operation returns successfully even if a policy with the
        /// specified name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        DeleteIdentityPolicyResponse DeleteIdentityPolicy(DeleteIdentityPolicyRequest request);



        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (an email
        /// address or a domain). This operation returns successfully even if a policy with the
        /// specified name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        Task<DeleteIdentityPolicyResponse> DeleteIdentityPolicyAsync(DeleteIdentityPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptFilter


        /// <summary>
        /// Deletes the specified IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        DeleteReceiptFilterResponse DeleteReceiptFilter(DeleteReceiptFilterRequest request);



        /// <summary>
        /// Deletes the specified IP address filter.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        Task<DeleteReceiptFilterResponse> DeleteReceiptFilterAsync(DeleteReceiptFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptRule


        /// <summary>
        /// Deletes the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        DeleteReceiptRuleResponse DeleteReceiptRule(DeleteReceiptRuleRequest request);



        /// <summary>
        /// Deletes the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        Task<DeleteReceiptRuleResponse> DeleteReceiptRuleAsync(DeleteReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReceiptRuleSet


        /// <summary>
        /// Deletes the specified receipt rule set and all of the receipt rules it contains.
        /// 
        ///  <note> 
        /// <para>
        /// The currently active rule set cannot be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CannotDeleteException">
        /// Indicates that the delete operation could not be completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        DeleteReceiptRuleSetResponse DeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request);



        /// <summary>
        /// Deletes the specified receipt rule set and all of the receipt rules it contains.
        /// 
        ///  <note> 
        /// <para>
        /// The currently active rule set cannot be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CannotDeleteException">
        /// Indicates that the delete operation could not be completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        Task<DeleteReceiptRuleSetResponse> DeleteReceiptRuleSetAsync(DeleteReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes an email template.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);



        /// <summary>
        /// Deletes an email template.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVerifiedEmailAddress


        /// <summary>
        /// Deprecated. Use the <c>DeleteIdentity</c> operation to delete email addresses and
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request);



        /// <summary>
        /// Deprecated. Use the <c>DeleteIdentity</c> operation to delete email addresses and
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeActiveReceiptRuleSet


        /// <summary>
        /// Returns the metadata and receipt rules for the receipt rule set that is currently
        /// active.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DescribeActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        DescribeActiveReceiptRuleSetResponse DescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request);



        /// <summary>
        /// Returns the metadata and receipt rules for the receipt rule set that is currently
        /// active.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-concepts.html#receiving-email-concepts-rules">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        Task<DescribeActiveReceiptRuleSetResponse> DescribeActiveReceiptRuleSetAsync(DescribeActiveReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationSet


        /// <summary>
        /// Returns the details of the specified configuration set. For information about using
        /// configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        DescribeConfigurationSetResponse DescribeConfigurationSet(DescribeConfigurationSetRequest request);



        /// <summary>
        /// Returns the details of the specified configuration set. For information about using
        /// configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        Task<DescribeConfigurationSetResponse> DescribeConfigurationSetAsync(DescribeConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReceiptRule


        /// <summary>
        /// Returns the details of the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        DescribeReceiptRuleResponse DescribeReceiptRule(DescribeReceiptRuleRequest request);



        /// <summary>
        /// Returns the details of the specified receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        Task<DescribeReceiptRuleResponse> DescribeReceiptRuleAsync(DescribeReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReceiptRuleSet


        /// <summary>
        /// Returns the details of the specified receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DescribeReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        DescribeReceiptRuleSetResponse DescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request);



        /// <summary>
        /// Returns the details of the specified receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        Task<DescribeReceiptRuleSetResponse> DescribeReceiptRuleSetAsync(DescribeReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountSendingEnabled


        /// <summary>
        /// Returns the email sending status of the Amazon SES account for the current Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSendingEnabled service method.</param>
        /// 
        /// <returns>The response from the GetAccountSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        GetAccountSendingEnabledResponse GetAccountSendingEnabled(GetAccountSendingEnabledRequest request);



        /// <summary>
        /// Returns the email sending status of the Amazon SES account for the current Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSendingEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        Task<GetAccountSendingEnabledResponse> GetAccountSendingEnabledAsync(GetAccountSendingEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCustomVerificationEmailTemplate


        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request);



        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        Task<GetCustomVerificationEmailTemplateResponse> GetCustomVerificationEmailTemplateAsync(GetCustomVerificationEmailTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityDkimAttributes


        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name identities,
        /// this operation also returns the DKIM tokens that are required for Easy DKIM signing,
        /// and whether Amazon SES has successfully verified that these tokens have been published.
        /// 
        ///  
        /// <para>
        /// This operation takes a list of identities as input and returns the following information
        /// for each:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether Easy DKIM signing is enabled or disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A set of DKIM tokens that represent the identity. If the identity is an email address,
        /// the tokens represent the domain of that address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether Amazon SES has successfully verified the DKIM tokens published in the domain's
        /// DNS. This information is only returned for domain name identities, not for email addresses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is throttled at one request per second and can only get DKIM attributes
        /// for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy-managing.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request);



        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name identities,
        /// this operation also returns the DKIM tokens that are required for Easy DKIM signing,
        /// and whether Amazon SES has successfully verified that these tokens have been published.
        /// 
        ///  
        /// <para>
        /// This operation takes a list of identities as input and returns the following information
        /// for each:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether Easy DKIM signing is enabled or disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A set of DKIM tokens that represent the identity. If the identity is an email address,
        /// the tokens represent the domain of that address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether Amazon SES has successfully verified the DKIM tokens published in the domain's
        /// DNS. This information is only returned for domain name identities, not for email addresses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is throttled at one request per second and can only get DKIM attributes
        /// for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy-managing.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityMailFromDomainAttributes


        /// <summary>
        /// Returns the custom MAIL FROM attributes for a list of identities (email addresses
        /// : domains).
        /// 
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get custom MAIL
        /// FROM attributes for up to 100 identities at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityMailFromDomainAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityMailFromDomainAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        GetIdentityMailFromDomainAttributesResponse GetIdentityMailFromDomainAttributes(GetIdentityMailFromDomainAttributesRequest request);



        /// <summary>
        /// Returns the custom MAIL FROM attributes for a list of identities (email addresses
        /// : domains).
        /// 
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get custom MAIL
        /// FROM attributes for up to 100 identities at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityMailFromDomainAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityMailFromDomainAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        Task<GetIdentityMailFromDomainAttributesResponse> GetIdentityMailFromDomainAttributesAsync(GetIdentityMailFromDomainAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityNotificationAttributes


        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity notification attributes.
        /// 
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get notification
        /// attributes for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request);



        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity notification attributes.
        /// 
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get notification
        /// attributes for up to 100 identities at a time.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityPolicies


        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (an email
        /// address or a domain). The policies are returned as a map of policy names to policy
        /// contents. You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        GetIdentityPoliciesResponse GetIdentityPolicies(GetIdentityPoliciesRequest request);



        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (an email
        /// address or a domain). The policies are returned as a map of policy names to policy
        /// contents. You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        Task<GetIdentityPoliciesResponse> GetIdentityPoliciesAsync(GetIdentityPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIdentityVerificationAttributes


        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        /// status and (for domain identities) the verification token for each identity.
        /// 
        ///  
        /// <para>
        /// The verification status of an email address is "Pending" until the email address owner
        /// clicks the link within the verification email that Amazon SES sent to that address.
        /// If the email address owner clicks the link within 24 hours, the verification status
        /// of the email address changes to "Success". If the link is not clicked within 24 hours,
        /// the verification status changes to "Failed." In that case, to verify the email address,
        /// you must restart the verification process from the beginning.
        /// </para>
        ///  
        /// <para>
        /// For domain identities, the domain's verification status is "Pending" as Amazon SES
        /// searches for the required TXT record in the DNS settings of the domain. When Amazon
        /// SES detects the record, the domain's verification status changes to "Success". If
        /// Amazon SES is unable to detect the record within 72 hours, the domain's verification
        /// status changes to "Failed." In that case, to verify the domain, you must restart the
        /// verification process from the beginning.
        /// </para>
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get verification
        /// attributes for up to 100 identities at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request);



        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        /// status and (for domain identities) the verification token for each identity.
        /// 
        ///  
        /// <para>
        /// The verification status of an email address is "Pending" until the email address owner
        /// clicks the link within the verification email that Amazon SES sent to that address.
        /// If the email address owner clicks the link within 24 hours, the verification status
        /// of the email address changes to "Success". If the link is not clicked within 24 hours,
        /// the verification status changes to "Failed." In that case, to verify the email address,
        /// you must restart the verification process from the beginning.
        /// </para>
        ///  
        /// <para>
        /// For domain identities, the domain's verification status is "Pending" as Amazon SES
        /// searches for the required TXT record in the DNS settings of the domain. When Amazon
        /// SES detects the record, the domain's verification status changes to "Success". If
        /// Amazon SES is unable to detect the record within 72 hours, the domain's verification
        /// status changes to "Failed." In that case, to verify the domain, you must restart the
        /// verification process from the beginning.
        /// </para>
        ///  
        /// <para>
        /// This operation is throttled at one request per second and can only get verification
        /// attributes for up to 100 identities at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSendQuota


        /// <summary>
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        GetSendQuotaResponse GetSendQuota();


        /// <summary>
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota service method.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request);


        /// <summary>
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        Task<GetSendQuotaResponse> GetSendQuotaAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSendStatistics


        /// <summary>
        /// Provides sending statistics for the current Amazon Web Services Region. The result
        /// is a list of data points, representing the last two weeks of sending activity. Each
        /// data point in the list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        GetSendStatisticsResponse GetSendStatistics();


        /// <summary>
        /// Provides sending statistics for the current Amazon Web Services Region. The result
        /// is a list of data points, representing the last two weeks of sending activity. Each
        /// data point in the list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request);


        /// <summary>
        /// Provides sending statistics for the current Amazon Web Services Region. The result
        /// is a list of data points, representing the last two weeks of sending activity. Each
        /// data point in the list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        Task<GetSendStatisticsResponse> GetSendStatisticsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides sending statistics for the current Amazon Web Services Region. The result
        /// is a list of data points, representing the last two weeks of sending activity. Each
        /// data point in the list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Displays the template object (which includes the Subject line, HTML part and text
        /// part) for the template you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);



        /// <summary>
        /// Displays the template object (which includes the Subject line, HTML part and text
        /// part) for the template you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurationSets


        /// <summary>
        /// Provides a list of the configuration sets associated with your Amazon SES account
        /// in the current Amazon Web Services Region. For information about using configuration
        /// sets, see <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Monitoring
        /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second. This operation returns
        /// up to 1,000 configuration sets each time it is run. If your Amazon SES account has
        /// more than 1,000 configuration sets, this operation also returns <c>NextToken</c>.
        /// You can then execute the <c>ListConfigurationSets</c> operation again, passing the
        /// <c>NextToken</c> parameter and the value of the NextToken element to retrieve additional
        /// results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request);



        /// <summary>
        /// Provides a list of the configuration sets associated with your Amazon SES account
        /// in the current Amazon Web Services Region. For information about using configuration
        /// sets, see <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Monitoring
        /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second. This operation returns
        /// up to 1,000 configuration sets each time it is run. If your Amazon SES account has
        /// more than 1,000 configuration sets, this operation also returns <c>NextToken</c>.
        /// You can then execute the <c>ListConfigurationSets</c> operation again, passing the
        /// <c>NextToken</c> parameter and the value of the NextToken element to retrieve additional
        /// results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCustomVerificationEmailTemplates


        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCustomVerificationEmailTemplates service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request);



        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomVerificationEmailTemplates service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        Task<ListCustomVerificationEmailTemplatesResponse> ListCustomVerificationEmailTemplatesAsync(ListCustomVerificationEmailTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentities


        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your Amazon Web Services account in the current Amazon Web Services Region, regardless
        /// of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  <note> 
        /// <para>
        /// It's recommended that for successive pagination calls of this API, you continue to
        /// the use the same parameter/value pairs as used in the original call, e.g., if you
        /// used <c>IdentityType=Domain</c> in the the original call and received a <c>NextToken</c>
        /// in the response, you should continue providing the <c>IdentityType=Domain</c> parameter
        /// for further <c>NextToken</c> calls; however, if you didn't provide the <c>IdentityType</c>
        /// parameter in the original call, then continue to not provide it for successive pagination
        /// calls. Using this protocol will ensure consistent results.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        ListIdentitiesResponse ListIdentities();


        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your Amazon Web Services account in the current Amazon Web Services Region, regardless
        /// of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  <note> 
        /// <para>
        /// It's recommended that for successive pagination calls of this API, you continue to
        /// the use the same parameter/value pairs as used in the original call, e.g., if you
        /// used <c>IdentityType=Domain</c> in the the original call and received a <c>NextToken</c>
        /// in the response, you should continue providing the <c>IdentityType=Domain</c> parameter
        /// for further <c>NextToken</c> calls; however, if you didn't provide the <c>IdentityType</c>
        /// parameter in the original call, then continue to not provide it for successive pagination
        /// calls. Using this protocol will ensure consistent results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request);


        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your Amazon Web Services account in the current Amazon Web Services Region, regardless
        /// of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  <note> 
        /// <para>
        /// It's recommended that for successive pagination calls of this API, you continue to
        /// the use the same parameter/value pairs as used in the original call, e.g., if you
        /// used <c>IdentityType=Domain</c> in the the original call and received a <c>NextToken</c>
        /// in the response, you should continue providing the <c>IdentityType=Domain</c> parameter
        /// for further <c>NextToken</c> calls; however, if you didn't provide the <c>IdentityType</c>
        /// parameter in the original call, then continue to not provide it for successive pagination
        /// calls. Using this protocol will ensure consistent results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        Task<ListIdentitiesResponse> ListIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your Amazon Web Services account in the current Amazon Web Services Region, regardless
        /// of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  <note> 
        /// <para>
        /// It's recommended that for successive pagination calls of this API, you continue to
        /// the use the same parameter/value pairs as used in the original call, e.g., if you
        /// used <c>IdentityType=Domain</c> in the the original call and received a <c>NextToken</c>
        /// in the response, you should continue providing the <c>IdentityType=Domain</c> parameter
        /// for further <c>NextToken</c> calls; however, if you didn't provide the <c>IdentityType</c>
        /// parameter in the original call, then continue to not provide it for successive pagination
        /// calls. Using this protocol will ensure consistent results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIdentityPolicies


        /// <summary>
        /// Returns a list of sending authorization policies that are attached to the given identity
        /// (an email address or a domain). This operation returns only a list. To get the actual
        /// policy content, use <c>GetIdentityPolicies</c>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        ListIdentityPoliciesResponse ListIdentityPolicies(ListIdentityPoliciesRequest request);



        /// <summary>
        /// Returns a list of sending authorization policies that are attached to the given identity
        /// (an email address or a domain). This operation returns only a list. To get the actual
        /// policy content, use <c>GetIdentityPolicies</c>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityPolicies service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        Task<ListIdentityPoliciesResponse> ListIdentityPoliciesAsync(ListIdentityPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceiptFilters


        /// <summary>
        /// Lists the IP address filters associated with your Amazon Web Services account in the
        /// current Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters service method.</param>
        /// 
        /// <returns>The response from the ListReceiptFilters service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        ListReceiptFiltersResponse ListReceiptFilters(ListReceiptFiltersRequest request);



        /// <summary>
        /// Lists the IP address filters associated with your Amazon Web Services account in the
        /// current Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceiptFilters service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        Task<ListReceiptFiltersResponse> ListReceiptFiltersAsync(ListReceiptFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReceiptRuleSets


        /// <summary>
        /// Lists the receipt rule sets that exist under your Amazon Web Services account in the
        /// current Amazon Web Services Region. If there are additional receipt rule sets to be
        /// retrieved, you receive a <c>NextToken</c> that you can provide to the next call to
        /// <c>ListReceiptRuleSets</c> to retrieve the additional entries.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListReceiptRuleSets service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        ListReceiptRuleSetsResponse ListReceiptRuleSets(ListReceiptRuleSetsRequest request);



        /// <summary>
        /// Lists the receipt rule sets that exist under your Amazon Web Services account in the
        /// current Amazon Web Services Region. If there are additional receipt rule sets to be
        /// retrieved, you receive a <c>NextToken</c> that you can provide to the next call to
        /// <c>ListReceiptRuleSets</c> to retrieve the additional entries.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceiptRuleSets service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        Task<ListReceiptRuleSetsResponse> ListReceiptRuleSetsAsync(ListReceiptRuleSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);



        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVerifiedEmailAddresses


        /// <summary>
        /// Deprecated. Use the <c>ListIdentities</c> operation to list the email addresses and
        /// domains associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses();


        /// <summary>
        /// Deprecated. Use the <c>ListIdentities</c> operation to list the email addresses and
        /// domains associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request);


        /// <summary>
        /// Deprecated. Use the <c>ListIdentities</c> operation to list the email addresses and
        /// domains associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Deprecated. Use the <c>ListIdentities</c> operation to list the email addresses and
        /// domains associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions


        /// <summary>
        /// Adds or updates the delivery options for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidDeliveryOptionsException">
        /// Indicates that provided delivery option is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request);



        /// <summary>
        /// Adds or updates the delivery options for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidDeliveryOptionsException">
        /// Indicates that provided delivery option is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIdentityPolicy


        /// <summary>
        /// Adds or updates a sending authorization policy for the specified identity (an email
        /// address or a domain).
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the PutIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidPolicyException">
        /// Indicates that the provided policy is invalid. Check the error stack for more information
        /// about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        PutIdentityPolicyResponse PutIdentityPolicy(PutIdentityPolicyRequest request);



        /// <summary>
        /// Adds or updates a sending authorization policy for the specified identity (an email
        /// address or a domain).
        /// 
        ///  <note> 
        /// <para>
        /// This operation is for the identity owner only. If you have not verified the identity,
        /// it returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIdentityPolicy service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidPolicyException">
        /// Indicates that the provided policy is invalid. Check the error stack for more information
        /// about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        Task<PutIdentityPolicyResponse> PutIdentityPolicyAsync(PutIdentityPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReorderReceiptRuleSet


        /// <summary>
        /// Reorders the receipt rules within a receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// All of the rules in the rule set must be represented in this request. That is, it
        /// is error if the reorder request doesn't explicitly position all of the rules.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        ReorderReceiptRuleSetResponse ReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request);



        /// <summary>
        /// Reorders the receipt rules within a receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// All of the rules in the rule set must be represented in this request. That is, it
        /// is error if the reorder request doesn't explicitly position all of the rules.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReorderReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        Task<ReorderReceiptRuleSetResponse> ReorderReceiptRuleSetAsync(ReorderReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendBounce


        /// <summary>
        /// Generates and sends a bounce message to the sender of an email you received through
        /// Amazon SES. You can only use this operation on an email up to 24 hours after you receive
        /// it.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use this operation to send generic bounces for mail that was not received
        /// by Amazon SES.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about receiving email through Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBounce service method.</param>
        /// 
        /// <returns>The response from the SendBounce service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        SendBounceResponse SendBounce(SendBounceRequest request);



        /// <summary>
        /// Generates and sends a bounce message to the sender of an email you received through
        /// Amazon SES. You can only use this operation on an email up to 24 hours after you receive
        /// it.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use this operation to send generic bounces for mail that was not received
        /// by Amazon SES.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about receiving email through Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBounce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendBounce service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        Task<SendBounceResponse> SendBounceAsync(SendBounceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendBulkTemplatedEmail


        /// <summary>
        /// Composes an email message to multiple destinations. The message body is created using
        /// an email template.
        /// 
        ///  
        /// <para>
        /// To send email using this operation, your call must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The call must refer to an existing email template. You can create email templates
        /// using <a>CreateTemplate</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may send only to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each <c>Destination</c> parameter must include at least one recipient email address.
        /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
        /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <c>SendBulkTemplatedEmail</c>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of destinations you can contact in a single call can be limited by your
        /// account's maximum sending rate.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBulkTemplatedEmail service method.</param>
        /// 
        /// <returns>The response from the SendBulkTemplatedEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        SendBulkTemplatedEmailResponse SendBulkTemplatedEmail(SendBulkTemplatedEmailRequest request);



        /// <summary>
        /// Composes an email message to multiple destinations. The message body is created using
        /// an email template.
        /// 
        ///  
        /// <para>
        /// To send email using this operation, your call must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The call must refer to an existing email template. You can create email templates
        /// using <a>CreateTemplate</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may send only to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each <c>Destination</c> parameter must include at least one recipient email address.
        /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
        /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <c>SendBulkTemplatedEmail</c>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of destinations you can contact in a single call can be limited by your
        /// account's maximum sending rate.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBulkTemplatedEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendBulkTemplatedEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        Task<SendBulkTemplatedEmailResponse> SendBulkTemplatedEmailAsync(SendBulkTemplatedEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendCustomVerificationEmail


        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail service method.</param>
        /// 
        /// <returns>The response from the SendCustomVerificationEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ProductionAccessNotGrantedException">
        /// Indicates that the account has not been granted production access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request);



        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCustomVerificationEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ProductionAccessNotGrantedException">
        /// Indicates that the account has not been granted production access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        Task<SendCustomVerificationEmailResponse> SendCustomVerificationEmailAsync(SendCustomVerificationEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendEmail


        /// <summary>
        /// Composes an email message and immediately queues it for sending. To send email using
        /// this operation, your message must meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain. If you attempt to
        /// send email using a non-verified address or domain, the operation results in an "Email
        /// address not verified" error. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must include at least one recipient email address. The recipient address
        /// can be a To: address, a CC: address, or a BCC: address. If a recipient email address
        /// is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <c>SendEmail</c>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/dg/manage-sending-quotas.html">Managing
        /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        SendEmailResponse SendEmail(SendEmailRequest request);



        /// <summary>
        /// Composes an email message and immediately queues it for sending. To send email using
        /// this operation, your message must meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain. If you attempt to
        /// send email using a non-verified address or domain, the operation results in an "Email
        /// address not verified" error. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must include at least one recipient email address. The recipient address
        /// can be a To: address, a CC: address, or a BCC: address. If a recipient email address
        /// is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <c>SendEmail</c>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/dg/manage-sending-quotas.html">Managing
        /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendRawEmail


        /// <summary>
        /// Composes an email message and immediately queues it for sending.
        /// 
        ///  
        /// <para>
        /// This operation is more flexible than the <c>SendEmail</c> operation. When you use
        /// the <c>SendRawEmail</c> operation, you can specify the headers of the message as well
        /// as its content. This flexibility is useful, for example, when you need to send a multipart
        /// MIME email (such a message that contains both a text and an HTML version). You can
        /// also use this operation to send messages that include attachments.
        /// </para>
        ///  
        /// <para>
        /// The <c>SendRawEmail</c> operation has the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only send email from <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">verified
        /// email addresses or domains</a>. If you try to send email from an address that isn't
        /// verified, the operation results in an "Email address not verified" error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the <a href="https://docs.aws.amazon.com/ses/latest/dg/request-production-access.html">Amazon
        /// SES sandbox</a>, you can only send email to other verified addresses in your account,
        /// or to addresses that are associated with the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-an-email-from-console.html">Amazon
        /// SES mailbox simulator</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size, including attachments, is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each message has to include at least one recipient address. A recipient address includes
        /// any address on the To:, CC:, or BCC: lines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send a single message to more than one recipient address, and one of the recipient
        /// addresses isn't in a valid format (that is, it's not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// Amazon SES rejects the entire message, even if the other addresses are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each message can include up to 50 recipient addresses across the To:, CC:, or BCC:
        /// lines. If you need to send a single message to more than 50 recipients, you have to
        /// split the list of recipient addresses into groups of less than 50 recipients, and
        /// send separate messages to each group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SES allows you to specify 8-bit Content-Transfer-Encoding for MIME message
        /// parts. However, if Amazon SES has to modify the contents of your message (for example,
        /// if you use open and click tracking), 8-bit content isn't preserved. For this reason,
        /// we highly recommend that you encode all content that isn't 7-bit ASCII. For more information,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html#send-email-mime-encoding">MIME
        /// Encoding</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additionally, keep the following considerations in mind when using the <c>SendRawEmail</c>
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although you can customize the message headers when using the <c>SendRawEmail</c>
        /// operation, Amazon SES automatically applies its own <c>Message-ID</c> and <c>Date</c>
        /// headers; if you passed these headers when creating the message, they are overwritten
        /// by the values that Amazon SES provides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using sending authorization to send on behalf of another user, <c>SendRawEmail</c>
        /// enables you to specify the cross-account identity for the email's Source, From, and
        /// Return-Path parameters in one of two ways: you can pass optional parameters <c>SourceArn</c>,
        /// <c>FromArn</c>, and/or <c>ReturnPathArn</c>, or you can include the following X-headers
        /// in the header of your raw email:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>X-SES-SOURCE-ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>X-SES-FROM-ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>X-SES-RETURN-PATH-ARN</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Don't include these X-headers in the DKIM signature. Amazon SES removes these before
        /// it sends the email.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you only specify the <c>SourceIdentityArn</c> parameter, Amazon SES sets the From
        /// and Return-Path addresses to the same identity that you specified.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Using
        /// Sending Authorization with Amazon SES</a> in the <i>Amazon SES Developer Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/dg/manage-sending-quotas.html">Managing
        /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        SendRawEmailResponse SendRawEmail(SendRawEmailRequest request);



        /// <summary>
        /// Composes an email message and immediately queues it for sending.
        /// 
        ///  
        /// <para>
        /// This operation is more flexible than the <c>SendEmail</c> operation. When you use
        /// the <c>SendRawEmail</c> operation, you can specify the headers of the message as well
        /// as its content. This flexibility is useful, for example, when you need to send a multipart
        /// MIME email (such a message that contains both a text and an HTML version). You can
        /// also use this operation to send messages that include attachments.
        /// </para>
        ///  
        /// <para>
        /// The <c>SendRawEmail</c> operation has the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only send email from <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">verified
        /// email addresses or domains</a>. If you try to send email from an address that isn't
        /// verified, the operation results in an "Email address not verified" error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the <a href="https://docs.aws.amazon.com/ses/latest/dg/request-production-access.html">Amazon
        /// SES sandbox</a>, you can only send email to other verified addresses in your account,
        /// or to addresses that are associated with the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-an-email-from-console.html">Amazon
        /// SES mailbox simulator</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size, including attachments, is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each message has to include at least one recipient address. A recipient address includes
        /// any address on the To:, CC:, or BCC: lines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send a single message to more than one recipient address, and one of the recipient
        /// addresses isn't in a valid format (that is, it's not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// Amazon SES rejects the entire message, even if the other addresses are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each message can include up to 50 recipient addresses across the To:, CC:, or BCC:
        /// lines. If you need to send a single message to more than 50 recipients, you have to
        /// split the list of recipient addresses into groups of less than 50 recipients, and
        /// send separate messages to each group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SES allows you to specify 8-bit Content-Transfer-Encoding for MIME message
        /// parts. However, if Amazon SES has to modify the contents of your message (for example,
        /// if you use open and click tracking), 8-bit content isn't preserved. For this reason,
        /// we highly recommend that you encode all content that isn't 7-bit ASCII. For more information,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html#send-email-mime-encoding">MIME
        /// Encoding</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additionally, keep the following considerations in mind when using the <c>SendRawEmail</c>
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although you can customize the message headers when using the <c>SendRawEmail</c>
        /// operation, Amazon SES automatically applies its own <c>Message-ID</c> and <c>Date</c>
        /// headers; if you passed these headers when creating the message, they are overwritten
        /// by the values that Amazon SES provides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using sending authorization to send on behalf of another user, <c>SendRawEmail</c>
        /// enables you to specify the cross-account identity for the email's Source, From, and
        /// Return-Path parameters in one of two ways: you can pass optional parameters <c>SourceArn</c>,
        /// <c>FromArn</c>, and/or <c>ReturnPathArn</c>, or you can include the following X-headers
        /// in the header of your raw email:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>X-SES-SOURCE-ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>X-SES-FROM-ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>X-SES-RETURN-PATH-ARN</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Don't include these X-headers in the DKIM signature. Amazon SES removes these before
        /// it sends the email.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you only specify the <c>SourceIdentityArn</c> parameter, Amazon SES sets the From
        /// and Return-Path addresses to the same identity that you specified.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Using
        /// Sending Authorization with Amazon SES</a> in the <i>Amazon SES Developer Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/dg/manage-sending-quotas.html">Managing
        /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendTemplatedEmail


        /// <summary>
        /// Composes an email message using an email template and immediately queues it for sending.
        /// 
        ///  
        /// <para>
        /// To send email using this operation, your call must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The call must refer to an existing email template. You can create email templates
        /// using the <a>CreateTemplate</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to the <c>SendTemplatedEmail</c> operation may only include one <c>Destination</c>
        /// parameter. A destination is a set of recipients that receives the same version of
        /// the email. The <c>Destination</c> parameter can include up to 50 recipients, across
        /// the To:, CC: and BCC: fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Destination</c> parameter must include at least one recipient email address.
        /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
        /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If your call to the <c>SendTemplatedEmail</c> operation includes all of the required
        /// parameters, Amazon SES accepts it and returns a Message ID. However, if Amazon SES
        /// can't render the email because the template contains errors, it doesn't send the email.
        /// Additionally, because it already accepted the message, Amazon SES doesn't return a
        /// message stating that it was unable to send the email.
        /// </para>
        ///  
        /// <para>
        /// For these reasons, we highly recommend that you set up Amazon SES to send you notifications
        /// when Rendering Failure events occur. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Sending
        /// Personalized Email Using the Amazon SES API</a> in the <i>Amazon Simple Email Service
        /// Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTemplatedEmail service method.</param>
        /// 
        /// <returns>The response from the SendTemplatedEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        SendTemplatedEmailResponse SendTemplatedEmail(SendTemplatedEmailRequest request);



        /// <summary>
        /// Composes an email message using an email template and immediately queues it for sending.
        /// 
        ///  
        /// <para>
        /// To send email using this operation, your call must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The call must refer to an existing email template. You can create email templates
        /// using the <a>CreateTemplate</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum message size is 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to the <c>SendTemplatedEmail</c> operation may only include one <c>Destination</c>
        /// parameter. A destination is a set of recipients that receives the same version of
        /// the email. The <c>Destination</c> parameter can include up to 50 recipients, across
        /// the To:, CC: and BCC: fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Destination</c> parameter must include at least one recipient email address.
        /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
        /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message is rejected, even if the message contains other recipients that
        /// are valid.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If your call to the <c>SendTemplatedEmail</c> operation includes all of the required
        /// parameters, Amazon SES accepts it and returns a Message ID. However, if Amazon SES
        /// can't render the email because the template contains errors, it doesn't send the email.
        /// Additionally, because it already accepted the message, Amazon SES doesn't return a
        /// message stating that it was unable to send the email.
        /// </para>
        ///  
        /// <para>
        /// For these reasons, we highly recommend that you set up Amazon SES to send you notifications
        /// when Rendering Failure events occur. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Sending
        /// Personalized Email Using the Amazon SES API</a> in the <i>Amazon Simple Email Service
        /// Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTemplatedEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTemplatedEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.AccountSendingPausedException">
        /// Indicates that email sending is disabled for your entire Amazon SES account.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for your Amazon SES account using <a>UpdateAccountSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetSendingPausedException">
        /// Indicates that email sending is disabled for the configuration set.
        /// 
        ///  
        /// <para>
        /// You can enable or disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MailFromDomainNotVerifiedException">
        /// Indicates that the message could not be sent because Amazon SES could not read the
        /// MX record required to use the specified MAIL FROM domain. For information about editing
        /// the custom MAIL FROM domain settings for an identity, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        Task<SendTemplatedEmailResponse> SendTemplatedEmailAsync(SendTemplatedEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetActiveReceiptRuleSet


        /// <summary>
        /// Sets the specified receipt rule set as the active receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// To disable your email-receiving through Amazon SES completely, you can call this operation
        /// with <c>RuleSetName</c> set to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the SetActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        SetActiveReceiptRuleSetResponse SetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request);



        /// <summary>
        /// Sets the specified receipt rule set as the active receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// To disable your email-receiving through Amazon SES completely, you can call this operation
        /// with <c>RuleSetName</c> set to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        Task<SetActiveReceiptRuleSetResponse> SetActiveReceiptRuleSetAsync(SetActiveReceiptRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityDkimEnabled


        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity. If Easy DKIM
        /// signing is enabled for a domain, then Amazon SES uses DKIM to sign all email that
        /// it sends from addresses on that domain. If Easy DKIM signing is enabled for an email
        /// address, then Amazon SES uses DKIM to sign all email it sends from that address.
        /// 
        ///  <note> 
        /// <para>
        /// For email addresses (for example, <c>user@example.com</c>), you can only enable DKIM
        /// signing if the corresponding domain (in this case, <c>example.com</c>) has been set
        /// up to use Easy DKIM.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can enable DKIM signing for an identity at any time after you start the verification
        /// process for the identity, even if the verification process isn't complete. 
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about Easy DKIM signing, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request);



        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity. If Easy DKIM
        /// signing is enabled for a domain, then Amazon SES uses DKIM to sign all email that
        /// it sends from addresses on that domain. If Easy DKIM signing is enabled for an email
        /// address, then Amazon SES uses DKIM to sign all email it sends from that address.
        /// 
        ///  <note> 
        /// <para>
        /// For email addresses (for example, <c>user@example.com</c>), you can only enable DKIM
        /// signing if the corresponding domain (in this case, <c>example.com</c>) has been set
        /// up to use Easy DKIM.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can enable DKIM signing for an identity at any time after you start the verification
        /// process for the identity, even if the verification process isn't complete. 
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about Easy DKIM signing, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled


        /// <summary>
        /// Given an identity (an email address or a domain), enables or disables whether Amazon
        /// SES forwards bounce and complaint notifications as email. Feedback forwarding can
        /// only be disabled when Amazon Simple Notification Service (Amazon SNS) topics are specified
        /// for both bounces and complaints.
        /// 
        ///  <note> 
        /// <para>
        /// Feedback forwarding does not apply to delivery notifications. Delivery notifications
        /// are only available through Amazon SNS.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request);



        /// <summary>
        /// Given an identity (an email address or a domain), enables or disables whether Amazon
        /// SES forwards bounce and complaint notifications as email. Feedback forwarding can
        /// only be disabled when Amazon Simple Notification Service (Amazon SNS) topics are specified
        /// for both bounces and complaints.
        /// 
        ///  <note> 
        /// <para>
        /// Feedback forwarding does not apply to delivery notifications. Delivery notifications
        /// are only available through Amazon SNS.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityHeadersInNotificationsEnabled


        /// <summary>
        /// Given an identity (an email address or a domain), sets whether Amazon SES includes
        /// the original email headers in the Amazon Simple Notification Service (Amazon SNS)
        /// notifications of a specified type.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityHeadersInNotificationsEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        SetIdentityHeadersInNotificationsEnabledResponse SetIdentityHeadersInNotificationsEnabled(SetIdentityHeadersInNotificationsEnabledRequest request);



        /// <summary>
        /// Given an identity (an email address or a domain), sets whether Amazon SES includes
        /// the original email headers in the Amazon Simple Notification Service (Amazon SNS)
        /// notifications of a specified type.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about using notifications with Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityHeadersInNotificationsEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        Task<SetIdentityHeadersInNotificationsEnabledResponse> SetIdentityHeadersInNotificationsEnabledAsync(SetIdentityHeadersInNotificationsEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityMailFromDomain


        /// <summary>
        /// Enables or disables the custom MAIL FROM domain setup for a verified identity (an
        /// email address or a domain).
        /// 
        ///  <important> 
        /// <para>
        /// To send emails using the specified MAIL FROM domain, you must add an MX record to
        /// your MAIL FROM domain's DNS settings. To ensure that your emails pass Sender Policy
        /// Framework (SPF) checks, you must also add or update an SPF record. For more information,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/mail-from.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityMailFromDomain service method.</param>
        /// 
        /// <returns>The response from the SetIdentityMailFromDomain service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        SetIdentityMailFromDomainResponse SetIdentityMailFromDomain(SetIdentityMailFromDomainRequest request);



        /// <summary>
        /// Enables or disables the custom MAIL FROM domain setup for a verified identity (an
        /// email address or a domain).
        /// 
        ///  <important> 
        /// <para>
        /// To send emails using the specified MAIL FROM domain, you must add an MX record to
        /// your MAIL FROM domain's DNS settings. To ensure that your emails pass Sender Policy
        /// Framework (SPF) checks, you must also add or update an SPF record. For more information,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/mail-from.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityMailFromDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityMailFromDomain service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        Task<SetIdentityMailFromDomainResponse> SetIdentityMailFromDomainAsync(SetIdentityMailFromDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetIdentityNotificationTopic


        /// <summary>
        /// Sets an Amazon Simple Notification Service (Amazon SNS) topic to use when delivering
        /// notifications. When you use this operation, you specify a verified identity, such
        /// as an email address or domain. When you send an email that uses the chosen identity
        /// in the Source field, Amazon SES sends notifications to the topic you specified. You
        /// can send bounce, complaint, or delivery notifications (or any combination of the three)
        /// to the Amazon SNS topic that you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about feedback notification, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request);



        /// <summary>
        /// Sets an Amazon Simple Notification Service (Amazon SNS) topic to use when delivering
        /// notifications. When you use this operation, you specify a verified identity, such
        /// as an email address or domain. When you send an email that uses the chosen identity
        /// in the Source field, Amazon SES sends notifications to the topic you specified. You
        /// can send bounce, complaint, or delivery notifications (or any combination of the three)
        /// to the Amazon SNS topic that you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// For more information about feedback notification, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetReceiptRulePosition


        /// <summary>
        /// Sets the position of the specified receipt rule in the receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        SetReceiptRulePositionResponse SetReceiptRulePosition(SetReceiptRulePositionRequest request);



        /// <summary>
        /// Sets the position of the specified receipt rule in the receipt rule set.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetReceiptRulePosition service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        Task<SetReceiptRulePositionResponse> SetReceiptRulePositionAsync(SetReceiptRulePositionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestRenderTemplate


        /// <summary>
        /// Creates a preview of the MIME content of an email when provided with a template and
        /// a set of replacement data.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRenderTemplate service method.</param>
        /// 
        /// <returns>The response from the TestRenderTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidRenderingParameterException">
        /// Indicates that one or more of the replacement values you provided is invalid. This
        /// error may occur when the TemplateData object contains invalid JSON.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MissingRenderingAttributeException">
        /// Indicates that one or more of the replacement values for the specified template was
        /// not specified. Ensure that the TemplateData object contains references to all of the
        /// replacement tags in the specified template.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        TestRenderTemplateResponse TestRenderTemplate(TestRenderTemplateRequest request);



        /// <summary>
        /// Creates a preview of the MIME content of an email when provided with a template and
        /// a set of replacement data.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRenderTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestRenderTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidRenderingParameterException">
        /// Indicates that one or more of the replacement values you provided is invalid. This
        /// error may occur when the TemplateData object contains invalid JSON.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MissingRenderingAttributeException">
        /// Indicates that one or more of the replacement values for the specified template was
        /// not specified. Ensure that the TemplateData object contains references to all of the
        /// replacement tags in the specified template.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        Task<TestRenderTemplateResponse> TestRenderTemplateAsync(TestRenderTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccountSendingEnabled


        /// <summary>
        /// Enables or disables email sending across your entire Amazon SES account in the current
        /// Amazon Web Services Region. You can use this operation in conjunction with Amazon
        /// CloudWatch alarms to temporarily pause email sending across your Amazon SES account
        /// in a given Amazon Web Services Region when reputation metrics (such as your bounce
        /// or complaint rates) reach certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSendingEnabled service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        UpdateAccountSendingEnabledResponse UpdateAccountSendingEnabled(UpdateAccountSendingEnabledRequest request);



        /// <summary>
        /// Enables or disables email sending across your entire Amazon SES account in the current
        /// Amazon Web Services Region. You can use this operation in conjunction with Amazon
        /// CloudWatch alarms to temporarily pause email sending across your Amazon SES account
        /// in a given Amazon Web Services Region when reputation metrics (such as your bounce
        /// or complaint rates) reach certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSendingEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        Task<UpdateAccountSendingEnabledResponse> UpdateAccountSendingEnabledAsync(UpdateAccountSendingEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Updates the event destination of a configuration set. Event destinations are associated
        /// with configuration sets, which enable you to publish email sending events to Amazon
        /// CloudWatch, Amazon Kinesis Firehose, or Amazon Simple Notification Service (Amazon
        /// SNS). For information about using configuration sets, see <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Monitoring
        /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  <note> 
        /// <para>
        /// When you create or update an event destination, you must provide one, and only one,
        /// destination. The destination can be Amazon CloudWatch, Amazon Kinesis Firehose, or
        /// Amazon Simple Notification Service (Amazon SNS).
        /// </para>
        ///  </note> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationDoesNotExistException">
        /// Indicates that the event destination does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidCloudWatchDestinationException">
        /// Indicates that the Amazon CloudWatch destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidFirehoseDestinationException">
        /// Indicates that the Amazon Kinesis Firehose destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSNSDestinationException">
        /// Indicates that the Amazon Simple Notification Service (Amazon SNS) destination is
        /// invalid. See the error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request);



        /// <summary>
        /// Updates the event destination of a configuration set. Event destinations are associated
        /// with configuration sets, which enable you to publish email sending events to Amazon
        /// CloudWatch, Amazon Kinesis Firehose, or Amazon Simple Notification Service (Amazon
        /// SNS). For information about using configuration sets, see <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Monitoring
        /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  <note> 
        /// <para>
        /// When you create or update an event destination, you must provide one, and only one,
        /// destination. The destination can be Amazon CloudWatch, Amazon Kinesis Firehose, or
        /// Amazon Simple Notification Service (Amazon SNS).
        /// </para>
        ///  </note> 
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.EventDestinationDoesNotExistException">
        /// Indicates that the event destination does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidCloudWatchDestinationException">
        /// Indicates that the Amazon CloudWatch destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidFirehoseDestinationException">
        /// Indicates that the Amazon Kinesis Firehose destination is invalid. See the error message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSNSDestinationException">
        /// Indicates that the Amazon Simple Notification Service (Amazon SNS) destination is
        /// invalid. See the error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationSetReputationMetricsEnabled


        /// <summary>
        /// Enables or disables the publishing of reputation metrics for emails sent using a specific
        /// configuration set in a given Amazon Web Services Region. Reputation metrics include
        /// bounce and complaint rates. These metrics are published to Amazon CloudWatch. By using
        /// CloudWatch, you can create alarms when bounce or complaint rates exceed certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetReputationMetricsEnabled service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetReputationMetricsEnabled service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        UpdateConfigurationSetReputationMetricsEnabledResponse UpdateConfigurationSetReputationMetricsEnabled(UpdateConfigurationSetReputationMetricsEnabledRequest request);



        /// <summary>
        /// Enables or disables the publishing of reputation metrics for emails sent using a specific
        /// configuration set in a given Amazon Web Services Region. Reputation metrics include
        /// bounce and complaint rates. These metrics are published to Amazon CloudWatch. By using
        /// CloudWatch, you can create alarms when bounce or complaint rates exceed certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetReputationMetricsEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetReputationMetricsEnabled service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        Task<UpdateConfigurationSetReputationMetricsEnabledResponse> UpdateConfigurationSetReputationMetricsEnabledAsync(UpdateConfigurationSetReputationMetricsEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationSetSendingEnabled


        /// <summary>
        /// Enables or disables email sending for messages sent using a specific configuration
        /// set in a given Amazon Web Services Region. You can use this operation in conjunction
        /// with Amazon CloudWatch alarms to temporarily pause email sending for a configuration
        /// set when the reputation metrics for that configuration set (such as your bounce on
        /// complaint rate) exceed certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetSendingEnabled service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        UpdateConfigurationSetSendingEnabledResponse UpdateConfigurationSetSendingEnabled(UpdateConfigurationSetSendingEnabledRequest request);



        /// <summary>
        /// Enables or disables email sending for messages sent using a specific configuration
        /// set in a given Amazon Web Services Region. You can use this operation in conjunction
        /// with Amazon CloudWatch alarms to temporarily pause email sending for a configuration
        /// set when the reputation metrics for that configuration set (such as your bounce on
        /// complaint rate) exceed certain thresholds.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetSendingEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetSendingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        Task<UpdateConfigurationSetSendingEnabledResponse> UpdateConfigurationSetSendingEnabledAsync(UpdateConfigurationSetSendingEnabledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationSetTrackingOptions


        /// <summary>
        /// Modifies an association between a configuration set and a custom domain for open and
        /// click event tracking. 
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTrackingOptionsException">
        /// Indicates that the custom domain to be used for open and click tracking redirects
        /// is invalid. This error appears most often in the following situations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// When the tracking domain you specified is not verified in Amazon SES.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the tracking domain you specified is not a valid domain or subdomain.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsDoesNotExistException">
        /// Indicates that the TrackingOptions object you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        UpdateConfigurationSetTrackingOptionsResponse UpdateConfigurationSetTrackingOptions(UpdateConfigurationSetTrackingOptionsRequest request);



        /// <summary>
        /// Modifies an association between a configuration set and a custom domain for open and
        /// click event tracking. 
        /// 
        ///  
        /// <para>
        /// By default, images and links used for tracking open and click events are hosted on
        /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
        /// these events. For information about using custom domains, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetTrackingOptions service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.ConfigurationSetDoesNotExistException">
        /// Indicates that the configuration set does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTrackingOptionsException">
        /// Indicates that the custom domain to be used for open and click tracking redirects
        /// is invalid. This error appears most often in the following situations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// When the tracking domain you specified is not verified in Amazon SES.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the tracking domain you specified is not a valid domain or subdomain.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TrackingOptionsDoesNotExistException">
        /// Indicates that the TrackingOptions object you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        Task<UpdateConfigurationSetTrackingOptionsResponse> UpdateConfigurationSetTrackingOptionsAsync(UpdateConfigurationSetTrackingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate


        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailInvalidContentException">
        /// Indicates that custom verification email template provided content is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request);



        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomVerificationEmailTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailInvalidContentException">
        /// Indicates that custom verification email template provided content is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.CustomVerificationEmailTemplateDoesNotExistException">
        /// Indicates that a custom verification email template with the name you specified does
        /// not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.FromEmailAddressNotVerifiedException">
        /// Indicates that the sender address specified for a custom verification email is not
        /// verified, and is therefore not eligible to send the custom verification email.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        Task<UpdateCustomVerificationEmailTemplateResponse> UpdateCustomVerificationEmailTemplateAsync(UpdateCustomVerificationEmailTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReceiptRule


        /// <summary>
        /// Updates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule service method.</param>
        /// 
        /// <returns>The response from the UpdateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided Amazon Web Services Lambda function is invalid, or that
        /// Amazon SES could not execute the provided function, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or Amazon Web Services KMS encryption
        /// key is invalid, or that Amazon SES could not publish to the bucket, possibly due to
        /// permissions issues. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        UpdateReceiptRuleResponse UpdateReceiptRule(UpdateReceiptRuleRequest request);



        /// <summary>
        /// Updates a receipt rule.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReceiptRule service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidLambdaFunctionException">
        /// Indicates that the provided Amazon Web Services Lambda function is invalid, or that
        /// Amazon SES could not execute the provided function, possibly due to permissions issues.
        /// For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidS3ConfigurationException">
        /// Indicates that the provided Amazon S3 bucket or Amazon Web Services KMS encryption
        /// key is invalid, or that Amazon SES could not publish to the bucket, possibly due to
        /// permissions issues. For information about giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidSnsTopicException">
        /// Indicates that the provided Amazon SNS topic is invalid, or that Amazon SES could
        /// not publish to the topic, possibly due to permissions issues. For information about
        /// giving permissions, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-permissions.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.LimitExceededException">
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        Task<UpdateReceiptRuleResponse> UpdateReceiptRuleAsync(UpdateReceiptRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single operation. For more information, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTemplateException">
        /// Indicates that the template that you specified could not be rendered. This issue may
        /// occur when a template refers to a partial that does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);



        /// <summary>
        /// Updates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single operation. For more information, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.InvalidTemplateException">
        /// Indicates that the template that you specified could not be rendered. This issue may
        /// occur when a template refers to a partial that does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.TemplateDoesNotExistException">
        /// Indicates that the Template object you specified does not exist in your Amazon SES
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyDomainDkim


        /// <summary>
        /// Returns a set of DKIM tokens for a domain identity.
        /// 
        ///  <important> 
        /// <para>
        /// When you execute the <c>VerifyDomainDkim</c> operation, the domain that you specify
        /// is added to the list of identities that are associated with your account. This is
        /// true even if you haven't already associated the domain with your account by using
        /// the <c>VerifyDomainIdentity</c> operation. However, you can't send email from the
        /// domain until you either successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#verify-domain-procedure">verify
        /// it</a> or you successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">set
        /// up DKIM for it</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You use the tokens that are generated by this operation to create CNAME records. When
        /// Amazon SES detects that you've added these records to the DNS configuration for a
        /// domain, you can start sending email from that domain. You can start sending email
        /// even if you haven't added the TXT record provided by the VerifyDomainIdentity operation
        /// to the DNS configuration for your domain. All email that you send from the domain
        /// is authenticated using DKIM.
        /// </para>
        ///  
        /// <para>
        /// To create the CNAME records for DKIM authentication, use the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Name</b>: <i>token</i>._domainkey.<i>example.com</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Type</b>: CNAME
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Value</b>: <i>token</i>.dkim.amazonses.com
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the preceding example, replace <i>token</i> with one of the tokens that are generated
        /// when you execute this operation. Replace <i>example.com</i> with your domain. Repeat
        /// this process for each token that's generated by this operation.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request);



        /// <summary>
        /// Returns a set of DKIM tokens for a domain identity.
        /// 
        ///  <important> 
        /// <para>
        /// When you execute the <c>VerifyDomainDkim</c> operation, the domain that you specify
        /// is added to the list of identities that are associated with your account. This is
        /// true even if you haven't already associated the domain with your account by using
        /// the <c>VerifyDomainIdentity</c> operation. However, you can't send email from the
        /// domain until you either successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#verify-domain-procedure">verify
        /// it</a> or you successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">set
        /// up DKIM for it</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You use the tokens that are generated by this operation to create CNAME records. When
        /// Amazon SES detects that you've added these records to the DNS configuration for a
        /// domain, you can start sending email from that domain. You can start sending email
        /// even if you haven't added the TXT record provided by the VerifyDomainIdentity operation
        /// to the DNS configuration for your domain. All email that you send from the domain
        /// is authenticated using DKIM.
        /// </para>
        ///  
        /// <para>
        /// To create the CNAME records for DKIM authentication, use the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Name</b>: <i>token</i>._domainkey.<i>example.com</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Type</b>: CNAME
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Value</b>: <i>token</i>.dkim.amazonses.com
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the preceding example, replace <i>token</i> with one of the tokens that are generated
        /// when you execute this operation. Replace <i>example.com</i> with your domain. Repeat
        /// this process for each token that's generated by this operation.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyDomainIdentity


        /// <summary>
        /// Adds a domain to the list of identities for your Amazon SES account in the current
        /// Amazon Web Services Region and attempts to verify it. For more information about verifying
        /// domains, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request);



        /// <summary>
        /// Adds a domain to the list of identities for your Amazon SES account in the current
        /// Amazon Web Services Region and attempts to verify it. For more information about verifying
        /// domains, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyEmailAddress


        /// <summary>
        /// Deprecated. Use the <c>VerifyEmailIdentity</c> operation to verify a new email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request);



        /// <summary>
        /// Deprecated. Use the <c>VerifyEmailIdentity</c> operation to verify a new email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyEmailIdentity


        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request);



        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}