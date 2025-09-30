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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PcaConnectorAd.Model;
using Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations;
using Amazon.PcaConnectorAd.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PcaConnectorAd
{
    /// <summary>
    /// <para>Implementation for accessing PcaConnectorAd</para>
    ///
    /// Amazon Web Services Private CA Connector for Active Directory creates a connector
    /// between Amazon Web Services Private CA and Active Directory (AD) that enables you
    /// to provision security certificates for AD signed by a private CA that you own. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/ad-connector.html">Amazon
    /// Web Services Private CA Connector for Active Directory</a>.
    /// </summary>
    public partial class AmazonPcaConnectorAdClient : AmazonServiceClient, IAmazonPcaConnectorAd
    {
        private static IServiceMetadata serviceMetadata = new AmazonPcaConnectorAdMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPcaConnectorAdPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPcaConnectorAdPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PcaConnectorAdPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorAdClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPcaConnectorAdConfig()) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorAdClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPcaConnectorAdConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(AmazonPcaConnectorAdConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials)
            : this(credentials, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPcaConnectorAdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials and an
        /// AmazonPcaConnectorAdClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials, AmazonPcaConnectorAdConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorAdConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorAdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPcaConnectorAdConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorAdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorAdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPcaConnectorAdConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPcaConnectorAdEndpointResolver());
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


        #region  CreateConnector

        /// <summary>
        /// Creates a connector between Amazon Web Services Private CA and an Active Directory.
        /// You must specify the private CA, directory ID, and security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual IAsyncResult BeginCreateConnector(CreateConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnector.</param>
        /// 
        /// <returns>Returns a  CreateConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDirectoryRegistration

        /// <summary>
        /// Creates a directory registration that authorizes communication between Amazon Web
        /// Services Private CA and an Active Directory
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        public virtual CreateDirectoryRegistrationResponse CreateDirectoryRegistration(CreateDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        public virtual IAsyncResult BeginCreateDirectoryRegistration(CreateDirectoryRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        public virtual CreateDirectoryRegistrationResponse EndCreateDirectoryRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDirectoryRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServicePrincipalName

        /// <summary>
        /// Creates a service principal name (SPN) for the service account in Active Directory.
        /// Kerberos authentication uses SPNs to associate a service instance with a service sign-in
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the CreateServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        public virtual CreateServicePrincipalNameResponse CreateServicePrincipalName(CreateServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<CreateServicePrincipalNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        public virtual IAsyncResult BeginCreateServicePrincipalName(CreateServicePrincipalNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServicePrincipalNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  CreateServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        public virtual CreateServicePrincipalNameResponse EndCreateServicePrincipalName(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServicePrincipalNameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplate

        /// <summary>
        /// Creates an Active Directory compatible certificate template. The connectors issues
        /// certificates using these templates based on the requester’s Active Directory group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplateGroupAccessControlEntry

        /// <summary>
        /// Create a group access control entry. Allow or deny Active Directory groups from enrolling
        /// and/or autoenrolling with the template based on the group security identifiers (SIDs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual CreateTemplateGroupAccessControlEntryResponse CreateTemplateGroupAccessControlEntry(CreateTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateGroupAccessControlEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplateGroupAccessControlEntry(CreateTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  CreateTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual CreateTemplateGroupAccessControlEntryResponse EndCreateTemplateGroupAccessControlEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateGroupAccessControlEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnector

        /// <summary>
        /// Deletes a connector for Active Directory. You must provide the Amazon Resource Name
        /// (ARN) of the connector that you want to delete. You can find the ARN by calling the
        /// <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors</a>
        /// action. Deleting a connector does not deregister your directory with Amazon Web Services
        /// Private CA. You can deregister your directory by calling the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnector(DeleteConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnector.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDirectoryRegistration

        /// <summary>
        /// Deletes a directory registration. Deleting a directory registration deauthorizes Amazon
        /// Web Services Private CA with the directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        public virtual DeleteDirectoryRegistrationResponse DeleteDirectoryRegistration(DeleteDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        public virtual IAsyncResult BeginDeleteDirectoryRegistration(DeleteDirectoryRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        public virtual DeleteDirectoryRegistrationResponse EndDeleteDirectoryRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDirectoryRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServicePrincipalName

        /// <summary>
        /// Deletes the service principal name (SPN) used by a connector to authenticate with
        /// your Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the DeleteServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        public virtual DeleteServicePrincipalNameResponse DeleteServicePrincipalName(DeleteServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<DeleteServicePrincipalNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        public virtual IAsyncResult BeginDeleteServicePrincipalName(DeleteServicePrincipalNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServicePrincipalNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  DeleteServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        public virtual DeleteServicePrincipalNameResponse EndDeleteServicePrincipalName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServicePrincipalNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTemplate

        /// <summary>
        /// Deletes a template. Certificates issued using the template are still valid until they
        /// are revoked or expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTemplateGroupAccessControlEntry

        /// <summary>
        /// Deletes a group access control entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        public virtual DeleteTemplateGroupAccessControlEntryResponse DeleteTemplateGroupAccessControlEntry(DeleteTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateGroupAccessControlEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplateGroupAccessControlEntry(DeleteTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        public virtual DeleteTemplateGroupAccessControlEntryResponse EndDeleteTemplateGroupAccessControlEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateGroupAccessControlEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnector

        /// <summary>
        /// Lists information about your connector. You specify the connector on input by its
        /// ARN (Amazon Resource Name).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual GetConnectorResponse GetConnector(GetConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;

            return Invoke<GetConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual IAsyncResult BeginGetConnector(GetConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnector.</param>
        /// 
        /// <returns>Returns a  GetConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual GetConnectorResponse EndGetConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDirectoryRegistration

        /// <summary>
        /// A structure that contains information about your directory registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        public virtual GetDirectoryRegistrationResponse GetDirectoryRegistration(GetDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        public virtual IAsyncResult BeginGetDirectoryRegistration(GetDirectoryRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  GetDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        public virtual GetDirectoryRegistrationResponse EndGetDirectoryRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDirectoryRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServicePrincipalName

        /// <summary>
        /// Lists the service principal name that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the GetServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        public virtual GetServicePrincipalNameResponse GetServicePrincipalName(GetServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<GetServicePrincipalNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        public virtual IAsyncResult BeginGetServicePrincipalName(GetServicePrincipalNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicePrincipalNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  GetServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        public virtual GetServicePrincipalNameResponse EndGetServicePrincipalName(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServicePrincipalNameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplate

        /// <summary>
        /// Retrieves a certificate template that the connector uses to issue certificates from
        /// a private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplateGroupAccessControlEntry

        /// <summary>
        /// Retrieves the group access control entries for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the GetTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        public virtual GetTemplateGroupAccessControlEntryResponse GetTemplateGroupAccessControlEntry(GetTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateGroupAccessControlEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        public virtual IAsyncResult BeginGetTemplateGroupAccessControlEntry(GetTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  GetTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        public virtual GetTemplateGroupAccessControlEntryResponse EndGetTemplateGroupAccessControlEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateGroupAccessControlEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectors

        /// <summary>
        /// Lists the connectors that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual IAsyncResult BeginListConnectors(ListConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectors.</param>
        /// 
        /// <returns>Returns a  ListConnectorsResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDirectoryRegistrations

        /// <summary>
        /// Lists the directory registrations that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListDirectoryRegistrations service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        public virtual ListDirectoryRegistrationsResponse ListDirectoryRegistrations(ListDirectoryRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoryRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoryRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListDirectoryRegistrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDirectoryRegistrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDirectoryRegistrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        public virtual IAsyncResult BeginListDirectoryRegistrations(ListDirectoryRegistrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoryRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoryRegistrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDirectoryRegistrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDirectoryRegistrations.</param>
        /// 
        /// <returns>Returns a  ListDirectoryRegistrationsResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        public virtual ListDirectoryRegistrationsResponse EndListDirectoryRegistrations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDirectoryRegistrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServicePrincipalNames

        /// <summary>
        /// Lists the service principal names that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames service method.</param>
        /// 
        /// <returns>The response from the ListServicePrincipalNames service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        public virtual ListServicePrincipalNamesResponse ListServicePrincipalNames(ListServicePrincipalNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicePrincipalNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePrincipalNamesResponseUnmarshaller.Instance;

            return Invoke<ListServicePrincipalNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServicePrincipalNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServicePrincipalNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        public virtual IAsyncResult BeginListServicePrincipalNames(ListServicePrincipalNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicePrincipalNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePrincipalNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServicePrincipalNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServicePrincipalNames.</param>
        /// 
        /// <returns>Returns a  ListServicePrincipalNamesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        public virtual ListServicePrincipalNamesResponse EndListServicePrincipalNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicePrincipalNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags, if any, that are associated with your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplateGroupAccessControlEntries

        /// <summary>
        /// Lists group access control entries you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries service method.</param>
        /// 
        /// <returns>The response from the ListTemplateGroupAccessControlEntries service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        public virtual ListTemplateGroupAccessControlEntriesResponse ListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateGroupAccessControlEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateGroupAccessControlEntriesResponseUnmarshaller.Instance;

            return Invoke<ListTemplateGroupAccessControlEntriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateGroupAccessControlEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateGroupAccessControlEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        public virtual IAsyncResult BeginListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateGroupAccessControlEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateGroupAccessControlEntriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateGroupAccessControlEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateGroupAccessControlEntries.</param>
        /// 
        /// <returns>Returns a  ListTemplateGroupAccessControlEntriesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        public virtual ListTemplateGroupAccessControlEntriesResponse EndListTemplateGroupAccessControlEntries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplateGroupAccessControlEntriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplates

        /// <summary>
        /// Lists the templates, if any, that are associated with a connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplate

        /// <summary>
        /// Update template configuration to define the information included in certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplateGroupAccessControlEntry

        /// <summary>
        /// Update a group access control entry you created using <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplateGroupAccessControlEntry.html">CreateTemplateGroupAccessControlEntry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual UpdateTemplateGroupAccessControlEntryResponse UpdateTemplateGroupAccessControlEntry(UpdateTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateGroupAccessControlEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplateGroupAccessControlEntry(UpdateTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual UpdateTemplateGroupAccessControlEntryResponse EndUpdateTemplateGroupAccessControlEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateGroupAccessControlEntryResponse>(asyncResult);
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
            var resolver = new AmazonPcaConnectorAdEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}