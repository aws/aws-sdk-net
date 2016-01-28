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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
    /// Apps</a> or <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook.html">Custom
    /// Recipes and Cookbooks</a>.
    /// </summary>
    public partial class Source
    {
        private string _password;
        private string _revision;
        private string _sshKey;
        private SourceType _type;
        private string _url;
        private string _username;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// When included in a request, the parameter depends on the repository type. 
        /// </para>
        ///  <ul> <li>For Amazon S3 bundles, set <code>Password</code> to the appropriate IAM
        /// secret access key.</li> <li>For HTTP bundles and Subversion repositories, set <code>Password</code>
        /// to the password.</li> </ul> 
        /// <para>
        /// For more information on how to safely handle IAM credentials, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-access-keys-best-practices.html"/>.
        /// </para>
        ///  
        /// <para>
        /// In responses, AWS OpsWorks returns <code>*****FILTERED*****</code> instead of the
        /// actual value.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
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
        /// of an application. One of the simplest approaches is to have branches or revisions
        /// in your repository that represent different versions that can potentially be deployed.
        /// </para>
        /// </summary>
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property SshKey. 
        /// <para>
        /// In requests, the repository's SSH key.
        /// </para>
        ///  
        /// <para>
        /// In responses, AWS OpsWorks returns <code>*****FILTERED*****</code> instead of the
        /// actual value.
        /// </para>
        /// </summary>
        public string SshKey
        {
            get { return this._sshKey; }
            set { this._sshKey = value; }
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
        public SourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
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
        ///  <ul> <li>For Amazon S3 bundles, set <code>Username</code> to the appropriate IAM
        /// access key ID.</li> <li>For HTTP bundles, Git repositories, and Subversion repositories,
        /// set <code>Username</code> to the user name.</li> </ul>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}