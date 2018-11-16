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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the TagRole operation.
    /// Adds one or more tags to an IAM role. The role can be a regular role or a service-linked
    /// role. If a tag with the same key name already exists, then that tag is overwritten
    /// with the new value.
    /// 
    ///  
    /// <para>
    /// A tag consists of a key name and an associated value. By assigning tags to your resources,
    /// you can do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
    /// organization and search. For example, you could search for all resources with the
    /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
    /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Access control</b> - Reference tags in IAM user-based and resource-based policies.
    /// You can use tags to restrict access to only an IAM user or role that has a specified
    /// tag attached. You can also restrict access to only those resources that have a certain
    /// tag attached. For examples of policies that show how to use tags to control access,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
    /// Access Using IAM Tags</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
    /// which AWS resources.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// Make sure that you have no invalid tags and that you do not exceed the allowed number
    /// of tags per role. In either case, the entire request fails and <i>no</i> tags are
    /// added to the role.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
    /// store an array, you can store comma-separated values in the string. However, you must
    /// interpret the value in your code.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about tagging, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
    /// IAM Identities</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TagRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _roleName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that you want to add tags to.
        /// </para>
        ///  
        /// <para>
        /// This parameter accepts (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters that consist of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags that you want to attach to the role. Each tag consists of a key name
        /// and an associated value. You can specify this with a JSON string.
        /// </para>
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