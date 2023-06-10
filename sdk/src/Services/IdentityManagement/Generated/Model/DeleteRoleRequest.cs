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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRole operation.
    /// Deletes the specified role. Unlike the Amazon Web Services Management Console, when
    /// you delete a role programmatically, you must delete the items attached to the role
    /// manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_manage_delete.html#roles-managingrole-deleting-cli">Deleting
    /// an IAM role</a>. Before attempting to delete a role, remove the following attached
    /// items: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Inline policies (<a>DeleteRolePolicy</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Attached managed policies (<a>DetachRolePolicy</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance profile (<a>RemoveRoleFromInstanceProfile</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optional – Delete instance profile after detaching from role for resource clean up
    /// (<a>DeleteInstanceProfile</a>)
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// Make sure that you do not have any Amazon EC2 instances running with the role you
    /// are about to delete. Deleting a role or instance profile that is associated with a
    /// running instance will break any applications running on the instance.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to delete.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}