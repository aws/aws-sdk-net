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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The Role data type contains information about a role.</para> <para> This data type is used as a response element in the following
    /// actions:</para>
    /// <ul>
    /// <li> <para> CreateRole </para> </li>
    /// <li> <para> GetRole </para> </li>
    /// <li> <para> ListRoles </para> </li>
    /// 
    /// </ul>
    /// </summary>
    public class Role
    {
        
        private string path;
        private string roleName;
        private string roleId;
        private string arn;
        private DateTime? createDate;
        private string assumeRolePolicyDocument;


        /// <summary>
        /// Path to the role. For more information about paths, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>.
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

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;
        }

        /// <summary>
        /// The name identifying the role.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this.roleName; }
            set { this.roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this.roleName != null;
        }

        /// <summary>
        /// The stable and unique string identifying the role. For more information about IDs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>.
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
        public string RoleId
        {
            get { return this.roleId; }
            set { this.roleId = value; }
        }

        // Check to see if RoleId property is set
        internal bool IsSetRoleId()
        {
            return this.roleId != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the role. For more information about ARNs and how to use them in policies, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>.
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

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
        }

        /// <summary>
        /// The date when the role was created.
        ///  
        /// </summary>
        public DateTime CreateDate
        {
            get { return this.createDate ?? default(DateTime); }
            set { this.createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDate.HasValue;
        }

        /// <summary>
        /// The policy that grants an entity permission to assume the role. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 131072</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AssumeRolePolicyDocument
        {
            get { return this.assumeRolePolicyDocument; }
            set { this.assumeRolePolicyDocument = value; }
        }

        // Check to see if AssumeRolePolicyDocument property is set
        internal bool IsSetAssumeRolePolicyDocument()
        {
            return this.assumeRolePolicyDocument != null;
        }
    }
}
