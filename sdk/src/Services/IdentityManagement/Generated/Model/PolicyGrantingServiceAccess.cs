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
    /// Contains details about the permissions policies that are attached to the specified
    /// identity (user, group, or role).
    /// 
    ///  
    /// <para>
    /// This data type is an element of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPoliciesGrantingServiceAccessEntry.html">ListPoliciesGrantingServiceAccessEntry</a>
    /// object.
    /// </para>
    /// </summary>
    public partial class PolicyGrantingServiceAccess
    {
        private string _entityName;
        private PolicyOwnerEntityType _entityType;
        private string _policyArn;
        private string _policyName;
        private PolicyType _policyType;

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the entity (user or role) to which the inline policy is attached.
        /// </para>
        ///  
        /// <para>
        /// This field is null for managed policies. For more information about these policy types,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity (user or role) that used the policy to access the service to which
        /// the inline policy is attached.
        /// </para>
        ///  
        /// <para>
        /// This field is null for managed policies. For more information about these policy types,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public PolicyOwnerEntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

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
        /// The policy name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type. For more information about these policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}