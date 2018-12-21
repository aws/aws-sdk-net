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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FMS.Model;
using Amazon.FMS.Model.Internal.MarshallTransformations;
using Amazon.FMS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FMS
{
    /// <summary>
    /// Implementation for accessing FMS
    ///
    /// AWS Firewall Manager 
    /// <para>
    /// This is the <i>AWS Firewall Manager API Reference</i>. This guide is for developers
    /// who need detailed information about the AWS Firewall Manager API actions, data types,
    /// and errors. For detailed information about AWS Firewall Manager features, see the
    /// <a href="http://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">AWS
    /// Firewall Manager Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonFMSClient : AmazonServiceClient, IAmazonFMS
    {
        private static IServiceMetadata serviceMetadata = new AmazonFMSMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        public AmazonFMSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFMSConfig()) { }

        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        public AmazonFMSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFMSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(AmazonFMSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFMSClient(AWSCredentials credentials)
            : this(credentials, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFMSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials and an
        /// AmazonFMSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(AWSCredentials credentials, AmazonFMSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFMSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFMSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFMSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFMSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFMSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFMSConfig clientConfig)
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


        #region  AssociateAdminAccount

        internal virtual AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual Task<AssociateAdminAccountResponse> AssociateAdminAccountAsync(AssociateAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationChannel

        internal virtual DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual Task<DeleteNotificationChannelResponse> DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAdminAccount

        internal virtual DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual Task<DisassociateAdminAccountResponse> DisassociateAdminAccountAsync(DisassociateAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAdminAccount

        internal virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual Task<GetAdminAccountResponse> GetAdminAccountAsync(GetAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceDetail

        internal virtual GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual Task<GetComplianceDetailResponse> GetComplianceDetailAsync(GetComplianceDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceDetailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationChannel

        internal virtual GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<GetNotificationChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual Task<GetNotificationChannelResponse> GetNotificationChannelAsync(GetNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComplianceStatus

        internal virtual ListComplianceStatusResponse ListComplianceStatus(ListComplianceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return Invoke<ListComplianceStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListComplianceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        public virtual Task<ListComplianceStatusResponse> ListComplianceStatusAsync(ListComplianceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMemberAccounts

        internal virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMemberAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationChannel

        internal virtual PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<PutNotificationChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual Task<PutNotificationChannelResponse> PutNotificationChannelAsync(PutNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPolicy

        internal virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}