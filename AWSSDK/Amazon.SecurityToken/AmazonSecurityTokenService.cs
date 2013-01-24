/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Interface for accessing AmazonSecurityTokenService.
    ///  
    ///  AWS Security Token Service <para>The AWS Security Token Service is a web service that enables you to request temporary, limited-privilege
    /// credentials for AWS Identity and Access Management (IAM) users or for users that you authenticate (federated users). This guide provides
    /// descriptions of the AWS Security Token Service API.</para> <para>For more detailed information about using this service, go to Using
    /// Temporary Security Credentials.</para> <para>For information about setting up signatures and authorization through the API, go to Signing
    /// AWS API Requests in the <i>AWS General Reference</i> . For general information about the Query API, go to Making Query Requests in <i>Using
    /// IAM</i> . For information about using security tokens with other AWS products, go to Using Temporary Security Credentials to Access AWS in
    /// <i>Using Temporary Security Credentials</i> .</para> <para>If you're new to AWS and need additional technical information about a specific
    /// AWS product, you can find the product's technical documentation at http://aws.amazon.com/documentation/.</para> <para>We will refer to
    /// Amazon Identity and Access Management using the abbreviated form IAM. All copyrights and legal protections still apply.</para>
    /// </summary>
    public interface AmazonSecurityTokenService : IDisposable
    {
        

        #region GetSessionToken

        /// <summary>
        /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
        /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
        /// users can be between 15 minutes and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to a
        /// maximum of one hour. Providing the AWS Multi-Factor Authentication (MFA) device serial number and the token code is optional.</para>
        /// <para>For more information about using GetSessionToken to create temporary credentials, go to Creating Temporary Credentials to Enable
        /// Access for IAM Users in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest getSessionTokenRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
        /// </summary>
        /// 
        /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionToken
        ///         operation.</returns>
        IAsyncResult BeginGetSessionToken(GetSessionTokenRequest getSessionTokenRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionToken.</param>
        /// 
        /// <returns>Returns a GetSessionTokenResult from AmazonSecurityTokenService.</returns>
        GetSessionTokenResponse EndGetSessionToken(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
        /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
        /// users can be between 15 minutes and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to a
        /// maximum of one hour. Providing the AWS Multi-Factor Authentication (MFA) device serial number and the token code is optional.</para>
        /// <para>For more information about using GetSessionToken to create temporary credentials, go to Creating Temporary Credentials to Enable
        /// Access for IAM Users in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        GetSessionTokenResponse GetSessionToken();
        
        #endregion
        
    

        #region GetFederationToken

        /// <summary>
        /// <para>The GetFederationToken action returns a set of temporary credentials for a federated user with the user name and policy specified in
        /// the request. The credentials consist of an Access Key ID, a Secret Access Key, and a security token. Credentials created by IAM users are
        /// valid for the specified duration, between 15 minutes and 36 hours; credentials created using account credentials have a maximum duration of
        /// one hour.</para> <para>The federated user who holds these credentials has any permissions allowed by the intersection of the specified
        /// policy and any resource or user policies that apply to the caller of the GetFederationToken API, and any resource policies that apply to the
        /// federated user's Amazon Resource Name (ARN). For more information about how token permissions work, see Controlling Permissions in Temporary
        /// Credentials in <i>Using IAM</i> . For information about using GetFederationToken to create temporary credentials, see Creating Temporary
        /// Credentials to Enable Access for Federated Users in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <param name="getFederationTokenRequest">Container for the necessary parameters to execute the GetFederationToken service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest getFederationTokenRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetFederationToken"/>
        /// </summary>
        /// 
        /// <param name="getFederationTokenRequest">Container for the necessary parameters to execute the GetFederationToken operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetFederationToken operation.</returns>
        IAsyncResult BeginGetFederationToken(GetFederationTokenRequest getFederationTokenRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetFederationToken"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFederationToken.</param>
        /// 
        /// <returns>Returns a GetFederationTokenResult from AmazonSecurityTokenService.</returns>
        GetFederationTokenResponse EndGetFederationToken(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AssumeRole

        /// <summary>
        /// <para> The <c>AssumeRole</c> action returns a set of temporary security credentials that you can use to access resources that are defined in
        /// the role's policy. The returned credentials consist of an Access Key ID, a Secret Access Key, and a security token. </para> <para>
        /// <b>Important:</b> Only IAM users can assume a role. If you use AWS account credentials to call AssumeRole, access is denied. </para> <para>
        /// The credentials are valid for the duration that you specified when calling <c>AssumeRole</c> , which can be from 15 minutes to 1 hour.
        /// </para> <para> When you assume a role, you have the privileges that are defined in the role. You can further restrict the privileges by
        /// passing a policy when calling <c>AssumeRole</c> .
        /// </para> <para> To assume a role, you must be an IAM user from a trusted entity and have permission to call <c>AssumeRole</c> .
        /// Trusted entites are defined when the IAM role is created. Permission to call <c>AssumeRole</c> is defined in your or your group's
        /// IAM policy. </para>
        /// </summary>
        /// 
        /// <param name="assumeRoleRequest">Container for the necessary parameters to execute the AssumeRole service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        AssumeRoleResponse AssumeRole(AssumeRoleRequest assumeRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRole"/>
        /// </summary>
        /// 
        /// <param name="assumeRoleRequest">Container for the necessary parameters to execute the AssumeRole operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRole
        ///         operation.</returns>
        IAsyncResult BeginAssumeRole(AssumeRoleRequest assumeRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRole.</param>
        /// 
        /// <returns>Returns a AssumeRoleResult from AmazonSecurityTokenService.</returns>
        AssumeRoleResponse EndAssumeRole(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
