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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an attached policy.
    /// 
    ///  
    /// <para>
    /// An attached policy is a managed policy that has been attached to a user, group, or
    /// role. This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedGroupPolicies.html">ListAttachedGroupPolicies</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedRolePolicies.html">ListAttachedRolePolicies</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedUserPolicies.html">ListAttachedUserPolicies</a>,
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountAuthorizationDetails.html">GetAccountAuthorizationDetails</a>
    /// operations. 
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AttachedPolicyType
    {
        private string _policyArn;
        private string _policyName;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The friendly name of the attached policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}