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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// <para>Creates a new User for your AWS Account.</para> <para>For
    /// information about limitations on the number of Users you can create,
    /// see Limitations on IAM Entities in Using AWS Identity and Access
    /// Management.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateUser"/>
    public class CreateUserRequest : AmazonWebServiceRequest
    {
        private string path;
        private string userName;

        /// <summary>
        /// The path for the User name. For more information about paths, see
        /// Identifiers for Users and Groups in <a
        /// href="http://docs.amazonwebservices.com/IAM/2010-05-08/UserGuide/"
        /// target="_blank">Using AWS Identity and Access Management</a>. This
        /// parameter is optional. If it is not included, it defaults to a slash
        /// (/).
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
        public CreateUserRequest WithPath(string path)
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
        /// Name of the User to create.
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
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        public CreateUserRequest WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            
        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }
    }
}
    
