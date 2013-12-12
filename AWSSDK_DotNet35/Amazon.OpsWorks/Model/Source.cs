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
    /// <para>Contains the information required to retrieve an app or cookbook from a repository. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html" >Creating Apps</a> or <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook.html" >Custom Recipes and Cookbooks</a> .</para>
    /// </summary>
    public class Source
    {
        
        private SourceType type;
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
        public SourceType Type
        {
            get { return this.type; }
            set { this.type = value; }
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

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this.revision != null;
        }
    }
}
