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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Interface for accessing SecurityTokenService
    ///
    /// AWS Security Token Service 
    /// <para>
    /// The AWS Security Token Service (STS) is a web service that enables you to request
    /// temporary, limited-privilege credentials for AWS Identity and Access Management (IAM)
    /// users or for users that you authenticate (federated users). This guide provides descriptions
    /// of the STS API. For more detailed information about using this service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  As an alternative to using the API, you can use one of the AWS SDKs, which consist
    /// of libraries and sample code for various programming languages and platforms (Java,
    /// Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient way to create programmatic
    /// access to STS. For example, the SDKs take care of cryptographically signing requests,
    /// managing errors, and retrying requests automatically. For information about the AWS
    /// SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about the Query API, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in <i>Using IAM</i>. For information about using security tokens
    /// with other AWS products, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html">AWS
    /// Services That Work with IAM</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// The AWS Security Token Service (STS) has a default endpoint of https://sts.amazonaws.com
    /// that maps to the US East (N. Virginia) region. Additional regions are available and
    /// are activated by default. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about STS endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region">Regions
    /// and Endpoints</a> in the <i>AWS General Reference</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API requests</b> 
    /// </para>
    ///  
    /// <para>
    /// STS supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    /// account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by CloudTrail, you can determine what requests were successfully made to STS, who
    /// made the request, when it was made, and so on. To learn more about CloudTrail, including
    /// how to turn it on and find your log files, see the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonSecurityTokenService : IAmazonService, IDisposable
    {

        
        #region  AssumeRole


        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret access key, and a security token) that you can use to access AWS resources
        /// that you might not normally have access to. Typically, you use <code>AssumeRole</code>
        /// for cross-account access or federation. For a comparison of <code>AssumeRole</code>
        /// with the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  <b>Important:</b> You cannot call <code>AssumeRole</code> by using AWS root account
        /// credentials; access is denied. You must use credentials for an IAM user or an IAM
        /// role to call <code>AssumeRole</code>. 
        /// </para>
        ///  
        /// <para>
        /// For cross-account access, imagine that you own multiple accounts and need to access
        /// resources in each account. You could create long-term credentials in each account
        /// to access those resources. However, managing all those credentials and remembering
        /// which one can access which account can be time consuming. Instead, you can create
        /// one set of long-term credentials in one account and then use temporary security credentials
        /// to access all the other accounts by assuming roles in those accounts. For more information
        /// about roles, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">IAM
        /// Roles (Delegation and Federation)</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For federation, you can, for example, grant single sign-on access to the AWS Management
        /// Console. If you already have an identity and authentication system in your corporate
        /// network, you don't have to recreate user identities in AWS in order to grant those
        /// user identities access to AWS. Instead, after a user has been authenticated, you call
        /// <code>AssumeRole</code> (and specify the role with the appropriate permissions) to
        /// get temporary security credentials for that user. With those temporary security credentials,
        /// you construct a sign-in URL that users can use to access the console. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html#sts-introduction">Common
        /// Scenarios for Temporary Credentials</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRole</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. You can provide a value from 900
        /// seconds (15 minutes) up to the maximum session duration setting for the role. This
        /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
        /// value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI operations but does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRole</code> can be used
        /// to make API calls to any AWS service with the following exception: you cannot call
        /// the STS service's <code>GetFederationToken</code> or <code>GetSessionToken</code>
        /// APIs.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass a policy, the temporary security credentials that are returned by the operation
        /// have the permissions that are defined in the access policy of the role that is being
        /// assumed. If you pass a policy to this operation, the temporary security credentials
        /// that are returned by the operation have the permissions that are allowed by both the
        /// access policy of the role that is being assumed, <i> <b>and</b> </i> the policy that
        /// you pass. This gives you a way to further restrict the permissions for the resulting
        /// temporary security credentials. You cannot use the passed policy to grant permissions
        /// that are in excess of those allowed by the access policy of the role that is being
        /// assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
        /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To assume a role, your AWS account must be trusted by the role. The trust relationship
        /// is defined in the role's trust policy when the role is created. That trust policy
        /// states which accounts are allowed to delegate access to this account's role. 
        /// </para>
        ///  
        /// <para>
        /// The user who wants to access the role must also have permissions delegated from the
        /// role's administrator. If the user is in a different account than the role, then the
        /// user's administrator must attach a policy that allows the user to call AssumeRole
        /// on the ARN of the role in the other account. If the user is in the same account as
        /// the role, then you can either attach a policy to the user (identical to the previous
        /// different account user), or you can add the user as a principal directly in the role's
        /// trust policy. In this case, the trust policy acts as the only resource-based policy
        /// in IAM, and users in the same account as the role do not need explicit permission
        /// to assume the role. For more information about trust policies and resource-based policies,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Using MFA with AssumeRole</b> 
        /// </para>
        ///  
        /// <para>
        /// You can optionally include multi-factor authentication (MFA) information when you
        /// call <code>AssumeRole</code>. This is useful for cross-account scenarios in which
        /// you want to make sure that the user who is assuming the role has been authenticated
        /// using an AWS MFA device. In that scenario, the trust policy of the role being assumed
        /// includes a condition that tests for MFA authentication; if the caller does not include
        /// valid MFA information, the request to assume the role is denied. The condition in
        /// a trust policy that tests for MFA authentication might look like the following example.
        /// </para>
        ///  
        /// <para>
        ///  <code>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
        /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
        /// </para>
        ///  
        /// <para>
        /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
        /// and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
        /// the user's hardware or virtual MFA device. The <code>TokenCode</code> is the time-based
        /// one-time password (TOTP) that the MFA devices produces. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole service method.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        AssumeRoleResponse AssumeRole(AssumeRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        IAsyncResult BeginAssumeRole(AssumeRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRole.</param>
        /// 
        /// <returns>Returns a  AssumeRoleResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        AssumeRoleResponse EndAssumeRole(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeRoleWithSAML


        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// via a SAML authentication response. This operation provides a mechanism for tying
        /// an enterprise identity store or directory to role-based AWS access without user-specific
        /// credentials or configuration. For a comparison of <code>AssumeRoleWithSAML</code>
        /// with the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The temporary security credentials returned by this operation consist of an access
        /// key ID, a secret access key, and a security token. Applications can use these temporary
        /// security credentials to sign calls to AWS services.
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRoleWithSAML</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. Your role session lasts for the
        /// duration that you specify, or until the time specified in the SAML authentication
        /// response's <code>SessionNotOnOrAfter</code> value, whichever is shorter. You can provide
        /// a <code>DurationSeconds</code> value from 900 seconds (15 minutes) up to the maximum
        /// session duration setting for the role. This setting can have a value from 1 hour to
        /// 12 hours. To learn how to view the maximum value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI operations but does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRoleWithSAML</code> can
        /// be used to make API calls to any AWS service with the following exception: you cannot
        /// call the STS service's <code>GetFederationToken</code> or <code>GetSessionToken</code>
        /// APIs.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass a policy, the temporary security credentials that are returned by the operation
        /// have the permissions that are defined in the access policy of the role that is being
        /// assumed. If you pass a policy to this operation, the temporary security credentials
        /// that are returned by the operation have the permissions that are allowed by the intersection
        /// of both the access policy of the role that is being assumed, <i> <b>and</b> </i> the
        /// policy that you pass. This means that both policies must grant the permission for
        /// the action to be allowed. This gives you a way to further restrict the permissions
        /// for the resulting temporary security credentials. You cannot use the passed policy
        /// to grant permissions that are in excess of those allowed by the access policy of the
        /// role that is being assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
        /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
        /// your SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
        /// you must use AWS Identity and Access Management (IAM) to create a SAML provider entity
        /// in your AWS account that represents your identity provider, and create an IAM role
        /// that specifies this SAML provider in its trust policy. 
        /// </para>
        ///  
        /// <para>
        /// Calling <code>AssumeRoleWithSAML</code> does not require the use of AWS security credentials.
        /// The identity of the caller is validated by using keys in the metadata document that
        /// is uploaded for the SAML provider entity for your identity provider. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <code>AssumeRoleWithSAML</code> can result in an entry in your AWS CloudTrail
        /// logs. The entry includes the value in the <code>NameID</code> element of the SAML
        /// assertion. We recommend that you use a NameIDType that is not associated with any
        /// personally identifiable information (PII). For example, you could instead use the
        /// Persistent Identifier (<code>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</code>).
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml.html">Creating
        /// SAML Identity Providers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml_relying-party.html">Configuring
        /// a Relying Party and Claims</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_saml.html">Creating
        /// a Role for SAML 2.0 Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithSAML service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRoleWithSAML
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        IAsyncResult BeginAssumeRoleWithSAML(AssumeRoleWithSAMLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithSAML.</param>
        /// 
        /// <returns>Returns a  AssumeRoleWithSAMLResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        AssumeRoleWithSAMLResponse EndAssumeRoleWithSAML(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeRoleWithWebIdentity


        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// in a mobile or web application with a web identity provider, such as Amazon Cognito,
        /// Login with Amazon, Facebook, Google, or any OpenID Connect-compatible identity provider.
        /// 
        ///  <note> 
        /// <para>
        /// For mobile applications, we recommend that you use Amazon Cognito. You can use Amazon
        /// Cognito with the <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS</a> and
        /// the <a href="http://aws.amazon.com/sdkforandroid/">AWS SDK for Android</a> to uniquely
        /// identify a user and supply the user with a consistent identity throughout the lifetime
        /// of an application.
        /// </para>
        ///  
        /// <para>
        /// To learn more about Amazon Cognito, see <a href="http://docs.aws.amazon.com/mobile/sdkforandroid/developerguide/cognito-auth.html#d0e840">Amazon
        /// Cognito Overview</a> in the <i>AWS SDK for Android Developer Guide</i> guide and <a
        /// href="http://docs.aws.amazon.com/mobile/sdkforios/developerguide/cognito-auth.html#d0e664">Amazon
        /// Cognito Overview</a> in the <i>AWS SDK for iOS Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling <code>AssumeRoleWithWebIdentity</code> does not require the use of AWS security
        /// credentials. Therefore, you can distribute an application (for example, on mobile
        /// devices) that requests temporary security credentials without including long-term
        /// AWS credentials in the application, and without deploying server-based proxy services
        /// that use long-term AWS credentials. Instead, the identity of the caller is validated
        /// by using a token from the web identity provider. For a comparison of <code>AssumeRoleWithWebIdentity</code>
        /// with the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials returned by this API consist of an access key ID,
        /// a secret access key, and a security token. Applications can use these temporary security
        /// credentials to sign calls to AWS service APIs.
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. You can provide a value from 900
        /// seconds (15 minutes) up to the maximum session duration setting for the role. This
        /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
        /// value for your role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI operations but does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// Roles</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
        /// can be used to make API calls to any AWS service with the following exception: you
        /// cannot call the STS service's <code>GetFederationToken</code> or <code>GetSessionToken</code>
        /// APIs.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass a policy, the temporary security credentials that are returned by the operation
        /// have the permissions that are defined in the access policy of the role that is being
        /// assumed. If you pass a policy to this operation, the temporary security credentials
        /// that are returned by the operation have the permissions that are allowed by both the
        /// access policy of the role that is being assumed, <i> <b>and</b> </i> the policy that
        /// you pass. This gives you a way to further restrict the permissions for the resulting
        /// temporary security credentials. You cannot use the passed policy to grant permissions
        /// that are in excess of those allowed by the access policy of the role that is being
        /// assumed. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_assumerole.html">Permissions
        /// for AssumeRole, AssumeRoleWithSAML, and AssumeRoleWithWebIdentity</a> in the <i>IAM
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <code>AssumeRoleWithWebIdentity</code>, you must
        /// have an identity token from a supported identity provider and create a role that the
        /// application can assume. The role that your application assumes must trust the identity
        /// provider that is associated with the identity token. In other words, the identity
        /// provider must be specified in the role's trust policy. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <code>AssumeRoleWithWebIdentity</code> can result in an entry in your AWS
        /// CloudTrail logs. The entry includes the <a href="http://openid.net/specs/openid-connect-core-1_0.html#Claims">Subject</a>
        /// of the provided Web Identity Token. We recommend that you avoid using any personally
        /// identifiable information (PII) in this field. For example, you could instead use a
        /// GUID or a pairwise identifier, as <a href="http://openid.net/specs/openid-connect-core-1_0.html#SubjectIDTypes">suggested
        /// in the OIDC specification</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about how to use web identity federation and the <code>AssumeRoleWithWebIdentity</code>
        /// API, see the following resources: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc_manual.html">Using
        /// Web Identity Federation APIs for Mobile Apps</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://web-identity-federation-playground.s3.amazonaws.com/index.html">
        /// Web Identity Federation Playground</a>. This interactive website lets you walk through
        /// the process of authenticating via Login with Amazon, Facebook, or Google, getting
        /// temporary security credentials, and then using those credentials to make a request
        /// to AWS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS</a> and <a href="http://aws.amazon.com/sdkforandroid/">AWS
        /// SDK for Android</a>. These toolkits contain sample apps that show how to invoke the
        /// identity providers, and then how to use the information from these providers to get
        /// and use temporary security credentials. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/articles/web-identity-federation-with-mobile-applications">Web
        /// Identity Federation with Mobile Applications</a>. This article discusses web identity
        /// federation and shows an example of how to use web identity federation to get access
        /// to content in Amazon S3. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPCommunicationErrorException">
        /// The request could not be fulfilled because the non-AWS identity provider (IDP) that
        /// was asked to verify the incoming identity token could not be reached. This is often
        /// a transient error caused by network conditions. Retry the request a limited number
        /// of times so that you don't exceed the request rate. If the error persists, the non-AWS
        /// identity provider might be down or not responding.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRoleWithWebIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        IAsyncResult BeginAssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithWebIdentity.</param>
        /// 
        /// <returns>Returns a  AssumeRoleWithWebIdentityResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        AssumeRoleWithWebIdentityResponse EndAssumeRoleWithWebIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DecodeAuthorizationMessage


        /// <summary>
        /// Decodes additional information about the authorization status of a request from an
        /// encoded message returned in response to an AWS request.
        /// 
        ///  
        /// <para>
        /// For example, if a user is not authorized to perform an action that he or she has requested,
        /// the request returns a <code>Client.UnauthorizedOperation</code> response (an HTTP
        /// 403 response). Some AWS actions additionally return an encoded message that can provide
        /// details about this authorization failure. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only certain AWS actions return an encoded authorization message. The documentation
        /// for an individual action indicates whether that action returns an encoded message
        /// in addition to returning an HTTP code.
        /// </para>
        ///  </note> 
        /// <para>
        /// The message is encoded because the details of the authorization status can constitute
        /// privileged information that the user who requested the action should not see. To decode
        /// an authorization status message, a user must be granted permissions via an IAM policy
        /// to request the <code>DecodeAuthorizationMessage</code> (<code>sts:DecodeAuthorizationMessage</code>)
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// The decoded message includes the following type of information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether the request was denied due to an explicit deny or due to the absence of an
        /// explicit allow. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-denyallow">Determining
        /// Whether a Request is Allowed or Denied</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principal who made the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The values of condition keys in the context of the user's request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage service method.</param>
        /// 
        /// <returns>The response from the DecodeAuthorizationMessage service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidAuthorizationMessageException">
        /// The error returned if the message passed to <code>DecodeAuthorizationMessage</code>
        /// was invalid. This can happen if the token contains invalid characters, such as linebreaks.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecodeAuthorizationMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        IAsyncResult BeginDecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecodeAuthorizationMessage.</param>
        /// 
        /// <returns>Returns a  DecodeAuthorizationMessageResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        DecodeAuthorizationMessageResponse EndDecodeAuthorizationMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCallerIdentity


        /// <summary>
        /// Returns details about the IAM identity whose credentials are used to call the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCallerIdentity service method, as returned by SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCallerIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        IAsyncResult BeginGetCallerIdentity(GetCallerIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCallerIdentity.</param>
        /// 
        /// <returns>Returns a  GetCallerIdentityResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        GetCallerIdentityResponse EndGetCallerIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFederationToken


        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret access key, and a security token) for a federated user. A typical use is in
        /// a proxy application that gets temporary security credentials on behalf of distributed
        /// applications inside a corporate network. Because you must call the <code>GetFederationToken</code>
        /// action using the long-term security credentials of an IAM user, this call is appropriate
        /// in contexts where those credentials can be safely stored, usually in a server-based
        /// application. For a comparison of <code>GetFederationToken</code> with the other APIs
        /// that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If you are creating a mobile-based or browser-based app that can authenticate users
        /// using a web identity provider like Login with Amazon, Facebook, Google, or an OpenID
        /// Connect-compatible identity provider, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
        /// Cognito</a> or <code>AssumeRoleWithWebIdentity</code>. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>GetFederationToken</code> action must be called by using the long-term AWS
        /// security credentials of an IAM user. You can also call <code>GetFederationToken</code>
        /// using the security credentials of an AWS root account, but we do not recommended it.
        /// Instead, we recommend that you create an IAM user for the purpose of the proxy application
        /// and then attach a policy to the IAM user that limits federated users to only the actions
        /// and resources that they need access to. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html">IAM
        /// Best Practices</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials that are obtained by using the long-term credentials
        /// of an IAM user are valid for the specified duration, from 900 seconds (15 minutes)
        /// up to a maximium of 129600 seconds (36 hours). The default is 43200 seconds (12 hours).
        /// Temporary credentials that are obtained by using AWS root account credentials have
        /// a maximum duration of 3600 seconds (1 hour).
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetFederationToken</code> can
        /// be used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot use these credentials to call any IAM APIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS APIs except <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The permissions for the temporary security credentials returned by <code>GetFederationToken</code>
        /// are determined by a combination of the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The policy or policies that are attached to the IAM user whose credentials are used
        /// to call <code>GetFederationToken</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy that is passed as a parameter in the call.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The passed policy is attached to the temporary security credentials that result from
        /// the <code>GetFederationToken</code> API call--that is, to the <i>federated user</i>.
        /// When the federated user makes an AWS request, AWS evaluates the policy attached to
        /// the federated user in combination with the policy or policies attached to the IAM
        /// user whose credentials were used to call <code>GetFederationToken</code>. AWS allows
        /// the federated user's request only when both the federated user <i> <b>and</b> </i>
        /// the IAM user are explicitly allowed to perform the requested action. The passed policy
        /// cannot grant more permissions than those that are defined in the IAM user policy.
        /// </para>
        ///  
        /// <para>
        /// A typical use case is that the permissions of the IAM user whose credentials are used
        /// to call <code>GetFederationToken</code> are designed to allow access to all the actions
        /// and resources that any federated user will need. Then, for individual users, you pass
        /// a policy to the operation that scopes down the permissions to a level that's appropriate
        /// to that individual user, using a policy that allows only a subset of permissions that
        /// are granted to the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// If you do not pass a policy, the resulting temporary security credentials have no
        /// effective permissions. The only exception is when the temporary security credentials
        /// are used to access a resource that has a resource-based policy that specifically allows
        /// the federated user to access the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about how permissions work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getfederationtoken.html">Permissions
        /// for GetFederationToken</a>. For information about using <code>GetFederationToken</code>
        /// to create temporary security credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getfederationtoken">GetFederationToken—Federation
        /// Through a Custom Identity Broker</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFederationToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        IAsyncResult BeginGetFederationToken(GetFederationTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFederationToken.</param>
        /// 
        /// <returns>Returns a  GetFederationTokenResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        GetFederationTokenResponse EndGetFederationToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSessionToken


        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        /// consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to specific AWS APIs like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// are returned from the call, IAM users can then make programmatic calls to APIs that
        /// require MFA authentication. If you do not supply a correct MFA code, then the API
        /// returns an access denied error. For a comparison of <code>GetSessionToken</code> with
        /// the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The <code>GetSessionToken</code> action must be called by using the long-term AWS
        /// security credentials of the AWS account or an IAM user. Credentials that are created
        /// by IAM users are valid for the duration that you specify, from 900 seconds (15 minutes)
        /// up to a maximum of 129600 seconds (36 hours), with a default of 43200 seconds (12
        /// hours); credentials that are created by using account credentials can range from 900
        /// seconds (15 minutes) up to a maximum of 3600 seconds (1 hour), with a default of 1
        /// hour. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetSessionToken</code> can be
        /// used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM APIs unless MFA authentication information is included in
        /// the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with root account credentials.
        /// Instead, follow our <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The permissions associated with the temporary security credentials returned by <code>GetSessionToken</code>
        /// are based on the permissions associated with account or IAM user whose credentials
        /// are used to call the action. If <code>GetSessionToken</code> is called using root
        /// account credentials, the temporary credentials have root account permissions. Similarly,
        /// if <code>GetSessionToken</code> is called using the credentials of an IAM user, the
        /// temporary credentials have the same permissions as the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        GetSessionTokenResponse GetSessionToken();

        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        /// consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to specific AWS APIs like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// are returned from the call, IAM users can then make programmatic calls to APIs that
        /// require MFA authentication. If you do not supply a correct MFA code, then the API
        /// returns an access denied error. For a comparison of <code>GetSessionToken</code> with
        /// the other APIs that produce temporary credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS APIs</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The <code>GetSessionToken</code> action must be called by using the long-term AWS
        /// security credentials of the AWS account or an IAM user. Credentials that are created
        /// by IAM users are valid for the duration that you specify, from 900 seconds (15 minutes)
        /// up to a maximum of 129600 seconds (36 hours), with a default of 43200 seconds (12
        /// hours); credentials that are created by using account credentials can range from 900
        /// seconds (15 minutes) up to a maximum of 3600 seconds (1 hour), with a default of 1
        /// hour. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetSessionToken</code> can be
        /// used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM APIs unless MFA authentication information is included in
        /// the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with root account credentials.
        /// Instead, follow our <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The permissions associated with the temporary security credentials returned by <code>GetSessionToken</code>
        /// are based on the permissions associated with account or IAM user whose credentials
        /// are used to call the action. If <code>GetSessionToken</code> is called using root
        /// account credentials, the temporary credentials have root account permissions. Similarly,
        /// if <code>GetSessionToken</code> is called using the credentials of an IAM user, the
        /// temporary credentials have the same permissions as the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken service method.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        IAsyncResult BeginGetSessionToken(GetSessionTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionToken.</param>
        /// 
        /// <returns>Returns a  GetSessionTokenResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        GetSessionTokenResponse EndGetSessionToken(IAsyncResult asyncResult);

        #endregion
        
    }
}