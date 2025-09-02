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
using System.Collections.Generic;
using System.Net;

using Amazon.Notifications.Model;
using Amazon.Notifications.Model.Internal.MarshallTransformations;
using Amazon.Notifications.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNotificationsConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNotificationsConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNotificationsEndpointResolver());
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelResponseUnmarshaller.Instance;

            return Invoke<AssociateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        public virtual IAsyncResult BeginAssociateChannel(AssociateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateChannel.</param>
        /// 
        /// <returns>Returns a  AssociateChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        public virtual AssociateChannelResponse EndAssociateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateChannelResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedNotificationAccountContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateManagedNotificationAccountContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAccountContact operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateManagedNotificationAccountContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAccountContact">REST API Reference for AssociateManagedNotificationAccountContact Operation</seealso>
        public virtual IAsyncResult BeginAssociateManagedNotificationAccountContact(AssociateManagedNotificationAccountContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateManagedNotificationAccountContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateManagedNotificationAccountContact.</param>
        /// 
        /// <returns>Returns a  AssociateManagedNotificationAccountContactResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAccountContact">REST API Reference for AssociateManagedNotificationAccountContact Operation</seealso>
        public virtual AssociateManagedNotificationAccountContactResponse EndAssociateManagedNotificationAccountContact(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateManagedNotificationAccountContactResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedNotificationAdditionalChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateManagedNotificationAdditionalChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAdditionalChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateManagedNotificationAdditionalChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAdditionalChannel">REST API Reference for AssociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual IAsyncResult BeginAssociateManagedNotificationAdditionalChannel(AssociateManagedNotificationAdditionalChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateManagedNotificationAdditionalChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateManagedNotificationAdditionalChannel.</param>
        /// 
        /// <returns>Returns a  AssociateManagedNotificationAdditionalChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAdditionalChannel">REST API Reference for AssociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual AssociateManagedNotificationAdditionalChannelResponse EndAssociateManagedNotificationAdditionalChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateManagedNotificationAdditionalChannelResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<AssociateOrganizationalUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateOrganizationalUnit operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateOrganizationalUnit">REST API Reference for AssociateOrganizationalUnit Operation</seealso>
        public virtual IAsyncResult BeginAssociateOrganizationalUnit(AssociateOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  AssociateOrganizationalUnitResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateOrganizationalUnit">REST API Reference for AssociateOrganizationalUnit Operation</seealso>
        public virtual AssociateOrganizationalUnitResponse EndAssociateOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateOrganizationalUnitResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventRuleResponseUnmarshaller.Instance;

            return Invoke<CreateEventRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        public virtual IAsyncResult BeginCreateEventRule(CreateEventRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventRule.</param>
        /// 
        /// <returns>Returns a  CreateEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        public virtual CreateEventRuleResponse EndCreateEventRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventRuleResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateNotificationConfiguration(CreateNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        public virtual CreateNotificationConfigurationResponse EndCreateNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotificationConfigurationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteEventRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventRule(DeleteEventRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventRule.</param>
        /// 
        /// <returns>Returns a  DeleteEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        public virtual DeleteEventRuleResponse EndDeleteEventRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventRuleResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationConfigurationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNotificationHubResponseUnmarshaller.Instance;

            return Invoke<DeregisterNotificationHubResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterNotificationHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        public virtual IAsyncResult BeginDeregisterNotificationHub(DeregisterNotificationHubRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterNotificationHubResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterNotificationHub.</param>
        /// 
        /// <returns>Returns a  DeregisterNotificationHubResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        public virtual DeregisterNotificationHubResponse EndDeregisterNotificationHub(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterNotificationHubResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DisableNotificationsAccessForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableNotificationsAccessForOrganization operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableNotificationsAccessForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisableNotificationsAccessForOrganization">REST API Reference for DisableNotificationsAccessForOrganization Operation</seealso>
        public virtual IAsyncResult BeginDisableNotificationsAccessForOrganization(DisableNotificationsAccessForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableNotificationsAccessForOrganization.</param>
        /// 
        /// <returns>Returns a  DisableNotificationsAccessForOrganizationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisableNotificationsAccessForOrganization">REST API Reference for DisableNotificationsAccessForOrganization Operation</seealso>
        public virtual DisableNotificationsAccessForOrganizationResponse EndDisableNotificationsAccessForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableNotificationsAccessForOrganizationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelResponseUnmarshaller.Instance;

            return Invoke<DisassociateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        public virtual IAsyncResult BeginDisassociateChannel(DisassociateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateChannel.</param>
        /// 
        /// <returns>Returns a  DisassociateChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        public virtual DisassociateChannelResponse EndDisassociateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateChannelResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedNotificationAccountContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateManagedNotificationAccountContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAccountContact operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateManagedNotificationAccountContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAccountContact">REST API Reference for DisassociateManagedNotificationAccountContact Operation</seealso>
        public virtual IAsyncResult BeginDisassociateManagedNotificationAccountContact(DisassociateManagedNotificationAccountContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAccountContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAccountContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateManagedNotificationAccountContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateManagedNotificationAccountContact.</param>
        /// 
        /// <returns>Returns a  DisassociateManagedNotificationAccountContactResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAccountContact">REST API Reference for DisassociateManagedNotificationAccountContact Operation</seealso>
        public virtual DisassociateManagedNotificationAccountContactResponse EndDisassociateManagedNotificationAccountContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateManagedNotificationAccountContactResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedNotificationAdditionalChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateManagedNotificationAdditionalChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAdditionalChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateManagedNotificationAdditionalChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAdditionalChannel">REST API Reference for DisassociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual IAsyncResult BeginDisassociateManagedNotificationAdditionalChannel(DisassociateManagedNotificationAdditionalChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateManagedNotificationAdditionalChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedNotificationAdditionalChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateManagedNotificationAdditionalChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateManagedNotificationAdditionalChannel.</param>
        /// 
        /// <returns>Returns a  DisassociateManagedNotificationAdditionalChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAdditionalChannel">REST API Reference for DisassociateManagedNotificationAdditionalChannel Operation</seealso>
        public virtual DisassociateManagedNotificationAdditionalChannelResponse EndDisassociateManagedNotificationAdditionalChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateManagedNotificationAdditionalChannelResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DisassociateOrganizationalUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOrganizationalUnit operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateOrganizationalUnit">REST API Reference for DisassociateOrganizationalUnit Operation</seealso>
        public virtual IAsyncResult BeginDisassociateOrganizationalUnit(DisassociateOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  DisassociateOrganizationalUnitResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateOrganizationalUnit">REST API Reference for DisassociateOrganizationalUnit Operation</seealso>
        public virtual DisassociateOrganizationalUnitResponse EndDisassociateOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateOrganizationalUnitResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableNotificationsAccessForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableNotificationsAccessForOrganization operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableNotificationsAccessForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/EnableNotificationsAccessForOrganization">REST API Reference for EnableNotificationsAccessForOrganization Operation</seealso>
        public virtual IAsyncResult BeginEnableNotificationsAccessForOrganization(EnableNotificationsAccessForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableNotificationsAccessForOrganization.</param>
        /// 
        /// <returns>Returns a  EnableNotificationsAccessForOrganizationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/EnableNotificationsAccessForOrganization">REST API Reference for EnableNotificationsAccessForOrganization Operation</seealso>
        public virtual EnableNotificationsAccessForOrganizationResponse EndEnableNotificationsAccessForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableNotificationsAccessForOrganizationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventRuleResponseUnmarshaller.Instance;

            return Invoke<GetEventRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        public virtual IAsyncResult BeginGetEventRule(GetEventRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventRule.</param>
        /// 
        /// <returns>Returns a  GetEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        public virtual GetEventRuleResponse EndGetEventRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventRuleResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationChildEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationChildEventResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationChildEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedNotificationChildEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationChildEvent operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedNotificationChildEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationChildEvent">REST API Reference for GetManagedNotificationChildEvent Operation</seealso>
        public virtual IAsyncResult BeginGetManagedNotificationChildEvent(GetManagedNotificationChildEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationChildEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationChildEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedNotificationChildEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedNotificationChildEvent.</param>
        /// 
        /// <returns>Returns a  GetManagedNotificationChildEventResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationChildEvent">REST API Reference for GetManagedNotificationChildEvent Operation</seealso>
        public virtual GetManagedNotificationChildEventResponse EndGetManagedNotificationChildEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedNotificationChildEventResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationConfiguration">REST API Reference for GetManagedNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetManagedNotificationConfiguration(GetManagedNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetManagedNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationConfiguration">REST API Reference for GetManagedNotificationConfiguration Operation</seealso>
        public virtual GetManagedNotificationConfigurationResponse EndGetManagedNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedNotificationConfigurationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationEventResponseUnmarshaller.Instance;

            return Invoke<GetManagedNotificationEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationEvent operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedNotificationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationEvent">REST API Reference for GetManagedNotificationEvent Operation</seealso>
        public virtual IAsyncResult BeginGetManagedNotificationEvent(GetManagedNotificationEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedNotificationEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedNotificationEvent.</param>
        /// 
        /// <returns>Returns a  GetManagedNotificationEventResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationEvent">REST API Reference for GetManagedNotificationEvent Operation</seealso>
        public virtual GetManagedNotificationEventResponse EndGetManagedNotificationEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedNotificationEventResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        public virtual GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationConfigurationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationEventResponseUnmarshaller.Instance;

            return Invoke<GetNotificationEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationEvent(GetNotificationEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationEvent.</param>
        /// 
        /// <returns>Returns a  GetNotificationEventResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        public virtual GetNotificationEventResponse EndGetNotificationEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationEventResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetNotificationsAccessForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationsAccessForOrganization operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationsAccessForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationsAccessForOrganization">REST API Reference for GetNotificationsAccessForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationsAccessForOrganization(GetNotificationsAccessForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationsAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationsAccessForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationsAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationsAccessForOrganization.</param>
        /// 
        /// <returns>Returns a  GetNotificationsAccessForOrganizationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationsAccessForOrganization">REST API Reference for GetNotificationsAccessForOrganization Operation</seealso>
        public virtual GetNotificationsAccessForOrganizationResponse EndGetNotificationsAccessForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationsAccessForOrganizationResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventRulesResponseUnmarshaller.Instance;

            return Invoke<ListEventRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        public virtual IAsyncResult BeginListEventRules(ListEventRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventRules.</param>
        /// 
        /// <returns>Returns a  ListEventRulesResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        public virtual ListEventRulesResponse EndListEventRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventRulesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChannelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationChannelAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedNotificationChannelAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChannelAssociations operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedNotificationChannelAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChannelAssociations">REST API Reference for ListManagedNotificationChannelAssociations Operation</seealso>
        public virtual IAsyncResult BeginListManagedNotificationChannelAssociations(ListManagedNotificationChannelAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChannelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChannelAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedNotificationChannelAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedNotificationChannelAssociations.</param>
        /// 
        /// <returns>Returns a  ListManagedNotificationChannelAssociationsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChannelAssociations">REST API Reference for ListManagedNotificationChannelAssociations Operation</seealso>
        public virtual ListManagedNotificationChannelAssociationsResponse EndListManagedNotificationChannelAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedNotificationChannelAssociationsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChildEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChildEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationChildEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedNotificationChildEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChildEvents operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedNotificationChildEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChildEvents">REST API Reference for ListManagedNotificationChildEvents Operation</seealso>
        public virtual IAsyncResult BeginListManagedNotificationChildEvents(ListManagedNotificationChildEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationChildEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationChildEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedNotificationChildEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedNotificationChildEvents.</param>
        /// 
        /// <returns>Returns a  ListManagedNotificationChildEventsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChildEvents">REST API Reference for ListManagedNotificationChildEvents Operation</seealso>
        public virtual ListManagedNotificationChildEventsResponse EndListManagedNotificationChildEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedNotificationChildEventsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationConfigurations operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedNotificationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationConfigurations">REST API Reference for ListManagedNotificationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListManagedNotificationConfigurations(ListManagedNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  ListManagedNotificationConfigurationsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationConfigurations">REST API Reference for ListManagedNotificationConfigurations Operation</seealso>
        public virtual ListManagedNotificationConfigurationsResponse EndListManagedNotificationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedNotificationConfigurationsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedNotificationEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationEvents operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedNotificationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationEvents">REST API Reference for ListManagedNotificationEvents Operation</seealso>
        public virtual IAsyncResult BeginListManagedNotificationEvents(ListManagedNotificationEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedNotificationEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedNotificationEvents.</param>
        /// 
        /// <returns>Returns a  ListManagedNotificationEventsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationEvents">REST API Reference for ListManagedNotificationEvents Operation</seealso>
        public virtual ListManagedNotificationEventsResponse EndListManagedNotificationEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedNotificationEventsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual IAsyncResult BeginListMemberAccounts(ListMemberAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberAccounts.</param>
        /// 
        /// <returns>Returns a  ListMemberAccountsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual ListMemberAccountsResponse EndListMemberAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMemberAccountsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListNotificationConfigurations(ListNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNotificationConfigurationsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        public virtual ListNotificationConfigurationsResponse EndListNotificationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationConfigurationsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationEventsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        public virtual IAsyncResult BeginListNotificationEvents(ListNotificationEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationEvents.</param>
        /// 
        /// <returns>Returns a  ListNotificationEventsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        public virtual ListNotificationEventsResponse EndListNotificationEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationEventsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationHubsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationHubsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationHubs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationHubs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        public virtual IAsyncResult BeginListNotificationHubs(ListNotificationHubsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationHubsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationHubs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationHubs.</param>
        /// 
        /// <returns>Returns a  ListNotificationHubsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        public virtual ListNotificationHubsResponse EndListNotificationHubs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationHubsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationalUnitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationalUnits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnits operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationalUnits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListOrganizationalUnits">REST API Reference for ListOrganizationalUnits Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationalUnits(ListOrganizationalUnitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationalUnits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationalUnits.</param>
        /// 
        /// <returns>Returns a  ListOrganizationalUnitsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListOrganizationalUnits">REST API Reference for ListOrganizationalUnits Operation</seealso>
        public virtual ListOrganizationalUnitsResponse EndListOrganizationalUnits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationalUnitsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNotificationHubResponseUnmarshaller.Instance;

            return Invoke<RegisterNotificationHubResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterNotificationHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        public virtual IAsyncResult BeginRegisterNotificationHub(RegisterNotificationHubRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterNotificationHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterNotificationHubResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterNotificationHub.</param>
        /// 
        /// <returns>Returns a  RegisterNotificationHubResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        public virtual RegisterNotificationHubResponse EndRegisterNotificationHub(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterNotificationHubResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateEventRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventRule(UpdateEventRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventRule.</param>
        /// 
        /// <returns>Returns a  UpdateEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        public virtual UpdateEventRuleResponse EndUpdateEventRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventRuleResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse EndUpdateNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonNotificationsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}