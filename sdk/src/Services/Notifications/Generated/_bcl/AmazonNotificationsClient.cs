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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Notifications.Model;
using Amazon.Notifications.Model.Internal.MarshallTransformations;
using Amazon.Notifications.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Notifications
{
    /// <summary>
    /// <para>Implementation for accessing Notifications</para>
    ///
    /// The <i>User Notifications API Reference</i> provides descriptions, API request parameters,
    /// and the JSON response for each of the User Notifications API actions.
    /// 
    ///  
    /// <para>
    /// User Notification control plane APIs are currently available in US East (Virginia)
    /// - <c>us-east-1</c>.
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/notifications/latest/APIReference/API_GetNotificationEvent.html">GetNotificationEvent</a>
    /// and <a href="https://docs.aws.amazon.com/notifications/latest/APIReference/API_ListNotificationEvents.html">ListNotificationEvents</a>
    /// APIs are currently available in <a href="https://docs.aws.amazon.com/notifications/latest/userguide/supported-regions.html">commercial
    /// partition Regions</a> and only return notifications stored in the same Region in which
    /// they're called.
    /// </para>
    ///  
    /// <para>
    /// The User Notifications console can only be used in US East (Virginia). Your data however,
    /// is stored in each Region chosen as a <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">notification
    /// hub</a> in addition to US East (Virginia).
    /// </para>
    ///  <note> 
    /// <para>
    /// For information about descriptions, API request parameters, and the JSON response
    /// for email contact related API actions, see the <a href="https://docs.aws.amazon.com/notificationscontacts/latest/APIReference/Welcome.html">User
    /// Notifications Contacts API Reference Guide</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonNotificationsClient : AmazonServiceClient, IAmazonNotifications
    {
        private static IServiceMetadata serviceMetadata = new AmazonNotificationsMetadata();
        private INotificationsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INotificationsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NotificationsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonNotificationsClient with the credentials loaded from the application's
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
        public AmazonNotificationsClient()
            : base(new AmazonNotificationsConfig()) { }

        /// <summary>
        /// Constructs AmazonNotificationsClient with the credentials loaded from the application's
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
        public AmazonNotificationsClient(RegionEndpoint region)
            : base(new AmazonNotificationsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNotificationsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNotificationsClient Configuration Object</param>
        public AmazonNotificationsClient(AmazonNotificationsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNotificationsClient(AWSCredentials credentials)
            : this(credentials, new AmazonNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNotificationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Credentials and an
        /// AmazonNotificationsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNotificationsClient Configuration Object</param>
        public AmazonNotificationsClient(AWSCredentials credentials, AmazonNotificationsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNotificationsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNotificationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNotificationsClient Configuration Object</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNotificationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNotificationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNotificationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNotificationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNotificationsClient Configuration Object</param>
        public AmazonNotificationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNotificationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNotificationsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNotificationsAuthSchemeHandler());
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


        #region  AssociateChannel


        /// <summary>
        /// Associates a delivery <a href="https://docs.aws.amazon.com/notifications/latest/userguide/managing-delivery-channels.html">Channel</a>
        /// with a particular <c>NotificationConfiguration</c>. Supported Channels include Amazon
        /// Q Developer in chat applications, the Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel service method.</param>
        /// 
        /// <returns>The response from the AssociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        public virtual AssociateChannelResponse AssociateChannel(AssociateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelResponseUnmarshaller.Instance;

            return Invoke<AssociateChannelResponse>(request, options);
        }


        /// <summary>
        /// Associates a delivery <a href="https://docs.aws.amazon.com/notifications/latest/userguide/managing-delivery-channels.html">Channel</a>
        /// with a particular <c>NotificationConfiguration</c>. Supported Channels include Amazon
        /// Q Developer in chat applications, the Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        public virtual Task<AssociateChannelResponse> AssociateChannelAsync(AssociateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateManagedNotificationAccountContact


        /// <summary>
        /// Associates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAccountContact service method.</param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAccountContact">REST API Reference for AssociateManagedNotificationAccountContact Operation</seealso>
        public virtual AssociateManagedNotificationAccountContactResponse AssociateManagedNotificationAccountContact(AssociateManagedNotificationAccountContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedNotificationAccountContactResponse>(request, options);
        }


        /// <summary>
        /// Associates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAccountContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAccountContact">REST API Reference for AssociateManagedNotificationAccountContact Operation</seealso>
        public virtual Task<AssociateManagedNotificationAccountContactResponse> AssociateManagedNotificationAccountContactAsync(AssociateManagedNotificationAccountContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAccountContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateManagedNotificationAccountContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateManagedNotificationAdditionalChannel


        /// <summary>
        /// Associates an additional Channel with a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAdditionalChannel service method.</param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAdditionalChannel">REST API Reference for AssociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual AssociateManagedNotificationAdditionalChannelResponse AssociateManagedNotificationAdditionalChannel(AssociateManagedNotificationAdditionalChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedNotificationAdditionalChannelResponse>(request, options);
        }


        /// <summary>
        /// Associates an additional Channel with a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAdditionalChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAdditionalChannel">REST API Reference for AssociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual Task<AssociateManagedNotificationAdditionalChannelResponse> AssociateManagedNotificationAdditionalChannelAsync(AssociateManagedNotificationAdditionalChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateManagedNotificationAdditionalChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateOrganizationalUnit


        /// <summary>
        /// Associates an organizational unit with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the AssociateOrganizationalUnit service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateOrganizationalUnit">REST API Reference for AssociateOrganizationalUnit Operation</seealso>
        public virtual AssociateOrganizationalUnitResponse AssociateOrganizationalUnit(AssociateOrganizationalUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<AssociateOrganizationalUnitResponse>(request, options);
        }


        /// <summary>
        /// Associates an organizational unit with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOrganizationalUnit service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateOrganizationalUnit">REST API Reference for AssociateOrganizationalUnit Operation</seealso>
        public virtual Task<AssociateOrganizationalUnitResponse> AssociateOrganizationalUnitAsync(AssociateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOrganizationalUnitResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventRule


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">
        /// <c>EventRule</c> </a> that is associated with a specified <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule service method.</param>
        /// 
        /// <returns>The response from the CreateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        public virtual CreateEventRuleResponse CreateEventRule(CreateEventRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventRuleResponseUnmarshaller.Instance;

            return Invoke<CreateEventRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">
        /// <c>EventRule</c> </a> that is associated with a specified <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        public virtual Task<CreateEventRuleResponse> CreateEventRuleAsync(CreateEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotificationConfiguration


        /// <summary>
        /// Creates a new <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a new <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventRule


        /// <summary>
        /// Deletes an <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule service method.</param>
        /// 
        /// <returns>The response from the DeleteEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        public virtual DeleteEventRuleResponse DeleteEventRule(DeleteEventRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteEventRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes an <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        public virtual Task<DeleteEventRuleResponse> DeleteEventRuleAsync(DeleteEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterNotificationHub


        /// <summary>
        /// Deregisters a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't deregister the last <c>NotificationHub</c> in the account. <c>NotificationEvents</c>
        /// stored in the deregistered <c>NotificationConfiguration</c> are no longer be visible.
        /// Recreating a new <c>NotificationConfiguration</c> in the same Region restores access
        /// to those <c>NotificationEvents</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub service method.</param>
        /// 
        /// <returns>The response from the DeregisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        public virtual DeregisterNotificationHubResponse DeregisterNotificationHub(DeregisterNotificationHubRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNotificationHubResponseUnmarshaller.Instance;

            return Invoke<DeregisterNotificationHubResponse>(request, options);
        }


        /// <summary>
        /// Deregisters a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't deregister the last <c>NotificationHub</c> in the account. <c>NotificationEvents</c>
        /// stored in the deregistered <c>NotificationConfiguration</c> are no longer be visible.
        /// Recreating a new <c>NotificationConfiguration</c> in the same Region restores access
        /// to those <c>NotificationEvents</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        public virtual Task<DeregisterNotificationHubResponse> DeregisterNotificationHubAsync(DeregisterNotificationHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNotificationHubResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterNotificationHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableNotificationsAccessForOrganization


        /// <summary>
        /// Disables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableNotificationsAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the DisableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisableNotificationsAccessForOrganization">REST API Reference for DisableNotificationsAccessForOrganization Operation</seealso>
        public virtual DisableNotificationsAccessForOrganizationResponse DisableNotificationsAccessForOrganization(DisableNotificationsAccessForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DisableNotificationsAccessForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Disables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisableNotificationsAccessForOrganization">REST API Reference for DisableNotificationsAccessForOrganization Operation</seealso>
        public virtual Task<DisableNotificationsAccessForOrganizationResponse> DisableNotificationsAccessForOrganizationAsync(DisableNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableNotificationsAccessForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateChannel


        /// <summary>
        /// Disassociates a Channel from a specified <c>NotificationConfiguration</c>. Supported
        /// Channels include Amazon Q Developer in chat applications, the Console Mobile Application,
        /// and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel service method.</param>
        /// 
        /// <returns>The response from the DisassociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        public virtual DisassociateChannelResponse DisassociateChannel(DisassociateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelResponseUnmarshaller.Instance;

            return Invoke<DisassociateChannelResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a Channel from a specified <c>NotificationConfiguration</c>. Supported
        /// Channels include Amazon Q Developer in chat applications, the Console Mobile Application,
        /// and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        public virtual Task<DisassociateChannelResponse> DisassociateChannelAsync(DisassociateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateManagedNotificationAccountContact


        /// <summary>
        /// Disassociates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAccountContact service method.</param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAccountContact">REST API Reference for DisassociateManagedNotificationAccountContact Operation</seealso>
        public virtual DisassociateManagedNotificationAccountContactResponse DisassociateManagedNotificationAccountContact(DisassociateManagedNotificationAccountContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedNotificationAccountContactResponse>(request, options);
        }


        /// <summary>
        /// Disassociates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAccountContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAccountContact">REST API Reference for DisassociateManagedNotificationAccountContact Operation</seealso>
        public virtual Task<DisassociateManagedNotificationAccountContactResponse> DisassociateManagedNotificationAccountContactAsync(DisassociateManagedNotificationAccountContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAccountContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateManagedNotificationAccountContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateManagedNotificationAdditionalChannel


        /// <summary>
        /// Disassociates an additional Channel from a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAdditionalChannel service method.</param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAdditionalChannel">REST API Reference for DisassociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual DisassociateManagedNotificationAdditionalChannelResponse DisassociateManagedNotificationAdditionalChannel(DisassociateManagedNotificationAdditionalChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedNotificationAdditionalChannelResponse>(request, options);
        }


        /// <summary>
        /// Disassociates an additional Channel from a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAdditionalChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAdditionalChannel">REST API Reference for DisassociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual Task<DisassociateManagedNotificationAdditionalChannelResponse> DisassociateManagedNotificationAdditionalChannelAsync(DisassociateManagedNotificationAdditionalChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateManagedNotificationAdditionalChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateOrganizationalUnit


        /// <summary>
        /// Removes the association between an organizational unit and a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the DisassociateOrganizationalUnit service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateOrganizationalUnit">REST API Reference for DisassociateOrganizationalUnit Operation</seealso>
        public virtual DisassociateOrganizationalUnitResponse DisassociateOrganizationalUnit(DisassociateOrganizationalUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DisassociateOrganizationalUnitResponse>(request, options);
        }


        /// <summary>
        /// Removes the association between an organizational unit and a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOrganizationalUnit service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateOrganizationalUnit">REST API Reference for DisassociateOrganizationalUnit Operation</seealso>
        public virtual Task<DisassociateOrganizationalUnitResponse> DisassociateOrganizationalUnitAsync(DisassociateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOrganizationalUnitResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableNotificationsAccessForOrganization


        /// <summary>
        /// Enables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableNotificationsAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/EnableNotificationsAccessForOrganization">REST API Reference for EnableNotificationsAccessForOrganization Operation</seealso>
        public virtual EnableNotificationsAccessForOrganizationResponse EnableNotificationsAccessForOrganization(EnableNotificationsAccessForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableNotificationsAccessForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Enables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/EnableNotificationsAccessForOrganization">REST API Reference for EnableNotificationsAccessForOrganization Operation</seealso>
        public virtual Task<EnableNotificationsAccessForOrganizationResponse> EnableNotificationsAccessForOrganizationAsync(EnableNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableNotificationsAccessForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventRule


        /// <summary>
        /// Returns a specified <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule service method.</param>
        /// 
        /// <returns>The response from the GetEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        public virtual GetEventRuleResponse GetEventRule(GetEventRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventRuleResponseUnmarshaller.Instance;

            return Invoke<GetEventRuleResponse>(request, options);
        }


        /// <summary>
        /// Returns a specified <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        public virtual Task<GetEventRuleResponse> GetEventRuleAsync(GetEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedNotificationChildEvent


        /// <summary>
        /// Returns the child event of a specific given <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationChildEvent service method.</param>
        /// 
        /// <returns>The response from the GetManagedNotificationChildEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationChildEvent">REST API Reference for GetManagedNotificationChildEvent Operation</seealso>
        public virtual GetManagedNotificationChildEventResponse GetManagedNotificationChildEvent(GetManagedNotificationChildEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationChildEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationChildEventResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationChildEventResponse>(request, options);
        }


        /// <summary>
        /// Returns the child event of a specific given <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationChildEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationChildEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationChildEvent">REST API Reference for GetManagedNotificationChildEvent Operation</seealso>
        public virtual Task<GetManagedNotificationChildEventResponse> GetManagedNotificationChildEventAsync(GetManagedNotificationChildEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationChildEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationChildEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedNotificationChildEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedNotificationConfiguration


        /// <summary>
        /// Returns a specified <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetManagedNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationConfiguration">REST API Reference for GetManagedNotificationConfiguration Operation</seealso>
        public virtual GetManagedNotificationConfigurationResponse GetManagedNotificationConfiguration(GetManagedNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns a specified <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationConfiguration">REST API Reference for GetManagedNotificationConfiguration Operation</seealso>
        public virtual Task<GetManagedNotificationConfigurationResponse> GetManagedNotificationConfigurationAsync(GetManagedNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedNotificationEvent


        /// <summary>
        /// Returns a specified <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationEvent service method.</param>
        /// 
        /// <returns>The response from the GetManagedNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationEvent">REST API Reference for GetManagedNotificationEvent Operation</seealso>
        public virtual GetManagedNotificationEventResponse GetManagedNotificationEvent(GetManagedNotificationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationEventResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationEventResponse>(request, options);
        }


        /// <summary>
        /// Returns a specified <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationEvent">REST API Reference for GetManagedNotificationEvent Operation</seealso>
        public virtual Task<GetManagedNotificationEventResponse> GetManagedNotificationEventAsync(GetManagedNotificationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetManagedNotificationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationConfiguration


        /// <summary>
        /// Returns a specified <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns a specified <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationEvent


        /// <summary>
        /// Returns a specified <c>NotificationEvent</c>.
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. <c>GetNotificationEvent</c>
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent service method.</param>
        /// 
        /// <returns>The response from the GetNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        public virtual GetNotificationEventResponse GetNotificationEvent(GetNotificationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationEventResponseUnmarshaller.Instance;

            return Invoke<GetNotificationEventResponse>(request, options);
        }


        /// <summary>
        /// Returns a specified <c>NotificationEvent</c>.
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. <c>GetNotificationEvent</c>
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        public virtual Task<GetNotificationEventResponse> GetNotificationEventAsync(GetNotificationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNotificationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationsAccessForOrganization


        /// <summary>
        /// Returns the AccessStatus of Service Trust Enablement for User Notifications and Amazon
        /// Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationsAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationsAccessForOrganization">REST API Reference for GetNotificationsAccessForOrganization Operation</seealso>
        public virtual GetNotificationsAccessForOrganizationResponse GetNotificationsAccessForOrganization(GetNotificationsAccessForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationsAccessForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns the AccessStatus of Service Trust Enablement for User Notifications and Amazon
        /// Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationsAccessForOrganization">REST API Reference for GetNotificationsAccessForOrganization Operation</seealso>
        public virtual Task<GetNotificationsAccessForOrganizationResponse> GetNotificationsAccessForOrganizationAsync(GetNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationsAccessForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNotificationsAccessForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Returns a list of Channels for a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Channels for a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventRules


        /// <summary>
        /// Returns a list of <c>EventRules</c> according to specified filters, in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules service method.</param>
        /// 
        /// <returns>The response from the ListEventRules service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        public virtual ListEventRulesResponse ListEventRules(ListEventRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventRulesResponseUnmarshaller.Instance;

            return Invoke<ListEventRulesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>EventRules</c> according to specified filters, in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventRules service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        public virtual Task<ListEventRulesResponse> ListEventRulesAsync(ListEventRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedNotificationChannelAssociations


        /// <summary>
        /// Returns a list of Account contacts and Channels associated with a <c>ManagedNotificationConfiguration</c>,
        /// in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChannelAssociations service method.</param>
        /// 
        /// <returns>The response from the ListManagedNotificationChannelAssociations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChannelAssociations">REST API Reference for ListManagedNotificationChannelAssociations Operation</seealso>
        public virtual ListManagedNotificationChannelAssociationsResponse ListManagedNotificationChannelAssociations(ListManagedNotificationChannelAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationChannelAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Account contacts and Channels associated with a <c>ManagedNotificationConfiguration</c>,
        /// in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChannelAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationChannelAssociations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChannelAssociations">REST API Reference for ListManagedNotificationChannelAssociations Operation</seealso>
        public virtual Task<ListManagedNotificationChannelAssociationsResponse> ListManagedNotificationChannelAssociationsAsync(ListManagedNotificationChannelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChannelAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedNotificationChannelAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedNotificationChildEvents


        /// <summary>
        /// Returns a list of <c>ManagedNotificationChildEvents</c> for a specified aggregate
        /// <c>ManagedNotificationEvent</c>, ordered by creation time in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChildEvents service method.</param>
        /// 
        /// <returns>The response from the ListManagedNotificationChildEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChildEvents">REST API Reference for ListManagedNotificationChildEvents Operation</seealso>
        public virtual ListManagedNotificationChildEventsResponse ListManagedNotificationChildEvents(ListManagedNotificationChildEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChildEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChildEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationChildEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>ManagedNotificationChildEvents</c> for a specified aggregate
        /// <c>ManagedNotificationEvent</c>, ordered by creation time in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChildEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationChildEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChildEvents">REST API Reference for ListManagedNotificationChildEvents Operation</seealso>
        public virtual Task<ListManagedNotificationChildEventsResponse> ListManagedNotificationChildEventsAsync(ListManagedNotificationChildEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChildEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChildEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedNotificationChildEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedNotificationConfigurations


        /// <summary>
        /// Returns a list of Managed Notification Configurations according to specified filters,
        /// ordered by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListManagedNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationConfigurations">REST API Reference for ListManagedNotificationConfigurations Operation</seealso>
        public virtual ListManagedNotificationConfigurationsResponse ListManagedNotificationConfigurations(ListManagedNotificationConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Managed Notification Configurations according to specified filters,
        /// ordered by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationConfigurations">REST API Reference for ListManagedNotificationConfigurations Operation</seealso>
        public virtual Task<ListManagedNotificationConfigurationsResponse> ListManagedNotificationConfigurationsAsync(ListManagedNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedNotificationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedNotificationEvents


        /// <summary>
        /// Returns a list of Managed Notification Events according to specified filters, ordered
        /// by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationEvents service method.</param>
        /// 
        /// <returns>The response from the ListManagedNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationEvents">REST API Reference for ListManagedNotificationEvents Operation</seealso>
        public virtual ListManagedNotificationEventsResponse ListManagedNotificationEvents(ListManagedNotificationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Managed Notification Events according to specified filters, ordered
        /// by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationEvents">REST API Reference for ListManagedNotificationEvents Operation</seealso>
        public virtual Task<ListManagedNotificationEventsResponse> ListManagedNotificationEventsAsync(ListManagedNotificationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListManagedNotificationEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMemberAccounts


        /// <summary>
        /// Returns a list of member accounts associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of member accounts associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMemberAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotificationConfigurations


        /// <summary>
        /// Returns a list of abbreviated <c>NotificationConfigurations</c> according to specified
        /// filters, in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual ListNotificationConfigurationsResponse ListNotificationConfigurations(ListNotificationConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of abbreviated <c>NotificationConfigurations</c> according to specified
        /// filters, in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual Task<ListNotificationConfigurationsResponse> ListNotificationConfigurationsAsync(ListNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotificationEvents


        /// <summary>
        /// Returns a list of <c>NotificationEvents</c> according to specified filters, in reverse
        /// chronological order (newest first).
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. ListNotificationEvents
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents service method.</param>
        /// 
        /// <returns>The response from the ListNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        public virtual ListNotificationEventsResponse ListNotificationEvents(ListNotificationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationEventsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>NotificationEvents</c> according to specified filters, in reverse
        /// chronological order (newest first).
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. ListNotificationEvents
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        public virtual Task<ListNotificationEventsResponse> ListNotificationEventsAsync(ListNotificationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotificationHubs


        /// <summary>
        /// Returns a list of <c>NotificationHubs</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs service method.</param>
        /// 
        /// <returns>The response from the ListNotificationHubs service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        public virtual ListNotificationHubsResponse ListNotificationHubs(ListNotificationHubsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationHubsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationHubsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>NotificationHubs</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationHubs service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        public virtual Task<ListNotificationHubsResponse> ListNotificationHubsAsync(ListNotificationHubsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationHubsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationHubsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationalUnits


        /// <summary>
        /// Returns a list of organizational units associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnits service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationalUnits service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListOrganizationalUnits">REST API Reference for ListOrganizationalUnits Operation</seealso>
        public virtual ListOrganizationalUnitsResponse ListOrganizationalUnits(ListOrganizationalUnitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationalUnitsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of organizational units associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationalUnits service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListOrganizationalUnits">REST API Reference for ListOrganizationalUnits Operation</seealso>
        public virtual Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(ListOrganizationalUnitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationalUnitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterNotificationHub


        /// <summary>
        /// Registers a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  
        /// <para>
        /// There is a maximum of one <c>NotificationConfiguration</c> per Region. You can have
        /// a maximum of 3 <c>NotificationHub</c> resources at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub service method.</param>
        /// 
        /// <returns>The response from the RegisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        public virtual RegisterNotificationHubResponse RegisterNotificationHub(RegisterNotificationHubRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNotificationHubResponseUnmarshaller.Instance;

            return Invoke<RegisterNotificationHubResponse>(request, options);
        }


        /// <summary>
        /// Registers a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  
        /// <para>
        /// There is a maximum of one <c>NotificationConfiguration</c> per Region. You can have
        /// a maximum of 3 <c>NotificationHub</c> resources at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        public virtual Task<RegisterNotificationHubResponse> RegisterNotificationHubAsync(RegisterNotificationHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNotificationHubResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterNotificationHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags the resource with a tag key and value.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tags the resource with a tag key and value.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventRule


        /// <summary>
        /// Updates an existing <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule service method.</param>
        /// 
        /// <returns>The response from the UpdateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        public virtual UpdateEventRuleResponse UpdateEventRule(UpdateEventRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateEventRuleResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing <c>EventRule</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        public virtual Task<UpdateEventRuleResponse> UpdateEventRuleAsync(UpdateEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationConfiguration


        /// <summary>
        /// Updates a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates a <c>NotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotificationConfigurationResponse>(request, options, cancellationToken);
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