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
        /// Authorizes the DDoS Response team (DRT) to access the specified Amazon S3 bucket containing
        /// your flow logs. You can associate up to 10 Amazon S3 buckets with your subscription.
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
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
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
        /// Exception that indicates that the parameters passed to the API are invalid.
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual AssociateDRTLogBucketResponse AssociateDRTLogBucket(AssociateDRTLogBucketRequest request)
        {
            var marshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTLogBucketRequest,AssociateDRTLogBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTLogBucket operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDRTLogBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual IAsyncResult BeginAssociateDRTLogBucket(AssociateDRTLogBucketRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTLogBucketResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDRTLogBucketRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDRTLogBucket.</param>
        /// 
        /// <returns>Returns a  AssociateDRTLogBucketResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTLogBucket">REST API Reference for AssociateDRTLogBucket Operation</seealso>
        public virtual AssociateDRTLogBucketResponse EndAssociateDRTLogBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDRTLogBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDRTRole

        /// <summary>
        /// Authorizes the DDoS Response team (DRT), using the specified role, to access your
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
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
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
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual AssociateDRTRoleResponse AssociateDRTRole(AssociateDRTRoleRequest request)
        {
            var marshaller = AssociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateDRTRoleRequest,AssociateDRTRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDRTRole operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDRTRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual IAsyncResult BeginAssociateDRTRole(AssociateDRTRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = AssociateDRTRoleResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDRTRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDRTRole.</param>
        /// 
        /// <returns>Returns a  AssociateDRTRoleResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/AssociateDRTRole">REST API Reference for AssociateDRTRole Operation</seealso>
        public virtual AssociateDRTRoleResponse EndAssociateDRTRole(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDRTRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProtection

        /// <summary>
        /// Enables AWS Shield Advanced for a specific AWS resource. The resource can be an Amazon
        /// CloudFront distribution, Elastic Load Balancing load balancer, Elastic IP Address,
        /// or an Amazon Route 53 hosted zone.
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual CreateProtectionResponse CreateProtection(CreateProtectionRequest request)
        {
            var marshaller = CreateProtectionRequestMarshaller.Instance;
            var unmarshaller = CreateProtectionResponseUnmarshaller.Instance;

            return Invoke<CreateProtectionRequest,CreateProtectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual IAsyncResult BeginCreateProtection(CreateProtectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateProtectionRequestMarshaller.Instance;
            var unmarshaller = CreateProtectionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProtectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProtection.</param>
        /// 
        /// <returns>Returns a  CreateProtectionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateProtection">REST API Reference for CreateProtection Operation</seealso>
        public virtual CreateProtectionResponse EndCreateProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscription

        /// <summary>
        /// Activates AWS Shield Advanced for an account.
        /// 
        ///  
        /// <para>
        /// As part of this request you can specify <code>EmergencySettings</code> that automaticaly
        /// grant the DDoS response team (DRT) needed permissions to assist you during a suspected
        /// DDoS attack. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/authorize-DRT.html">Authorize
        /// the DDoS Response Team to Create Rules and Web ACLs on Your Behalf</a>.
        /// </para>
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
        /// Exception indicating the specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var marshaller = CreateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionRequest,CreateSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscription(CreateSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse EndCreateSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionResponse>(asyncResult);
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request)
        {
            var marshaller = DeleteProtectionRequestMarshaller.Instance;
            var unmarshaller = DeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectionRequest,DeleteProtectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual IAsyncResult BeginDeleteProtection(DeleteProtectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteProtectionRequestMarshaller.Instance;
            var unmarshaller = DeleteProtectionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProtectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProtection.</param>
        /// 
        /// <returns>Returns a  DeleteProtectionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteProtection">REST API Reference for DeleteProtection Operation</seealso>
        public virtual DeleteProtectionResponse EndDeleteProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProtectionResponse>(asyncResult);
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
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request)
        {
            var marshaller = DeleteSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionRequest,DeleteSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual IAsyncResult BeginDeleteSubscription(DeleteSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DeleteSubscription">REST API Reference for DeleteSubscription Operation</seealso>
        [Obsolete("Use UpdateSubscription operation to disable automatic subscription renewal instead.")]
        public virtual DeleteSubscriptionResponse EndDeleteSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAttack

        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual DescribeAttackResponse DescribeAttack(DescribeAttackRequest request)
        {
            var marshaller = DescribeAttackRequestMarshaller.Instance;
            var unmarshaller = DescribeAttackResponseUnmarshaller.Instance;

            return Invoke<DescribeAttackRequest,DescribeAttackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAttack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual IAsyncResult BeginDescribeAttack(DescribeAttackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeAttackRequestMarshaller.Instance;
            var unmarshaller = DescribeAttackResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAttackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAttack.</param>
        /// 
        /// <returns>Returns a  DescribeAttackResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeAttack">REST API Reference for DescribeAttack Operation</seealso>
        public virtual DescribeAttackResponse EndDescribeAttack(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAttackResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDRTAccess

        /// <summary>
        /// Returns the current role and list of Amazon S3 log buckets used by the DDoS Response
        /// team (DRT) to access your AWS account while assisting with attack mitigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeDRTAccess service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual DescribeDRTAccessResponse DescribeDRTAccess(DescribeDRTAccessRequest request)
        {
            var marshaller = DescribeDRTAccessRequestMarshaller.Instance;
            var unmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeDRTAccessRequest,DescribeDRTAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDRTAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDRTAccess operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDRTAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual IAsyncResult BeginDescribeDRTAccess(DescribeDRTAccessRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDRTAccessRequestMarshaller.Instance;
            var unmarshaller = DescribeDRTAccessResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDRTAccessRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDRTAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDRTAccess.</param>
        /// 
        /// <returns>Returns a  DescribeDRTAccessResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeDRTAccess">REST API Reference for DescribeDRTAccess Operation</seealso>
        public virtual DescribeDRTAccessResponse EndDescribeDRTAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDRTAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEmergencyContactSettings

        /// <summary>
        /// Lists the email addresses that the DRT can use to contact you during a suspected attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual DescribeEmergencyContactSettingsResponse DescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request)
        {
            var marshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeEmergencyContactSettingsRequest,DescribeEmergencyContactSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmergencyContactSettings operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEmergencyContactSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeEmergencyContactSettings(DescribeEmergencyContactSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeEmergencyContactSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEmergencyContactSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEmergencyContactSettings.</param>
        /// 
        /// <returns>Returns a  DescribeEmergencyContactSettingsResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeEmergencyContactSettings">REST API Reference for DescribeEmergencyContactSettings Operation</seealso>
        public virtual DescribeEmergencyContactSettingsResponse EndDescribeEmergencyContactSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEmergencyContactSettingsResponse>(asyncResult);
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
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request)
        {
            var marshaller = DescribeProtectionRequestMarshaller.Instance;
            var unmarshaller = DescribeProtectionResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectionRequest,DescribeProtectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual IAsyncResult BeginDescribeProtection(DescribeProtectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProtectionRequestMarshaller.Instance;
            var unmarshaller = DescribeProtectionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProtectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProtection.</param>
        /// 
        /// <returns>Returns a  DescribeProtectionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeProtection">REST API Reference for DescribeProtection Operation</seealso>
        public virtual DescribeProtectionResponse EndDescribeProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProtectionResponse>(asyncResult);
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
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request)
        {
            var marshaller = DescribeSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriptionRequest,DescribeSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual IAsyncResult BeginDescribeSubscription(DescribeSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeSubscriptionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DescribeSubscription">REST API Reference for DescribeSubscription Operation</seealso>
        public virtual DescribeSubscriptionResponse EndDescribeSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDRTLogBucket

        /// <summary>
        /// Removes the DDoS Response team's (DRT) access to the specified Amazon S3 bucket containing
        /// your flow logs.
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
        /// In order to grant the necessary access to the DDoS Response Team, the user submitting
        /// <code>AssociateDRTRole</code> must have the <code>iam:PassRole</code> permission.
        /// This error indicates the user did not have the appropriate permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual DisassociateDRTLogBucketResponse DisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request)
        {
            var marshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTLogBucketRequest,DisassociateDRTLogBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTLogBucket operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDRTLogBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDRTLogBucket(DisassociateDRTLogBucketRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateDRTLogBucketRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTLogBucketResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateDRTLogBucketRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDRTLogBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDRTLogBucket.</param>
        /// 
        /// <returns>Returns a  DisassociateDRTLogBucketResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTLogBucket">REST API Reference for DisassociateDRTLogBucket Operation</seealso>
        public virtual DisassociateDRTLogBucketResponse EndDisassociateDRTLogBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDRTLogBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDRTRole

        /// <summary>
        /// Removes the DDoS Response team's (DRT) access to your AWS account.
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
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual DisassociateDRTRoleResponse DisassociateDRTRole(DisassociateDRTRoleRequest request)
        {
            var marshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateDRTRoleRequest,DisassociateDRTRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDRTRole operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDRTRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDRTRole(DisassociateDRTRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateDRTRoleRequestMarshaller.Instance;
            var unmarshaller = DisassociateDRTRoleResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateDRTRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDRTRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDRTRole.</param>
        /// 
        /// <returns>Returns a  DisassociateDRTRoleResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/DisassociateDRTRole">REST API Reference for DisassociateDRTRole Operation</seealso>
        public virtual DisassociateDRTRoleResponse EndDisassociateDRTRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDRTRoleResponse>(asyncResult);
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
            var marshaller = GetSubscriptionStateRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionStateRequest,GetSubscriptionStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionState operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionState(GetSubscriptionStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSubscriptionStateRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionStateResponseUnmarshaller.Instance;

            return BeginInvoke<GetSubscriptionStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionState.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionStateResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/GetSubscriptionState">REST API Reference for GetSubscriptionState Operation</seealso>
        public virtual GetSubscriptionStateResponse EndGetSubscriptionState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionStateResponse>(asyncResult);
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
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual ListAttacksResponse ListAttacks(ListAttacksRequest request)
        {
            var marshaller = ListAttacksRequestMarshaller.Instance;
            var unmarshaller = ListAttacksResponseUnmarshaller.Instance;

            return Invoke<ListAttacksRequest,ListAttacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual IAsyncResult BeginListAttacks(ListAttacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAttacksRequestMarshaller.Instance;
            var unmarshaller = ListAttacksResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttacks.</param>
        /// 
        /// <returns>Returns a  ListAttacksResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListAttacks">REST API Reference for ListAttacks Operation</seealso>
        public virtual ListAttacksResponse EndListAttacks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttacksResponse>(asyncResult);
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
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual ListProtectionsResponse ListProtections(ListProtectionsRequest request)
        {
            var marshaller = ListProtectionsRequestMarshaller.Instance;
            var unmarshaller = ListProtectionsResponseUnmarshaller.Instance;

            return Invoke<ListProtectionsRequest,ListProtectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtections operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual IAsyncResult BeginListProtections(ListProtectionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListProtectionsRequestMarshaller.Instance;
            var unmarshaller = ListProtectionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListProtectionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtections.</param>
        /// 
        /// <returns>Returns a  ListProtectionsResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/ListProtections">REST API Reference for ListProtections Operation</seealso>
        public virtual ListProtectionsResponse EndListProtections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEmergencyContactSettings

        /// <summary>
        /// Updates the details of the list of email addresses that the DRT can use to contact
        /// you during a suspected attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateEmergencyContactSettings service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual UpdateEmergencyContactSettingsResponse UpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request)
        {
            var marshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateEmergencyContactSettingsRequest,UpdateEmergencyContactSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmergencyContactSettings operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmergencyContactSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateEmergencyContactSettings(UpdateEmergencyContactSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateEmergencyContactSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateEmergencyContactSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEmergencyContactSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmergencyContactSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmergencyContactSettings.</param>
        /// 
        /// <returns>Returns a  UpdateEmergencyContactSettingsResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateEmergencyContactSettings">REST API Reference for UpdateEmergencyContactSettings Operation</seealso>
        public virtual UpdateEmergencyContactSettingsResponse EndUpdateEmergencyContactSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEmergencyContactSettingsResponse>(asyncResult);
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
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// You are trying to update a subscription that has not yet completed the 1-year commitment.
        /// You can change the <code>AutoRenew</code> parameter during the last 30 days of your
        /// subscription. This exception indicates that you are attempting to change <code>AutoRenew</code>
        /// prior to that period.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            var marshaller = UpdateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionRequest,UpdateSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscription(UpdateSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateSubscriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionResult from Shield.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/shield-2016-06-02/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        public virtual UpdateSubscriptionResponse EndUpdateSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionResponse>(asyncResult);
        }

        #endregion
        
    }
}