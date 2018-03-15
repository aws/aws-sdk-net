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
    /// Contains details about a root. A root is a top-level parent node in the hierarchy
    /// of an organization that can contain organizational units (OUs) and accounts. Every
    /// root contains every AWS account in the organization. Each root enables the accounts
    /// to be organized in a different way and to have different policy types enabled for
    /// use in that root.
    /// </summary>
    public partial class Root
    {
        private string _arn;
        private string _id;
        private string _name;
        private List<PolicyTypeSummary> _policyTypes = new List<PolicyTypeSummary>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the root.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_permissions.html#orgs-permissions-arns">ARN
        /// Formats Supported by Organizations</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) for the root.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a root ID string
        /// requires "r-" followed by from 4 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the root.
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
        /// Gets and sets the property PolicyTypes. 
        /// <para>
        /// The types of policies that are currently enabled for the root and therefore can be
        /// attached to the root or to its OUs or accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Even if a policy type is shown as available in the organization, you can separately
        /// enable and disable them at the root level by using <a>EnablePolicyType</a> and <a>DisablePolicyType</a>.
        /// Use <a>DescribeOrganization</a> to see the availability of the policy types in that
        /// organization.
        /// </para>
        ///  </note>
        /// </summary>
        public List<PolicyTypeSummary> PolicyTypes
        {
            get { return this._policyTypes; }
            set { this._policyTypes = value; }
        }

        // Check to see if PolicyTypes property is set
        internal bool IsSetPolicyTypes()
        {
            return this._policyTypes != null && this._policyTypes.Count > 0; 
        }

    }
}