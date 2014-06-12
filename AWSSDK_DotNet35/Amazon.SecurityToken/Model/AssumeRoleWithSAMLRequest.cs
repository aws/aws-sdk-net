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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRoleWithSAML operation.
    /// Returns a set of temporary security credentials for users who have been authenticated
    /// via a      SAML authentication response. This operation provides a mechanism for tying
    /// an enterprise      identity store or directory to role-based AWS access without user-specific
    /// credentials or      configuration. 
    /// 
    ///     
    /// <para>
    /// The temporary security credentials returned by this operation consist of an access
    /// key ID, a      secret access key, and a security token. Applications can use these
    /// temporary security      credentials to sign calls to AWS services. The credentials
    /// are valid for the duration that you      specified when calling <code>AssumeRoleWithSAML</code>,
    /// which can be up to 3600 seconds (1      hour) or until the time specified in the SAML
    /// authentication response's        <code>NotOnOrAfter</code> value, whichever is shorter.
    /// </para>
    ///     <note>The maximum duration for a session is 1 hour, and the minimum duration is
    /// 15 minutes, even      if values outside this range are specified. </note>
    /// <para>
    /// Optionally, you can pass an IAM access policy to this operation. If you choose not
    /// to pass a      policy, the temporary security credentials that are returned by the
    /// operation have the      permissions that are defined in the access policy of the role
    /// that is being assumed. If you      pass a policy to this operation, the temporary
    /// security credentials that are returned by the      operation have the permissions
    /// that are allowed by both the access policy of the role that is      being assumed,
    /// <i><b>and</b></i> the policy that you pass. This gives you a way to further      restrict
    /// the permissions for the resulting temporary security credentials. You cannot use the
    ///      passed policy to grant permissions that are in excess of those allowed by the
    /// access policy of      the role that is being assumed. For more information, see <a
    /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-assume-role.html">Permissions
    /// for        AssumeRoleWithSAML</a> in <i>Using Temporary Security Credentials</i>.
    /// </para>
    ///     
    /// <para>
    /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
    /// your      SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
    /// you must use      AWS Identity and Access Management (IAM) to create a SAML provider
    /// entity in your AWS account that represents your      identity provider, and create
    /// an IAM role that specifies this SAML provider in its trust      policy. 
    /// </para>
    ///     
    /// <para>
    /// Calling <code>AssumeRoleWithSAML</code> does not require the use of AWS security 
    ///     credentials. The identity of the caller is validated by using keys in the metadata
    /// document      that is uploaded for the SAML provider entity for your identity provider.
    /// 
    /// </para>
    ///     
    /// <para>
    /// For more information, see the following resources:
    /// </para>
    ///     <ul>      <li><a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating
    /// Temporary Security Credentials for SAML          Federation</a> in <i>Using Temporary
    /// Security Credentials</i>. </li>      <li>        <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/idp-managing-identityproviders.html">SAML
    /// Providers</a> in          <i>Using IAM</i>. </li>      <li>        <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring
    /// a Relying Party and          Claims</a> in <i>Using IAM</i>. </li>      <li>     
    ///   <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml.html">Creating
    /// a Role for SAML-Based Federation</a>        in <i>Using IAM</i>. </li>    </ul>  
    ///  <member name="RoleArn" target="arnType"></member>    <member name="SAMLAssertion"
    /// target="SAMLAssertionType"></member>    <member name="Policy" target="sessionPolicyDocumentType"></member>
    ///    <member name="DurationSeconds" target="roleDurationSecondsType"></member>
    /// </summary>
    public partial class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
    {
        private int? _durationSeconds;
        private string _policy;
        private string _principalArn;
        private string _roleArn;
        private string _sAMLAssertion;


        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds
        /// (15      minutes) to 3600 seconds (1 hour). By default, the value is set to 3600 seconds.
        /// An expiration      can also be specified in the SAML authentication response's <code>NotOnOrAfter</code>
        /// value.      The actual expiration time is whichever value is shorter. 
        /// </para>
        ///     <note>The maximum duration for a session is 1 hour, and the minimum duration is
        /// 15 minutes, even      if values outside this range are specified. </note>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM policy in JSON format.
        /// </para>
        ///     
        /// <para>
        /// The policy parameter is optional. If you pass a policy, the temporary security credentials
        ///      that are returned by the operation have the permissions that are allowed by both
        /// the access      policy of the role that is being assumed, <i><b>and</b></i> the policy
        /// that you pass. This      gives you a way to further restrict the permissions for the
        /// resulting temporary security      credentials. You cannot use the passed policy to
        /// grant permissions that are in excess of those      allowed by the access policy of
        /// the role that is being assumed. For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-assume-role.html">Permissions
        /// for        AssumeRoleWithSAML</a> in <i>Using Temporary Security Credentials</i>.
        /// 
        /// </para>
        ///     <note>The policy must be 2048 bytes or shorter, and its packed size must be less
        /// than 450      bytes.</note>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }


        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider in IAM that describes the IdP.
        /// </para>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }


        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that the caller is assuming.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }


        /// <summary>
        /// Gets and sets the property SAMLAssertion. 
        /// <para>
        /// The base-64 encoded SAML authentication response provided by the IdP.
        /// </para>
        ///     
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring
        ///        a Relying Party and Adding Claims</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string SAMLAssertion
        {
            get { return this._sAMLAssertion; }
            set { this._sAMLAssertion = value; }
        }

        // Check to see if SAMLAssertion property is set
        internal bool IsSetSAMLAssertion()
        {
            return this._sAMLAssertion != null;
        }

    }
}