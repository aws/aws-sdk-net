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
    /// Organizational Units</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
    /// permission.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account.
    /// </para>
    /// </summary>
    public partial class CreateOrganizationalUnitRequest : AmazonOrganizationsRequest
    {
        private string _name;
        private string _parentId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name to assign to the new OU.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The unique identifier (ID) of the parent root or OU that you want to create the new
        /// OU in.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a parent ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> - A string that begins with "r-" followed by from 4 to 32 lowercase letters
        /// or digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Organizational unit (OU)</b> - A string that begins with "ou-" followed by from
        /// 4 to 32 lowercase letters or digits (the ID of the root that the OU is in). This string
        /// is followed by a second "-" dash and from 8 to 32 additional lowercase letters or
        /// digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the newly created OU. For each tag in the
        /// list, you must specify both a tag key and a value. You can set the value to an empty
        /// string, but you can't set it to <code>null</code>. For more information about tagging,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html">Tagging
        /// Organizations resources</a> in the Organizations User Guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is not valid or if you exceed the allowed number of tags for
        /// an OU, then the entire request fails and the OU is not created.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}