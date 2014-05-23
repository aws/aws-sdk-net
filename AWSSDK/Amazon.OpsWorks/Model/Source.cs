/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the information required to retrieve an app or cookbook from a repository.
    /// For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
    /// Apps</a> or  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook.html">Custom
    /// Recipes and Cookbooks</a>.
    /// </summary>
    public partial class Source
    {
        private string _password;
        private string _revision;
        private string _sshKey;
        private string _type;
        private string _url;
        private string _username;


        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// This parameter depends on the repository type. 
        /// </para>
        ///   <ul>    <li>For Amazon S3 bundles, set <code>Password</code> to the appropriate
        /// IAM secret access key.</li>    <li>For HTTP bundles and Subversion repositories, set
        /// <code>Password</code> to the password.</li>  </ul>  
        /// <para>
        /// For more information on how to safely handle IAM credentials, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-access-keys-best-practices.html"></a>.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }


        /// <summary>
        /// Sets the Password property
        /// </summary>
        /// <param name="password">The value to set for the Password property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithPassword(string password)
        {
            this._password = password;
            return this;
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }


        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The application's version. AWS OpsWorks enables you to easily deploy new versions
        /// of an application.         One of the simplest approaches is to have branches or revisions
        /// in your repository that represent different         versions that can potentially
        /// be deployed.
        /// </para>
        /// </summary>
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }


        /// <summary>
        /// Sets the Revision property
        /// </summary>
        /// <param name="revision">The value to set for the Revision property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithRevision(string revision)
        {
            this._revision = revision;
            return this;
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }


        /// <summary>
        /// Gets and sets the property SshKey. 
        /// <para>
        /// The repository's SSH key.
        /// </para>
        /// </summary>
        public string SshKey
        {
            get { return this._sshKey; }
            set { this._sshKey = value; }
        }


        /// <summary>
        /// Sets the SshKey property
        /// </summary>
        /// <param name="sshKey">The value to set for the SshKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithSshKey(string sshKey)
        {
            this._sshKey = sshKey;
            return this;
        }

        // Check to see if SshKey property is set
        internal bool IsSetSshKey()
        {
            return this._sshKey != null;
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The repository type.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }


        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithType(string type)
        {
            this._type = type;
            return this;
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }


        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The source URL. 
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }


        /// <summary>
        /// Sets the Url property
        /// </summary>
        /// <param name="url">The value to set for the Url property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithUrl(string url)
        {
            this._url = url;
            return this;
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }


        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// This parameter depends on the repository type. 
        /// </para>
        ///   <ul>  <li>For Amazon S3 bundles, set <code>Username</code> to the appropriate IAM
        /// access key ID.</li>  <li>For HTTP bundles, Git repositories, and Subversion repositories,
        /// set <code>Username</code> to the user name.</li>  </ul>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }


        /// <summary>
        /// Sets the Username property
        /// </summary>
        /// <param name="username">The value to set for the Username property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Source WithUsername(string username)
        {
            this._username = username;
            return this;
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}