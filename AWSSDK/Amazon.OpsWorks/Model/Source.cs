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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the information required to retrieve an app or cookbook from a repository. For more information, see Creating Apps or Custom
    /// Recipes and Cookbooks.</para>
    /// </summary>
    public class Source
    {
        
        private string type;
        private string url;
        private string username;
        private string password;
        private string sshKey;
        private string revision;

        /// <summary>
        /// The repository type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>git, svn, archive, s3</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// The source URL.
        ///  
        /// </summary>
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }

        /// <summary>
        /// Sets the Url property
        /// </summary>
        /// <param name="url">The value to set for the Url property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithUrl(string url)
        {
            this.url = url;
            return this;
        }
            

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this.url != null;
        }

        /// <summary>
        /// This parameter depends on the repository type. <ul> <li>For Amazon S3 bundles, set <c>Username</c> to the appropriate AWS access key.</li>
        /// <li>For HTTP bundles, Git repositories, and Subversion repositories, set <c>Username</c> to the user name.</li> </ul>
        ///  
        /// </summary>
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        /// <summary>
        /// Sets the Username property
        /// </summary>
        /// <param name="username">The value to set for the Username property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithUsername(string username)
        {
            this.username = username;
            return this;
        }
            

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this.username != null;
        }

        /// <summary>
        /// This parameter depends on the repository type. <ul> <li>For Amazon S3 bundles, set <c>Password</c> to the appropriate AWS secret key.</li>
        /// <li>For HTTP bundles, Git repositories, and Subversion repositories, set <c>Password</c> to the password.</li> </ul>
        ///  
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        /// <summary>
        /// Sets the Password property
        /// </summary>
        /// <param name="password">The value to set for the Password property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithPassword(string password)
        {
            this.password = password;
            return this;
        }
            

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this.password != null;
        }

        /// <summary>
        /// The repository's SSH key.
        ///  
        /// </summary>
        public string SshKey
        {
            get { return this.sshKey; }
            set { this.sshKey = value; }
        }

        /// <summary>
        /// Sets the SshKey property
        /// </summary>
        /// <param name="sshKey">The value to set for the SshKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithSshKey(string sshKey)
        {
            this.sshKey = sshKey;
            return this;
        }
            

        // Check to see if SshKey property is set
        internal bool IsSetSshKey()
        {
            return this.sshKey != null;
        }

        /// <summary>
        /// The application's version. AWS OpsWorks enables you to easily deploy new versions of an application. One of the simplest approaches is to
        /// have branches or revisions in your repository that represent different versions that can potentially be deployed.
        ///  
        /// </summary>
        public string Revision
        {
            get { return this.revision; }
            set { this.revision = value; }
        }

        /// <summary>
        /// Sets the Revision property
        /// </summary>
        /// <param name="revision">The value to set for the Revision property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithRevision(string revision)
        {
            this.revision = revision;
            return this;
        }
            

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this.revision != null;
        }
    }
}
