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
    /// Container for the parameters to the EnablePolicyType operation.
    /// Enables a policy type in a root. After you enable a policy type in a root, you can
    /// attach policies of that type to the root, any organizational unit (OU), or account
    /// in that root. You can undo this by using the <a>DisablePolicyType</a> operation.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    ///  
    /// <para>
    /// You can enable a policy type in a root only if that policy type is available in the
    /// organization. Use <a>DescribeOrganization</a> to view the status of available policy
    /// types in the organization.
    /// </para>
    ///  
    /// <para>
    /// To view the status of policy type in a root, use <a>ListRoots</a>.
    /// </para>
    /// </summary>
    public partial class EnablePolicyTypeRequest : AmazonOrganizationsRequest
    {
        private PolicyType _policyType;
        private string _rootId;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type that you want to enable.
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
        /// The unique identifier (ID) of the root in which you want to enable a policy type.
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