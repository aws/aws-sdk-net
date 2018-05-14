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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DisablePolicyType operation.
    /// Disables an organizational control policy type in a root. A policy of a certain type
    /// can be attached to entities in a root only if that type is enabled in the root. After
    /// you perform this operation, you no longer can attach policies of the specified type
    /// to that root or to any organizational unit (OU) or account in that root. You can undo
    /// this by using the <a>EnablePolicyType</a> operation.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you disable a policy type for a root, it still shows as enabled for the organization
    /// if all features are enabled in that organization. Use <a>ListRoots</a> to see the
    /// status of policy types for a specified root. Use <a>DescribeOrganization</a> to see
    /// the status of policy types in the organization.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisablePolicyTypeRequest : AmazonOrganizationsRequest
    {
        private PolicyType _policyType;
        private string _rootId;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type that you want to disable in this root.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property RootId. 
        /// <para>
        /// The unique identifier (ID) of the root in which you want to disable a policy type.
        /// You can get the ID from the <a>ListRoots</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a root ID string
        /// requires "r-" followed by from 4 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string RootId
        {
            get { return this._rootId; }
            set { this._rootId = value; }
        }

        // Check to see if RootId property is set
        internal bool IsSetRootId()
        {
            return this._rootId != null;
        }

    }
}