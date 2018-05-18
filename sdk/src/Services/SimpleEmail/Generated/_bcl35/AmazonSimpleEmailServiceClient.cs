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
using System.Collections.Generic;

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
    ///  This document contains reference information for the <a href="https://aws.amazon.com/ses/">Amazon
    /// Simple Email Service</a> (Amazon SES) API, version 2010-12-01. This document is best
    /// used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions
    /// and Amazon SES</a> in the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonSimpleEmailServiceClient : AmazonServiceClient, IAmazonSimpleEmailService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        public virtual CloneReceiptRuleSetResponse CloneReceiptRuleSet(CloneReceiptRuleSetRequest request)
        {
            var marshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CloneReceiptRuleSetRequest,CloneReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloneReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginCloneReceiptRuleSet(CloneReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<CloneReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CloneReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  CloneReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        public virtual CloneReceiptRuleSetResponse EndCloneReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CloneReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfigurationSet

        /// <summary>
        /// Creates a configuration set.
        /// 
        ///  
        /// <para>
        /// Configuration sets enable you to publish email sending events. For information about
        /// using configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationSet(CreateConfigurationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConfigurationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSet.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual CreateConfigurationSetResponse EndCreateConfigurationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationSetResponse>(asyncResult);
        }

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
        /// An event destination is the AWS service to which Amazon SES publishes the email sending
        /// events associated with a configuration set. For information about using configuration
        /// sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetEventDestinationResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual CreateConfigurationSetEventDestinationResponse EndCreateConfigurationSetEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationSetEventDestinationResponse>(asyncResult);
        }

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
        /// these events. For information about using custom domains, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/configure-custom-open-click-domains.html">Amazon
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
        public virtual CreateConfigurationSetTrackingOptionsResponse CreateConfigurationSetTrackingOptions(CreateConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetTrackingOptionsRequest,CreateConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSetTrackingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationSetTrackingOptions(CreateConfigurationSetTrackingOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSetTrackingOptions.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetTrackingOptionsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        public virtual CreateConfigurationSetTrackingOptionsResponse EndCreateConfigurationSetTrackingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationSetTrackingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate

        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateCustomVerificationEmailTemplateRequest,CreateCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateCustomVerificationEmailTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual CreateCustomVerificationEmailTemplateResponse EndCreateCustomVerificationEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomVerificationEmailTemplateResponse>(asyncResult);
        }

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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        public virtual CreateReceiptFilterResponse CreateReceiptFilter(CreateReceiptFilterRequest request)
        {
            var marshaller = CreateReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptFilterRequest,CreateReceiptFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReceiptFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateReceiptFilter(CreateReceiptFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReceiptFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReceiptFilter.</param>
        /// 
        /// <returns>Returns a  CreateReceiptFilterResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        public virtual CreateReceiptFilterResponse EndCreateReceiptFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReceiptFilterResponse>(asyncResult);
        }

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
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        public virtual CreateReceiptRuleResponse CreateReceiptRule(CreateReceiptRuleRequest request)
        {
            var marshaller = CreateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleRequest,CreateReceiptRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReceiptRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        public virtual IAsyncResult BeginCreateReceiptRule(CreateReceiptRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReceiptRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReceiptRule.</param>
        /// 
        /// <returns>Returns a  CreateReceiptRuleResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        public virtual CreateReceiptRuleResponse EndCreateReceiptRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReceiptRuleResponse>(asyncResult);
        }

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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        public virtual CreateReceiptRuleSetResponse CreateReceiptRuleSet(CreateReceiptRuleSetRequest request)
        {
            var marshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleSetRequest,CreateReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginCreateReceiptRuleSet(CreateReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  CreateReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        public virtual CreateReceiptRuleSetResponse EndCreateReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplate

        /// <summary>
        /// Creates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
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
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var marshaller = CreateTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateRequest,CreateTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        /// <summary>
        /// Deletes a configuration set. Configuration sets enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
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
        public virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationSet(DeleteConfigurationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConfigurationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual DeleteConfigurationSetResponse EndDeleteConfigurationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        /// <summary>
        /// Deletes a configuration set event destination. Configuration set event destinations
        /// are associated with configuration sets, which enable you to publish email sending
        /// events. For information about using configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
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
        public virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetEventDestinationResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual DeleteConfigurationSetEventDestinationResponse EndDeleteConfigurationSetEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationSetEventDestinationResponse>(asyncResult);
        }

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
        /// these events. For information about using custom domains, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/configure-custom-open-click-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleting this kind of association will result in emails sent using the specified configuration
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
        public virtual DeleteConfigurationSetTrackingOptionsResponse DeleteConfigurationSetTrackingOptions(DeleteConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetTrackingOptionsRequest,DeleteConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSetTrackingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationSetTrackingOptions(DeleteConfigurationSetTrackingOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSetTrackingOptions.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetTrackingOptionsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        public virtual DeleteConfigurationSetTrackingOptionsResponse EndDeleteConfigurationSetTrackingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationSetTrackingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate

        /// <summary>
        /// Deletes an existing custom verification email template. 
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        public virtual DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomVerificationEmailTemplateRequest,DeleteCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteCustomVerificationEmailTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        public virtual DeleteCustomVerificationEmailTemplateResponse EndDeleteCustomVerificationEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomVerificationEmailTemplateResponse>(asyncResult);
        }

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
        public virtual DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request)
        {
            var marshaller = DeleteIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityRequest,DeleteIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdentity(DeleteIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        public virtual DeleteIdentityResponse EndDeleteIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdentityPolicy

        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (an email
        /// address or a domain). This API returns successfully even if a policy with the specified
        /// name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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
        public virtual DeleteIdentityPolicyResponse DeleteIdentityPolicy(DeleteIdentityPolicyRequest request)
        {
            var marshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPolicyRequest,DeleteIdentityPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdentityPolicy(DeleteIdentityPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIdentityPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityPolicyResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        public virtual DeleteIdentityPolicyResponse EndDeleteIdentityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityPolicyResponse>(asyncResult);
        }

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
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteReceiptFilter service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        public virtual DeleteReceiptFilterResponse DeleteReceiptFilter(DeleteReceiptFilterRequest request)
        {
            var marshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptFilterRequest,DeleteReceiptFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReceiptFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteReceiptFilter(DeleteReceiptFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteReceiptFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReceiptFilter.</param>
        /// 
        /// <returns>Returns a  DeleteReceiptFilterResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        public virtual DeleteReceiptFilterResponse EndDeleteReceiptFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReceiptFilterResponse>(asyncResult);
        }

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
        public virtual DeleteReceiptRuleResponse DeleteReceiptRule(DeleteReceiptRuleRequest request)
        {
            var marshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleRequest,DeleteReceiptRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReceiptRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteReceiptRule(DeleteReceiptRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteReceiptRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReceiptRule.</param>
        /// 
        /// <returns>Returns a  DeleteReceiptRuleResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        public virtual DeleteReceiptRuleResponse EndDeleteReceiptRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReceiptRuleResponse>(asyncResult);
        }

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
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
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
        public virtual DeleteReceiptRuleSetResponse DeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request)
        {
            var marshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleSetRequest,DeleteReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  DeleteReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        public virtual DeleteReceiptRuleSetResponse EndDeleteReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReceiptRuleSetResponse>(asyncResult);
        }

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
        public virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var marshaller = DeleteTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateRequest,DeleteTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        /// <summary>
        /// Deprecated. Use the <code>DeleteIdentity</code> operation to delete email addresses
        /// and domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        public virtual DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request)
        {
            var marshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return Invoke<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVerifiedEmailAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        public virtual IAsyncResult BeginDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVerifiedEmailAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVerifiedEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVerifiedEmailAddress.</param>
        /// 
        /// <returns>Returns a  DeleteVerifiedEmailAddressResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        public virtual DeleteVerifiedEmailAddressResponse EndDeleteVerifiedEmailAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVerifiedEmailAddressResponse>(asyncResult);
        }

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
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet service method.</param>
        /// 
        /// <returns>The response from the DescribeActiveReceiptRuleSet service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        public virtual DescribeActiveReceiptRuleSetResponse DescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request)
        {
            var marshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeActiveReceiptRuleSetRequest,DescribeActiveReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActiveReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginDescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeActiveReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActiveReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  DescribeActiveReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        public virtual DescribeActiveReceiptRuleSetResponse EndDescribeActiveReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActiveReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationSet

        /// <summary>
        /// Returns the details of the specified configuration set. For information about using
        /// configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
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
        public virtual DescribeConfigurationSetResponse DescribeConfigurationSet(DescribeConfigurationSetRequest request)
        {
            var marshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSetRequest,DescribeConfigurationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationSet(DescribeConfigurationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigurationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        public virtual DescribeConfigurationSetResponse EndDescribeConfigurationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationSetResponse>(asyncResult);
        }

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
        public virtual DescribeReceiptRuleResponse DescribeReceiptRule(DescribeReceiptRuleRequest request)
        {
            var marshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleRequest,DescribeReceiptRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReceiptRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeReceiptRule(DescribeReceiptRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReceiptRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReceiptRule.</param>
        /// 
        /// <returns>Returns a  DescribeReceiptRuleResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        public virtual DescribeReceiptRuleResponse EndDescribeReceiptRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReceiptRuleResponse>(asyncResult);
        }

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
        public virtual DescribeReceiptRuleSetResponse DescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request)
        {
            var marshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleSetRequest,DescribeReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginDescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  DescribeReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        public virtual DescribeReceiptRuleSetResponse EndDescribeReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSendingEnabled

        /// <summary>
        /// Returns the email sending status of the Amazon SES account for the current region.
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
        public virtual GetAccountSendingEnabledResponse GetAccountSendingEnabled(GetAccountSendingEnabledRequest request)
        {
            var marshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<GetAccountSendingEnabledRequest,GetAccountSendingEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSendingEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSendingEnabled(GetAccountSendingEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountSendingEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSendingEnabled.</param>
        /// 
        /// <returns>Returns a  GetAccountSendingEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        public virtual GetAccountSendingEnabledResponse EndGetAccountSendingEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSendingEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomVerificationEmailTemplate

        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        public virtual GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCustomVerificationEmailTemplateRequest,GetCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<GetCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetCustomVerificationEmailTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        public virtual GetCustomVerificationEmailTemplateResponse EndGetCustomVerificationEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomVerificationEmailTemplateResponse>(asyncResult);
        }

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
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        public virtual GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request)
        {
            var marshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityDkimAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityDkimAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityDkimAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityDkimAttributesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        public virtual GetIdentityDkimAttributesResponse EndGetIdentityDkimAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityDkimAttributesResponse>(asyncResult);
        }

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
        public virtual GetIdentityMailFromDomainAttributesResponse GetIdentityMailFromDomainAttributes(GetIdentityMailFromDomainAttributesRequest request)
        {
            var marshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityMailFromDomainAttributesRequest,GetIdentityMailFromDomainAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityMailFromDomainAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityMailFromDomainAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityMailFromDomainAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityMailFromDomainAttributes(GetIdentityMailFromDomainAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityMailFromDomainAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityMailFromDomainAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityMailFromDomainAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityMailFromDomainAttributesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        public virtual GetIdentityMailFromDomainAttributesResponse EndGetIdentityMailFromDomainAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityMailFromDomainAttributesResponse>(asyncResult);
        }

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
        /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        public virtual GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request)
        {
            var marshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityNotificationAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityNotificationAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityNotificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityNotificationAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityNotificationAttributesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        public virtual GetIdentityNotificationAttributesResponse EndGetIdentityNotificationAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityNotificationAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityPolicies

        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (an email
        /// address or a domain). The policies are returned as a map of policy names to policy
        /// contents. You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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
        public virtual GetIdentityPoliciesResponse GetIdentityPolicies(GetIdentityPoliciesRequest request)
        {
            var marshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoliciesRequest,GetIdentityPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityPolicies(GetIdentityPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityPolicies.</param>
        /// 
        /// <returns>Returns a  GetIdentityPoliciesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        public virtual GetIdentityPoliciesResponse EndGetIdentityPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityPoliciesResponse>(asyncResult);
        }

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
        /// the verification status changes to "Failed." In that case, if you still want to verify
        /// the email address, you must restart the verification process from the beginning.
        /// </para>
        ///  
        /// <para>
        /// For domain identities, the domain's verification status is "Pending" as Amazon SES
        /// searches for the required TXT record in the DNS settings of the domain. When Amazon
        /// SES detects the record, the domain's verification status changes to "Success". If
        /// Amazon SES is unable to detect the record within 72 hours, the domain's verification
        /// status changes to "Failed." In that case, if you still want to verify the domain,
        /// you must restart the verification process from the beginning.
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
        public virtual GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request)
        {
            var marshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityVerificationAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityVerificationAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityVerificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityVerificationAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityVerificationAttributesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        public virtual GetIdentityVerificationAttributesResponse EndGetIdentityVerificationAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityVerificationAttributesResponse>(asyncResult);
        }

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
        public virtual GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }

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
        public virtual GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request)
        {
            var marshaller = GetSendQuotaRequestMarshaller.Instance;
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return Invoke<GetSendQuotaRequest,GetSendQuotaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendQuota
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual IAsyncResult BeginGetSendQuota(GetSendQuotaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSendQuotaRequestMarshaller.Instance;
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return BeginInvoke<GetSendQuotaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSendQuota operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendQuota.</param>
        /// 
        /// <returns>Returns a  GetSendQuotaResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual GetSendQuotaResponse EndGetSendQuota(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSendQuotaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSendStatistics

        /// <summary>
        /// Provides sending statistics for the current AWS Region. The result is a list of data
        /// points, representing the last two weeks of sending activity. Each data point in the
        /// list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }

        /// <summary>
        /// Provides sending statistics for the current AWS Region. The result is a list of data
        /// points, representing the last two weeks of sending activity. Each data point in the
        /// list contains statistics for a 15-minute period of time.
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
        public virtual GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request)
        {
            var marshaller = GetSendStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetSendStatisticsRequest,GetSendStatisticsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetSendStatistics(GetSendStatisticsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSendStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSendStatisticsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSendStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendStatistics.</param>
        /// 
        /// <returns>Returns a  GetSendStatisticsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual GetSendStatisticsResponse EndGetSendStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSendStatisticsResponse>(asyncResult);
        }

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
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var marshaller = GetTemplateRequestMarshaller.Instance;
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateRequest,GetTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTemplateRequestMarshaller.Instance;
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<GetTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationSets

        /// <summary>
        /// Provides a list of the configuration sets associated with your Amazon SES account
        /// in the current AWS Region. For information about using configuration sets, see <a
        /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Monitoring
        /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second. This operation will return
        /// up to 1,000 configuration sets each time it is run. If your Amazon SES account has
        /// more than 1,000 configuration sets, this operation will also return a NextToken element.
        /// You can then execute the <code>ListConfigurationSets</code> operation again, passing
        /// the <code>NextToken</code> parameter and the value of the NextToken element to retrieve
        /// additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsRequest,ListConfigurationSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationSets(ListConfigurationSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListConfigurationSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationSets.</param>
        /// 
        /// <returns>Returns a  ListConfigurationSetsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual ListConfigurationSetsResponse EndListConfigurationSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomVerificationEmailTemplates

        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// AWS Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        public virtual ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request)
        {
            var marshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCustomVerificationEmailTemplatesRequest,ListCustomVerificationEmailTemplatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomVerificationEmailTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        public virtual IAsyncResult BeginListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListCustomVerificationEmailTemplatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomVerificationEmailTemplates.</param>
        /// 
        /// <returns>Returns a  ListCustomVerificationEmailTemplatesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        public virtual ListCustomVerificationEmailTemplatesResponse EndListCustomVerificationEmailTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomVerificationEmailTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your AWS account in the current AWS Region, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual ListIdentitiesResponse ListIdentities()
        {
            return ListIdentities(new ListIdentitiesRequest());
        }

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your AWS account in the current AWS Region, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual IAsyncResult BeginListIdentities(ListIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentities.</param>
        /// 
        /// <returns>Returns a  ListIdentitiesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual ListIdentitiesResponse EndListIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityPolicies

        /// <summary>
        /// Returns a list of sending authorization policies that are attached to the given identity
        /// (an email address or a domain). This API returns only a list. If you want the actual
        /// policy content, you can use <code>GetIdentityPolicies</code>.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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
        public virtual ListIdentityPoliciesResponse ListIdentityPolicies(ListIdentityPoliciesRequest request)
        {
            var marshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoliciesRequest,ListIdentityPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        public virtual IAsyncResult BeginListIdentityPolicies(ListIdentityPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentityPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPolicies.</param>
        /// 
        /// <returns>Returns a  ListIdentityPoliciesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        public virtual ListIdentityPoliciesResponse EndListIdentityPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReceiptFilters

        /// <summary>
        /// Lists the IP address filters associated with your AWS account in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// For information about managing IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-ip-filters.html">Amazon
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
        public virtual ListReceiptFiltersResponse ListReceiptFilters(ListReceiptFiltersRequest request)
        {
            var marshaller = ListReceiptFiltersRequestMarshaller.Instance;
            var unmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return Invoke<ListReceiptFiltersRequest,ListReceiptFiltersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceiptFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        public virtual IAsyncResult BeginListReceiptFilters(ListReceiptFiltersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListReceiptFiltersRequestMarshaller.Instance;
            var unmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return BeginInvoke<ListReceiptFiltersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceiptFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceiptFilters.</param>
        /// 
        /// <returns>Returns a  ListReceiptFiltersResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        public virtual ListReceiptFiltersResponse EndListReceiptFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReceiptFiltersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReceiptRuleSets

        /// <summary>
        /// Lists the receipt rule sets that exist under your AWS account in the current AWS Region.
        /// If there are additional receipt rule sets to be retrieved, you will receive a <code>NextToken</code>
        /// that you can provide to the next call to <code>ListReceiptRuleSets</code> to retrieve
        /// the additional entries.
        /// 
        ///  
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
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
        public virtual ListReceiptRuleSetsResponse ListReceiptRuleSets(ListReceiptRuleSetsRequest request)
        {
            var marshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            var unmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListReceiptRuleSetsRequest,ListReceiptRuleSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceiptRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        public virtual IAsyncResult BeginListReceiptRuleSets(ListReceiptRuleSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            var unmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListReceiptRuleSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceiptRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceiptRuleSets.</param>
        /// 
        /// <returns>Returns a  ListReceiptRuleSetsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        public virtual ListReceiptRuleSetsResponse EndListReceiptRuleSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReceiptRuleSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplates

        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current AWS Region.
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
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var marshaller = ListTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesRequest,ListTemplatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTemplatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        /// <summary>
        /// Deprecated. Use the <code>ListIdentities</code> operation to list the email addresses
        /// and domains associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }

        /// <summary>
        /// Deprecated. Use the <code>ListIdentities</code> operation to list the email addresses
        /// and domains associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request)
        {
            var marshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return Invoke<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVerifiedEmailAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual IAsyncResult BeginListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<ListVerifiedEmailAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVerifiedEmailAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVerifiedEmailAddresses.</param>
        /// 
        /// <returns>Returns a  ListVerifiedEmailAddressesResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual ListVerifiedEmailAddressesResponse EndListVerifiedEmailAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVerifiedEmailAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutIdentityPolicy

        /// <summary>
        /// Adds or updates a sending authorization policy for the specified identity (an email
        /// address or a domain).
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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
        public virtual PutIdentityPolicyResponse PutIdentityPolicy(PutIdentityPolicyRequest request)
        {
            var marshaller = PutIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<PutIdentityPolicyRequest,PutIdentityPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIdentityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutIdentityPolicy(PutIdentityPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutIdentityPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIdentityPolicy.</param>
        /// 
        /// <returns>Returns a  PutIdentityPolicyResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        public virtual PutIdentityPolicyResponse EndPutIdentityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutIdentityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ReorderReceiptRuleSet

        /// <summary>
        /// Reorders the receipt rules within a receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// All of the rules in the rule set must be represented in this request. That is, this
        /// API will return an error if the reorder request doesn't explicitly position all of
        /// the rules.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
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
        public virtual ReorderReceiptRuleSetResponse ReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request)
        {
            var marshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<ReorderReceiptRuleSetRequest,ReorderReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReorderReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReorderReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<ReorderReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReorderReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReorderReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  ReorderReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        public virtual ReorderReceiptRuleSetResponse EndReorderReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ReorderReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  SendBounce

        /// <summary>
        /// Generates and sends a bounce message to the sender of an email you received through
        /// Amazon SES. You can only use this API on an email up to 24 hours after you receive
        /// it.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use this API to send generic bounces for mail that was not received by
        /// Amazon SES.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about receiving email through Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email.html">Amazon
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
        public virtual SendBounceResponse SendBounce(SendBounceRequest request)
        {
            var marshaller = SendBounceRequestMarshaller.Instance;
            var unmarshaller = SendBounceResponseUnmarshaller.Instance;

            return Invoke<SendBounceRequest,SendBounceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendBounce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBounce operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendBounce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        public virtual IAsyncResult BeginSendBounce(SendBounceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendBounceRequestMarshaller.Instance;
            var unmarshaller = SendBounceResponseUnmarshaller.Instance;

            return BeginInvoke<SendBounceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendBounce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendBounce.</param>
        /// 
        /// <returns>Returns a  SendBounceResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        public virtual SendBounceResponse EndSendBounce(IAsyncResult asyncResult)
        {
            return EndInvoke<SendBounceResponse>(asyncResult);
        }

        #endregion
        
        #region  SendBulkTemplatedEmail

        /// <summary>
        /// Composes an email message to multiple destinations. The message body is created using
        /// an email template.
        /// 
        ///  
        /// <para>
        /// In order to send email using the <code>SendBulkTemplatedEmail</code> operation, your
        /// call to the API must meet the following requirements:
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
        /// Simulator. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total size of the message, including attachments, must be less than 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each <code>Destination</code> parameter must include at least one recipient email
        /// address. The recipient address can be a To: address, a CC: address, or a BCC: address.
        /// If a recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message will be rejected, even if the message contains other recipients
        /// that are valid.
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
        /// the custom MAIL FROM domain settings for an identity, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
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
        public virtual SendBulkTemplatedEmailResponse SendBulkTemplatedEmail(SendBulkTemplatedEmailRequest request)
        {
            var marshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendBulkTemplatedEmailRequest,SendBulkTemplatedEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendBulkTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBulkTemplatedEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendBulkTemplatedEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        public virtual IAsyncResult BeginSendBulkTemplatedEmail(SendBulkTemplatedEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendBulkTemplatedEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendBulkTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendBulkTemplatedEmail.</param>
        /// 
        /// <returns>Returns a  SendBulkTemplatedEmailResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        public virtual SendBulkTemplatedEmailResponse EndSendBulkTemplatedEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendBulkTemplatedEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SendCustomVerificationEmail

        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current AWS Region and attempts to verify it. As a result of executing this operation,
        /// a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        public virtual SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request)
        {
            var marshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            var unmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return Invoke<SendCustomVerificationEmailRequest,SendCustomVerificationEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCustomVerificationEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        public virtual IAsyncResult BeginSendCustomVerificationEmail(SendCustomVerificationEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            var unmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendCustomVerificationEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCustomVerificationEmail.</param>
        /// 
        /// <returns>Returns a  SendCustomVerificationEmailResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        public virtual SendCustomVerificationEmailResponse EndSendCustomVerificationEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendCustomVerificationEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SendEmail

        /// <summary>
        /// Composes an email message and immediately queues it for sending. In order to send
        /// email using the <code>SendEmail</code> operation, your message must meet the following
        /// requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain. If you attempt to
        /// send email using a non-verified address or domain, the operation will result in an
        /// "Email address not verified" error. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total size of the message, including attachments, must be smaller than 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must include at least one recipient email address. The recipient address
        /// can be a To: address, a CC: address, or a BCC: address. If a recipient email address
        /// is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message will be rejected, even if the message contains other recipients
        /// that are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <code>SendEmail</code>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Managing
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
        /// the custom MAIL FROM domain settings for an identity, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailRequest,SendEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual IAsyncResult BeginSendEmail(SendEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a  SendEmailResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual SendEmailResponse EndSendEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SendRawEmail

        /// <summary>
        /// Composes an email message and immediately queues it for sending. When calling this
        /// operation, you may specify the message headers as well as the content. The <code>SendRawEmail</code>
        /// operation is particularly useful for sending multipart MIME emails (such as those
        /// that contain both a plain-text and an HTML version). 
        /// 
        ///  
        /// <para>
        /// In order to send email using the <code>SendRawEmail</code> operation, your message
        /// must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message must be sent from a verified email address or domain. If you attempt to
        /// send email using a non-verified address or domain, the operation will result in an
        /// "Email address not verified" error. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account is still in the Amazon SES sandbox, you may only send to verified
        /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
        /// Simulator. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total size of the message, including attachments, must be smaller than 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message must include at least one recipient email address. The recipient address
        /// can be a To: address, a CC: address, or a BCC: address. If a recipient email address
        /// is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message will be rejected, even if the message contains other recipients
        /// that are valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
        /// fields. If you need to send an email message to a larger audience, you can divide
        /// your recipient list into groups of 50 or fewer, and then call the <code>SendRawEmail</code>
        /// operation several times to send the message to each group.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// For every message that you send, the total number of recipients (including each recipient
        /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
        /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
        /// sending quotas in Amazon SES, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Managing
        /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </important> 
        /// <para>
        /// Additionally, keep the following considerations in mind when using the <code>SendRawEmail</code>
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although you can customize the message headers when using the <code>SendRawEmail</code>
        /// operation, Amazon SES will automatically apply its own <code>Message-ID</code> and
        /// <code>Date</code> headers; if you passed these headers when creating the message,
        /// they will be overwritten by the values that Amazon SES provides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using sending authorization to send on behalf of another user, <code>SendRawEmail</code>
        /// enables you to specify the cross-account identity for the email's Source, From, and
        /// Return-Path parameters in one of two ways: you can pass optional parameters <code>SourceArn</code>,
        /// <code>FromArn</code>, and/or <code>ReturnPathArn</code> to the API, or you can include
        /// the following X-headers in the header of your raw email:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>X-SES-SOURCE-ARN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>X-SES-FROM-ARN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>X-SES-RETURN-PATH-ARN</code> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not include these X-headers in the DKIM signature; Amazon SES will remove them
        /// before sending the email.
        /// </para>
        ///  </important> 
        /// <para>
        /// For most common sending authorization scenarios, we recommend that you specify the
        /// <code>SourceIdentityArn</code> parameter and not the <code>FromIdentityArn</code>
        /// or <code>ReturnPathIdentityArn</code> parameters. If you only specify the <code>SourceIdentityArn</code>
        /// parameter, Amazon SES will set the From and Return Path addresses to the identity
        /// specified in <code>SourceIdentityArn</code>. For more information about sending authorization,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Using
        /// Sending Authorization with Amazon SES</a> in the <i>Amazon SES Developer Guide.</i>
        /// 
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
        /// the custom MAIL FROM domain settings for an identity, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more information about what caused the error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        public virtual SendRawEmailResponse SendRawEmail(SendRawEmailRequest request)
        {
            var marshaller = SendRawEmailRequestMarshaller.Instance;
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return Invoke<SendRawEmailRequest,SendRawEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendRawEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        public virtual IAsyncResult BeginSendRawEmail(SendRawEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendRawEmailRequestMarshaller.Instance;
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendRawEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendRawEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendRawEmail.</param>
        /// 
        /// <returns>Returns a  SendRawEmailResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        public virtual SendRawEmailResponse EndSendRawEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendRawEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SendTemplatedEmail

        /// <summary>
        /// Composes an email message using an email template and immediately queues it for sending.
        /// 
        ///  
        /// <para>
        /// In order to send email using the <code>SendTemplatedEmail</code> operation, your call
        /// to the API must meet the following requirements:
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
        /// Simulator. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
        /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total size of the message, including attachments, must be less than 10 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to the <code>SendTemplatedEmail</code> operation may only include one <code>Destination</code>
        /// parameter. A destination is a set of recipients who will receive the same version
        /// of the email. The <code>Destination</code> parameter can include up to 50 recipients,
        /// across the To:, CC: and BCC: fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Destination</code> parameter must include at least one recipient email address.
        /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
        /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
        /// the entire message will be rejected, even if the message contains other recipients
        /// that are valid.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If your call to the <code>SendTemplatedEmail</code> operation includes all of the
        /// required parameters, Amazon SES accepts it and returns a Message ID. However, if Amazon
        /// SES can't render the email because the template contains errors, it doesn't send the
        /// email. Additionally, because it already accepted the message, Amazon SES doesn't return
        /// a message stating that it was unable to send the email.
        /// </para>
        ///  
        /// <para>
        /// For these reasons, we highly recommend that you set up Amazon SES to send you notifications
        /// when Rendering Failure events occur. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Sending
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
        /// the custom MAIL FROM domain settings for an identity, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-edit.html">Amazon
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
        public virtual SendTemplatedEmailResponse SendTemplatedEmail(SendTemplatedEmailRequest request)
        {
            var marshaller = SendTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendTemplatedEmailRequest,SendTemplatedEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTemplatedEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTemplatedEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        public virtual IAsyncResult BeginSendTemplatedEmail(SendTemplatedEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SendTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendTemplatedEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTemplatedEmail.</param>
        /// 
        /// <returns>Returns a  SendTemplatedEmailResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        public virtual SendTemplatedEmailResponse EndSendTemplatedEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendTemplatedEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SetActiveReceiptRuleSet

        /// <summary>
        /// Sets the specified receipt rule set as the active receipt rule set.
        /// 
        ///  <note> 
        /// <para>
        /// To disable your email-receiving through Amazon SES completely, you can call this API
        /// with RuleSetName set to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about managing receipt rule sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
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
        public virtual SetActiveReceiptRuleSetResponse SetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request)
        {
            var marshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<SetActiveReceiptRuleSetRequest,SetActiveReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetActiveReceiptRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        public virtual IAsyncResult BeginSetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke<SetActiveReceiptRuleSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetActiveReceiptRuleSet.</param>
        /// 
        /// <returns>Returns a  SetActiveReceiptRuleSetResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        public virtual SetActiveReceiptRuleSetResponse EndSetActiveReceiptRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<SetActiveReceiptRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityDkimEnabled

        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Easy DKIM signing is enabled for a domain name identity (such as <code>example.com</code>),
        /// then Amazon SES will DKIM-sign all email sent by addresses under that domain name
        /// (for example, <code>user@example.com</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Easy DKIM signing is enabled for an email address, then Amazon SES will DKIM-sign
        /// all email sent by that email address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For email addresses (for example, <code>user@example.com</code>), you can only enable
        /// Easy DKIM signing if the corresponding domain (in this case, <code>example.com</code>)
        /// has been set up for Easy DKIM using the AWS Console or the <code>VerifyDomainDkim</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        public virtual SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request)
        {
            var marshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityDkimEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        public virtual IAsyncResult BeginSetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityDkimEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityDkimEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityDkimEnabled.</param>
        /// 
        /// <returns>Returns a  SetIdentityDkimEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        public virtual SetIdentityDkimEnabledResponse EndSetIdentityDkimEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityDkimEnabledResponse>(asyncResult);
        }

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
        /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        public virtual SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request)
        {
            var marshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityFeedbackForwardingEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        public virtual IAsyncResult BeginSetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityFeedbackForwardingEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityFeedbackForwardingEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityFeedbackForwardingEnabled.</param>
        /// 
        /// <returns>Returns a  SetIdentityFeedbackForwardingEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        public virtual SetIdentityFeedbackForwardingEnabledResponse EndSetIdentityFeedbackForwardingEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityFeedbackForwardingEnabledResponse>(asyncResult);
        }

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
        /// For more information about using notifications with Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityHeadersInNotificationsEnabled service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        public virtual SetIdentityHeadersInNotificationsEnabledResponse SetIdentityHeadersInNotificationsEnabled(SetIdentityHeadersInNotificationsEnabledRequest request)
        {
            var marshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityHeadersInNotificationsEnabledRequest,SetIdentityHeadersInNotificationsEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityHeadersInNotificationsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityHeadersInNotificationsEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        public virtual IAsyncResult BeginSetIdentityHeadersInNotificationsEnabled(SetIdentityHeadersInNotificationsEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityHeadersInNotificationsEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityHeadersInNotificationsEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityHeadersInNotificationsEnabled.</param>
        /// 
        /// <returns>Returns a  SetIdentityHeadersInNotificationsEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        public virtual SetIdentityHeadersInNotificationsEnabledResponse EndSetIdentityHeadersInNotificationsEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityHeadersInNotificationsEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityMailFromDomain

        /// <summary>
        /// Enables or disables the custom MAIL FROM domain setup for a verified identity (an
        /// email address or a domain).
        /// 
        ///  <important> 
        /// <para>
        /// To send emails using the specified MAIL FROM domain, you must add an MX record to
        /// your MAIL FROM domain's DNS settings. If you want your emails to pass Sender Policy
        /// Framework (SPF) checks, you must also add or update an SPF record. For more information,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mail-from-set.html">Amazon
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
        public virtual SetIdentityMailFromDomainResponse SetIdentityMailFromDomain(SetIdentityMailFromDomainRequest request)
        {
            var marshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            var unmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return Invoke<SetIdentityMailFromDomainRequest,SetIdentityMailFromDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityMailFromDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityMailFromDomain operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityMailFromDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        public virtual IAsyncResult BeginSetIdentityMailFromDomain(SetIdentityMailFromDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            var unmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityMailFromDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityMailFromDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityMailFromDomain.</param>
        /// 
        /// <returns>Returns a  SetIdentityMailFromDomainResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        public virtual SetIdentityMailFromDomainResponse EndSetIdentityMailFromDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityMailFromDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityNotificationTopic

        /// <summary>
        /// Given an identity (an email address or a domain), sets the Amazon Simple Notification
        /// Service (Amazon SNS) topic to which Amazon SES will publish bounce, complaint, and/or
        /// delivery notifications for emails sent with that identity as the <code>Source</code>.
        /// 
        ///  <note> 
        /// <para>
        /// Unless feedback forwarding is enabled, you must specify Amazon SNS topics for bounce
        /// and complaint notifications. For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can execute this operation no more than once per second.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        public virtual SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request)
        {
            var marshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return Invoke<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityNotificationTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        public virtual IAsyncResult BeginSetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityNotificationTopicRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityNotificationTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityNotificationTopic.</param>
        /// 
        /// <returns>Returns a  SetIdentityNotificationTopicResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        public virtual SetIdentityNotificationTopicResponse EndSetIdentityNotificationTopic(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityNotificationTopicResponse>(asyncResult);
        }

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
        public virtual SetReceiptRulePositionResponse SetReceiptRulePosition(SetReceiptRulePositionRequest request)
        {
            var marshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            var unmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return Invoke<SetReceiptRulePositionRequest,SetReceiptRulePositionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetReceiptRulePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetReceiptRulePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        public virtual IAsyncResult BeginSetReceiptRulePosition(SetReceiptRulePositionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            var unmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return BeginInvoke<SetReceiptRulePositionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetReceiptRulePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetReceiptRulePosition.</param>
        /// 
        /// <returns>Returns a  SetReceiptRulePositionResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        public virtual SetReceiptRulePositionResponse EndSetReceiptRulePosition(IAsyncResult asyncResult)
        {
            return EndInvoke<SetReceiptRulePositionResponse>(asyncResult);
        }

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
        public virtual TestRenderTemplateResponse TestRenderTemplate(TestRenderTemplateRequest request)
        {
            var marshaller = TestRenderTemplateRequestMarshaller.Instance;
            var unmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return Invoke<TestRenderTemplateRequest,TestRenderTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestRenderTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRenderTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRenderTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        public virtual IAsyncResult BeginTestRenderTemplate(TestRenderTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TestRenderTemplateRequestMarshaller.Instance;
            var unmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<TestRenderTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestRenderTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRenderTemplate.</param>
        /// 
        /// <returns>Returns a  TestRenderTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        public virtual TestRenderTemplateResponse EndTestRenderTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<TestRenderTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountSendingEnabled

        /// <summary>
        /// Enables or disables email sending across your entire Amazon SES account in the current
        /// AWS Region. You can use this operation in conjunction with Amazon CloudWatch alarms
        /// to temporarily pause email sending across your Amazon SES account in a given AWS Region
        /// when reputation metrics (such as your bounce or complaint rates) reach certain thresholds.
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
        public virtual UpdateAccountSendingEnabledResponse UpdateAccountSendingEnabled(UpdateAccountSendingEnabledRequest request)
        {
            var marshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSendingEnabledRequest,UpdateAccountSendingEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSendingEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountSendingEnabled(UpdateAccountSendingEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAccountSendingEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSendingEnabled.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSendingEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        public virtual UpdateAccountSendingEnabledResponse EndUpdateAccountSendingEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountSendingEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        /// <summary>
        /// Updates the event destination of a configuration set. Event destinations are associated
        /// with configuration sets, which enable you to publish email sending events to Amazon
        /// CloudWatch, Amazon Kinesis Firehose, or Amazon Simple Notification Service (Amazon
        /// SNS). For information about using configuration sets, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Monitoring
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
        public virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetEventDestinationResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual UpdateConfigurationSetEventDestinationResponse EndUpdateConfigurationSetEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationSetEventDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationSetReputationMetricsEnabled

        /// <summary>
        /// Enables or disables the publishing of reputation metrics for emails sent using a specific
        /// configuration set in a given AWS Region. Reputation metrics include bounce and complaint
        /// rates. These metrics are published to Amazon CloudWatch. By using CloudWatch, you
        /// can create alarms when bounce or complaint rates exceed certain thresholds.
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
        public virtual UpdateConfigurationSetReputationMetricsEnabledResponse UpdateConfigurationSetReputationMetricsEnabled(UpdateConfigurationSetReputationMetricsEnabledRequest request)
        {
            var marshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetReputationMetricsEnabledRequest,UpdateConfigurationSetReputationMetricsEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetReputationMetricsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetReputationMetricsEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetReputationMetricsEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationSetReputationMetricsEnabled(UpdateConfigurationSetReputationMetricsEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConfigurationSetReputationMetricsEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetReputationMetricsEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetReputationMetricsEnabled.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetReputationMetricsEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        public virtual UpdateConfigurationSetReputationMetricsEnabledResponse EndUpdateConfigurationSetReputationMetricsEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationSetReputationMetricsEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationSetSendingEnabled

        /// <summary>
        /// Enables or disables email sending for messages sent using a specific configuration
        /// set in a given AWS Region. You can use this operation in conjunction with Amazon CloudWatch
        /// alarms to temporarily pause email sending for a configuration set when the reputation
        /// metrics for that configuration set (such as your bounce on complaint rate) exceed
        /// certain thresholds.
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
        public virtual UpdateConfigurationSetSendingEnabledResponse UpdateConfigurationSetSendingEnabled(UpdateConfigurationSetSendingEnabledRequest request)
        {
            var marshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetSendingEnabledRequest,UpdateConfigurationSetSendingEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetSendingEnabled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationSetSendingEnabled(UpdateConfigurationSetSendingEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConfigurationSetSendingEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetSendingEnabled.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetSendingEnabledResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        public virtual UpdateConfigurationSetSendingEnabledResponse EndUpdateConfigurationSetSendingEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationSetSendingEnabledResponse>(asyncResult);
        }

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
        /// these events. For information about using custom domains, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/configure-custom-open-click-domains.html">Amazon
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
        public virtual UpdateConfigurationSetTrackingOptionsResponse UpdateConfigurationSetTrackingOptions(UpdateConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetTrackingOptionsRequest,UpdateConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetTrackingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationSetTrackingOptions(UpdateConfigurationSetTrackingOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetTrackingOptions.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetTrackingOptionsResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        public virtual UpdateConfigurationSetTrackingOptionsResponse EndUpdateConfigurationSetTrackingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationSetTrackingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate

        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/custom-verification-emails.html">Using
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
        public virtual UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomVerificationEmailTemplateRequest,UpdateCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateCustomVerificationEmailTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        public virtual UpdateCustomVerificationEmailTemplateResponse EndUpdateCustomVerificationEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomVerificationEmailTemplateResponse>(asyncResult);
        }

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
        /// You can execute this operation no more than once per second.
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
        /// Indicates that a resource could not be created because of service limits. For a list
        /// of Amazon SES limits, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/limits.html">Amazon
        /// SES Developer Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleDoesNotExistException">
        /// Indicates that the provided receipt rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmail.Model.RuleSetDoesNotExistException">
        /// Indicates that the provided receipt rule set does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        public virtual UpdateReceiptRuleResponse UpdateReceiptRule(UpdateReceiptRuleRequest request)
        {
            var marshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateReceiptRuleRequest,UpdateReceiptRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReceiptRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateReceiptRule(UpdateReceiptRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateReceiptRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReceiptRule.</param>
        /// 
        /// <returns>Returns a  UpdateReceiptRuleResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        public virtual UpdateReceiptRuleResponse EndUpdateReceiptRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReceiptRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplate

        /// <summary>
        /// Updates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
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
        public virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var marshaller = UpdateTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateRequest,UpdateTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateResponse>(asyncResult);
        }

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
        /// You can execute this operation no more than once per second.
        /// </para>
        ///  
        /// <para>
        /// To enable or disable Easy DKIM signing for a domain, use the <code>SetIdentityDkimEnabled</code>
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        public virtual VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request)
        {
            var marshaller = VerifyDomainDkimRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainDkimRequest,VerifyDomainDkimResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDomainDkim
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        public virtual IAsyncResult BeginVerifyDomainDkim(VerifyDomainDkimRequest request, AsyncCallback callback, object state)
        {
            var marshaller = VerifyDomainDkimRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyDomainDkimRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyDomainDkim operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainDkim.</param>
        /// 
        /// <returns>Returns a  VerifyDomainDkimResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        public virtual VerifyDomainDkimResponse EndVerifyDomainDkim(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyDomainDkimResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyDomainIdentity

        /// <summary>
        /// Adds a domain to the list of identities for your Amazon SES account in the current
        /// AWS Region and attempts to verify it. For more information about verifying domains,
        /// see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
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
        public virtual VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request)
        {
            var marshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDomainIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        public virtual IAsyncResult BeginVerifyDomainIdentity(VerifyDomainIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyDomainIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyDomainIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainIdentity.</param>
        /// 
        /// <returns>Returns a  VerifyDomainIdentityResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        public virtual VerifyDomainIdentityResponse EndVerifyDomainIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyDomainIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyEmailAddress

        /// <summary>
        /// Deprecated. Use the <code>VerifyEmailIdentity</code> operation to verify a new email
        /// address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        public virtual VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request)
        {
            var marshaller = VerifyEmailAddressRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailAddressRequest,VerifyEmailAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyEmailAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        public virtual IAsyncResult BeginVerifyEmailAddress(VerifyEmailAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = VerifyEmailAddressRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyEmailAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailAddress.</param>
        /// 
        /// <returns>Returns a  VerifyEmailAddressResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        public virtual VerifyEmailAddressResponse EndVerifyEmailAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyEmailAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyEmailIdentity

        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current AWS region and attempts to verify it. As a result of executing this operation,
        /// a verification email is sent to the specified address.
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
        public virtual VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request)
        {
            var marshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        public virtual IAsyncResult BeginVerifyEmailIdentity(VerifyEmailIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyEmailIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailIdentity.</param>
        /// 
        /// <returns>Returns a  VerifyEmailIdentityResult from SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        public virtual VerifyEmailIdentityResponse EndVerifyEmailIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyEmailIdentityResponse>(asyncResult);
        }

        #endregion
        
    }
}