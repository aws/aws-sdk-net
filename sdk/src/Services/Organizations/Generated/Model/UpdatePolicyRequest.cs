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
    /// Container for the parameters to the UpdatePolicy operation.
    /// Updates an existing policy with a new name, description, or content. If any parameter
    /// is not supplied, that value remains unchanged. Note that you cannot change a policy's
    /// type.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
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
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
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
        /// requires "p-" followed by from 8 to 128 lower-case letters or digits.
        /// </para>
        /// </summary>
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