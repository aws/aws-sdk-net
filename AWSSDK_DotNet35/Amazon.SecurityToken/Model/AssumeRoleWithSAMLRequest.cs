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
    /// <para> Returns a set of temporary security credentials for users who have been authenticated via a SAML authentication response. This
    /// operation provides a mechanism for tying an enterprise identity store or directory to role-based AWS access without user-specific
    /// credentials or configuration. </para> <para> The temporary security credentials returned by this operation consist of an access key ID, a
    /// secret access key, and a security token. Applications can use these temporary security credentials to sign calls to AWS services. The
    /// credentials are valid for the duration that you specified when calling <c>AssumeRoleWithSAML</c> , which can be up to 3600 seconds (1 hour)
    /// or until the time specified in the SAML authentication response's <c>NotOnOrAfter</c> value, whichever is shorter.</para>
    /// <para><b>NOTE:</b>The maximum duration for a session is 1 hour, and the minimum duration is 15 minutes, even if values outside this range
    /// are specified. </para> <para>Optionally, you can pass an AWS IAM access policy to this operation. The temporary security credentials that
    /// are returned by the operation have the permissions that are associated with the access policy of the role being assumed, except for any
    /// permissions explicitly denied by the policy you pass. This gives you a way to further restrict the permissions for the federated user. These
    /// policies and any applicable resource-based policies are evaluated when calls to AWS are made using the temporary security credentials.
    /// </para> <para> Before your application can call <c>AssumeRoleWithSAML</c> , you must configure your SAML identity provider (IdP) to issue
    /// the claims required by AWS. Additionally, you must use AWS Identity and Access Management (AWS IAM) to create a SAML provider entity in your
    /// AWS account that represents your identity provider, and create an AWS IAM role that specifies this SAML provider in its trust policy.
    /// </para> <para> Calling <c>AssumeRoleWithSAML</c> does not require the use of AWS security credentials. The identity of the caller is
    /// validated by using keys in the metadata document that is uploaded for the SAML provider entity for your identity provider. </para> <para>For
    /// more information, see the following resources:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html" >Creating Temporary Security Credentials for SAML
    /// Federation</a> in the <i>Using Temporary Security Credentials</i> guide. </li>
    /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/idp-managing-identityproviders.html" >SAML Providers</a> in the <i>Using
    /// IAM</i> guide. </li>
    /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html" >Configuring a Relying Party and Claims in
    /// the Using IAM guide. </a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml.html" >Creating a Role for SAML-Based Federation</a> in the
    /// <i>Using IAM</i> guide. </li>
    /// 
    /// </ul>
    /// 
    /// </summary>
    public partial class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
    {
        private string roleArn;
        private string principalArn;
        private string sAMLAssertion;
        private string policy;
        private int? durationSeconds;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the role that the caller is assuming.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this.roleArn; }
            set { this.roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this.roleArn != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the SAML provider in AWS IAM that describes the IdP.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PrincipalArn
        {
            get { return this.principalArn; }
            set { this.principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this.principalArn != null;
        }

        /// <summary>
        /// The base-64 encoded SAML authentication response provided by the IdP. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring a Relying Party and Adding Claims</a> in
        /// the <i>Using IAM</i> guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 50000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SAMLAssertion
        {
            get { return this.sAMLAssertion; }
            set { this.sAMLAssertion = value; }
        }

        // Check to see if SAMLAssertion property is set
        internal bool IsSetSAMLAssertion()
        {
            return this.sAMLAssertion != null;
        }

        /// <summary>
        /// An AWS IAM policy in JSON format. The temporary security credentials that are returned by this operation have the permissions that are
        /// associated with the access policy of the role being assumed, except for any permissions explicitly denied by the policy you pass. These
        /// policies and any applicable resource-based policies are evaluated when calls to AWS are made using the temporary security credentials.
        /// <note>The policy must be 2048 bytes or shorter, and its packed size must be less than 450 bytes.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2048</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this.policy; }
            set { this.policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.policy != null;
        }

        /// <summary>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default, the
        /// value is set to 3600 seconds. An expiration can also be specified in the SAML authentication response's <c>NotOnOrAfter</c> value. The
        /// actual expiration time is whichever value is shorter. <note>The maximum duration for a session is 1 hour, and the minimum duration is 15
        /// minutes, even if values outside this range are specified. </note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>900 - 129600</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this.durationSeconds ?? default(int); }
            set { this.durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;
        }

    }
}
    
