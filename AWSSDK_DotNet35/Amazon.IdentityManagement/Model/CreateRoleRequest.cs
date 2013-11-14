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
    /// Container for the parameters to the CreateRole operation.
    /// <para>Creates a new role for your AWS account. For more information about roles, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .
    /// For information about limitations on role names and the number of roles you can create, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
    /// AWS Identity and Access Management</i> .</para> <para>The policy grants permission to an EC2 instance to assume the role. The policy is
    /// URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
    /// >http://www.faqs.org/rfcs/rfc3986.html</a> .
    /// Currently, only EC2 instances can assume roles.</para>
    /// </summary>
    public partial class CreateRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string path;
        private string roleName;
        private string assumeRolePolicyDocument;


        /// <summary>
        /// The path to the role. For more information about paths, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>. This parameter is optional. If it is not included, it defaults to a slash (/).
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
        /// Name of the role to create.
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
        /// The policy that grants an entity permission to assume the role.
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
    
