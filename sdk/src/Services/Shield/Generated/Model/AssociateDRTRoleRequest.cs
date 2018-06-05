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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDRTRole operation.
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
    public partial class AssociateDRTRoleRequest : AmazonShieldRequest
    {
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role the DRT will use to access your AWS account.
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <code>AssociateDRTRole</code> request, you must attach the <a
        /// href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>
        /// managed policy to this role. For more information see <a href=" https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Attaching
        /// and Detaching IAM Policies</a>.
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

    }
}