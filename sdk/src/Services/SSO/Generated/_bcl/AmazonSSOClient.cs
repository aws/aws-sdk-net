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
 * Do not modify this file. This file is generated from the sso-2019-06-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SSO.Model;
using Amazon.SSO.Model.Internal.MarshallTransformations;
using Amazon.SSO.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SSO
{
    /// <summary>
    /// <para>Implementation for accessing SSO</para>
    ///
    /// AWS IAM Identity Center (successor to AWS Single Sign-On) Portal is a web service
    /// that makes it easy for you to assign user access to IAM Identity Center resources
    /// such as the AWS access portal. Users can get AWS account applications and roles assigned
    /// to them and get federated into the application.
    /// 
    ///  <note> 
    /// <para>
    /// Although AWS Single Sign-On was renamed, the <c>sso</c> and <c>identitystore</c> API
    /// namespaces will continue to retain their original name for backward compatibility
    /// purposes. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html#renamed">IAM
    /// Identity Center rename</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This reference guide describes the IAM Identity Center Portal operations that you
    /// can call programatically and includes detailed information on data types and errors.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms, such as Java, Ruby, .Net, iOS, or Android. The SDKs provide
    /// a convenient way to create programmatic access to IAM Identity Center and other AWS
    /// services. For more information about the AWS SDKs, including how to download and install
    /// them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonSSOClient : AmazonServiceClient, IAmazonSSO
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSOMetadata();
        private ISSOPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSOPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSOPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSOClient with the credentials loaded from the application's
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
        public AmazonSSOClient()
            : base(new AmazonSSOConfig()) { }

        /// <summary>
        /// Constructs AmazonSSOClient with the credentials loaded from the application's
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
        public AmazonSSOClient(RegionEndpoint region)
            : base(new AmazonSSOConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSOClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSOClient Configuration Object</param>
        public AmazonSSOClient(AmazonSSOConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSOClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSOConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSOConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Credentials and an
        /// AmazonSSOClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSOClient Configuration Object</param>
        public AmazonSSOClient(AWSCredentials credentials, AmazonSSOConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSOClient Configuration Object</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSOConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSOClient Configuration Object</param>
        public AmazonSSOClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSOConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSOEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSOAuthSchemeHandler());
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


        #region  GetRoleCredentials


        /// <summary>
        /// Returns the STS short-term credentials for a given role name that is assigned to the
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// 
        /// <returns>The response from the GetRoleCredentials service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        public virtual GetRoleCredentialsResponse GetRoleCredentials(GetRoleCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoleCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetRoleCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Returns the STS short-term credentials for a given role name that is assigned to the
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoleCredentials service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        public virtual Task<GetRoleCredentialsResponse> GetRoleCredentialsAsync(GetRoleCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoleCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRoleCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountRoles


        /// <summary>
        /// Lists all roles that are assigned to the user for a given AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountRoles service method.</param>
        /// 
        /// <returns>The response from the ListAccountRoles service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccountRoles">REST API Reference for ListAccountRoles Operation</seealso>
        public virtual ListAccountRolesResponse ListAccountRoles(ListAccountRolesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountRolesResponseUnmarshaller.Instance;

            return Invoke<ListAccountRolesResponse>(request, options);
        }


        /// <summary>
        /// Lists all roles that are assigned to the user for a given AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountRoles service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccountRoles">REST API Reference for ListAccountRoles Operation</seealso>
        public virtual Task<ListAccountRolesResponse> ListAccountRolesAsync(ListAccountRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountRolesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountRolesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccounts


        /// <summary>
        /// Lists all AWS accounts assigned to the user. These AWS accounts are assigned by the
        /// administrator of the account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/useraccess.html#assignusers">Assign
        /// User Access</a> in the <i>IAM Identity Center User Guide</i>. This operation returns
        /// a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsResponse>(request, options);
        }


        /// <summary>
        /// Lists all AWS accounts assigned to the user. These AWS accounts are assigned by the
        /// administrator of the account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/useraccess.html#assignusers">Assign
        /// User Access</a> in the <i>IAM Identity Center User Guide</i>. This operation returns
        /// a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Logout


        /// <summary>
        /// Removes the locally stored SSO tokens from the client-side cache and sends an API
        /// call to the IAM Identity Center service to invalidate the corresponding server-side
        /// IAM Identity Center sign in session.
        /// 
        ///  <note> 
        /// <para>
        /// If a user uses IAM Identity Center to access the AWS CLI, the user’s IAM Identity
        /// Center sign in session is used to obtain an IAM session, as specified in the corresponding
        /// IAM Identity Center permission set. More specifically, IAM Identity Center assumes
        /// an IAM role in the target account on behalf of the user, and the corresponding temporary
        /// AWS credentials are returned to the client.
        /// </para>
        ///  
        /// <para>
        /// After user logout, any existing IAM role sessions that were created by using IAM Identity
        /// Center permission sets continue based on the duration configured in the permission
        /// set. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/authconcept.html">User
        /// authentications</a> in the <i>IAM Identity Center User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Logout service method.</param>
        /// 
        /// <returns>The response from the Logout service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/Logout">REST API Reference for Logout Operation</seealso>
        public virtual LogoutResponse Logout(LogoutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LogoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LogoutResponseUnmarshaller.Instance;

            return Invoke<LogoutResponse>(request, options);
        }


        /// <summary>
        /// Removes the locally stored SSO tokens from the client-side cache and sends an API
        /// call to the IAM Identity Center service to invalidate the corresponding server-side
        /// IAM Identity Center sign in session.
        /// 
        ///  <note> 
        /// <para>
        /// If a user uses IAM Identity Center to access the AWS CLI, the user’s IAM Identity
        /// Center sign in session is used to obtain an IAM session, as specified in the corresponding
        /// IAM Identity Center permission set. More specifically, IAM Identity Center assumes
        /// an IAM role in the target account on behalf of the user, and the corresponding temporary
        /// AWS credentials are returned to the client.
        /// </para>
        ///  
        /// <para>
        /// After user logout, any existing IAM role sessions that were created by using IAM Identity
        /// Center permission sets continue based on the duration configured in the permission
        /// set. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/authconcept.html">User
        /// authentications</a> in the <i>IAM Identity Center User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Logout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Logout service method, as returned by SSO.</returns>
        /// <exception cref="Amazon.SSO.Model.InvalidRequestException">
        /// Indicates that a problem occurred with the input to the request. For example, a required
        /// parameter might be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.TooManyRequestsException">
        /// Indicates that the request is being made too frequently and is more than what the
        /// server can handle.
        /// </exception>
        /// <exception cref="Amazon.SSO.Model.UnauthorizedException">
        /// Indicates that the request is not authorized. This can happen due to an invalid access
        /// token in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-2019-06-10/Logout">REST API Reference for Logout Operation</seealso>
        public virtual Task<LogoutResponse> LogoutAsync(LogoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LogoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LogoutResponseUnmarshaller.Instance;
            
            return InvokeAsync<LogoutResponse>(request, options, cancellationToken);
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