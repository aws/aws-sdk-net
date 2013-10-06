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
    /// Container for the parameters to the UpdateUser operation.
    /// <para>Updates the name and/or the path of the specified user.</para> <para><b>IMPORTANT:</b> You should understand the implications of
    /// changing a user's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
    /// <para><b>NOTE:</b>To change a user name the requester must have appropriate permissions on both the source object and the target object.
    /// For example, to change Bob to Robert, the entity making the request must have permission on Bob and Robert, or must have permission on all
    /// (*). For more information about permissions, see Permissions and Policies. </para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateUser"/>
    public class UpdateUserRequest : AmazonWebServiceRequest
    {
        private string userName;
        private string newPath;
        private string newUserName;

        /// <summary>
        /// Name of the user to update. If you're changing the name of the user, this is the original user name.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserRequest WithUserName(string userName)
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
        /// New path for the user. Include this parameter only if you're changing the user's path.
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
        public UpdateUserRequest WithNewPath(string newPath)
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
        /// New name for the user. Include this parameter only if you're changing the user's name.
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
        public string NewUserName
        {
            get { return this.newUserName; }
            set { this.newUserName = value; }
        }

        /// <summary>
        /// Sets the NewUserName property
        /// </summary>
        /// <param name="newUserName">The value to set for the NewUserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserRequest WithNewUserName(string newUserName)
        {
            this.newUserName = newUserName;
            return this;
        }
            

        // Check to see if NewUserName property is set
        internal bool IsSetNewUserName()
        {
            return this.newUserName != null;       
        }
    }
}
    
