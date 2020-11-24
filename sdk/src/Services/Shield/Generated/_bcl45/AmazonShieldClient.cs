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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Shield.Model;
using Amazon.Shield.Model.Internal.MarshallTransformations;
using Amazon.Shield.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Shield
{
    /// <summary>
    /// Implementation for accessing Shield
    ///
    /// AWS Shield Advanced 
    /// <para>
    /// This is the <i>AWS Shield Advanced API Reference</i>. This guide is for developers
    /// who need detailed information about the AWS Shield Advanced API actions, data types,
    /// and errors. For detailed information about AWS WAF and AWS Shield Advanced features
    /// and an overview of how to use the AWS WAF and AWS Shield Advanced APIs, see the <a
    /// href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF and AWS Shield
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonShieldClient : AmazonServiceClient, IAmazonShield
    {
        private static IServiceMetadata serviceMetadata = new AmazonShieldMetadata();
        private IShieldPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IShieldPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ShieldPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonShieldClient with the credentials loaded from the application's
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
        public AmazonShieldClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonShieldConfig()) { }

        /// <summary>
        /// Constructs AmazonShieldClient with the credentials loaded from the application's
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
        public AmazonShieldClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonShieldConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonShieldClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonShieldClient Configuration Object</param>
        public AmazonShieldClient(AmazonShieldConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonShieldClient(AWSCredentials credentials)
            : this(credentials, new AmazonShieldConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonShieldClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonShieldConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Credentials and an
        /// AmazonShieldClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonShieldClient Configuration Object</param>
        public AmazonShieldClient(AWSCredentials credentials, AmazonShieldConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonShieldConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonShieldConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonShieldClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonShieldClient Configuration Object</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonShieldConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonShieldConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonShieldConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonShieldClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonShieldClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonShieldClient Configuration Object</param>
        public AmazonShieldClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonShieldConfig clientConfig)
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


        #region  AssociateDRTLogBucket


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT) to access the specified Amazon S3 bucket containing
        /// your AWS WAF logs. You can associate up to 10 Amazon S3 buckets with your subscription.
        /// 
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTLogBucket</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual AssociateDRTLogBucketResponse AssociateDRTLogBucket(AssociateDRTLogBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTLogBucketResponse>(request, options);
        }


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT) to access the specified Amazon S3 bucket containing
        /// your AWS WAF logs. You can associate up to 10 Amazon S3 buckets with your subscription.
        /// 
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTLogBucket</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual Task<AssociateDRTLogBucketResponse> AssociateDRTLogBucketAsync(AssociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateDRTLogBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDRTRole


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT), using the specified role, to access your
        /// AWS account to assist with DDoS attack mitigation during potential attacks. This enables
        /// the DRT to inspect your AWS WAF configuration and create or update AWS WAF rules and
        /// web ACLs.
        /// 
        ///  
        /// <para>
        /// You can associate only one <code>RoleArn</code> with your subscription. If you submit
        /// an <code>AssociateDRTRole</code> request for an account that already has an associated
        /// role, the new <code>RoleArn</code> will replace the existing <code>RoleArn</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <code>AssociateDRTRole</code> request, you must attach the <a
        /// href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>
        /// managed policy to the role you will specify in the request. For more information see
        /// <a href=" https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Attaching
        /// and Detaching IAM Policies</a>. The role must also trust the service principal <code>
        /// drt.shield.amazonaws.com</code>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// JSON Policy Elements: Principal</a>.
        /// </para>
        ///  
        /// <para>
        /// The DRT will have access only to your AWS WAF and Shield resources. By submitting
        /// this request, you authorize the DRT to inspect your AWS WAF and Shield configuration
        /// and create and update AWS WAF rules and web ACLs on your behalf. The DRT takes these
        /// actions only if explicitly authorized by you.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>iam:PassRole</code> permission to make an <code>AssociateDRTRole</code>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>. 
        /// </para>
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTRole</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole service method.</param>
        /// 
        /// <returns>The response from the AssociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual AssociateDRTRoleResponse AssociateDRTRole(AssociateDRTRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDRTRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTRoleResponse>(request, options);
        }


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT), using the specified role, to access your
        /// AWS account to assist with DDoS attack mitigation during potential attacks. This enables
        /// the DRT to inspect your AWS WAF configuration and create or update AWS WAF rules and
        /// web ACLs.
        /// 
        ///  
        /// <para>
        /// You can associate only one <code>RoleArn</code> with your subscription. If you submit
        /// an <code>AssociateDRTRole</code> request for an account that already has an associated
        /// role, the new <code>RoleArn</code> will replace the existing <code>RoleArn</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <code>AssociateDRTRole</code> request, you must attach the <a
        /// href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>
        /// managed policy to the role you will specify in the request. For more information see
        /// <a href=" https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Attaching
        /// and Detaching IAM Policies</a>. The role must also trust the service principal <code>
        /// drt.shield.amazonaws.com</code>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// JSON Policy Elements: Principal</a>.
        /// </para>
        ///  
        /// <para>
        /// The DRT will have access only to your AWS WAF and Shield resources. By submitting
        /// this request, you authorize the DRT to inspect your AWS WAF and Shield configuration
        /// and create and update AWS WAF rules and web ACLs on your behalf. The DRT takes these
        /// actions only if explicitly authorized by you.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>iam:PassRole</code> permission to make an <code>AssociateDRTRole</code>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>. 
        /// </para>
        ///  
        /// <para>
        /// To use the services of the DRT and make an <code>AssociateDRTRole</code> request,
        /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
        /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual Task<AssociateDRTRoleResponse> AssociateDRTRoleAsync(AssociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDRTRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateDRTRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateHealthCheck


        /// <summary>
        /// Adds health-based detection to the Shield Advanced protection for a resource. Shield
        /// Advanced health-based detection uses the health of your AWS resource to improve responsiveness
        /// and accuracy in attack detection and mitigation. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate it with your Shield Advanced
        /// protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF and AWS Shield Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the AssociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateHealthCheck">REST API Reference for AssociateHealthCheck Operation</seealso>
        public virtual AssociateHealthCheckResponse AssociateHealthCheck(AssociateHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<AssociateHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Adds health-based detection to the Shield Advanced protection for a resource. Shield
        /// Advanced health-based detection uses the health of your AWS resource to improve responsiveness
        /// and accuracy in attack detection and mitigation. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate it with your Shield Advanced
        /// protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF and AWS Shield Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateHealthCheck">REST API Reference for AssociateHealthCheck Operation</seealso>
        public virtual Task<AssociateHealthCheckResponse> AssociateHealthCheckAsync(AssociateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHealthCheckResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateProactiveEngagementDetails


        /// <summary>
        /// Initializes proactive engagement and sets the list of contacts for the DDoS Response
        /// Team (DRT) to use. You must provide at least one phone number in the emergency contact
        /// list. 
        /// 
        ///  
        /// <para>
        /// After you have initialized proactive engagement using this call, to disable or enable
        /// proactive engagement, use the calls <code>DisableProactiveEngagement</code> and <code>EnableProactiveEngagement</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This call defines the list of email addresses and phone numbers that the DDoS Response
        /// Team (DRT) can use to contact you for escalations to the DRT and to initiate proactive
        /// customer support.
        /// </para>
        ///  
        /// <para>
        /// The contacts that you provide in the request replace any contacts that were already
        /// defined. If you already have contacts defined and want to use them, retrieve the list
        /// using <code>DescribeEmergencyContactSettings</code> and then provide it to this call.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProactiveEngagementDetails service method.</param>
        /// 
        /// <returns>The response from the AssociateProactiveEngagementDetails service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateProactiveEngagementDetails">REST API Reference for AssociateProactiveEngagementDetails Operation</seealso>
        public virtual AssociateProactiveEngagementDetailsResponse AssociateProactiveEngagementDetails(AssociateProactiveEngagementDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProactiveEngagementDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProactiveEngagementDetailsResponseUnmarshaller.Instance;

            return Invoke<AssociateProactiveEngagementDetailsResponse>(request, options);
        }


        /// <summary>
        /// Initializes proactive engagement and sets the list of contacts for the DDoS Response
        /// Team (DRT) to use. You must provide at least one phone number in the emergency contact
        /// list. 
        /// 
        ///  
        /// <para>
        /// After you have initialized proactive engagement using this call, to disable or enable
        /// proactive engagement, use the calls <code>DisableProactiveEngagement</code> and <code>EnableProactiveEngagement</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This call defines the list of email addresses and phone numbers that the DDoS Response
        /// Team (DRT) can use to contact you for escalations to the DRT and to initiate proactive
        /// customer support.
        /// </para>
        ///  
        /// <para>
        /// The contacts that you provide in the request replace any contacts that were already
        /// defined. If you already have contacts defined and want to use them, retrieve the list
        /// using <code>DescribeEmergencyContactSettings</code> and then provide it to this call.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProactiveEngagementDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProactiveEngagementDetails service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateProactiveEngagementDetails">REST API Reference for AssociateProactiveEngagementDetails Operation</seealso>
        public virtual Task<AssociateProactiveEngagementDetailsResponse> AssociateProactiveEngagementDetailsAsync(AssociateProactiveEngagementDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProactiveEngagementDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProactiveEngagementDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateProactiveEngagementDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProtection


        /// <summary>
        /// Enables AWS Shield Advanced for a specific AWS resource. The resource can be an Amazon
        /// CloudFront distribution, Elastic Load Balancing load balancer, AWS Global Accelerator
        /// accelerator, Elastic IP Address, or an Amazon Route 53 hosted zone.
        /// 
        ///  
        /// <para>
        /// You can add protection to only a single resource with each CreateProtection request.
        /// If you want to add protection to multiple resources at once, use the <a href="https://console.aws.amazon.com/waf/">AWS
        /// WAF console</a>. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with AWS Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Add
        /// AWS Shield Advanced Protection to more AWS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection service method.</param>
        /// 
        /// <returns>The response from the CreateProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual CreateProtectionResponse CreateProtection(CreateProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectionResponseUnmarshaller.Instance;

            return Invoke<CreateProtectionResponse>(request, options);
        }


        /// <summary>
        /// Enables AWS Shield Advanced for a specific AWS resource. The resource can be an Amazon
        /// CloudFront distribution, Elastic Load Balancing load balancer, AWS Global Accelerator
        /// accelerator, Elastic IP Address, or an Amazon Route 53 hosted zone.
        /// 
        ///  
        /// <para>
        /// You can add protection to only a single resource with each CreateProtection request.
        /// If you want to add protection to multiple resources at once, use the <a href="https://console.aws.amazon.com/waf/">AWS
        /// WAF console</a>. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
        /// Started with AWS Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Add
        /// AWS Shield Advanced Protection to more AWS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual Task<CreateProtectionResponse> CreateProtectionAsync(CreateProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProtectionGroup


        /// <summary>
        /// Creates a grouping of protected resources so they can be handled as a collective.
        /// This resource grouping improves the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtectionGroup">REST API Reference for CreateProtectionGroup Operation</seealso>
        public virtual CreateProtectionGroupResponse CreateProtectionGroup(CreateProtectionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateProtectionGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a grouping of protected resources so they can be handled as a collective.
        /// This resource grouping improves the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// 
        ///  
        /// <para>
        ///  <code>Type</code> is the type of limit that would be exceeded.
        /// </para>
        ///  
        /// <para>
        ///  <code>Limit</code> is the threshold that would be exceeded.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtectionGroup">REST API Reference for CreateProtectionGroup Operation</seealso>
        public virtual Task<CreateProtectionGroupResponse> CreateProtectionGroupAsync(CreateProtectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProtectionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Activates AWS Shield Advanced for an account.
        /// 
        ///  
        /// <para>
        /// When you initally create a subscription, your subscription is set to be automatically
        /// renewed at the end of the existing subscription period. You can change this by submitting
        /// an <code>UpdateSubscription</code> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Activates AWS Shield Advanced for an account.
        /// 
        ///  
        /// <para>
        /// When you initally create a subscription, your subscription is set to be automatically
        /// renewed at the end of the existing subscription period. You can change this by submitting
        /// an <code>UpdateSubscription</code> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProtection


        /// <summary>
        /// Deletes an AWS Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectionResponse>(request, options);
        }


        /// <summary>
        /// Deletes an AWS Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual Task<DeleteProtectionResponse> DeleteProtectionAsync(DeleteProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProtectionGroup


        /// <summary>
        /// Removes the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtectionGroup">REST API Reference for DeleteProtectionGroup Operation</seealso>
        public virtual DeleteProtectionGroupResponse DeleteProtectionGroup(DeleteProtectionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectionGroupResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtectionGroup">REST API Reference for DeleteProtectionGroup Operation</seealso>
        public virtual Task<DeleteProtectionGroupResponse> DeleteProtectionGroupAsync(DeleteProtectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProtectionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscription


        /// <summary>
        /// Removes AWS Shield Advanced from an account. AWS Shield Advanced requires a 1-year
        /// subscription commitment. You cannot delete a subscription prior to the completion
        /// of that commitment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Removes AWS Shield Advanced from an account. AWS Shield Advanced requires a 1-year
        /// subscription commitment. You cannot delete a subscription prior to the completion
        /// of that commitment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAttack


        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedException">
        /// Exception that indicates the specified <code>AttackId</code> does not exist, or the
        /// requester does not have the appropriate permissions to access the <code>AttackId</code>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual DescribeAttackResponse DescribeAttack(DescribeAttackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAttackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAttackResponseUnmarshaller.Instance;

            return Invoke<DescribeAttackResponse>(request, options);
        }


        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedException">
        /// Exception that indicates the specified <code>AttackId</code> does not exist, or the
        /// requester does not have the appropriate permissions to access the <code>AttackId</code>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual Task<DescribeAttackResponse> DescribeAttackAsync(DescribeAttackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAttackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAttackResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAttackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAttackStatistics


        /// <summary>
        /// Provides information about the number and type of attacks AWS Shield has detected
        /// in the last year for all resources that belong to your account, regardless of whether
        /// you've defined Shield protections for them. This operation is available to Shield
        /// customers as well as to Shield Advanced customers.
        /// 
        ///  
        /// <para>
        /// The operation returns data for the time range of midnight UTC, one year ago, to midnight
        /// UTC, today. For example, if the current time is <code>2020-10-26 15:39:32 PDT</code>,
        /// equal to <code>2020-10-26 22:39:32 UTC</code>, then the time range for the attack
        /// data returned is from <code>2019-10-26 00:00:00 UTC</code> to <code>2020-10-26 00:00:00
        /// UTC</code>. 
        /// </para>
        ///  
        /// <para>
        /// The time range indicates the period covered by the attack statistics data items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttackStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeAttackStatistics service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttackStatistics">REST API Reference for DescribeAttackStatistics Operation</seealso>
        public virtual DescribeAttackStatisticsResponse DescribeAttackStatistics(DescribeAttackStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAttackStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAttackStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeAttackStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Provides information about the number and type of attacks AWS Shield has detected
        /// in the last year for all resources that belong to your account, regardless of whether
        /// you've defined Shield protections for them. This operation is available to Shield
        /// customers as well as to Shield Advanced customers.
        /// 
        ///  
        /// <para>
        /// The operation returns data for the time range of midnight UTC, one year ago, to midnight
        /// UTC, today. For example, if the current time is <code>2020-10-26 15:39:32 PDT</code>,
        /// equal to <code>2020-10-26 22:39:32 UTC</code>, then the time range for the attack
        /// data returned is from <code>2019-10-26 00:00:00 UTC</code> to <code>2020-10-26 00:00:00
        /// UTC</code>. 
        /// </para>
        ///  
        /// <para>
        /// The time range indicates the period covered by the attack statistics data items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttackStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAttackStatistics service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttackStatistics">REST API Reference for DescribeAttackStatistics Operation</seealso>
        public virtual Task<DescribeAttackStatisticsResponse> DescribeAttackStatisticsAsync(DescribeAttackStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAttackStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAttackStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAttackStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDRTAccess


        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the DDoS Response
        /// Team (DRT) to access your AWS account while assisting with attack mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual DescribeDRTAccessResponse DescribeDRTAccess(DescribeDRTAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDRTAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeDRTAccessResponse>(request, options);
        }


        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the DDoS Response
        /// Team (DRT) to access your AWS account while assisting with attack mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual Task<DescribeDRTAccessResponse> DescribeDRTAccessAsync(DescribeDRTAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDRTAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDRTAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEmergencyContactSettings


        /// <summary>
        /// A list of email addresses and phone numbers that the DDoS Response Team (DRT) can
        /// use to contact you if you have proactive engagement enabled, for escalations to the
        /// DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual DescribeEmergencyContactSettingsResponse DescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeEmergencyContactSettingsResponse>(request, options);
        }


        /// <summary>
        /// A list of email addresses and phone numbers that the DDoS Response Team (DRT) can
        /// use to contact you if you have proactive engagement enabled, for escalations to the
        /// DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual Task<DescribeEmergencyContactSettingsResponse> DescribeEmergencyContactSettingsAsync(DescribeEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEmergencyContactSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProtection


        /// <summary>
        /// Lists the details of a <a>Protection</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection service method.</param>
        /// 
        /// <returns>The response from the DescribeProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectionResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectionResponse>(request, options);
        }


        /// <summary>
        /// Lists the details of a <a>Protection</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual Task<DescribeProtectionResponse> DescribeProtectionAsync(DescribeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProtectionGroup


        /// <summary>
        /// Returns the specification for the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtectionGroup">REST API Reference for DescribeProtectionGroup Operation</seealso>
        public virtual DescribeProtectionGroupResponse DescribeProtectionGroup(DescribeProtectionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectionGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectionGroupResponse>(request, options);
        }


        /// <summary>
        /// Returns the specification for the specified protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtectionGroup">REST API Reference for DescribeProtectionGroup Operation</seealso>
        public virtual Task<DescribeProtectionGroupResponse> DescribeProtectionGroupAsync(DescribeProtectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProtectionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscription


        /// <summary>
        /// Provides details about the AWS Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Provides details about the AWS Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual Task<DescribeSubscriptionResponse> DescribeSubscriptionAsync(DescribeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableProactiveEngagement


        /// <summary>
        /// Removes authorization from the DDoS Response Team (DRT) to notify contacts about escalations
        /// to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProactiveEngagement service method.</param>
        /// 
        /// <returns>The response from the DisableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableProactiveEngagement">REST API Reference for DisableProactiveEngagement Operation</seealso>
        public virtual DisableProactiveEngagementResponse DisableProactiveEngagement(DisableProactiveEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableProactiveEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableProactiveEngagementResponseUnmarshaller.Instance;

            return Invoke<DisableProactiveEngagementResponse>(request, options);
        }


        /// <summary>
        /// Removes authorization from the DDoS Response Team (DRT) to notify contacts about escalations
        /// to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProactiveEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisableProactiveEngagement">REST API Reference for DisableProactiveEngagement Operation</seealso>
        public virtual Task<DisableProactiveEngagementResponse> DisableProactiveEngagementAsync(DisableProactiveEngagementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableProactiveEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableProactiveEngagementResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableProactiveEngagementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDRTLogBucket


        /// <summary>
        /// Removes the DDoS Response Team's (DRT) access to the specified Amazon S3 bucket containing
        /// your AWS WAF logs.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTLogBucket</code> request, you must be subscribed to
        /// the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTLogBucket</code> request to remove this access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket service method.</param>
        /// 
        /// <returns>The response from the DisassociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual DisassociateDRTLogBucketResponse DisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTLogBucketResponse>(request, options);
        }


        /// <summary>
        /// Removes the DDoS Response Team's (DRT) access to the specified Amazon S3 bucket containing
        /// your AWS WAF logs.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTLogBucket</code> request, you must be subscribed to
        /// the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTLogBucket</code> request to remove this access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDRTLogBucket service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.AccessDeniedForDependencyException">
        /// In order to grant the necessary access to the DDoS Response Team (DRT), the user submitting
        /// the request must have the <code>iam:PassRole</code> permission. This error indicates
        /// the user did not have the appropriate permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a User Permissions to Pass a Role to an AWS Service</a>.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.NoAssociatedRoleException">
        /// The ARN of the role that you specifed does not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual Task<DisassociateDRTLogBucketResponse> DisassociateDRTLogBucketAsync(DisassociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateDRTLogBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDRTRole


        /// <summary>
        /// Removes the DDoS Response Team's (DRT) access to your AWS account.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTRole</code> request, you must be subscribed to the
        /// <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTRole</code> request to remove this access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole service method.</param>
        /// 
        /// <returns>The response from the DisassociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual DisassociateDRTRoleResponse DisassociateDRTRole(DisassociateDRTRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTRoleResponse>(request, options);
        }


        /// <summary>
        /// Removes the DDoS Response Team's (DRT) access to your AWS account.
        /// 
        ///  
        /// <para>
        /// To make a <code>DisassociateDRTRole</code> request, you must be subscribed to the
        /// <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
        /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
        /// Support plan</a>. However, if you are not subscribed to one of these support plans,
        /// but had been previously and had granted the DRT access to your account, you can submit
        /// a <code>DisassociateDRTRole</code> request to remove this access.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDRTRole service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual Task<DisassociateDRTRoleResponse> DisassociateDRTRoleAsync(DisassociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateDRTRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateHealthCheck


        /// <summary>
        /// Removes health-based detection from the Shield Advanced protection for a resource.
        /// Shield Advanced health-based detection uses the health of your AWS resource to improve
        /// responsiveness and accuracy in attack detection and mitigation. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate or disassociate it with
        /// your Shield Advanced protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF and AWS Shield Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DisassociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateHealthCheck">REST API Reference for DisassociateHealthCheck Operation</seealso>
        public virtual DisassociateHealthCheckResponse DisassociateHealthCheck(DisassociateHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DisassociateHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Removes health-based detection from the Shield Advanced protection for a resource.
        /// Shield Advanced health-based detection uses the health of your AWS resource to improve
        /// responsiveness and accuracy in attack detection and mitigation. 
        /// 
        ///  
        /// <para>
        /// You define the health check in Route 53 and then associate or disassociate it with
        /// your Shield Advanced protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
        /// Advanced Health-Based Detection</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF and AWS Shield Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateHealthCheck service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateHealthCheck">REST API Reference for DisassociateHealthCheck Operation</seealso>
        public virtual Task<DisassociateHealthCheckResponse> DisassociateHealthCheckAsync(DisassociateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHealthCheckResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableProactiveEngagement


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT) to use email and phone to notify contacts
        /// about escalations to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProactiveEngagement service method.</param>
        /// 
        /// <returns>The response from the EnableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableProactiveEngagement">REST API Reference for EnableProactiveEngagement Operation</seealso>
        public virtual EnableProactiveEngagementResponse EnableProactiveEngagement(EnableProactiveEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableProactiveEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableProactiveEngagementResponseUnmarshaller.Instance;

            return Invoke<EnableProactiveEngagementResponse>(request, options);
        }


        /// <summary>
        /// Authorizes the DDoS Response Team (DRT) to use email and phone to notify contacts
        /// about escalations to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProactiveEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableProactiveEngagement service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/EnableProactiveEngagement">REST API Reference for EnableProactiveEngagement Operation</seealso>
        public virtual Task<EnableProactiveEngagementResponse> EnableProactiveEngagementAsync(EnableProactiveEngagementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableProactiveEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableProactiveEngagementResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableProactiveEngagementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionState


        /// <summary>
        /// Returns the <code>SubscriptionState</code>, either <code>Active</code> or <code>Inactive</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionState service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        public virtual GetSubscriptionStateResponse GetSubscriptionState(GetSubscriptionStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionStateResponse>(request, options);
        }


        /// <summary>
        /// Returns the <code>SubscriptionState</code>, either <code>Active</code> or <code>Inactive</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionState service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        public virtual Task<GetSubscriptionStateResponse> GetSubscriptionStateAsync(GetSubscriptionStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttacks


        /// <summary>
        /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks service method.</param>
        /// 
        /// <returns>The response from the ListAttacks service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual ListAttacksResponse ListAttacks(ListAttacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttacksResponseUnmarshaller.Instance;

            return Invoke<ListAttacksResponse>(request, options);
        }


        /// <summary>
        /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttacks service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual Task<ListAttacksResponse> ListAttacksAsync(ListAttacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttacksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAttacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProtectionGroups


        /// <summary>
        /// Retrieves the <a>ProtectionGroup</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectionGroups service method.</param>
        /// 
        /// <returns>The response from the ListProtectionGroups service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtectionGroups">REST API Reference for ListProtectionGroups Operation</seealso>
        public virtual ListProtectionGroupsResponse ListProtectionGroups(ListProtectionGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectionGroupsResponseUnmarshaller.Instance;

            return Invoke<ListProtectionGroupsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the <a>ProtectionGroup</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectionGroups service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtectionGroups">REST API Reference for ListProtectionGroups Operation</seealso>
        public virtual Task<ListProtectionGroupsResponse> ListProtectionGroupsAsync(ListProtectionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectionGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProtectionGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProtections


        /// <summary>
        /// Lists all <a>Protection</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual ListProtectionsResponse ListProtections(ListProtectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectionsResponseUnmarshaller.Instance;

            return Invoke<ListProtectionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all <a>Protection</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual Task<ListProtectionsResponse> ListProtectionsAsync(ListProtectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProtectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesInProtectionGroup


        /// <summary>
        /// Retrieves the resources that are included in the protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesInProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the ListResourcesInProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListResourcesInProtectionGroup">REST API Reference for ListResourcesInProtectionGroup Operation</seealso>
        public virtual ListResourcesInProtectionGroupResponse ListResourcesInProtectionGroup(ListResourcesInProtectionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesInProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesInProtectionGroupResponseUnmarshaller.Instance;

            return Invoke<ListResourcesInProtectionGroupResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the resources that are included in the protection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesInProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesInProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidPaginationTokenException">
        /// Exception that indicates that the NextToken specified in the request is invalid. Submit
        /// the request using the NextToken value that was returned in the response.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListResourcesInProtectionGroup">REST API Reference for ListResourcesInProtectionGroup Operation</seealso>
        public virtual Task<ListResourcesInProtectionGroupResponse> ListResourcesInProtectionGroupAsync(ListResourcesInProtectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesInProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesInProtectionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesInProtectionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEmergencyContactSettings


        /// <summary>
        /// Updates the details of the list of email addresses and phone numbers that the DDoS
        /// Response Team (DRT) can use to contact you if you have proactive engagement enabled,
        /// for escalations to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual UpdateEmergencyContactSettingsResponse UpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateEmergencyContactSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates the details of the list of email addresses and phone numbers that the DDoS
        /// Response Team (DRT) can use to contact you if you have proactive engagement enabled,
        /// for escalations to the DRT and to initiate proactive customer support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual Task<UpdateEmergencyContactSettingsResponse> UpdateEmergencyContactSettingsAsync(UpdateEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEmergencyContactSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProtectionGroup


        /// <summary>
        /// Updates an existing protection group. A protection group is a grouping of protected
        /// resources so they can be handled as a collective. This resource grouping improves
        /// the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectionGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateProtectionGroup">REST API Reference for UpdateProtectionGroup Operation</seealso>
        public virtual UpdateProtectionGroupResponse UpdateProtectionGroup(UpdateProtectionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectionGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectionGroupResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing protection group. A protection group is a grouping of protected
        /// resources so they can be handled as a collective. This resource grouping improves
        /// the accuracy of detection and reduces false positives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectionGroup service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateProtectionGroup">REST API Reference for UpdateProtectionGroup Operation</seealso>
        public virtual Task<UpdateProtectionGroupResponse> UpdateProtectionGroupAsync(UpdateProtectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProtectionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscription


        /// <summary>
        /// Updates the details of an existing subscription. Only enter values for parameters
        /// you want to change. Empty parameters are not updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the details of an existing subscription. Only enter values for parameters
        /// you want to change. Empty parameters are not updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid. If available,
        /// this exception includes details in additional properties.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the resource state has been modified by another client.
        /// Retrieve the resource and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist. If available, this exception
        /// includes details in additional properties.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}