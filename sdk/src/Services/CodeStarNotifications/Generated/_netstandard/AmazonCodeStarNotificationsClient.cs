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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeStarNotifications.Model;
using Amazon.CodeStarNotifications.Model.Internal.MarshallTransformations;
using Amazon.CodeStarNotifications.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CodeStarNotifications
{
    /// <summary>
    /// <para>Implementation for accessing CodeStarNotifications</para>
    ///
    /// This AWS CodeStar Notifications API Reference provides descriptions and usage examples
    /// of the operations and data types for the AWS CodeStar Notifications API. You can use
    /// the AWS CodeStar Notifications API to work with the following objects:
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
    ///  For information about how to use AWS CodeStar Notifications, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/what-is-dtconsole.html">Amazon
    /// Web Services Developer Tools Console User Guide</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonCodeStarNotificationsClient : AmazonServiceClient, IAmazonCodeStarNotifications
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeStarNotificationsMetadata();
        
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
            : base(new AmazonCodeStarNotificationsConfig()) { }

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
            : base(new AmazonCodeStarNotificationsConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeStarNotificationsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeStarNotificationsAuthSchemeHandler());
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

        internal virtual CreateNotificationRuleResponse CreateNotificationRule(CreateNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a notification rule for a resource. The rule specifies the events you want
        /// notifications about and the targets (such as Chatbot topics or Chatbot clients configured
        /// for Slack) where you want to receive them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.AccessDeniedException">
        /// AWS CodeStar Notifications can't create the notification rule because you do not have
        /// sufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
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
        public virtual Task<CreateNotificationRuleResponse> CreateNotificationRuleAsync(CreateNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotificationRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNotificationRule

        internal virtual DeleteNotificationRuleResponse DeleteNotificationRule(DeleteNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a notification rule for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        public virtual Task<DeleteNotificationRuleResponse> DeleteNotificationRuleAsync(DeleteNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTarget

        internal virtual DeleteTargetResponse DeleteTarget(DeleteTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified target for notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTarget service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        public virtual Task<DeleteTargetResponse> DeleteTargetAsync(DeleteTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNotificationRule

        internal virtual DescribeNotificationRuleResponse DescribeNotificationRule(DescribeNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationRuleResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specified notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        public virtual Task<DescribeNotificationRuleResponse> DescribeNotificationRuleAsync(DescribeNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventTypes

        internal virtual ListEventTypesResponse ListEventTypes(ListEventTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTypesResponseUnmarshaller.Instance;

            return Invoke<ListEventTypesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the event types available for configuring notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEventTypesResponse> ListEventTypesAsync(ListEventTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNotificationRules

        internal virtual ListNotificationRulesResponse ListNotificationRules(ListNotificationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationRulesResponseUnmarshaller.Instance;

            return Invoke<ListNotificationRulesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the notification rules for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListNotificationRulesResponse> ListNotificationRulesAsync(ListNotificationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotificationRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the tags associated with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTargets

        internal virtual ListTargetsResponse ListTargets(ListTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;

            return Invoke<ListTargetsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the notification rule targets for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Subscribe

        internal virtual SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return Invoke<SubscribeResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between a notification rule and an Chatbot topic or Chatbot
        /// client so that the associated target can receive notifications when the events described
        /// in the rule are triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of provided tags with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Unsubscribe

        internal virtual UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeResponse>(request, options);
        }



        /// <summary>
        /// Removes an association between a notification rule and an Chatbot topic so that subscribers
        /// to that topic stop receiving notifications when the events described in the rule are
        /// triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between one or more provided tags and a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateNotificationRule

        internal virtual UpdateNotificationRuleResponse UpdateNotificationRule(UpdateNotificationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationRuleResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        public virtual Task<UpdateNotificationRuleResponse> UpdateNotificationRuleAsync(UpdateNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotificationRuleResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}