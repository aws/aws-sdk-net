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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SSMContacts.Model;
using Amazon.SSMContacts.Model.Internal.MarshallTransformations;
using Amazon.SSMContacts.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SSMContacts
{
    /// <summary>
    /// Implementation for accessing SSMContacts
    ///
    /// Systems Manager Incident Manager is an incident management console designed to help
    /// users mitigate and recover from incidents affecting their Amazon Web Services-hosted
    /// applications. An incident is any unplanned interruption or reduction in quality of
    /// services.
    /// 
    ///  
    /// <para>
    /// Incident Manager increases incident resolution by notifying responders of impact,
    /// highlighting relevant troubleshooting data, and providing collaboration tools to get
    /// services back up and running. To achieve the primary goal of reducing the time-to-resolution
    /// of critical incidents, Incident Manager automates response plans and enables responder
    /// team escalation.
    /// </para>
    /// </summary>
    public partial class AmazonSSMContactsClient : AmazonServiceClient, IAmazonSSMContacts
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSMContactsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISSMContactsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSMContactsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSMContactsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSMContactsClient with the credentials loaded from the application's
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
        public AmazonSSMContactsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMContactsConfig()) { }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with the credentials loaded from the application's
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
        public AmazonSSMContactsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMContactsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSMContactsClient Configuration Object</param>
        public AmazonSSMContactsClient(AmazonSSMContactsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSMContactsClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSMContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMContactsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSMContactsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Credentials and an
        /// AmazonSSMContactsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSMContactsClient Configuration Object</param>
        public AmazonSSMContactsClient(AWSCredentials credentials, AmazonSSMContactsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMContactsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMContactsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSMContactsClient Configuration Object</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSMContactsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMContactsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMContactsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMContactsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMContactsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSMContactsClient Configuration Object</param>
        public AmazonSSMContactsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSMContactsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMContactsEndpointResolver());
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


        #region  AcceptPage

        /// <summary>
        /// Used to acknowledge an engagement to a contact channel during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage service method.</param>
        /// 
        /// <returns>The response from the AcceptPage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        public virtual AcceptPageResponse AcceptPage(AcceptPageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPageResponseUnmarshaller.Instance;

            return Invoke<AcceptPageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        public virtual IAsyncResult BeginAcceptPage(AcceptPageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPage.</param>
        /// 
        /// <returns>Returns a  AcceptPageResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        public virtual AcceptPageResponse EndAcceptPage(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptPageResponse>(asyncResult);
        }

        #endregion
        
        #region  ActivateContactChannel

        /// <summary>
        /// Activates a contact's contact channel. Incident Manager can't engage a contact until
        /// the contact channel has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateContactChannel service method.</param>
        /// 
        /// <returns>The response from the ActivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        public virtual ActivateContactChannelResponse ActivateContactChannel(ActivateContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateContactChannelResponseUnmarshaller.Instance;

            return Invoke<ActivateContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        public virtual IAsyncResult BeginActivateContactChannel(ActivateContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateContactChannel.</param>
        /// 
        /// <returns>Returns a  ActivateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        public virtual ActivateContactChannelResponse EndActivateContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<ActivateContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContact

        /// <summary>
        /// Contacts are either the contacts that Incident Manager engages during an incident
        /// or the escalation plans that Incident Manager uses to engage contacts in phases during
        /// an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return Invoke<CreateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual IAsyncResult BeginCreateContact(CreateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContact.</param>
        /// 
        /// <returns>Returns a  CreateContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual CreateContactResponse EndCreateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateContactChannel

        /// <summary>
        /// A contact channel is the method that Incident Manager uses to engage your contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel service method.</param>
        /// 
        /// <returns>The response from the CreateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        public virtual CreateContactChannelResponse CreateContactChannel(CreateContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactChannelResponseUnmarshaller.Instance;

            return Invoke<CreateContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateContactChannel(CreateContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactChannel.</param>
        /// 
        /// <returns>Returns a  CreateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        public virtual CreateContactChannelResponse EndCreateContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRotation

        /// <summary>
        /// Creates a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotation service method.</param>
        /// 
        /// <returns>The response from the CreateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotation">REST API Reference for CreateRotation Operation</seealso>
        public virtual CreateRotationResponse CreateRotation(CreateRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRotationResponseUnmarshaller.Instance;

            return Invoke<CreateRotationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRotation operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRotation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotation">REST API Reference for CreateRotation Operation</seealso>
        public virtual IAsyncResult BeginCreateRotation(CreateRotationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRotationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRotation.</param>
        /// 
        /// <returns>Returns a  CreateRotationResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotation">REST API Reference for CreateRotation Operation</seealso>
        public virtual CreateRotationResponse EndCreateRotation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRotationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRotationOverride

        /// <summary>
        /// Creates an override for a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotationOverride service method.</param>
        /// 
        /// <returns>The response from the CreateRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotationOverride">REST API Reference for CreateRotationOverride Operation</seealso>
        public virtual CreateRotationOverrideResponse CreateRotationOverride(CreateRotationOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRotationOverrideResponseUnmarshaller.Instance;

            return Invoke<CreateRotationOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRotationOverride operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRotationOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotationOverride">REST API Reference for CreateRotationOverride Operation</seealso>
        public virtual IAsyncResult BeginCreateRotationOverride(CreateRotationOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRotationOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRotationOverride.</param>
        /// 
        /// <returns>Returns a  CreateRotationOverrideResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotationOverride">REST API Reference for CreateRotationOverride Operation</seealso>
        public virtual CreateRotationOverrideResponse EndCreateRotationOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRotationOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  DeactivateContactChannel

        /// <summary>
        /// To no longer receive Incident Manager engagements to a contact channel, you can deactivate
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateContactChannel service method.</param>
        /// 
        /// <returns>The response from the DeactivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        public virtual DeactivateContactChannelResponse DeactivateContactChannel(DeactivateContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateContactChannelResponseUnmarshaller.Instance;

            return Invoke<DeactivateContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        public virtual IAsyncResult BeginDeactivateContactChannel(DeactivateContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateContactChannel.</param>
        /// 
        /// <returns>Returns a  DeactivateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        public virtual DeactivateContactChannelResponse EndDeactivateContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeactivateContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContact

        /// <summary>
        /// To remove a contact from Incident Manager, you can delete the contact. Deleting a
        /// contact removes them from all escalation plans and related response plans. Deleting
        /// an escalation plan removes it from all related response plans. You will have to recreate
        /// the contact and its contact channels before you can use it again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return Invoke<DeleteContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual IAsyncResult BeginDeleteContact(DeleteContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContact.</param>
        /// 
        /// <returns>Returns a  DeleteContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual DeleteContactResponse EndDeleteContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContactResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteContactChannel

        /// <summary>
        /// To no longer receive engagements on a contact channel, you can delete the channel
        /// from a contact. Deleting the contact channel removes it from the contact's engagement
        /// plan. If you delete the only contact channel for a contact, you won't be able to engage
        /// that contact during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        public virtual DeleteContactChannelResponse DeleteContactChannel(DeleteContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteContactChannel(DeleteContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactChannel.</param>
        /// 
        /// <returns>Returns a  DeleteContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        public virtual DeleteContactChannelResponse EndDeleteContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRotation

        /// <summary>
        /// Deletes a rotation from the system. If a rotation belongs to more than one on-call
        /// schedule, this operation deletes it from all of them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotation service method.</param>
        /// 
        /// <returns>The response from the DeleteRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotation">REST API Reference for DeleteRotation Operation</seealso>
        public virtual DeleteRotationResponse DeleteRotation(DeleteRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRotationResponseUnmarshaller.Instance;

            return Invoke<DeleteRotationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotation operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRotation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotation">REST API Reference for DeleteRotation Operation</seealso>
        public virtual IAsyncResult BeginDeleteRotation(DeleteRotationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRotationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRotation.</param>
        /// 
        /// <returns>Returns a  DeleteRotationResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotation">REST API Reference for DeleteRotation Operation</seealso>
        public virtual DeleteRotationResponse EndDeleteRotation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRotationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRotationOverride

        /// <summary>
        /// Deletes an existing override for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotationOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotationOverride">REST API Reference for DeleteRotationOverride Operation</seealso>
        public virtual DeleteRotationOverrideResponse DeleteRotationOverride(DeleteRotationOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRotationOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteRotationOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotationOverride operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRotationOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotationOverride">REST API Reference for DeleteRotationOverride Operation</seealso>
        public virtual IAsyncResult BeginDeleteRotationOverride(DeleteRotationOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRotationOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRotationOverride.</param>
        /// 
        /// <returns>Returns a  DeleteRotationOverrideResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotationOverride">REST API Reference for DeleteRotationOverride Operation</seealso>
        public virtual DeleteRotationOverrideResponse EndDeleteRotationOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRotationOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEngagement

        /// <summary>
        /// Incident Manager uses engagements to engage contacts and escalation plans during an
        /// incident. Use this command to describe the engagement that occurred during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngagement service method.</param>
        /// 
        /// <returns>The response from the DescribeEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        public virtual DescribeEngagementResponse DescribeEngagement(DescribeEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngagementResponseUnmarshaller.Instance;

            return Invoke<DescribeEngagementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngagement(DescribeEngagementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngagementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngagement.</param>
        /// 
        /// <returns>Returns a  DescribeEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        public virtual DescribeEngagementResponse EndDescribeEngagement(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngagementResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePage

        /// <summary>
        /// Lists details of the engagement to a contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePage service method.</param>
        /// 
        /// <returns>The response from the DescribePage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        public virtual DescribePageResponse DescribePage(DescribePageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePageResponseUnmarshaller.Instance;

            return Invoke<DescribePageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePage operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        public virtual IAsyncResult BeginDescribePage(DescribePageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePage.</param>
        /// 
        /// <returns>Returns a  DescribePageResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        public virtual DescribePageResponse EndDescribePage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContact

        /// <summary>
        /// Retrieves information about the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual GetContactResponse GetContact(GetContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return Invoke<GetContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual IAsyncResult BeginGetContact(GetContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContact.</param>
        /// 
        /// <returns>Returns a  GetContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual GetContactResponse EndGetContact(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContactChannel

        /// <summary>
        /// List details about a specific contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel service method.</param>
        /// 
        /// <returns>The response from the GetContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        public virtual GetContactChannelResponse GetContactChannel(GetContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactChannelResponseUnmarshaller.Instance;

            return Invoke<GetContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        public virtual IAsyncResult BeginGetContactChannel(GetContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactChannel.</param>
        /// 
        /// <returns>Returns a  GetContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        public virtual GetContactChannelResponse EndGetContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContactPolicy

        /// <summary>
        /// Retrieves the resource policies attached to the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        public virtual GetContactPolicyResponse GetContactPolicy(GetContactPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContactPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetContactPolicy(GetContactPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactPolicy.</param>
        /// 
        /// <returns>Returns a  GetContactPolicyResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        public virtual GetContactPolicyResponse EndGetContactPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRotation

        /// <summary>
        /// Retrieves information about an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotation service method.</param>
        /// 
        /// <returns>The response from the GetRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotation">REST API Reference for GetRotation Operation</seealso>
        public virtual GetRotationResponse GetRotation(GetRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRotationResponseUnmarshaller.Instance;

            return Invoke<GetRotationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRotation operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRotation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotation">REST API Reference for GetRotation Operation</seealso>
        public virtual IAsyncResult BeginGetRotation(GetRotationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRotationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRotation.</param>
        /// 
        /// <returns>Returns a  GetRotationResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotation">REST API Reference for GetRotation Operation</seealso>
        public virtual GetRotationResponse EndGetRotation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRotationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRotationOverride

        /// <summary>
        /// Retrieves information about an override to an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotationOverride service method.</param>
        /// 
        /// <returns>The response from the GetRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotationOverride">REST API Reference for GetRotationOverride Operation</seealso>
        public virtual GetRotationOverrideResponse GetRotationOverride(GetRotationOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRotationOverrideResponseUnmarshaller.Instance;

            return Invoke<GetRotationOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRotationOverride operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRotationOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotationOverride">REST API Reference for GetRotationOverride Operation</seealso>
        public virtual IAsyncResult BeginGetRotationOverride(GetRotationOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRotationOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRotationOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRotationOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRotationOverride.</param>
        /// 
        /// <returns>Returns a  GetRotationOverrideResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotationOverride">REST API Reference for GetRotationOverride Operation</seealso>
        public virtual GetRotationOverrideResponse EndGetRotationOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRotationOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContactChannels

        /// <summary>
        /// Lists all contact channels for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels service method.</param>
        /// 
        /// <returns>The response from the ListContactChannels service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        public virtual ListContactChannelsResponse ListContactChannels(ListContactChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactChannelsResponseUnmarshaller.Instance;

            return Invoke<ListContactChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        public virtual IAsyncResult BeginListContactChannels(ListContactChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactChannels.</param>
        /// 
        /// <returns>Returns a  ListContactChannelsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        public virtual ListContactChannelsResponse EndListContactChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListContacts

        /// <summary>
        /// Lists all contacts and escalation plans in Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual ListContactsResponse ListContacts(ListContactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return Invoke<ListContactsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual IAsyncResult BeginListContacts(ListContactsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContacts.</param>
        /// 
        /// <returns>Returns a  ListContactsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual ListContactsResponse EndListContacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListContactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEngagements

        /// <summary>
        /// Lists all engagements that have happened in an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements service method.</param>
        /// 
        /// <returns>The response from the ListEngagements service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        public virtual ListEngagementsResponse ListEngagements(ListEngagementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementsResponseUnmarshaller.Instance;

            return Invoke<ListEngagementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEngagements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEngagements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        public virtual IAsyncResult BeginListEngagements(ListEngagementsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEngagements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEngagements.</param>
        /// 
        /// <returns>Returns a  ListEngagementsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        public virtual ListEngagementsResponse EndListEngagements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEngagementsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPageReceipts

        /// <summary>
        /// Lists all of the engagements to contact channels that have been acknowledged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts service method.</param>
        /// 
        /// <returns>The response from the ListPageReceipts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        public virtual ListPageReceiptsResponse ListPageReceipts(ListPageReceiptsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPageReceiptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPageReceiptsResponseUnmarshaller.Instance;

            return Invoke<ListPageReceiptsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPageReceipts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPageReceipts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        public virtual IAsyncResult BeginListPageReceipts(ListPageReceiptsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPageReceiptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPageReceiptsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPageReceipts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPageReceipts.</param>
        /// 
        /// <returns>Returns a  ListPageReceiptsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        public virtual ListPageReceiptsResponse EndListPageReceipts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPageReceiptsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPageResolutions

        /// <summary>
        /// Returns the resolution path of an engagement. For example, the escalation plan engaged
        /// in an incident might target an on-call schedule that includes several contacts in
        /// a rotation, but just one contact on-call when the incident starts. The resolution
        /// path indicates the hierarchy of <i>escalation plan &gt; on-call schedule &gt; contact</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageResolutions service method.</param>
        /// 
        /// <returns>The response from the ListPageResolutions service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageResolutions">REST API Reference for ListPageResolutions Operation</seealso>
        public virtual ListPageResolutionsResponse ListPageResolutions(ListPageResolutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPageResolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPageResolutionsResponseUnmarshaller.Instance;

            return Invoke<ListPageResolutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPageResolutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPageResolutions operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPageResolutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageResolutions">REST API Reference for ListPageResolutions Operation</seealso>
        public virtual IAsyncResult BeginListPageResolutions(ListPageResolutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPageResolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPageResolutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPageResolutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPageResolutions.</param>
        /// 
        /// <returns>Returns a  ListPageResolutionsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageResolutions">REST API Reference for ListPageResolutions Operation</seealso>
        public virtual ListPageResolutionsResponse EndListPageResolutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPageResolutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPagesByContact

        /// <summary>
        /// Lists the engagements to a contact's contact channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact service method.</param>
        /// 
        /// <returns>The response from the ListPagesByContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        public virtual ListPagesByContactResponse ListPagesByContact(ListPagesByContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPagesByContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPagesByContactResponseUnmarshaller.Instance;

            return Invoke<ListPagesByContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPagesByContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPagesByContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        public virtual IAsyncResult BeginListPagesByContact(ListPagesByContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPagesByContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPagesByContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPagesByContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPagesByContact.</param>
        /// 
        /// <returns>Returns a  ListPagesByContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        public virtual ListPagesByContactResponse EndListPagesByContact(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPagesByContactResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPagesByEngagement

        /// <summary>
        /// Lists the engagements to contact channels that occurred by engaging a contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement service method.</param>
        /// 
        /// <returns>The response from the ListPagesByEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        public virtual ListPagesByEngagementResponse ListPagesByEngagement(ListPagesByEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPagesByEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPagesByEngagementResponseUnmarshaller.Instance;

            return Invoke<ListPagesByEngagementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPagesByEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPagesByEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        public virtual IAsyncResult BeginListPagesByEngagement(ListPagesByEngagementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPagesByEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPagesByEngagementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPagesByEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPagesByEngagement.</param>
        /// 
        /// <returns>Returns a  ListPagesByEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        public virtual ListPagesByEngagementResponse EndListPagesByEngagement(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPagesByEngagementResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPreviewRotationShifts

        /// <summary>
        /// Returns a list of shifts based on rotation configuration parameters.
        /// 
        ///  <note> 
        /// <para>
        /// The Incident Manager primarily uses this operation to populate the <b>Preview</b>
        /// calendar. It is not typically run by end users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreviewRotationShifts service method.</param>
        /// 
        /// <returns>The response from the ListPreviewRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPreviewRotationShifts">REST API Reference for ListPreviewRotationShifts Operation</seealso>
        public virtual ListPreviewRotationShiftsResponse ListPreviewRotationShifts(ListPreviewRotationShiftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPreviewRotationShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPreviewRotationShiftsResponseUnmarshaller.Instance;

            return Invoke<ListPreviewRotationShiftsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPreviewRotationShifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPreviewRotationShifts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPreviewRotationShifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPreviewRotationShifts">REST API Reference for ListPreviewRotationShifts Operation</seealso>
        public virtual IAsyncResult BeginListPreviewRotationShifts(ListPreviewRotationShiftsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPreviewRotationShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPreviewRotationShiftsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPreviewRotationShifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPreviewRotationShifts.</param>
        /// 
        /// <returns>Returns a  ListPreviewRotationShiftsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPreviewRotationShifts">REST API Reference for ListPreviewRotationShifts Operation</seealso>
        public virtual ListPreviewRotationShiftsResponse EndListPreviewRotationShifts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPreviewRotationShiftsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRotationOverrides

        /// <summary>
        /// Retrieves a list of overrides currently specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationOverrides service method.</param>
        /// 
        /// <returns>The response from the ListRotationOverrides service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationOverrides">REST API Reference for ListRotationOverrides Operation</seealso>
        public virtual ListRotationOverridesResponse ListRotationOverrides(ListRotationOverridesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationOverridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationOverridesResponseUnmarshaller.Instance;

            return Invoke<ListRotationOverridesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRotationOverrides operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRotationOverrides operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRotationOverrides
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationOverrides">REST API Reference for ListRotationOverrides Operation</seealso>
        public virtual IAsyncResult BeginListRotationOverrides(ListRotationOverridesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationOverridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationOverridesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRotationOverrides operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRotationOverrides.</param>
        /// 
        /// <returns>Returns a  ListRotationOverridesResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationOverrides">REST API Reference for ListRotationOverrides Operation</seealso>
        public virtual ListRotationOverridesResponse EndListRotationOverrides(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRotationOverridesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRotations

        /// <summary>
        /// Retrieves a list of on-call rotations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotations service method.</param>
        /// 
        /// <returns>The response from the ListRotations service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotations">REST API Reference for ListRotations Operation</seealso>
        public virtual ListRotationsResponse ListRotations(ListRotationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationsResponseUnmarshaller.Instance;

            return Invoke<ListRotationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRotations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRotations operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRotations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotations">REST API Reference for ListRotations Operation</seealso>
        public virtual IAsyncResult BeginListRotations(ListRotationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRotations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRotations.</param>
        /// 
        /// <returns>Returns a  ListRotationsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotations">REST API Reference for ListRotations Operation</seealso>
        public virtual ListRotationsResponse EndListRotations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRotationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRotationShifts

        /// <summary>
        /// Returns a list of shifts generated by an existing rotation in the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationShifts service method.</param>
        /// 
        /// <returns>The response from the ListRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationShifts">REST API Reference for ListRotationShifts Operation</seealso>
        public virtual ListRotationShiftsResponse ListRotationShifts(ListRotationShiftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationShiftsResponseUnmarshaller.Instance;

            return Invoke<ListRotationShiftsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRotationShifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRotationShifts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRotationShifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationShifts">REST API Reference for ListRotationShifts Operation</seealso>
        public virtual IAsyncResult BeginListRotationShifts(ListRotationShiftsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRotationShiftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRotationShiftsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRotationShifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRotationShifts.</param>
        /// 
        /// <returns>Returns a  ListRotationShiftsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationShifts">REST API Reference for ListRotationShifts Operation</seealso>
        public virtual ListRotationShiftsResponse EndListRotationShifts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRotationShiftsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags of an escalation plan or contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutContactPolicy

        /// <summary>
        /// Adds a resource policy to the specified contact or escalation plan. The resource policy
        /// is used to share the contact or escalation plan using Resource Access Manager (RAM).
        /// For more information about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/xa.html">Setting
        /// up cross-account functionality</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        public virtual PutContactPolicyResponse PutContactPolicy(PutContactPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactPolicyResponseUnmarshaller.Instance;

            return Invoke<PutContactPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContactPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutContactPolicy(PutContactPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContactPolicy.</param>
        /// 
        /// <returns>Returns a  PutContactPolicyResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        public virtual PutContactPolicyResponse EndPutContactPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutContactPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  SendActivationCode

        /// <summary>
        /// Sends an activation code to a contact channel. The contact can use this code to activate
        /// the contact channel in the console or with the <code>ActivateChannel</code> operation.
        /// Incident Manager can't engage a contact channel until it has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        public virtual SendActivationCodeResponse SendActivationCode(SendActivationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendActivationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendActivationCodeResponseUnmarshaller.Instance;

            return Invoke<SendActivationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendActivationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendActivationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        public virtual IAsyncResult BeginSendActivationCode(SendActivationCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendActivationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendActivationCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendActivationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendActivationCode.</param>
        /// 
        /// <returns>Returns a  SendActivationCodeResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        public virtual SendActivationCodeResponse EndSendActivationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<SendActivationCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  StartEngagement

        /// <summary>
        /// Starts an engagement to a contact or escalation plan. The engagement engages each
        /// contact specified in the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagement service method.</param>
        /// 
        /// <returns>The response from the StartEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        public virtual StartEngagementResponse StartEngagement(StartEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementResponseUnmarshaller.Instance;

            return Invoke<StartEngagementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        public virtual IAsyncResult BeginStartEngagement(StartEngagementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEngagement.</param>
        /// 
        /// <returns>Returns a  StartEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        public virtual StartEngagementResponse EndStartEngagement(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEngagementResponse>(asyncResult);
        }

        #endregion
        
        #region  StopEngagement

        /// <summary>
        /// Stops an engagement before it finishes the final stage of the escalation plan or engagement
        /// plan. Further contacts aren't engaged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEngagement service method.</param>
        /// 
        /// <returns>The response from the StopEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        public virtual StopEngagementResponse StopEngagement(StopEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEngagementResponseUnmarshaller.Instance;

            return Invoke<StopEngagementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        public virtual IAsyncResult BeginStopEngagement(StopEngagementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEngagementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEngagement.</param>
        /// 
        /// <returns>Returns a  StopEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        public virtual StopEngagementResponse EndStopEngagement(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEngagementResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a contact or escalation plan. You can tag only contacts and escalation plans
        /// in the first region of your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContact

        /// <summary>
        /// Updates the contact or escalation plan specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return Invoke<UpdateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual IAsyncResult BeginUpdateContact(UpdateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContact.</param>
        /// 
        /// <returns>Returns a  UpdateContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual UpdateContactResponse EndUpdateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateContactChannel

        /// <summary>
        /// Updates a contact's contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        public virtual UpdateContactChannelResponse UpdateContactChannel(UpdateContactChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateContactChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateContactChannel(UpdateContactChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactChannel.</param>
        /// 
        /// <returns>Returns a  UpdateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        public virtual UpdateContactChannelResponse EndUpdateContactChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateContactChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRotation

        /// <summary>
        /// Updates the information specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRotation service method.</param>
        /// 
        /// <returns>The response from the UpdateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateRotation">REST API Reference for UpdateRotation Operation</seealso>
        public virtual UpdateRotationResponse UpdateRotation(UpdateRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRotationResponseUnmarshaller.Instance;

            return Invoke<UpdateRotationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRotation operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRotation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateRotation">REST API Reference for UpdateRotation Operation</seealso>
        public virtual IAsyncResult BeginUpdateRotation(UpdateRotationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRotationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRotation.</param>
        /// 
        /// <returns>Returns a  UpdateRotationResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateRotation">REST API Reference for UpdateRotation Operation</seealso>
        public virtual UpdateRotationResponse EndUpdateRotation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRotationResponse>(asyncResult);
        }

        #endregion
        
    }
}