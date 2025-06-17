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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePolicy operation.
    /// Updates an existing policy with a new name, description, or content. If you don't
    /// supply any parameter, that value remains unchanged. You can't change a policy's type.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonOrganizationsRequest
    {
        private string _content;
        private string _description;
        private string _name;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// If provided, the new content for the policy. The text must be correctly formatted
        /// JSON that complies with the syntax for the policy's type. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scps_syntax.html">SCP
        /// syntax</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The maximum size of a policy document depends on the policy's type. For more information,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html#min-max-values">Maximum
        /// and minimum values</a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// If provided, the new description for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// If provided, the new name for the policy.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of any of the characters in the ASCII character range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier (ID) of the policy that you want to update.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a policy ID string
        /// requires "p-" followed by from 8 to 128 lowercase or uppercase letters, digits, or
        /// the underscore character (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=130)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

    }
}