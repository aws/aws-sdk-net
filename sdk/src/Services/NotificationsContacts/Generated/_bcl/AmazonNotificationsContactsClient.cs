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
 * Do not modify this file. This file is generated from the notificationscontacts-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NotificationsContacts.Model;
using Amazon.NotificationsContacts.Model.Internal.MarshallTransformations;
using Amazon.NotificationsContacts.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NotificationsContacts
{
    /// <summary>
    /// <para>Implementation for accessing NotificationsContacts</para>
    ///
    /// AWS User Notifications Contacts is a service that allows you to create and manage
    /// email contacts for AWS User Notifications. The AWS User Notifications Contacts API
    /// Reference provides descriptions, API request parameters, and the JSON response for
    /// all email contact related API actions.
    /// </summary>
    public partial class AmazonNotificationsContactsClient : AmazonServiceClient, IAmazonNotificationsContacts
    {
        private static IServiceMetadata serviceMetadata = new AmazonNotificationsContactsMetadata();
        private INotificationsContactsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INotificationsContactsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NotificationsContactsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with the credentials loaded from the application's
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
        public AmazonNotificationsContactsClient()
            : base(new AmazonNotificationsContactsConfig()) { }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with the credentials loaded from the application's
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
        public AmazonNotificationsContactsClient(RegionEndpoint region)
            : base(new AmazonNotificationsContactsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNotificationsContactsClient Configuration Object</param>
        public AmazonNotificationsContactsClient(AmazonNotificationsContactsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNotificationsContactsClient(AWSCredentials credentials)
            : this(credentials, new AmazonNotificationsContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsContactsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNotificationsContactsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Credentials and an
        /// AmazonNotificationsContactsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNotificationsContactsClient Configuration Object</param>
        public AmazonNotificationsContactsClient(AWSCredentials credentials, AmazonNotificationsContactsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNotificationsContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNotificationsContactsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNotificationsContactsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNotificationsContactsClient Configuration Object</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNotificationsContactsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNotificationsContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNotificationsContactsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNotificationsContactsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNotificationsContactsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNotificationsContactsClient Configuration Object</param>
        public AmazonNotificationsContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNotificationsContactsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNotificationsContactsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNotificationsContactsAuthSchemeHandler());
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


        #region  ActivateEmailContact


        /// <summary>
        /// Activates an email contact using an activation code. This code is in the activation
        /// email sent to the email address associated with this email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEmailContact service method.</param>
        /// 
        /// <returns>The response from the ActivateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ActivateEmailContact">REST API Reference for ActivateEmailContact Operation</seealso>
        public virtual ActivateEmailContactResponse ActivateEmailContact(ActivateEmailContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateEmailContactResponseUnmarshaller.Instance;

            return Invoke<ActivateEmailContactResponse>(request, options);
        }


        /// <summary>
        /// Activates an email contact using an activation code. This code is in the activation
        /// email sent to the email address associated with this email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ActivateEmailContact">REST API Reference for ActivateEmailContact Operation</seealso>
        public virtual Task<ActivateEmailContactResponse> ActivateEmailContactAsync(ActivateEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateEmailContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<ActivateEmailContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEmailContact


        /// <summary>
        /// Creates an email contact for the provided email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailContact service method.</param>
        /// 
        /// <returns>The response from the CreateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/CreateEmailContact">REST API Reference for CreateEmailContact Operation</seealso>
        public virtual CreateEmailContactResponse CreateEmailContact(CreateEmailContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailContactResponseUnmarshaller.Instance;

            return Invoke<CreateEmailContactResponse>(request, options);
        }


        /// <summary>
        /// Creates an email contact for the provided email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/CreateEmailContact">REST API Reference for CreateEmailContact Operation</seealso>
        public virtual Task<CreateEmailContactResponse> CreateEmailContactAsync(CreateEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEmailContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailContact


        /// <summary>
        /// Deletes an email contact.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting an email contact removes it from all associated notification configurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailContact service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/DeleteEmailContact">REST API Reference for DeleteEmailContact Operation</seealso>
        public virtual DeleteEmailContactResponse DeleteEmailContact(DeleteEmailContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailContactResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailContactResponse>(request, options);
        }


        /// <summary>
        /// Deletes an email contact.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting an email contact removes it from all associated notification configurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/DeleteEmailContact">REST API Reference for DeleteEmailContact Operation</seealso>
        public virtual Task<DeleteEmailContactResponse> DeleteEmailContactAsync(DeleteEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEmailContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEmailContact


        /// <summary>
        /// Returns an email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailContact service method.</param>
        /// 
        /// <returns>The response from the GetEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/GetEmailContact">REST API Reference for GetEmailContact Operation</seealso>
        public virtual GetEmailContactResponse GetEmailContact(GetEmailContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailContactResponseUnmarshaller.Instance;

            return Invoke<GetEmailContactResponse>(request, options);
        }


        /// <summary>
        /// Returns an email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/GetEmailContact">REST API Reference for GetEmailContact Operation</seealso>
        public virtual Task<GetEmailContactResponse> GetEmailContactAsync(GetEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEmailContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEmailContacts


        /// <summary>
        /// Lists all email contacts created under the Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailContacts service method.</param>
        /// 
        /// <returns>The response from the ListEmailContacts service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListEmailContacts">REST API Reference for ListEmailContacts Operation</seealso>
        public virtual ListEmailContactsResponse ListEmailContacts(ListEmailContactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailContactsResponseUnmarshaller.Instance;

            return Invoke<ListEmailContactsResponse>(request, options);
        }


        /// <summary>
        /// Lists all email contacts created under the Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailContacts service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListEmailContacts">REST API Reference for ListEmailContacts Operation</seealso>
        public virtual Task<ListEmailContactsResponse> ListEmailContactsAsync(ListEmailContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailContactsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEmailContactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendActivationCode


        /// <summary>
        /// Sends an activation email to the email address associated with the specified email
        /// contact.
        /// 
        ///  <note> 
        /// <para>
        /// It might take a few minutes for the activation email to arrive. If it doesn't arrive,
        /// check in your spam folder or try sending another activation email.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        public virtual SendActivationCodeResponse SendActivationCode(SendActivationCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendActivationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendActivationCodeResponseUnmarshaller.Instance;

            return Invoke<SendActivationCodeResponse>(request, options);
        }


        /// <summary>
        /// Sends an activation email to the email address associated with the specified email
        /// contact.
        /// 
        ///  <note> 
        /// <para>
        /// It might take a few minutes for the activation email to arrive. If it doesn't arrive,
        /// check in your spam folder or try sending another activation email.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        public virtual Task<SendActivationCodeResponse> SendActivationCodeAsync(SendActivationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendActivationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendActivationCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendActivationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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