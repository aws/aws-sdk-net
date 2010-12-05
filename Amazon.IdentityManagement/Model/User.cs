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
    /// <para>The User data type contains information about a User.</para>
    /// <para> This data type is used as a response element in the following
    /// actions:</para>
    /// <ul>
    /// <li> <para> CreateUser </para> </li>
    /// <li> <para> GetUser </para> </li>
    /// <li> <para> ListUsers </para> </li>
    /// 
    /// </ul>
    /// </summary>
    public class User  
    {
        
        private string path;
        private string userName;
        private string userId;
        private string arn;

        /// <summary>
        /// Path to the User name. For more information about paths, see
        /// Identifiers for Users and Groups in <a
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
        public User WithPath(string path)
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
        /// The name identifying the User.
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
        public User WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            
        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }

        /// <summary>
        /// The stable and unique string identifying the User. For more
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
        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        /// <summary>
        /// Sets the UserId property
        /// </summary>
        /// <param name="userId">The value to set for the UserId property </param>
        /// <returns>this instance</returns>
        public User WithUserId(string userId)
        {
            this.userId = userId;
            return this;
        }
            
        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this.userId != null;         
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the User. For more
        /// information about ARNs and how to use them in policies, see
        /// Identifiers for Users and Groups in <a
        /// href="http://docs.amazonwebservices.com/IAM/2010-05-08/UserGuide/"
        /// target="_blank">Using AWS Identity and Access Management</a>.
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
        public User WithArn(string arn)
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
