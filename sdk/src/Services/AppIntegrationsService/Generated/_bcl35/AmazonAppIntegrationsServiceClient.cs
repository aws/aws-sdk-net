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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AppIntegrationsService.Model;
using Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations;
using Amazon.AppIntegrationsService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppIntegrationsService
{
    /// <summary>
    /// Implementation for accessing AppIntegrationsService
    ///
    /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
    /// 
    ///  
    /// <para>
    /// The Amazon AppIntegrations service enables you to configure and reuse connections
    /// to external applications.
    /// </para>
    ///  
    /// <para>
    /// For information about how you can use external applications with Amazon Connect, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/crm.html">Set up pre-built
    /// integrations</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAppIntegrationsServiceClient : AmazonServiceClient, IAmazonAppIntegrationsService
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppIntegrationsServiceMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        public AmazonAppIntegrationsServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppIntegrationsServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        public AmazonAppIntegrationsServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(AmazonAppIntegrationsServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials and an
        /// AmazonAppIntegrationsServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials, AmazonAppIntegrationsServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppIntegrationsServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppIntegrationsServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppIntegrationsServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppIntegrationsServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppIntegrationsServiceConfig clientConfig)
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


        #region  CreateEventIntegration

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon Eventbridge bus in your account and a partner event source that will
        /// push events to that bus. No objects are created in the your account, only metadata
        /// that is persisted on the EventIntegration control plane.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        public virtual CreateEventIntegrationResponse CreateEventIntegration(CreateEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateEventIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        public virtual IAsyncResult BeginCreateEventIntegration(CreateEventIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventIntegration.</param>
        /// 
        /// <returns>Returns a  CreateEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        public virtual CreateEventIntegrationResponse EndCreateEventIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventIntegration

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        public virtual DeleteEventIntegrationResponse DeleteEventIntegration(DeleteEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventIntegration(DeleteEventIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        public virtual DeleteEventIntegrationResponse EndDeleteEventIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventIntegration

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Return information about the event integration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        public virtual GetEventIntegrationResponse GetEventIntegration(GetEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetEventIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        public virtual IAsyncResult BeginGetEventIntegration(GetEventIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventIntegration.</param>
        /// 
        /// <returns>Returns a  GetEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        public virtual GetEventIntegrationResponse EndGetEventIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventIntegrationAssociations

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of event integration associations in the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        public virtual ListEventIntegrationAssociationsResponse ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListEventIntegrationAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventIntegrationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        public virtual IAsyncResult BeginListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventIntegrationAssociations.</param>
        /// 
        /// <returns>Returns a  ListEventIntegrationAssociationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        public virtual ListEventIntegrationAssociationsResponse EndListEventIntegrationAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventIntegrationAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventIntegrations

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Returns a paginated list of event integrations in the account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        public virtual ListEventIntegrationsResponse ListEventIntegrations(ListEventIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListEventIntegrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        public virtual IAsyncResult BeginListEventIntegrations(ListEventIntegrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventIntegrations.</param>
        /// 
        /// <returns>Returns a  ListEventIntegrationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        public virtual ListEventIntegrationsResponse EndListEventIntegrations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventIntegrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Lists the tags for the specified resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Adds the specified tags to the specified resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Removes the specified tags from the specified resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventIntegration

        /// <summary>
        /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
        /// 
        ///  
        /// <para>
        /// Updates the description of an event integration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        public virtual UpdateEventIntegrationResponse UpdateEventIntegration(UpdateEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventIntegration(UpdateEventIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        public virtual UpdateEventIntegrationResponse EndUpdateEventIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventIntegrationResponse>(asyncResult);
        }

        #endregion
        
    }
}