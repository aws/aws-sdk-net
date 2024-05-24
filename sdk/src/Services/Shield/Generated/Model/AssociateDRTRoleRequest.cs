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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDRTRole operation.
    /// Authorizes the Shield Response Team (SRT) using the specified role, to access your
    /// Amazon Web Services account to assist with DDoS attack mitigation during potential
    /// attacks. This enables the SRT to inspect your WAF configuration and create or update
    /// WAF rules and web ACLs.
    /// 
    ///  
    /// <para>
    /// You can associate only one <c>RoleArn</c> with your subscription. If you submit an
    /// <c>AssociateDRTRole</c> request for an account that already has an associated role,
    /// the new <c>RoleArn</c> will replace the existing <c>RoleArn</c>. 
    /// </para>
    ///  
    /// <para>
    /// Prior to making the <c>AssociateDRTRole</c> request, you must attach the <c>AWSShieldDRTAccessPolicy</c>
    /// managed policy to the role that you'll specify in the request. You can access this
    /// policy in the IAM console at <a href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>.
    /// For more information see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Adding
    /// and removing IAM identity permissions</a>. The role must also trust the service principal
    /// <c>drt.shield.amazonaws.com</c>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
    /// JSON policy elements: Principal</a>.
    /// </para>
    ///  
    /// <para>
    /// The SRT will have access only to your WAF and Shield resources. By submitting this
    /// request, you authorize the SRT to inspect your WAF and Shield configuration and create
    /// and update WAF rules and web ACLs on your behalf. The SRT takes these actions only
    /// if explicitly authorized by you.
    /// </para>
    ///  
    /// <para>
    /// You must have the <c>iam:PassRole</c> permission to make an <c>AssociateDRTRole</c>
    /// request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
    /// a user permissions to pass a role to an Amazon Web Services service</a>. 
    /// </para>
    ///  
    /// <para>
    /// To use the services of the SRT and make an <c>AssociateDRTRole</c> request, you must
    /// be subscribed to the <a href="http://aws.amazon.com/premiumsupport/business-support/">Business
    /// Support plan</a> or the <a href="http://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
    /// Support plan</a>.
    /// </para>
    /// </summary>
    public partial class AssociateDRTRoleRequest : AmazonShieldRequest
    {
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role the SRT will use to access your Amazon
        /// Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Prior to making the <c>AssociateDRTRole</c> request, you must attach the <a href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSShieldDRTAccessPolicy">AWSShieldDRTAccessPolicy</a>
        /// managed policy to this role. For more information see <a href=" https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage-attach-detach.html">Attaching
        /// and Detaching IAM Policies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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