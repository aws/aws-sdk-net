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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkLink.Model;
using Amazon.WorkLink.Model.Internal.MarshallTransformations;
using Amazon.WorkLink.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkLink
{
    /// <summary>
    /// Implementation for accessing WorkLink
    ///
    /// Amazon WorkLink is a cloud-based service that provides secure access to internal websites
    /// and web apps from iOS phones. In a single step, your users, such as employees, can
    /// access internal websites as efficiently as they access any other public website. They
    /// enter a URL in their web browser, or choose a link to an internal website in an email.
    /// Amazon WorkLink authenticates the user's access and securely renders authorized internal
    /// web content in a secure rendering service in the AWS cloud. Amazon WorkLink doesn't
    /// download or store any internal web content on mobile devices.
    /// </summary>
    public partial class AmazonWorkLinkClient : AmazonServiceClient, IAmazonWorkLink
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkLinkMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AmazonWorkLinkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkLinkClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials and an
        /// AmazonWorkLinkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, AmazonWorkLinkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkLinkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkLinkConfig clientConfig)
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


        #region  AssociateWebsiteCertificateAuthority

        /// <summary>
        /// Imports the root certificate of a certificate authority (CA) used to obtain TLS certificates
        /// used by associated websites within the company network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the AssociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        public virtual AssociateWebsiteCertificateAuthorityResponse AssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<AssociateWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginAssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  AssociateWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        public virtual AssociateWebsiteCertificateAuthorityResponse EndAssociateWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a fleet. A fleet consists of resources and the configuration that delivers
        /// associated websites to authorized users who download and set up the Amazon WorkLink
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes a fleet. Prevents users from accessing previously associated websites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAuditStreamConfiguration

        /// <summary>
        /// Describes the configuration for delivering audit streams to the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        public virtual DescribeAuditStreamConfigurationResponse DescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditStreamConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditStreamConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditStreamConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAuditStreamConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        public virtual DescribeAuditStreamConfigurationResponse EndDescribeAuditStreamConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAuditStreamConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCompanyNetworkConfiguration

        /// <summary>
        /// Describes the networking configuration to access the internal websites associated
        /// with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        public virtual DescribeCompanyNetworkConfigurationResponse DescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeCompanyNetworkConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCompanyNetworkConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCompanyNetworkConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeCompanyNetworkConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        public virtual DescribeCompanyNetworkConfigurationResponse EndDescribeCompanyNetworkConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCompanyNetworkConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDevice

        /// <summary>
        /// Provides information about a user's device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDevicePolicyConfiguration

        /// <summary>
        /// Describes the device policy configuration for the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        public virtual DescribeDevicePolicyConfigurationResponse DescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDevicePolicyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevicePolicyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevicePolicyConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeDevicePolicyConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        public virtual DescribeDevicePolicyConfigurationResponse EndDescribeDevicePolicyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDevicePolicyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetMetadata

        /// <summary>
        /// Provides basic information for the specified fleet, excluding identity provider, networking,
        /// and device configuration details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        public virtual DescribeFleetMetadataResponse DescribeFleetMetadata(DescribeFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetMetadata(DescribeFleetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeFleetMetadataResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        public virtual DescribeFleetMetadataResponse EndDescribeFleetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityProviderConfiguration

        /// <summary>
        /// Describes the identity provider configuration of the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        public virtual DescribeIdentityProviderConfigurationResponse DescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        public virtual DescribeIdentityProviderConfigurationResponse EndDescribeIdentityProviderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityProviderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWebsiteCertificateAuthority

        /// <summary>
        /// Provides information about the certificate authority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DescribeWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        public virtual DescribeWebsiteCertificateAuthorityResponse DescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DescribeWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginDescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DescribeWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        public virtual DescribeWebsiteCertificateAuthorityResponse EndDescribeWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWebsiteCertificateAuthority

        /// <summary>
        /// Removes a certificate authority (CA).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        public virtual DisassociateWebsiteCertificateAuthorityResponse DisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DisassociateWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        public virtual DisassociateWebsiteCertificateAuthorityResponse EndDisassociateWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Retrieves a list of devices registered with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleets

        /// <summary>
        /// Retrieves a list of fleets for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebsiteCertificateAuthorities

        /// <summary>
        /// Retrieves a list of certificate authorities added for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListWebsiteCertificateAuthorities service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        public virtual ListWebsiteCertificateAuthoritiesResponse ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListWebsiteCertificateAuthoritiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebsiteCertificateAuthorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        public virtual IAsyncResult BeginListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebsiteCertificateAuthorities.</param>
        /// 
        /// <returns>Returns a  ListWebsiteCertificateAuthoritiesResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        public virtual ListWebsiteCertificateAuthoritiesResponse EndListWebsiteCertificateAuthorities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebsiteCertificateAuthoritiesResponse>(asyncResult);
        }

        #endregion
        
        #region  SignOutUser

        /// <summary>
        /// Signs the user out from all of their devices. The user can sign in again if they have
        /// valid credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser service method.</param>
        /// 
        /// <returns>The response from the SignOutUser service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        public virtual SignOutUserResponse SignOutUser(SignOutUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return Invoke<SignOutUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignOutUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        public virtual IAsyncResult BeginSignOutUser(SignOutUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignOutUser.</param>
        /// 
        /// <returns>Returns a  SignOutUserResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        public virtual SignOutUserResponse EndSignOutUser(IAsyncResult asyncResult)
        {
            return EndInvoke<SignOutUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuditStreamConfiguration

        /// <summary>
        /// Updates the audit stream configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        public virtual UpdateAuditStreamConfigurationResponse UpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAuditStreamConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuditStreamConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuditStreamConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAuditStreamConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        public virtual UpdateAuditStreamConfigurationResponse EndUpdateAuditStreamConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuditStreamConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCompanyNetworkConfiguration

        /// <summary>
        /// Updates the company network configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        public virtual UpdateCompanyNetworkConfigurationResponse UpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateCompanyNetworkConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCompanyNetworkConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCompanyNetworkConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateCompanyNetworkConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        public virtual UpdateCompanyNetworkConfigurationResponse EndUpdateCompanyNetworkConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCompanyNetworkConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevicePolicyConfiguration

        /// <summary>
        /// Updates the device policy configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        public virtual UpdateDevicePolicyConfigurationResponse UpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePolicyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevicePolicyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevicePolicyConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateDevicePolicyConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        public virtual UpdateDevicePolicyConfigurationResponse EndUpdateDevicePolicyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevicePolicyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetMetadata

        /// <summary>
        /// Updates fleet metadata, such as DisplayName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        public virtual UpdateFleetMetadataResponse UpdateFleetMetadata(UpdateFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateFleetMetadata(UpdateFleetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateFleetMetadataResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        public virtual UpdateFleetMetadataResponse EndUpdateFleetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityProviderConfiguration

        /// <summary>
        /// Updates the identity provider configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        public virtual UpdateIdentityProviderConfigurationResponse UpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        public virtual UpdateIdentityProviderConfigurationResponse EndUpdateIdentityProviderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityProviderConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}