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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeStarNotifications.Model;
using Amazon.CodeStarNotifications.Model.Internal.MarshallTransformations;
using Amazon.CodeStarNotifications.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CodeStarNotifications
{
    /// <summary>
    /// <para>Implementation for accessing CodeStarNotifications</para>
    ///
    /// This CodeStar Notifications API Reference provides descriptions and usage examples
    /// of the operations and data types for the CodeStar Notifications API. You can use the
    /// CodeStar Notifications API to work with the following objects:
    /// 
    ///  
    /// <para>
    /// Notification rules, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateNotificationRule</a>, which creates a notification rule for a resource in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteNotificationRule</a>, which deletes a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeNotificationRule</a>, which provides information about a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListNotificationRules</a>, which lists the notification rules associated with
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateNotificationRule</a>, which changes the name, events, or targets associated
    /// with a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Subscribe</a>, which subscribes a target to a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Unsubscribe</a>, which removes a target from a notification rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Targets, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteTarget</a>, which removes a notification rule target from a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTargets</a>, which lists the targets associated with a notification rule.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Events, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListEventTypes</a>, which lists the event types you can include in a notification
    /// rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Tags, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which lists the tags already associated with a notification
    /// rule in your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which associates a tag you provide with a notification rule in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes a tag from a notification rule in your account.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For information about how to use CodeStar Notifications, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/what-is-dtconsole.html">Amazon
    /// Web Services Developer Tools Console User Guide</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonCodeStarNotificationsClient : AmazonServiceClient, IAmazonCodeStarNotifications
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeStarNotificationsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICodeStarNotificationsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeStarNotificationsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeStarNotificationsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with the credentials loaded from the application's
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
        public AmazonCodeStarNotificationsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarNotificationsConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with the credentials loaded from the application's
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
        public AmazonCodeStarNotificationsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarNotificationsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeStarNotificationsClient Configuration Object</param>
        public AmazonCodeStarNotificationsClient(AmazonCodeStarNotificationsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeStarNotificationsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeStarNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarNotificationsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeStarNotificationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Credentials and an
        /// AmazonCodeStarNotificationsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeStarNotificationsClient Configuration Object</param>
        public AmazonCodeStarNotificationsClient(AWSCredentials credentials, AmazonCodeStarNotificationsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarNotificationsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarNotificationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeStarNotificationsClient Configuration Object</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeStarNotificationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarNotificationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarNotificationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarNotificationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeStarNotificationsClient Configuration Object</param>
        public AmazonCodeStarNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeStarNotificationsConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeStarNotificationsEndpointResolver());
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


        #region  CreateNotificationRule

        /// <summary>
        /// Creates a notification rule for a resource. The rule specifies the events you want
        /// notifications about and the targets (such as Amazon Q Developer in chat applications
        /// topics or Amazon Q Developer in chat applications clients configured for Slack) where
        /// you want to receive them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.AccessDeniedException">
        /// CodeStar Notifications can't create the notification rule because you do not have
        /// sufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// CodeStar Notifications can't complete the request because the resource is being modified
        /// by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceAlreadyExistsException">
        /// A resource with the same name or ID already exists. Notification rule names must be
        /// unique in your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        public virtual CreateNotificationRuleResponse CreateNotificationRule(CreateNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        public virtual IAsyncResult BeginCreateNotificationRule(CreateNotificationRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationRule.</param>
        /// 
        /// <returns>Returns a  CreateNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        public virtual CreateNotificationRuleResponse EndCreateNotificationRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotificationRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNotificationRule

        /// <summary>
        /// Deletes a notification rule for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// CodeStar Notifications can't complete the request because the resource is being modified
        /// by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        public virtual DeleteNotificationRuleResponse DeleteNotificationRule(DeleteNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotificationRule(DeleteNotificationRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationRule.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        public virtual DeleteNotificationRuleResponse EndDeleteNotificationRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTarget

        /// <summary>
        /// Deletes a specified target for notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteTarget service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        public virtual DeleteTargetResponse DeleteTarget(DeleteTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        public virtual IAsyncResult BeginDeleteTarget(DeleteTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTarget.</param>
        /// 
        /// <returns>Returns a  DeleteTargetResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        public virtual DeleteTargetResponse EndDeleteTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotificationRule

        /// <summary>
        /// Returns information about a specified notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        public virtual DescribeNotificationRuleResponse DescribeNotificationRule(DescribeNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotificationRule(DescribeNotificationRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationRule.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        public virtual DescribeNotificationRuleResponse EndDescribeNotificationRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventTypes

        /// <summary>
        /// Returns information about the event types available for configuring notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes service method.</param>
        /// 
        /// <returns>The response from the ListEventTypes service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        public virtual ListEventTypesResponse ListEventTypes(ListEventTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTypesResponseUnmarshaller.Instance;

            return Invoke<ListEventTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        public virtual IAsyncResult BeginListEventTypes(ListEventTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventTypes.</param>
        /// 
        /// <returns>Returns a  ListEventTypesResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        public virtual ListEventTypesResponse EndListEventTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotificationRules

        /// <summary>
        /// Returns a list of the notification rules for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules service method.</param>
        /// 
        /// <returns>The response from the ListNotificationRules service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        public virtual ListNotificationRulesResponse ListNotificationRules(ListNotificationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationRulesResponseUnmarshaller.Instance;

            return Invoke<ListNotificationRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        public virtual IAsyncResult BeginListNotificationRules(ListNotificationRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationRules.</param>
        /// 
        /// <returns>Returns a  ListNotificationRulesResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        public virtual ListNotificationRulesResponse EndListNotificationRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags associated with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTargets

        /// <summary>
        /// Returns a list of the notification rule targets for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// 
        /// <returns>The response from the ListTargets service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        public virtual ListTargetsResponse ListTargets(ListTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;

            return Invoke<ListTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargets operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        public virtual IAsyncResult BeginListTargets(ListTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargets.</param>
        /// 
        /// <returns>Returns a  ListTargetsResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        public virtual ListTargetsResponse EndListTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  Subscribe

        /// <summary>
        /// Creates an association between a notification rule and an Amazon Q Developer in chat
        /// applications topic or Amazon Q Developer in chat applications client so that the associated
        /// target can receive notifications when the events described in the rule are triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return Invoke<SubscribeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual IAsyncResult BeginSubscribe(SubscribeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Subscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a  SubscribeResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual SubscribeResponse EndSubscribe(IAsyncResult asyncResult)
        {
            return EndInvoke<SubscribeResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates a set of provided tags with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// CodeStar Notifications can't complete the request because the resource is being modified
        /// by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  Unsubscribe

        /// <summary>
        /// Removes an association between a notification rule and an Amazon Q Developer in chat
        /// applications topic so that subscribers to that topic stop receiving notifications
        /// when the events described in the rule are triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual IAsyncResult BeginUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        /// 
        /// <returns>Returns a  UnsubscribeResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult)
        {
            return EndInvoke<UnsubscribeResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the association between one or more provided tags and a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// CodeStar Notifications can't complete the request because the resource is being modified
        /// by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotificationRule

        /// <summary>
        /// Updates a notification rule for a resource. You can change the events that trigger
        /// the notification rule, the status of the rule, and the targets that receive the notifications.
        /// 
        ///  <note> 
        /// <para>
        /// To add or remove tags for a notification rule, you must use <a>TagResource</a> and
        /// <a>UntagResource</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationRule service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        public virtual UpdateNotificationRuleResponse UpdateNotificationRule(UpdateNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationRule operation on AmazonCodeStarNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotificationRule(UpdateNotificationRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationRule.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationRuleResult from CodeStarNotifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        public virtual UpdateNotificationRuleResponse EndUpdateNotificationRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationRuleResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonCodeStarNotificationsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}