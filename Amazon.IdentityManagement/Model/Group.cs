/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The Group data type contains information about a group.</para>
    /// <para> This data type is used as a response element in the following
    /// actions:</para>
    /// <ul>
    /// <li> CreateGroup </li>
    /// <li> GetGroup </li>
    /// <li> ListGroups </li>
    /// 
    /// </ul>
    /// </summary>
    public class Group  
    {
        
        private string path;
        private string groupName;
        private string groupId;
        private string arn;

        /// <summary>
        /// Path to the group. For more information about paths, see Identifiers
        /// for Users and Groups in <a
        /// href="http://docs.amazonwebservices.com/IAM/2010-05-08/UserGuide/"
        /// target="_blank">Using AWS Identity and Access Management</a>.
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
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        public Group WithPath(string path)
        {
            this.path = path;
            return this;
        }
            
        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;       
        }

        /// <summary>
        /// The name that identifies the group.
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
        public Group WithGroupName(string groupName)
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
        /// The stable and unique string identifying the group. For more
        /// information about IDs, see Identifiers for Users and Groups in <a
        /// href="http://docs.amazonwebservices.com/IAM/2010-05-08/UserGuide/"
        /// target="_blank">Using AWS Identity and Access Management</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>16 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }

        /// <summary>
        /// Sets the GroupId property
        /// </summary>
        /// <param name="groupId">The value to set for the GroupId property </param>
        /// <returns>this instance</returns>
        public Group WithGroupId(string groupId)
        {
            this.groupId = groupId;
            return this;
        }
            
        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this.groupId != null;        
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the group. For more
        /// information about ARNs and how to use them in policies, see
        /// Identifiers for Users and Groups in <a
        /// href="http://aws.amazon.com/documentation/iam/" target="_blank">Using
        /// AWS Identity and Access Management</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        public Group WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            
        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;        
        }
    }
}
