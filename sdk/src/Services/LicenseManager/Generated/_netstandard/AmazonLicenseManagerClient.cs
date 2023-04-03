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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LicenseManager.Model;
using Amazon.LicenseManager.Model.Internal.MarshallTransformations;
using Amazon.LicenseManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Implementation for accessing LicenseManager
    ///
    /// License Manager makes it easier to manage licenses from software vendors across multiple
    /// Amazon Web Services accounts and on-premises servers.
    /// </summary>
    public partial class AmazonLicenseManagerClient : AmazonServiceClient, IAmazonLicenseManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonLicenseManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AmazonLicenseManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials and an
        /// AmazonLicenseManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, AmazonLicenseManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLicenseManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLicenseManagerConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLicenseManagerEndpointResolver());
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


        #region  AcceptGrant

        internal virtual AcceptGrantResponse AcceptGrant(AcceptGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptGrantResponseUnmarshaller.Instance;

            return Invoke<AcceptGrantResponse>(request, options);
        }



        /// <summary>
        /// Accepts the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        public virtual Task<AcceptGrantResponse> AcceptGrantAsync(AcceptGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptGrantResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckInLicense

        internal virtual CheckInLicenseResponse CheckInLicense(CheckInLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckInLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckInLicenseResponseUnmarshaller.Instance;

            return Invoke<CheckInLicenseResponse>(request, options);
        }



        /// <summary>
        /// Checks in the specified license. Check in a license when it is no longer in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckInLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckInLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        public virtual Task<CheckInLicenseResponse> CheckInLicenseAsync(CheckInLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckInLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckInLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<CheckInLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckoutBorrowLicense

        internal virtual CheckoutBorrowLicenseResponse CheckoutBorrowLicense(CheckoutBorrowLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckoutBorrowLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckoutBorrowLicenseResponseUnmarshaller.Instance;

            return Invoke<CheckoutBorrowLicenseResponse>(request, options);
        }



        /// <summary>
        /// Checks out the specified license for offline use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutBorrowLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckoutBorrowLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.EntitlementNotAllowedException">
        /// The entitlement is not allowed.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        public virtual Task<CheckoutBorrowLicenseResponse> CheckoutBorrowLicenseAsync(CheckoutBorrowLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckoutBorrowLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckoutBorrowLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<CheckoutBorrowLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckoutLicense

        internal virtual CheckoutLicenseResponse CheckoutLicense(CheckoutLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckoutLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckoutLicenseResponseUnmarshaller.Instance;

            return Invoke<CheckoutLicenseResponse>(request, options);
        }



        /// <summary>
        /// Checks out the specified license.
        /// 
        ///  <note> 
        /// <para>
        /// If the account that created the license is the same that is performing the check out,
        /// you must specify the account as the beneficiary.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckoutLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        public virtual Task<CheckoutLicenseResponse> CheckoutLicenseAsync(CheckoutLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckoutLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckoutLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<CheckoutLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant

        internal virtual CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantResponse>(request, options);
        }



        /// <summary>
        /// Creates a grant for the specified license. A grant shares the use of license entitlements
        /// with a specific Amazon Web Services account, an organization, or an organizational
        /// unit (OU). For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGrantVersion

        internal virtual CreateGrantVersionResponse CreateGrantVersion(CreateGrantVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantVersionResponseUnmarshaller.Instance;

            return Invoke<CreateGrantVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of the specified grant. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrantVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrantVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        public virtual Task<CreateGrantVersionResponse> CreateGrantVersionAsync(CreateGrantVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicense

        internal virtual CreateLicenseResponse CreateLicense(CreateLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseResponse>(request, options);
        }



        /// <summary>
        /// Creates a license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        public virtual Task<CreateLicenseResponse> CreateLicenseAsync(CreateLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicenseConfiguration

        internal virtual CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        public virtual Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicenseConversionTaskForResource

        internal virtual CreateLicenseConversionTaskForResourceResponse CreateLicenseConversionTaskForResource(CreateLicenseConversionTaskForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConversionTaskForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConversionTaskForResourceResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseConversionTaskForResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new license conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConversionTaskForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseConversionTaskForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        public virtual Task<CreateLicenseConversionTaskForResourceResponse> CreateLicenseConversionTaskForResourceAsync(CreateLicenseConversionTaskForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConversionTaskForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConversionTaskForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseConversionTaskForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicenseManagerReportGenerator

        internal virtual CreateLicenseManagerReportGeneratorResponse CreateLicenseManagerReportGenerator(CreateLicenseManagerReportGeneratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseManagerReportGeneratorResponse>(request, options);
        }



        /// <summary>
        /// Creates a report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        public virtual Task<CreateLicenseManagerReportGeneratorResponse> CreateLicenseManagerReportGeneratorAsync(CreateLicenseManagerReportGeneratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseManagerReportGeneratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicenseVersion

        internal virtual CreateLicenseVersionResponse CreateLicenseVersion(CreateLicenseVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        public virtual Task<CreateLicenseVersionResponse> CreateLicenseVersionAsync(CreateLicenseVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateToken

        internal virtual CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return Invoke<CreateTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates a long-lived token.
        /// 
        ///  
        /// <para>
        /// A refresh token is a JWT token used to get an access token. With an access token,
        /// you can call AssumeRoleWithWebIdentity to get role credentials that you can use to
        /// call License Manager to manage the specified license.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGrant

        internal virtual DeleteGrantResponse DeleteGrant(DeleteGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteGrantResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        public virtual Task<DeleteGrantResponse> DeleteGrantAsync(DeleteGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicense

        internal virtual DeleteLicenseResponse DeleteLicense(DeleteLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        public virtual Task<DeleteLicenseResponse> DeleteLicenseAsync(DeleteLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicenseConfiguration

        internal virtual DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        public virtual Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicenseManagerReportGenerator

        internal virtual DeleteLicenseManagerReportGeneratorResponse DeleteLicenseManagerReportGenerator(DeleteLicenseManagerReportGeneratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseManagerReportGeneratorResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified report generator.
        /// 
        ///  
        /// <para>
        /// This action deletes the report generator, which stops it from generating future reports.
        /// The action cannot be reversed. It has no effect on the previous reports from this
        /// generator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        public virtual Task<DeleteLicenseManagerReportGeneratorResponse> DeleteLicenseManagerReportGeneratorAsync(DeleteLicenseManagerReportGeneratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLicenseManagerReportGeneratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteToken

        internal virtual DeleteTokenResponse DeleteToken(DeleteTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteTokenResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified token. Must be called in the license home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        public virtual Task<DeleteTokenResponse> DeleteTokenAsync(DeleteTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExtendLicenseConsumption

        internal virtual ExtendLicenseConsumptionResponse ExtendLicenseConsumption(ExtendLicenseConsumptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExtendLicenseConsumptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendLicenseConsumptionResponseUnmarshaller.Instance;

            return Invoke<ExtendLicenseConsumptionResponse>(request, options);
        }



        /// <summary>
        /// Extends the expiration date for license consumption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendLicenseConsumption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExtendLicenseConsumption service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        public virtual Task<ExtendLicenseConsumptionResponse> ExtendLicenseConsumptionAsync(ExtendLicenseConsumptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExtendLicenseConsumptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExtendLicenseConsumptionResponseUnmarshaller.Instance;

            return InvokeAsync<ExtendLicenseConsumptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessToken

        internal virtual GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return Invoke<GetAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Gets a temporary access token to use with AssumeRoleWithWebIdentity. Access tokens
        /// are valid for one hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        public virtual Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGrant

        internal virtual GetGrantResponse GetGrant(GetGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGrantResponseUnmarshaller.Instance;

            return Invoke<GetGrantResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        public virtual Task<GetGrantResponse> GetGrantAsync(GetGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGrantResponseUnmarshaller.Instance;

            return InvokeAsync<GetGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicense

        internal virtual GetLicenseResponse GetLicense(GetLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseResponseUnmarshaller.Instance;

            return Invoke<GetLicenseResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        public virtual Task<GetLicenseResponse> GetLicenseAsync(GetLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseConfiguration

        internal virtual GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        public virtual Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseConversionTask

        internal virtual GetLicenseConversionTaskResponse GetLicenseConversionTask(GetLicenseConversionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConversionTaskResponseUnmarshaller.Instance;

            return Invoke<GetLicenseConversionTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified license type conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConversionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseConversionTask service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        public virtual Task<GetLicenseConversionTaskResponse> GetLicenseConversionTaskAsync(GetLicenseConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseConversionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseManagerReportGenerator

        internal virtual GetLicenseManagerReportGeneratorResponse GetLicenseManagerReportGenerator(GetLicenseManagerReportGeneratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return Invoke<GetLicenseManagerReportGeneratorResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        public virtual Task<GetLicenseManagerReportGeneratorResponse> GetLicenseManagerReportGeneratorAsync(GetLicenseManagerReportGeneratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseManagerReportGeneratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseUsage

        internal virtual GetLicenseUsageResponse GetLicenseUsage(GetLicenseUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseUsageResponseUnmarshaller.Instance;

            return Invoke<GetLicenseUsageResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about the usage of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseUsage service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        public virtual Task<GetLicenseUsageResponse> GetLicenseUsageAsync(GetLicenseUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceSettings

        internal virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration

        internal virtual ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsForLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        public virtual Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsForLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDistributedGrants

        internal virtual ListDistributedGrantsResponse ListDistributedGrants(ListDistributedGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributedGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributedGrantsResponseUnmarshaller.Instance;

            return Invoke<ListDistributedGrantsResponse>(request, options);
        }



        /// <summary>
        /// Lists the grants distributed for the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributedGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        public virtual Task<ListDistributedGrantsResponse> ListDistributedGrantsAsync(ListDistributedGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDistributedGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributedGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributedGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFailuresForLicenseConfigurationOperations

        internal virtual ListFailuresForLicenseConfigurationOperationsResponse ListFailuresForLicenseConfigurationOperations(ListFailuresForLicenseConfigurationOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFailuresForLicenseConfigurationOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailuresForLicenseConfigurationOperationsResponseUnmarshaller.Instance;

            return Invoke<ListFailuresForLicenseConfigurationOperationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        public virtual Task<ListFailuresForLicenseConfigurationOperationsResponse> ListFailuresForLicenseConfigurationOperationsAsync(ListFailuresForLicenseConfigurationOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFailuresForLicenseConfigurationOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailuresForLicenseConfigurationOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFailuresForLicenseConfigurationOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseConfigurations

        internal virtual ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        public virtual Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseConversionTasks

        internal virtual ListLicenseConversionTasksResponse ListLicenseConversionTasks(ListLicenseConversionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConversionTasksResponseUnmarshaller.Instance;

            return Invoke<ListLicenseConversionTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists the license type conversion tasks for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConversionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseConversionTasks service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        public virtual Task<ListLicenseConversionTasksResponse> ListLicenseConversionTasksAsync(ListLicenseConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseConversionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseManagerReportGenerators

        internal virtual ListLicenseManagerReportGeneratorsResponse ListLicenseManagerReportGenerators(ListLicenseManagerReportGeneratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseManagerReportGeneratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseManagerReportGeneratorsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseManagerReportGeneratorsResponse>(request, options);
        }



        /// <summary>
        /// Lists the report generators for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseManagerReportGenerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseManagerReportGenerators service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        public virtual Task<ListLicenseManagerReportGeneratorsResponse> ListLicenseManagerReportGeneratorsAsync(ListLicenseManagerReportGeneratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseManagerReportGeneratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseManagerReportGeneratorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseManagerReportGeneratorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenses

        internal virtual ListLicensesResponse ListLicenses(ListLicensesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicensesResponseUnmarshaller.Instance;

            return Invoke<ListLicensesResponse>(request, options);
        }



        /// <summary>
        /// Lists the licenses for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        public virtual Task<ListLicensesResponse> ListLicensesAsync(ListLicensesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicensesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicensesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseSpecificationsForResource

        internal virtual ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListLicenseSpecificationsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseSpecificationsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseVersions

        internal virtual ListLicenseVersionsResponse ListLicenseVersions(ListLicenseVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseVersionsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all versions of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseVersions service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        public virtual Task<ListLicenseVersionsResponse> ListLicenseVersionsAsync(ListLicenseVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceivedGrants

        internal virtual ListReceivedGrantsResponse ListReceivedGrants(ListReceivedGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedGrantsResponseUnmarshaller.Instance;

            return Invoke<ListReceivedGrantsResponse>(request, options);
        }



        /// <summary>
        /// Lists grants that are received. Received grants are grants created while specifying
        /// the recipient as this Amazon Web Services account, your organization, or an organizational
        /// unit (OU) to which this member account belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        public virtual Task<ListReceivedGrantsResponse> ListReceivedGrantsAsync(ListReceivedGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceivedGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceivedGrantsForOrganization

        internal virtual ListReceivedGrantsForOrganizationResponse ListReceivedGrantsForOrganization(ListReceivedGrantsForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedGrantsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedGrantsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListReceivedGrantsForOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Lists the grants received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrantsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedGrantsForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        public virtual Task<ListReceivedGrantsForOrganizationResponse> ListReceivedGrantsForOrganizationAsync(ListReceivedGrantsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedGrantsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedGrantsForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceivedGrantsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceivedLicenses

        internal virtual ListReceivedLicensesResponse ListReceivedLicenses(ListReceivedLicensesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedLicensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedLicensesResponseUnmarshaller.Instance;

            return Invoke<ListReceivedLicensesResponse>(request, options);
        }



        /// <summary>
        /// Lists received licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        public virtual Task<ListReceivedLicensesResponse> ListReceivedLicensesAsync(ListReceivedLicensesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedLicensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedLicensesResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceivedLicensesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceivedLicensesForOrganization

        internal virtual ListReceivedLicensesForOrganizationResponse ListReceivedLicensesForOrganization(ListReceivedLicensesForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedLicensesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedLicensesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListReceivedLicensesForOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Lists the licenses received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicensesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReceivedLicensesForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        public virtual Task<ListReceivedLicensesForOrganizationResponse> ListReceivedLicensesForOrganizationAsync(ListReceivedLicensesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceivedLicensesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceivedLicensesForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceivedLicensesForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceInventory

        internal virtual ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;

            return Invoke<ListResourceInventoryResponse>(request, options);
        }



        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        public virtual Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceInventoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTokens

        internal virtual ListTokensResponse ListTokens(ListTokensRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTokensResponseUnmarshaller.Instance;

            return Invoke<ListTokensResponse>(request, options);
        }



        /// <summary>
        /// Lists your tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTokens service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        public virtual Task<ListTokensResponse> ListTokensAsync(ListTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTokensResponseUnmarshaller.Instance;

            return InvokeAsync<ListTokensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsageForLicenseConfiguration

        internal virtual ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListUsageForLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        public virtual Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsageForLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectGrant

        internal virtual RejectGrantResponse RejectGrant(RejectGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectGrantResponseUnmarshaller.Instance;

            return Invoke<RejectGrantResponse>(request, options);
        }



        /// <summary>
        /// Rejects the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        public virtual Task<RejectGrantResponse> RejectGrantAsync(RejectGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RejectGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseConfiguration

        internal virtual UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        public virtual Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseManagerReportGenerator

        internal virtual UpdateLicenseManagerReportGeneratorResponse UpdateLicenseManagerReportGenerator(UpdateLicenseManagerReportGeneratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseManagerReportGeneratorResponse>(request, options);
        }



        /// <summary>
        /// Updates a report generator.
        /// 
        ///  
        /// <para>
        /// After you make changes to a report generator, it starts generating new reports within
        /// 60 minutes of being updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseManagerReportGenerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        public virtual Task<UpdateLicenseManagerReportGeneratorResponse> UpdateLicenseManagerReportGeneratorAsync(UpdateLicenseManagerReportGeneratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseManagerReportGeneratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseManagerReportGeneratorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLicenseManagerReportGeneratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource

        internal virtual UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseSpecificationsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or removes the specified license configurations for the specified Amazon Web
        /// Services resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLicenseSpecificationsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSettings

        internal virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}