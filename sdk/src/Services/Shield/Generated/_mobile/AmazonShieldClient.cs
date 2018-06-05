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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Shield.Model;
using Amazon.Shield.Model.Internal.MarshallTransformations;
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
    /// href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF and AWS Shield
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonShieldClient : AmazonServiceClient, IAmazonShield
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual AssociateDRTLogBucketResponse AssociateDRTLogBucket(AssociateDRTLogBucketRequest request)
        {
            var marshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTLogBucketRequest,AssociateDRTLogBucketResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual Task<AssociateDRTLogBucketResponse> AssociateDRTLogBucketAsync(AssociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDRTLogBucketRequest,AssociateDRTLogBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateDRTRole

        internal virtual AssociateDRTRoleResponse AssociateDRTRole(AssociateDRTRoleRequest request)
        {
            var marshaller = AssociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTRoleRequest,AssociateDRTRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual Task<AssociateDRTRoleResponse> AssociateDRTRoleAsync(AssociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDRTRoleRequest,AssociateDRTRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProtection

        internal virtual CreateProtectionResponse CreateProtection(CreateProtectionRequest request)
        {
            var marshaller = CreateProtectionRequestMarshaller.Instance;
            var unmarshaller = CreateProtectionResponseUnmarshaller.Instance;

            return Invoke<CreateProtectionRequest,CreateProtectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual Task<CreateProtectionResponse> CreateProtectionAsync(CreateProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProtectionRequestMarshaller.Instance;
            var unmarshaller = CreateProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProtectionRequest,CreateProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscription

        internal virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var marshaller = CreateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionRequest,CreateSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionRequest,CreateSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProtection

        internal virtual DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request)
        {
            var marshaller = DeleteProtectionRequestMarshaller.Instance;
            var unmarshaller = DeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectionRequest,DeleteProtectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual Task<DeleteProtectionResponse> DeleteProtectionAsync(DeleteProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProtectionRequestMarshaller.Instance;
            var unmarshaller = DeleteProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProtectionRequest,DeleteProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscription

        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        internal virtual DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request)
        {
            var marshaller = DeleteSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionRequest,DeleteSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual Task<DeleteSubscriptionResponse> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionRequest,DeleteSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAttack

        internal virtual DescribeAttackResponse DescribeAttack(DescribeAttackRequest request)
        {
            var marshaller = DescribeAttackRequestMarshaller.Instance;
            var unmarshaller = DescribeAttackResponseUnmarshaller.Instance;

            return Invoke<DescribeAttackRequest,DescribeAttackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual Task<DescribeAttackResponse> DescribeAttackAsync(DescribeAttackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAttackRequestMarshaller.Instance;
            var unmarshaller = DescribeAttackResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAttackRequest,DescribeAttackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDRTAccess

        internal virtual DescribeDRTAccessResponse DescribeDRTAccess(DescribeDRTAccessRequest request)
        {
            var marshaller = DescribeDRTAccessRequestMarshaller.Instance;
            var unmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeDRTAccessRequest,DescribeDRTAccessResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDRTAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual Task<DescribeDRTAccessResponse> DescribeDRTAccessAsync(DescribeDRTAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDRTAccessRequestMarshaller.Instance;
            var unmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDRTAccessRequest,DescribeDRTAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEmergencyContactSettings

        internal virtual DescribeEmergencyContactSettingsResponse DescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request)
        {
            var marshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeEmergencyContactSettingsRequest,DescribeEmergencyContactSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual Task<DescribeEmergencyContactSettingsResponse> DescribeEmergencyContactSettingsAsync(DescribeEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEmergencyContactSettingsRequest,DescribeEmergencyContactSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProtection

        internal virtual DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request)
        {
            var marshaller = DescribeProtectionRequestMarshaller.Instance;
            var unmarshaller = DescribeProtectionResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectionRequest,DescribeProtectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual Task<DescribeProtectionResponse> DescribeProtectionAsync(DescribeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProtectionRequestMarshaller.Instance;
            var unmarshaller = DescribeProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProtectionRequest,DescribeProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscription

        internal virtual DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request)
        {
            var marshaller = DescribeSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriptionRequest,DescribeSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual Task<DescribeSubscriptionResponse> DescribeSubscriptionAsync(DescribeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscriptionRequest,DescribeSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDRTLogBucket

        internal virtual DisassociateDRTLogBucketResponse DisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request)
        {
            var marshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTLogBucketRequest,DisassociateDRTLogBucketResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual Task<DisassociateDRTLogBucketResponse> DisassociateDRTLogBucketAsync(DisassociateDRTLogBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDRTLogBucketRequest,DisassociateDRTLogBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDRTRole

        internal virtual DisassociateDRTRoleResponse DisassociateDRTRole(DisassociateDRTRoleRequest request)
        {
            var marshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTRoleRequest,DisassociateDRTRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual Task<DisassociateDRTRoleResponse> DisassociateDRTRoleAsync(DisassociateDRTRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDRTRoleRequest,DisassociateDRTRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionState

        internal virtual GetSubscriptionStateResponse GetSubscriptionState(GetSubscriptionStateRequest request)
        {
            var marshaller = GetSubscriptionStateRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionStateRequest,GetSubscriptionStateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        public virtual Task<GetSubscriptionStateResponse> GetSubscriptionStateAsync(GetSubscriptionStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSubscriptionStateRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionStateRequest,GetSubscriptionStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttacks

        internal virtual ListAttacksResponse ListAttacks(ListAttacksRequest request)
        {
            var marshaller = ListAttacksRequestMarshaller.Instance;
            var unmarshaller = ListAttacksResponseUnmarshaller.Instance;

            return Invoke<ListAttacksRequest,ListAttacksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual Task<ListAttacksResponse> ListAttacksAsync(ListAttacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAttacksRequestMarshaller.Instance;
            var unmarshaller = ListAttacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttacksRequest,ListAttacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProtections

        internal virtual ListProtectionsResponse ListProtections(ListProtectionsRequest request)
        {
            var marshaller = ListProtectionsRequestMarshaller.Instance;
            var unmarshaller = ListProtectionsResponseUnmarshaller.Instance;

            return Invoke<ListProtectionsRequest,ListProtectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProtections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual Task<ListProtectionsResponse> ListProtectionsAsync(ListProtectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListProtectionsRequestMarshaller.Instance;
            var unmarshaller = ListProtectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProtectionsRequest,ListProtectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEmergencyContactSettings

        internal virtual UpdateEmergencyContactSettingsResponse UpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request)
        {
            var marshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateEmergencyContactSettingsRequest,UpdateEmergencyContactSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual Task<UpdateEmergencyContactSettingsResponse> UpdateEmergencyContactSettingsAsync(UpdateEmergencyContactSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEmergencyContactSettingsRequest,UpdateEmergencyContactSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscription

        internal virtual UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            var marshaller = UpdateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionRequest,UpdateSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionRequest,UpdateSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}