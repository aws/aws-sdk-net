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
    /// Container for the parameters to the UpdateGroup operation.
    /// Updates the name and/or the path of the specified IAM group.
    /// 
    ///  <important> 
    /// <para>
    ///  You should understand the implications of changing a group's path or name. For more
    /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
    /// users and groups</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// The person making the request (the principal), must have permission to change the
    /// role group with the old name and the new name. For example, to change the group named
    /// <c>Managers</c> to <c>MGRs</c>, the principal must have a policy that allows them
    /// to update both groups. If the principal has permission to update the <c>Managers</c>
    /// group, but not the <c>MGRs</c> group, then the update fails. For more information
    /// about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
    /// management</a>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateGroupRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _newGroupName;
        private string _newPath;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateGroupRequest() { }

        /// <summary>
        /// Instantiates UpdateGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">Name of the IAM group to update. If you're changing the name of the group, this is the original name. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public UpdateGroupRequest(string groupName)
        {
            _groupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Name of the IAM group to update. If you're changing the name of the group, this is
        /// the original name.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property NewGroupName. 
        /// <para>
        /// New name for the IAM group. Only include this if changing the group's name.
        /// </para>
        ///  
        /// <para>
        /// IAM user, group, role, and policy names must be unique within the account. Names are
        /// not distinguished by case. For example, you cannot create resources named both "MyResource"
        /// and "myresource".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NewGroupName
        {
            get { return this._newGroupName; }
            set { this._newGroupName = value; }
        }

        // Check to see if NewGroupName property is set
        internal bool IsSetNewGroupName()
        {
            return this._newGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NewPath. 
        /// <para>
        /// New path for the IAM group. Only include this if changing the group's path.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (<c>\u0021</c>) through the DEL character (<c>\u007F</c>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string NewPath
        {
            get { return this._newPath; }
            set { this._newPath = value; }
        }

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this._newPath != null;
        }

    }
}