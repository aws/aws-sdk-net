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
    /// Container for the parameters to the CreateOrganizationalUnit operation.
    /// Creates an organizational unit (OU) within a root or parent OU. An OU is a container
    /// for accounts that enables you to organize your accounts to apply policies according
    /// to your business requirements. The number of levels deep that you can nest OUs is
    /// dependent upon the policy types enabled for that root. For service control policies,
    /// the limit is five. 
    /// 
    ///  
    /// <para>
    /// For more information about OUs, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
    /// Organizational Units</a> in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class CreateOrganizationalUnitRequest : AmazonOrganizationsRequest
    {
        private string _name;
        private string _parentId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name to assign to the new OU.
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
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The unique identifier (ID) of the parent root or OU in which you want to create the
        /// new OU.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a parent ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Root: a string that begins with "r-" followed by from 4 to 32 lower-case letters or
        /// digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU): a string that begins with "ou-" followed by from 4 to 32
        /// lower-case letters or digits (the ID of the root that the OU is in) followed by a
        /// second "-" dash and from 8 to 32 additional lower-case letters or digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

    }
}