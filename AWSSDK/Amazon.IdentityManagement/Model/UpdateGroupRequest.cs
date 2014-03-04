/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the UpdateGroup operation.
    /// <para>Updates the name and/or the path of the specified group.</para> <para><b>IMPORTANT:</b> You should understand the implications of
    /// changing a group's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
    /// <para><b>NOTE:</b>To change a group name the requester must have appropriate permissions on both the source object and the target object.
    /// For example, to change Managers to MGRs, the entity making the request must have permission on Managers and MGRs, or must have permission on
    /// all (*). For more information about permissions, see Permissions and Policies. </para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateGroup"/>
    public class UpdateGroupRequest : AmazonWebServiceRequest
    {
        private string groupName;
        private string newPath;
        private string newGroupName;

        /// <summary>
        /// Name of the group to update. If you're changing the name of the group, this is the original name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">The value to set for the GroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateGroupRequest WithGroupName(string groupName)
        {
            this.groupName = groupName;
            return this;
        }
            

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;       
        }

        /// <summary>
        /// New path for the group. Only include this if changing the group's path.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(\u002F)|(\u002F[\u0021-\u007F]+\u002F)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NewPath
        {
            get { return this.newPath; }
            set { this.newPath = value; }
        }

        /// <summary>
        /// Sets the NewPath property
        /// </summary>
        /// <param name="newPath">The value to set for the NewPath property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateGroupRequest WithNewPath(string newPath)
        {
            this.newPath = newPath;
            return this;
        }
            

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this.newPath != null;       
        }

        /// <summary>
        /// New name for the group. Only include this if changing the group's name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NewGroupName
        {
            get { return this.newGroupName; }
            set { this.newGroupName = value; }
        }

        /// <summary>
        /// Sets the NewGroupName property
        /// </summary>
        /// <param name="newGroupName">The value to set for the NewGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateGroupRequest WithNewGroupName(string newGroupName)
        {
            this.newGroupName = newGroupName;
            return this;
        }
            

        // Check to see if NewGroupName property is set
        internal bool IsSetNewGroupName()
        {
            return this.newGroupName != null;       
        }
    }
}
    
