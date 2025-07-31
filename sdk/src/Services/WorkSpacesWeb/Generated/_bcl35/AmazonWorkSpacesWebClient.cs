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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkSpacesWeb.Model;
using Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations;
using Amazon.WorkSpacesWeb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.WorkSpacesWeb
{
    /// <summary>
    /// <para>Implementation for accessing WorkSpacesWeb</para>
    ///
    /// Amazon WorkSpaces Secure Browser is a low cost, fully managed WorkSpace built specifically
    /// to facilitate secure, web-based workloads. WorkSpaces Secure Browser makes it easy
    /// for customers to safely provide their employees with access to internal websites and
    /// SaaS web applications without the administrative burden of appliances or specialized
    /// client software. WorkSpaces Secure Browser provides simple policy tools tailored for
    /// user interactions, while offloading common tasks like capacity management, scaling,
    /// and maintaining browser images.
    /// </summary>
    public partial class AmazonWorkSpacesWebClient : AmazonServiceClient, IAmazonWorkSpacesWeb
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkSpacesWebMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IWorkSpacesWebPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkSpacesWebPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkSpacesWebPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesWebClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesWebConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesWebClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesWebConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(AmazonWorkSpacesWebConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkSpacesWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials and an
        /// AmazonWorkSpacesWebClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials, AmazonWorkSpacesWebConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesWebConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkSpacesWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkSpacesWebConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkSpacesWebEndpointResolver());
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


        #region  AssociateBrowserSettings

        /// <summary>
        /// Associates a browser settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        public virtual AssociateBrowserSettingsResponse AssociateBrowserSettings(AssociateBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateBrowserSettings(AssociateBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  AssociateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        public virtual AssociateBrowserSettingsResponse EndAssociateBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDataProtectionSettings

        /// <summary>
        /// Associates a data protection settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        public virtual AssociateDataProtectionSettingsResponse AssociateDataProtectionSettings(AssociateDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateDataProtectionSettings(AssociateDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  AssociateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        public virtual AssociateDataProtectionSettingsResponse EndAssociateDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateIpAccessSettings

        /// <summary>
        /// Associates an IP access settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        public virtual AssociateIpAccessSettingsResponse AssociateIpAccessSettings(AssociateIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateIpAccessSettings(AssociateIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  AssociateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        public virtual AssociateIpAccessSettingsResponse EndAssociateIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateNetworkSettings

        /// <summary>
        /// Associates a network settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        public virtual AssociateNetworkSettingsResponse AssociateNetworkSettings(AssociateNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateNetworkSettings(AssociateNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  AssociateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        public virtual AssociateNetworkSettingsResponse EndAssociateNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSessionLogger

        /// <summary>
        /// Associates a session logger with a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the AssociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        public virtual AssociateSessionLoggerResponse AssociateSessionLogger(AssociateSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<AssociateSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginAssociateSessionLogger(AssociateSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSessionLogger.</param>
        /// 
        /// <returns>Returns a  AssociateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        public virtual AssociateSessionLoggerResponse EndAssociateSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateTrustStore

        /// <summary>
        /// Associates a trust store with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the AssociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        public virtual AssociateTrustStoreResponse AssociateTrustStore(AssociateTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<AssociateTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        public virtual IAsyncResult BeginAssociateTrustStore(AssociateTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrustStore.</param>
        /// 
        /// <returns>Returns a  AssociateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        public virtual AssociateTrustStoreResponse EndAssociateTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateUserAccessLoggingSettings

        /// <summary>
        /// Associates a user access logging settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        public virtual AssociateUserAccessLoggingSettingsResponse AssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  AssociateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        public virtual AssociateUserAccessLoggingSettingsResponse EndAssociateUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateUserSettings

        /// <summary>
        /// Associates a user settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        public virtual AssociateUserSettingsResponse AssociateUserSettings(AssociateUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        public virtual IAsyncResult BeginAssociateUserSettings(AssociateUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateUserSettings.</param>
        /// 
        /// <returns>Returns a  AssociateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        public virtual AssociateUserSettingsResponse EndAssociateUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBrowserSettings

        /// <summary>
        /// Creates a browser settings resource that can be associated with a web portal. Once
        /// associated with a web portal, browser settings control how the browser will behave
        /// once a user starts a streaming session for the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        public virtual CreateBrowserSettingsResponse CreateBrowserSettings(CreateBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateBrowserSettings(CreateBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  CreateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        public virtual CreateBrowserSettingsResponse EndCreateBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataProtectionSettings

        /// <summary>
        /// Creates a data protection settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the CreateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        public virtual CreateDataProtectionSettingsResponse CreateDataProtectionSettings(CreateDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateDataProtectionSettings(CreateDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  CreateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        public virtual CreateDataProtectionSettingsResponse EndCreateDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdentityProvider

        /// <summary>
        /// Creates an identity provider resource that is then associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginCreateIdentityProvider(CreateIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  CreateIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual CreateIdentityProviderResponse EndCreateIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIpAccessSettings

        /// <summary>
        /// Creates an IP access settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the CreateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        public virtual CreateIpAccessSettingsResponse CreateIpAccessSettings(CreateIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateIpAccessSettings(CreateIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  CreateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        public virtual CreateIpAccessSettingsResponse EndCreateIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkSettings

        /// <summary>
        /// Creates a network settings resource that can be associated with a web portal. Once
        /// associated with a web portal, network settings define how streaming instances will
        /// connect with your specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        public virtual CreateNetworkSettingsResponse CreateNetworkSettings(CreateNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateNetworkSettings(CreateNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  CreateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        public virtual CreateNetworkSettingsResponse EndCreateNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortal

        /// <summary>
        /// Creates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual IAsyncResult BeginCreatePortal(CreatePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortal.</param>
        /// 
        /// <returns>Returns a  CreatePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse EndCreatePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSessionLogger

        /// <summary>
        /// Creates a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the CreateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        public virtual CreateSessionLoggerResponse CreateSessionLogger(CreateSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<CreateSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginCreateSessionLogger(CreateSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSessionLogger.</param>
        /// 
        /// <returns>Returns a  CreateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        public virtual CreateSessionLoggerResponse EndCreateSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrustStore

        /// <summary>
        /// Creates a trust store that can be associated with a web portal. A trust store contains
        /// certificate authority (CA) certificates. Once associated with a web portal, the browser
        /// in a streaming session will recognize certificates that have been issued using any
        /// of the CAs in the trust store. If your organization has internal websites that use
        /// certificates issued by private CAs, you should add the private CA certificate to the
        /// trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        public virtual CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<CreateTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        public virtual IAsyncResult BeginCreateTrustStore(CreateTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustStore.</param>
        /// 
        /// <returns>Returns a  CreateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        public virtual CreateTrustStoreResponse EndCreateTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserAccessLoggingSettings

        /// <summary>
        /// Creates a user access logging settings resource that can be associated with a web
        /// portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        public virtual CreateUserAccessLoggingSettingsResponse CreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  CreateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        public virtual CreateUserAccessLoggingSettingsResponse EndCreateUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserSettings

        /// <summary>
        /// Creates a user settings resource that can be associated with a web portal. Once associated
        /// with a web portal, user settings control how users can transfer data between a streaming
        /// session and the their local devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        public virtual CreateUserSettingsResponse CreateUserSettings(CreateUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        public virtual IAsyncResult BeginCreateUserSettings(CreateUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserSettings.</param>
        /// 
        /// <returns>Returns a  CreateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        public virtual CreateUserSettingsResponse EndCreateUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBrowserSettings

        /// <summary>
        /// Deletes browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        public virtual DeleteBrowserSettingsResponse DeleteBrowserSettings(DeleteBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteBrowserSettings(DeleteBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrowserSettings.</param>
        /// 
        /// <returns>Returns a  DeleteBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        public virtual DeleteBrowserSettingsResponse EndDeleteBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataProtectionSettings

        /// <summary>
        /// Deletes data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        public virtual DeleteDataProtectionSettingsResponse DeleteDataProtectionSettings(DeleteDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataProtectionSettings(DeleteDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  DeleteDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        public virtual DeleteDataProtectionSettingsResponse EndDeleteDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdentityProvider

        /// <summary>
        /// Deletes the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdentityProvider(DeleteIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual DeleteIdentityProviderResponse EndDeleteIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIpAccessSettings

        /// <summary>
        /// Deletes IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        public virtual DeleteIpAccessSettingsResponse DeleteIpAccessSettings(DeleteIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteIpAccessSettings(DeleteIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  DeleteIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        public virtual DeleteIpAccessSettingsResponse EndDeleteIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkSettings

        /// <summary>
        /// Deletes network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        public virtual DeleteNetworkSettingsResponse DeleteNetworkSettings(DeleteNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteNetworkSettings(DeleteNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkSettings.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        public virtual DeleteNetworkSettingsResponse EndDeleteNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePortal

        /// <summary>
        /// Deletes a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual IAsyncResult BeginDeletePortal(DeletePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortal.</param>
        /// 
        /// <returns>Returns a  DeletePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse EndDeletePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSessionLogger

        /// <summary>
        /// Deletes a session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSessionLogger service method.</param>
        /// 
        /// <returns>The response from the DeleteSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        public virtual DeleteSessionLoggerResponse DeleteSessionLogger(DeleteSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<DeleteSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginDeleteSessionLogger(DeleteSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSessionLogger.</param>
        /// 
        /// <returns>Returns a  DeleteSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        public virtual DeleteSessionLoggerResponse EndDeleteSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrustStore

        /// <summary>
        /// Deletes the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        public virtual DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrustStore(DeleteTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustStore.</param>
        /// 
        /// <returns>Returns a  DeleteTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        public virtual DeleteTrustStoreResponse EndDeleteTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserAccessLoggingSettings

        /// <summary>
        /// Deletes user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        public virtual DeleteUserAccessLoggingSettingsResponse DeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  DeleteUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        public virtual DeleteUserAccessLoggingSettingsResponse EndDeleteUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserSettings

        /// <summary>
        /// Deletes user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        public virtual DeleteUserSettingsResponse DeleteUserSettings(DeleteUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserSettings(DeleteUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserSettings.</param>
        /// 
        /// <returns>Returns a  DeleteUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        public virtual DeleteUserSettingsResponse EndDeleteUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateBrowserSettings

        /// <summary>
        /// Disassociates browser settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        public virtual DisassociateBrowserSettingsResponse DisassociateBrowserSettings(DisassociateBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateBrowserSettings(DisassociateBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        public virtual DisassociateBrowserSettingsResponse EndDisassociateBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDataProtectionSettings

        /// <summary>
        /// Disassociates data protection settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        public virtual DisassociateDataProtectionSettingsResponse DisassociateDataProtectionSettings(DisassociateDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDataProtectionSettings(DisassociateDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        public virtual DisassociateDataProtectionSettingsResponse EndDisassociateDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateIpAccessSettings

        /// <summary>
        /// Disassociates IP access settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        public virtual DisassociateIpAccessSettingsResponse DisassociateIpAccessSettings(DisassociateIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateIpAccessSettings(DisassociateIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        public virtual DisassociateIpAccessSettingsResponse EndDisassociateIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateNetworkSettings

        /// <summary>
        /// Disassociates network settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        public virtual DisassociateNetworkSettingsResponse DisassociateNetworkSettings(DisassociateNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateNetworkSettings(DisassociateNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        public virtual DisassociateNetworkSettingsResponse EndDisassociateNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSessionLogger

        /// <summary>
        /// Disassociates a session logger from a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the DisassociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        public virtual DisassociateSessionLoggerResponse DisassociateSessionLogger(DisassociateSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<DisassociateSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSessionLogger(DisassociateSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSessionLogger.</param>
        /// 
        /// <returns>Returns a  DisassociateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        public virtual DisassociateSessionLoggerResponse EndDisassociateSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTrustStore

        /// <summary>
        /// Disassociates a trust store from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        public virtual DisassociateTrustStoreResponse DisassociateTrustStore(DisassociateTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<DisassociateTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTrustStore(DisassociateTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrustStore.</param>
        /// 
        /// <returns>Returns a  DisassociateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        public virtual DisassociateTrustStoreResponse EndDisassociateTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateUserAccessLoggingSettings

        /// <summary>
        /// Disassociates user access logging settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        public virtual DisassociateUserAccessLoggingSettingsResponse DisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        public virtual DisassociateUserAccessLoggingSettingsResponse EndDisassociateUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateUserSettings

        /// <summary>
        /// Disassociates user settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        public virtual DisassociateUserSettingsResponse DisassociateUserSettings(DisassociateUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        public virtual IAsyncResult BeginDisassociateUserSettings(DisassociateUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateUserSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        public virtual DisassociateUserSettingsResponse EndDisassociateUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExpireSession

        /// <summary>
        /// Expires an active secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExpireSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual IAsyncResult BeginExpireSession(ExpireSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExpireSession.</param>
        /// 
        /// <returns>Returns a  ExpireSessionResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual ExpireSessionResponse EndExpireSession(IAsyncResult asyncResult)
        {
            return EndInvoke<ExpireSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBrowserSettings

        /// <summary>
        /// Gets browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the GetBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        public virtual GetBrowserSettingsResponse GetBrowserSettings(GetBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<GetBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginGetBrowserSettings(GetBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBrowserSettings.</param>
        /// 
        /// <returns>Returns a  GetBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        public virtual GetBrowserSettingsResponse EndGetBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataProtectionSettings

        /// <summary>
        /// Gets the data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the GetDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        public virtual GetDataProtectionSettingsResponse GetDataProtectionSettings(GetDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginGetDataProtectionSettings(GetDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  GetDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        public virtual GetDataProtectionSettingsResponse EndGetDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityProvider

        /// <summary>
        /// Gets the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the GetIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        public virtual GetIdentityProviderResponse GetIdentityProvider(GetIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginGetIdentityProvider(GetIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityProvider.</param>
        /// 
        /// <returns>Returns a  GetIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        public virtual GetIdentityProviderResponse EndGetIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIpAccessSettings

        /// <summary>
        /// Gets the IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the GetIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        public virtual GetIpAccessSettingsResponse GetIpAccessSettings(GetIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<GetIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginGetIpAccessSettings(GetIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  GetIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        public virtual GetIpAccessSettingsResponse EndGetIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkSettings

        /// <summary>
        /// Gets the network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkSettings(GetNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkSettings.</param>
        /// 
        /// <returns>Returns a  GetNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual GetNetworkSettingsResponse EndGetNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPortal

        /// <summary>
        /// Gets the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual IAsyncResult BeginGetPortal(GetPortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortal.</param>
        /// 
        /// <returns>Returns a  GetPortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual GetPortalResponse EndGetPortal(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPortalResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPortalServiceProviderMetadata

        /// <summary>
        /// Gets the service provider metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata service method.</param>
        /// 
        /// <returns>The response from the GetPortalServiceProviderMetadata service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        public virtual GetPortalServiceProviderMetadataResponse GetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortalServiceProviderMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalServiceProviderMetadataResponseUnmarshaller.Instance;

            return Invoke<GetPortalServiceProviderMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortalServiceProviderMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortalServiceProviderMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPortalServiceProviderMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalServiceProviderMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortalServiceProviderMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortalServiceProviderMetadata.</param>
        /// 
        /// <returns>Returns a  GetPortalServiceProviderMetadataResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        public virtual GetPortalServiceProviderMetadataResponse EndGetPortalServiceProviderMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPortalServiceProviderMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSession

        /// <summary>
        /// Gets information for a secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSessionLogger

        /// <summary>
        /// Gets details about a specific session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionLogger service method.</param>
        /// 
        /// <returns>The response from the GetSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        public virtual GetSessionLoggerResponse GetSessionLogger(GetSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<GetSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginGetSessionLogger(GetSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionLogger.</param>
        /// 
        /// <returns>Returns a  GetSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        public virtual GetSessionLoggerResponse EndGetSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrustStore

        /// <summary>
        /// Gets the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        public virtual GetTrustStoreResponse GetTrustStore(GetTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreResponseUnmarshaller.Instance;

            return Invoke<GetTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        public virtual IAsyncResult BeginGetTrustStore(GetTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStore.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        public virtual GetTrustStoreResponse EndGetTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrustStoreCertificate

        /// <summary>
        /// Gets the trust store certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate service method.</param>
        /// 
        /// <returns>The response from the GetTrustStoreCertificate service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        public virtual GetTrustStoreCertificateResponse GetTrustStoreCertificate(GetTrustStoreCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrustStoreCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreCertificateResponseUnmarshaller.Instance;

            return Invoke<GetTrustStoreCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStoreCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStoreCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetTrustStoreCertificate(GetTrustStoreCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrustStoreCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStoreCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStoreCertificate.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreCertificateResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        public virtual GetTrustStoreCertificateResponse EndGetTrustStoreCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrustStoreCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserAccessLoggingSettings

        /// <summary>
        /// Gets user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        public virtual GetUserAccessLoggingSettingsResponse GetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<GetUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginGetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  GetUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        public virtual GetUserAccessLoggingSettingsResponse EndGetUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserSettings

        /// <summary>
        /// Gets user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<GetUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual IAsyncResult BeginGetUserSettings(GetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserSettings.</param>
        /// 
        /// <returns>Returns a  GetUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual GetUserSettingsResponse EndGetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBrowserSettings

        /// <summary>
        /// Retrieves a list of browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the ListBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        public virtual ListBrowserSettingsResponse ListBrowserSettings(ListBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<ListBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginListBrowserSettings(ListBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrowserSettings.</param>
        /// 
        /// <returns>Returns a  ListBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        public virtual ListBrowserSettingsResponse EndListBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataProtectionSettings

        /// <summary>
        /// Retrieves a list of data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the ListDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        public virtual ListDataProtectionSettingsResponse ListDataProtectionSettings(ListDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<ListDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginListDataProtectionSettings(ListDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  ListDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        public virtual ListDataProtectionSettingsResponse EndListDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityProviders

        /// <summary>
        /// Retrieves a list of identity providers for a specific web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual IAsyncResult BeginListIdentityProviders(ListIdentityProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviders.</param>
        /// 
        /// <returns>Returns a  ListIdentityProvidersResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual ListIdentityProvidersResponse EndListIdentityProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIpAccessSettings

        /// <summary>
        /// Retrieves a list of IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the ListIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        public virtual ListIpAccessSettingsResponse ListIpAccessSettings(ListIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<ListIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginListIpAccessSettings(ListIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  ListIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        public virtual ListIpAccessSettingsResponse EndListIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworkSettings

        /// <summary>
        /// Retrieves a list of network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        public virtual ListNetworkSettingsResponse ListNetworkSettings(ListNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginListNetworkSettings(ListNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkSettings.</param>
        /// 
        /// <returns>Returns a  ListNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        public virtual ListNetworkSettingsResponse EndListNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPortals

        /// <summary>
        /// Retrieves a list or web portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortals operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual IAsyncResult BeginListPortals(ListPortalsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortals.</param>
        /// 
        /// <returns>Returns a  ListPortalsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse EndListPortals(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPortalsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSessionLoggers

        /// <summary>
        /// Lists all available session logger resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionLoggers service method.</param>
        /// 
        /// <returns>The response from the ListSessionLoggers service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        public virtual ListSessionLoggersResponse ListSessionLoggers(ListSessionLoggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionLoggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionLoggersResponseUnmarshaller.Instance;

            return Invoke<ListSessionLoggersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessionLoggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionLoggers operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionLoggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        public virtual IAsyncResult BeginListSessionLoggers(ListSessionLoggersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionLoggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionLoggersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionLoggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionLoggers.</param>
        /// 
        /// <returns>Returns a  ListSessionLoggersResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        public virtual ListSessionLoggersResponse EndListSessionLoggers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionLoggersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSessions

        /// <summary>
        /// Lists information for multiple secure browser sessions from a specific portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrustStoreCertificates

        /// <summary>
        /// Retrieves a list of trust store certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates service method.</param>
        /// 
        /// <returns>The response from the ListTrustStoreCertificates service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        public virtual ListTrustStoreCertificatesResponse ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustStoreCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoreCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListTrustStoreCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustStoreCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustStoreCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        public virtual IAsyncResult BeginListTrustStoreCertificates(ListTrustStoreCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustStoreCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoreCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustStoreCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustStoreCertificates.</param>
        /// 
        /// <returns>Returns a  ListTrustStoreCertificatesResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        public virtual ListTrustStoreCertificatesResponse EndListTrustStoreCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrustStoreCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrustStores

        /// <summary>
        /// Retrieves a list of trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        public virtual ListTrustStoresResponse ListTrustStores(ListTrustStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoresResponseUnmarshaller.Instance;

            return Invoke<ListTrustStoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        public virtual IAsyncResult BeginListTrustStores(ListTrustStoresRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustStores.</param>
        /// 
        /// <returns>Returns a  ListTrustStoresResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        public virtual ListTrustStoresResponse EndListTrustStores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrustStoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserAccessLoggingSettings

        /// <summary>
        /// Retrieves a list of user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        public virtual ListUserAccessLoggingSettingsResponse ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<ListUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  ListUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        public virtual ListUserAccessLoggingSettingsResponse EndListUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserSettings

        /// <summary>
        /// Retrieves a list of user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        public virtual ListUserSettingsResponse ListUserSettings(ListUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserSettingsResponseUnmarshaller.Instance;

            return Invoke<ListUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        public virtual IAsyncResult BeginListUserSettings(ListUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserSettings.</param>
        /// 
        /// <returns>Returns a  ListUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        public virtual ListUserSettingsResponse EndListUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.TooManyTagsException">
        /// There are too many tags.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBrowserSettings

        /// <summary>
        /// Updates browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        public virtual UpdateBrowserSettingsResponse UpdateBrowserSettings(UpdateBrowserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateBrowserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateBrowserSettings(UpdateBrowserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        public virtual UpdateBrowserSettingsResponse EndUpdateBrowserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBrowserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataProtectionSettings

        /// <summary>
        /// Updates data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        public virtual UpdateDataProtectionSettingsResponse UpdateDataProtectionSettings(UpdateDataProtectionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataProtectionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataProtectionSettings(UpdateDataProtectionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataProtectionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  UpdateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        public virtual UpdateDataProtectionSettingsResponse EndUpdateDataProtectionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataProtectionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityProvider

        /// <summary>
        /// Updates the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdentityProvider(UpdateIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual UpdateIdentityProviderResponse EndUpdateIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIpAccessSettings

        /// <summary>
        /// Updates IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        public virtual UpdateIpAccessSettingsResponse UpdateIpAccessSettings(UpdateIpAccessSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateIpAccessSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateIpAccessSettings(UpdateIpAccessSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpAccessSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  UpdateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        public virtual UpdateIpAccessSettingsResponse EndUpdateIpAccessSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIpAccessSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkSettings

        /// <summary>
        /// Updates network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetworkSettings(UpdateNetworkSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual UpdateNetworkSettingsResponse EndUpdateNetworkSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePortal

        /// <summary>
        /// Updates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual IAsyncResult BeginUpdatePortal(UpdatePortalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortal.</param>
        /// 
        /// <returns>Returns a  UpdatePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse EndUpdatePortal(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePortalResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSessionLogger

        /// <summary>
        /// Updates the details of a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the UpdateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        public virtual UpdateSessionLoggerResponse UpdateSessionLogger(UpdateSessionLoggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionLoggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        public virtual IAsyncResult BeginUpdateSessionLogger(UpdateSessionLoggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionLoggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSessionLogger.</param>
        /// 
        /// <returns>Returns a  UpdateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        public virtual UpdateSessionLoggerResponse EndUpdateSessionLogger(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSessionLoggerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrustStore

        /// <summary>
        /// Updates the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        public virtual UpdateTrustStoreResponse UpdateTrustStore(UpdateTrustStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrustStore(UpdateTrustStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustStore.</param>
        /// 
        /// <returns>Returns a  UpdateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        public virtual UpdateTrustStoreResponse EndUpdateTrustStore(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrustStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserAccessLoggingSettings

        /// <summary>
        /// Updates the user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        public virtual UpdateUserAccessLoggingSettingsResponse UpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAccessLoggingSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        public virtual UpdateUserAccessLoggingSettingsResponse EndUpdateUserAccessLoggingSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserAccessLoggingSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserSettings

        /// <summary>
        /// Updates the user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserSettings(UpdateUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual UpdateUserSettingsResponse EndUpdateUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserSettingsResponse>(asyncResult);
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
            var resolver = new AmazonWorkSpacesWebEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}